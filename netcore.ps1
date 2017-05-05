# Thanks to Andrew Lock for help with this script
# http://andrewlock.net/publishing-your-first-nuget-package-with-appveyor-and-myget/

param (
  [switch]$build = $false,
  [switch]$pack = $false,
  [switch]$debug = $false
)

<#  
.SYNOPSIS
    You can add this to you build script to ensure that psbuild is available before calling
    Invoke-MSBuild. If psbuild is not available locally it will be downloaded automatically.
#>
function EnsurePsbuildInstalled{  
    [cmdletbinding()]
    param(
        [string]$psbuildInstallUri = 'https://raw.githubusercontent.com/ligershark/psbuild/master/src/GetPSBuild.ps1'
    )
    process{
        if(-not (Get-Command "Invoke-MsBuild" -errorAction SilentlyContinue)){
            'Installing psbuild from [{0}]' -f $psbuildInstallUri | Write-Verbose
            (new-object Net.WebClient).DownloadString($psbuildInstallUri) | iex
        }
        else{
            'psbuild already loaded, skipping download' | Write-Verbose
        }

        # make sure it's loaded and throw if not
        if(-not (Get-Command "Invoke-MsBuild" -errorAction SilentlyContinue)){
            throw ('Unable to install/load psbuild from [{0}]' -f $psbuildInstallUri)
        }
    }
}

# Taken from psake https://github.com/psake/psake

<#  
.SYNOPSIS
  This is a helper function that runs a scriptblock and checks the PS variable $lastexitcode
  to see if an error occcured. If an error is detected then an exception is thrown.
  This function allows you to run command-line programs without having to
  explicitly check the $lastexitcode variable.
.EXAMPLE
  exec { svn info $repository_trunk } "Error executing SVN. Please verify SVN command-line client is installed"
#>
function Exec  
{
    [CmdletBinding()]
    param(
        [Parameter(Position=0,Mandatory=1)][scriptblock]$cmd,
        [Parameter(Position=1,Mandatory=0)][string]$errorMessage = ($msgs.error_bad_command -f $cmd)
    )
    & $cmd
    if ($lastexitcode -ne 0) {
        throw ("Exec: " + $errorMessage)
    }
}

If (Test-Path Env:APPVEYOR_REPO_TAG_NAME) {
  $version = ($env:APPVEYOR_REPO_TAG_NAME).Substring(1)
  if (($env:APPVEYOR_REPO_TAG_NAME).Contains("-") -eq $false) {
    #Building a Full Release
     $type = ""
     $buildNumber = ""
     echo "Tagged Release"
    } Else {
      #Building a Beta
      $version = ($version).Substring(0, (($env:APPVEYOR_REPO_TAG_NAME).IndexOf("-") - 1))
      $type = ($env:APPVEYOR_REPO_TAG_NAME).Substring((($env:APPVEYOR_REPO_TAG_NAME).IndexOf("-") + 1))
      $buildNumber = ""
      echo "Tag but not release"
    }
} Else {
  $version = "0.9.3"
  $type = "ci-"
  $buildNumber = @{ $true = $env:APPVEYOR_BUILD_NUMBER; $false = 1 }[$env:APPVEYOR_BUILD_NUMBER -ne $NULL];
  $buildNumber = "{0:D4}" -f [convert]::ToInt32($buildNumber, 10), $buildNumber
}


echo $version
echo $type
echo $buildNumber

$revision = + $type + $buildNumber

If ($debug) {
 $configuration = "-c=Debug"
} ElseIf ($env:APPVEYOR) {
 $configuration = "-c=CI"
} Else {
$configuration = "-c=Release"
}

If ($debug) {
     $libLoc = "bin\Debug"
    } ElseIf ($env:APPVEYOR) {
     $libLoc = "bin\CI"
    } Else {
    $libLoc = "bin\Release"
    }
    
    echo $libLoc

function UploadAppVeyorTestResults {
 # upload results to AppVeyor
  $wc = New-Object 'System.Net.WebClient'
  $wc.UploadFile("https://ci.appveyor.com/api/testresults/nunit3/$($env:APPVEYOR_JOB_ID)", (Resolve-Path .\TestResult.xml))
}

function Build {
  # build native library first
  ./gradlew copyToNet -PreleaseType=OFFICIAL

  if($LastExitCode -ne 0) { $host.SetShouldExit($LastExitCode )  }

  exec { & dotnet restore }
  echo $configuration
  
  exec { & dotnet build src\FRC.OpenCvSharp $configuration /p:VersionPrefix=$version /p:VersionSuffix=$revision }

  exec { & dotnet build src\FRC.OpenCvSharp.DesktopLibraries $configuration /p:VersionPrefix=$version /p:VersionSuffix=$revision }
}

function Pack { 
  if (Test-Path .\artifacts) { Remove-Item .\artifacts -Force -Recurse }

  exec { & dotnet pack src\FRC.OpenCvSharp $configuration --no-build -o .\artifacts /p:VersionPrefix=$version /p:VersionSuffix=$revision }

  exec { & dotnet pack src\FRC.OpenCvSharp.DesktopLibraries $configuration --no-build -o .\artifacts /p:VersionPrefix=$version /p:VersionSuffix=$revision }

  # Removing the OpenCv desktop symbols package since it's too big to upload
  Remove-Item .\artifacts\FRC.OpenCvSharp.DesktopLibraries.*.symbols.nupkg

  if ($env:APPVEYOR) {
    Get-ChildItem .\artifacts\*.nupkg | % { Push-AppveyorArtifact $_.FullName -FileName $_.Name }
  }
}

if ($build) {
 Build
}

if ($pack) {
 Pack
}