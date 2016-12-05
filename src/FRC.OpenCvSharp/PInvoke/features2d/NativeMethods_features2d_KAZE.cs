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
        public delegate IntPtr features2d_KAZE_createDelegate(bool extended, bool upright, float threshold,
                int nOctaves, int nOctaveLayers, int diffusivity);
        [NativeDelegate("features2d_KAZE_create")] public static features2d_KAZE_createDelegate features2d_KAZE_create;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_KAZE_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_KAZE_delete")] public static ReleaseFunc features2d_Ptr_KAZE_delete;

        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_KAZE_infoDelegate(IntPtr obj);
        [NativeDelegate("features2d_KAZE_info")] public static features2d_KAZE_infoDelegate features2d_KAZE_info;
        */

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_Ptr_KAZE_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_KAZE_get")] public static ObjFunc features2d_Ptr_KAZE_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_KAZE_setDiffusivityDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_KAZE_setDiffusivity")] public static features2d_KAZE_setDiffusivityDelegate features2d_KAZE_setDiffusivity;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_KAZE_getDiffusivityDelegate(IntPtr obj);
        [NativeDelegate("features2d_KAZE_getDiffusivity")] public static features2d_KAZE_getDiffusivityDelegate features2d_KAZE_getDiffusivity;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_KAZE_setExtendedDelegate(IntPtr obj, bool val);
        [NativeDelegate("features2d_KAZE_setExtended")] public static features2d_KAZE_setExtendedDelegate features2d_KAZE_setExtended;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool features2d_KAZE_getExtendedDelegate(IntPtr obj);
        [NativeDelegate("features2d_KAZE_getExtended")] public static features2d_KAZE_getExtendedDelegate features2d_KAZE_getExtended;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_KAZE_setNOctaveLayersDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_KAZE_setNOctaveLayers")] public static features2d_KAZE_setNOctaveLayersDelegate features2d_KAZE_setNOctaveLayers;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_KAZE_getNOctaveLayersDelegate(IntPtr obj);
        [NativeDelegate("features2d_KAZE_getNOctaveLayers")] public static features2d_KAZE_getNOctaveLayersDelegate features2d_KAZE_getNOctaveLayers;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_KAZE_setNOctavesDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_KAZE_setNOctaves")] public static features2d_KAZE_setNOctavesDelegate features2d_KAZE_setNOctaves;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_KAZE_getNOctavesDelegate(IntPtr obj);
        [NativeDelegate("features2d_KAZE_getNOctaves")] public static features2d_KAZE_getNOctavesDelegate features2d_KAZE_getNOctaves;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_KAZE_setThresholdDelegate(IntPtr obj, double val);
        [NativeDelegate("features2d_KAZE_setThreshold")] public static features2d_KAZE_setThresholdDelegate features2d_KAZE_setThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double features2d_KAZE_getThresholdDelegate(IntPtr obj);
        [NativeDelegate("features2d_KAZE_getThreshold")] public static features2d_KAZE_getThresholdDelegate features2d_KAZE_getThreshold;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_KAZE_setUprightDelegate(IntPtr obj, bool val);
        [NativeDelegate("features2d_KAZE_setUpright")] public static features2d_KAZE_setUprightDelegate features2d_KAZE_setUpright;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool features2d_KAZE_getUprightDelegate(IntPtr obj);
        [NativeDelegate("features2d_KAZE_getUpright")] public static features2d_KAZE_getUprightDelegate features2d_KAZE_getUpright;
    }
}
