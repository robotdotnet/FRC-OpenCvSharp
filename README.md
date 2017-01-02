# FRC-OpenCvSharp

**Build Status**

| Windows                 |  Linux/Mac              | NuGet                 | NuGet (DesktopLibraries) |
| ------------------------|-------------------------|-----------------------|--------------------------|
| [![Build status][1]][2] | Coming soon!            | [![NuGet][7]][8]      | [![NuGet][9]][10]        |

[1]: https://ci.appveyor.com/api/projects/status/8x4yh0lyivqvea1p?svg=true
[2]: https://ci.appveyor.com/project/robotdotnet/frc-opencvsharp
[7]: https://img.shields.io/nuget/vpre/FRC.OpenCvSharp.svg
[8]: https://www.nuget.org/packages/FRC.OpenCvSharp
[9]: https://img.shields.io/nuget/vpre/FRC.OpenCvSharp.DesktopLibraries.svg
[10]: https://www.nuget.org/packages/FRC.OpenCvSharp.DesktopLibraries

FRC-OpenCvSharp is a fork of [OpenCvSharp](https://github.com/shimat/opencvsharp), with modifications for use with FRC and the WPILib environment.

This repository contains both the .NET source code, and the native wrapper source code. The native wrapper is built with gradle, while the .NET source code is built with .NET Core.

## Supported Platforms
* .NET 4.5 or higher
* .NET Standard 1.5
* Since this uses a native library, only the platforms listed below are supported:
    * roboRIO (uses the FRC extension to set up native libraries)
    * Windows 64-bit
    * Windows 32-bit

    We hope to add support for Linux, Mac and armhf soon.

## Installation

FRC-OpenCvSharp is included by default in WPILib templates. If needed for another system, the wrapper can be installed via NuGet with the links above. Note you will need to get both 
*FRC OpenCvSharp.DesktopLibraries* and *FRC OpenCvSharp* packages in order to run on a system other then the roboRIO.

## Building .NET libraries
To build the .NET libraries, you will need .NET Core installed.
Once you have that, clone the repo, and run `.\netcore.psi -build` from a Powershell prompt on Windows, or `.\netcore.sh` from a linux shell. 

## Building native libraries
Coming soon

## License
See [LICENSE.txt](LICENSE.txt)

## Contributors

Thad House (@thadhouse)

[OpenCvSharp](https://github.com/shimat/opencvsharp)