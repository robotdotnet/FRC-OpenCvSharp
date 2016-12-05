using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        // ReSharper disable InconsistentNaming

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_GFTTDetector_createDelegate(int maxCorners, double qualityLevel,
            double minDistance, int blockSize, int useHarrisDetector, double k);
        [NativeDelegate("features2d_GFTTDetector_create")] public static features2d_GFTTDetector_createDelegate features2d_GFTTDetector_create;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_GFTTDetector_infoDelegate(IntPtr obj);
        [NativeDelegate("features2d_GFTTDetector_info")] public static features2d_GFTTDetector_infoDelegate features2d_GFTTDetector_info;
        */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_Ptr_GFTTDetector_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_GFTTDetector_get")] public static ObjFunc features2d_Ptr_GFTTDetector_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_GFTTDetector_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_GFTTDetector_delete")] public static ReleaseFunc features2d_Ptr_GFTTDetector_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_GFTTDetector_setMaxFeaturesDelegate(IntPtr obj, int maxFeatures);
        [NativeDelegate("features2d_GFTTDetector_setMaxFeatures")] public static features2d_GFTTDetector_setMaxFeaturesDelegate features2d_GFTTDetector_setMaxFeatures;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_GFTTDetector_getMaxFeaturesDelegate(IntPtr obj);
        [NativeDelegate("features2d_GFTTDetector_getMaxFeatures")] public static features2d_GFTTDetector_getMaxFeaturesDelegate features2d_GFTTDetector_getMaxFeatures;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_GFTTDetector_setQualityLevelDelegate(IntPtr obj, double qlevel);
        [NativeDelegate("features2d_GFTTDetector_setQualityLevel")] public static features2d_GFTTDetector_setQualityLevelDelegate features2d_GFTTDetector_setQualityLevel;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double features2d_GFTTDetector_getQualityLevelDelegate(IntPtr obj);
        [NativeDelegate("features2d_GFTTDetector_getQualityLevel")] public static features2d_GFTTDetector_getQualityLevelDelegate features2d_GFTTDetector_getQualityLevel;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_GFTTDetector_setMinDistanceDelegate(IntPtr obj, double minDistance);
        [NativeDelegate("features2d_GFTTDetector_setMinDistance")] public static features2d_GFTTDetector_setMinDistanceDelegate features2d_GFTTDetector_setMinDistance;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double features2d_GFTTDetector_getMinDistanceDelegate(IntPtr obj);
        [NativeDelegate("features2d_GFTTDetector_getMinDistance")] public static features2d_GFTTDetector_getMinDistanceDelegate features2d_GFTTDetector_getMinDistance;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_GFTTDetector_setBlockSizeDelegate(IntPtr obj, int blockSize);
        [NativeDelegate("features2d_GFTTDetector_setBlockSize")] public static features2d_GFTTDetector_setBlockSizeDelegate features2d_GFTTDetector_setBlockSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_GFTTDetector_getBlockSizeDelegate(IntPtr obj);
        [NativeDelegate("features2d_GFTTDetector_getBlockSize")] public static features2d_GFTTDetector_getBlockSizeDelegate features2d_GFTTDetector_getBlockSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_GFTTDetector_setHarrisDetectorDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_GFTTDetector_setHarrisDetector")] public static features2d_GFTTDetector_setHarrisDetectorDelegate features2d_GFTTDetector_setHarrisDetector;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_GFTTDetector_getHarrisDetectorDelegate(IntPtr obj);
        [NativeDelegate("features2d_GFTTDetector_getHarrisDetector")] public static features2d_GFTTDetector_getHarrisDetectorDelegate features2d_GFTTDetector_getHarrisDetector;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_GFTTDetector_setKDelegate(IntPtr obj, double k);
        [NativeDelegate("features2d_GFTTDetector_setK")] public static features2d_GFTTDetector_setKDelegate features2d_GFTTDetector_setK;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double features2d_GFTTDetector_getKDelegate(IntPtr obj);
        [NativeDelegate("features2d_GFTTDetector_getK")] public static features2d_GFTTDetector_getKDelegate features2d_GFTTDetector_getK;
    }
}
