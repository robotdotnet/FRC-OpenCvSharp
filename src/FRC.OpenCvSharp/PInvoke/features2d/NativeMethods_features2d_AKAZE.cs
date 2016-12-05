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
        public delegate IntPtr features2d_AKAZE_createDelegate(
            int descriptor_type, int descriptor_size, int descriptor_channels,
            float threshold, int nOctaves, int nOctaveLayers, int diffusivity);
        [NativeDelegate("features2d_AKAZE_create")] public static features2d_AKAZE_createDelegate features2d_AKAZE_create;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_AKAZE_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_AKAZE_delete")] public static ReleaseFunc features2d_Ptr_AKAZE_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_Ptr_AKAZE_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_AKAZE_get")] public static ObjFunc features2d_Ptr_AKAZE_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_AKAZE_setDescriptorTypeDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_AKAZE_setDescriptorType")] public static features2d_AKAZE_setDescriptorTypeDelegate features2d_AKAZE_setDescriptorType;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_AKAZE_getDescriptorTypeDelegate(IntPtr obj);
        [NativeDelegate("features2d_AKAZE_getDescriptorType")] public static features2d_AKAZE_getDescriptorTypeDelegate features2d_AKAZE_getDescriptorType;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_AKAZE_setDescriptorSizeDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_AKAZE_setDescriptorSize")] public static features2d_AKAZE_setDescriptorSizeDelegate features2d_AKAZE_setDescriptorSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_AKAZE_getDescriptorSizeDelegate(IntPtr obj);
        [NativeDelegate("features2d_AKAZE_getDescriptorSize")] public static features2d_AKAZE_getDescriptorSizeDelegate features2d_AKAZE_getDescriptorSize;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_AKAZE_setDescriptorChannelsDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_AKAZE_setDescriptorChannels")] public static features2d_AKAZE_setDescriptorChannelsDelegate features2d_AKAZE_setDescriptorChannels;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_AKAZE_getDescriptorChannelsDelegate(IntPtr obj);
        [NativeDelegate("features2d_AKAZE_getDescriptorChannels")] public static features2d_AKAZE_getDescriptorChannelsDelegate features2d_AKAZE_getDescriptorChannels;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_AKAZE_setThresholdDelegate(IntPtr obj, double val);
        [NativeDelegate("features2d_AKAZE_setThreshold")] public static features2d_AKAZE_setThresholdDelegate features2d_AKAZE_setThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double features2d_AKAZE_getThresholdDelegate(IntPtr obj);
        [NativeDelegate("features2d_AKAZE_getThreshold")] public static features2d_AKAZE_getThresholdDelegate features2d_AKAZE_getThreshold;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_AKAZE_setNOctavesDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_AKAZE_setNOctaves")] public static features2d_AKAZE_setNOctavesDelegate features2d_AKAZE_setNOctaves;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_AKAZE_getNOctavesDelegate(IntPtr obj);
        [NativeDelegate("features2d_AKAZE_getNOctaves")] public static features2d_AKAZE_getNOctavesDelegate features2d_AKAZE_getNOctaves;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_AKAZE_setNOctaveLayersDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_AKAZE_setNOctaveLayers")] public static features2d_AKAZE_setNOctaveLayersDelegate features2d_AKAZE_setNOctaveLayers;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_AKAZE_getNOctaveLayersDelegate(IntPtr obj);
        [NativeDelegate("features2d_AKAZE_getNOctaveLayers")] public static features2d_AKAZE_getNOctaveLayersDelegate features2d_AKAZE_getNOctaveLayers;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_AKAZE_setDiffusivityDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_AKAZE_setDiffusivity")] public static features2d_AKAZE_setDiffusivityDelegate features2d_AKAZE_setDiffusivity;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_AKAZE_getDiffusivityDelegate(IntPtr obj);
        [NativeDelegate("features2d_AKAZE_getDiffusivity")] public static features2d_AKAZE_getDiffusivityDelegate features2d_AKAZE_getDiffusivity;
    }
}
