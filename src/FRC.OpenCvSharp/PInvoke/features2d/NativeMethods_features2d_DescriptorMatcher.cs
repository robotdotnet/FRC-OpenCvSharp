using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        // DescriptorMatcher
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_DescriptorMatcher_addDelegate(IntPtr obj, IntPtr[] descriptors,
            int descriptorLength);
        [NativeDelegate("features2d_DescriptorMatcher_add")] public static features2d_DescriptorMatcher_addDelegate features2d_DescriptorMatcher_add;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_DescriptorMatcher_getTrainDescriptorsDelegate(IntPtr obj,
            IntPtr dst);
        [NativeDelegate("features2d_DescriptorMatcher_getTrainDescriptors")] public static features2d_DescriptorMatcher_getTrainDescriptorsDelegate features2d_DescriptorMatcher_getTrainDescriptors;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_DescriptorMatcher_clearDelegate(IntPtr obj);
        [NativeDelegate("features2d_DescriptorMatcher_clear")] public static features2d_DescriptorMatcher_clearDelegate features2d_DescriptorMatcher_clear;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_DescriptorMatcher_emptyDelegate(IntPtr obj);
        [NativeDelegate("features2d_DescriptorMatcher_empty")] public static features2d_DescriptorMatcher_emptyDelegate features2d_DescriptorMatcher_empty;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_DescriptorMatcher_isMaskSupportedDelegate(IntPtr obj);
        [NativeDelegate("features2d_DescriptorMatcher_isMaskSupported")] public static features2d_DescriptorMatcher_isMaskSupportedDelegate features2d_DescriptorMatcher_isMaskSupported;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_DescriptorMatcher_trainDelegate(IntPtr obj);
        [NativeDelegate("features2d_DescriptorMatcher_train")] public static features2d_DescriptorMatcher_trainDelegate features2d_DescriptorMatcher_train;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_DescriptorMatcher_match1Delegate(IntPtr obj,
            IntPtr queryDescriptors, IntPtr trainDescriptors, IntPtr matches, IntPtr mask);
        [NativeDelegate("features2d_DescriptorMatcher_match1")] public static features2d_DescriptorMatcher_match1Delegate features2d_DescriptorMatcher_match1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_DescriptorMatcher_knnMatch1Delegate(IntPtr obj,
            IntPtr queryDescriptors, IntPtr trainDescriptors, IntPtr matches, int k,
            IntPtr mask, int compactResult);
        [NativeDelegate("features2d_DescriptorMatcher_knnMatch1")] public static features2d_DescriptorMatcher_knnMatch1Delegate features2d_DescriptorMatcher_knnMatch1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_DescriptorMatcher_radiusMatch1Delegate(IntPtr obj,
            IntPtr queryDescriptors,IntPtr trainDescriptors, IntPtr matches, float maxDistance,
            IntPtr mask, int compactResult);
        [NativeDelegate("features2d_DescriptorMatcher_radiusMatch1")] public static features2d_DescriptorMatcher_radiusMatch1Delegate features2d_DescriptorMatcher_radiusMatch1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_DescriptorMatcher_match2Delegate(
            IntPtr obj, IntPtr queryDescriptors, IntPtr matches,
            IntPtr[] masks, int masksSize);
        [NativeDelegate("features2d_DescriptorMatcher_match2")] public static features2d_DescriptorMatcher_match2Delegate features2d_DescriptorMatcher_match2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_DescriptorMatcher_knnMatch2Delegate(
            IntPtr obj, IntPtr queryDescriptors, IntPtr matches,
            int k, IntPtr[] masks, int masksSize, int compactResult);
        [NativeDelegate("features2d_DescriptorMatcher_knnMatch2")] public static features2d_DescriptorMatcher_knnMatch2Delegate features2d_DescriptorMatcher_knnMatch2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_DescriptorMatcher_radiusMatch2Delegate(
            IntPtr obj, IntPtr queryDescriptors, IntPtr matches,
            float maxDistance, IntPtr[] masks, int masksSize, int compactResult);
        [NativeDelegate("features2d_DescriptorMatcher_radiusMatch2")] public static features2d_DescriptorMatcher_radiusMatch2Delegate features2d_DescriptorMatcher_radiusMatch2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_DescriptorMatcher_createDelegate([MarshalAs(UnmanagedType.LPStr)] string descriptorMatcherType);
        [NativeDelegate("features2d_DescriptorMatcher_create")] public static features2d_DescriptorMatcher_createDelegate features2d_DescriptorMatcher_create;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_DescriptorMatcher_infoDelegate(IntPtr obj);
        [NativeDelegate("features2d_DescriptorMatcher_info")] public static features2d_DescriptorMatcher_infoDelegate features2d_DescriptorMatcher_info;
        */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_Ptr_DescriptorMatcher_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_DescriptorMatcher_get")] public static ObjFunc features2d_Ptr_DescriptorMatcher_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_DescriptorMatcher_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_DescriptorMatcher_delete")] public static ReleaseFunc features2d_Ptr_DescriptorMatcher_delete;

        // BFMatcher
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_BFMatcher_newDelegate(int normType, int crossCheck);
        [NativeDelegate("features2d_BFMatcher_new")] public static features2d_BFMatcher_newDelegate features2d_BFMatcher_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_BFMatcher_deleteDelegate(IntPtr obj);
        [NativeDelegate("features2d_BFMatcher_delete")] public static features2d_BFMatcher_deleteDelegate features2d_BFMatcher_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_BFMatcher_isMaskSupportedDelegate(IntPtr obj);
        [NativeDelegate("features2d_BFMatcher_isMaskSupported")] public static features2d_BFMatcher_isMaskSupportedDelegate features2d_BFMatcher_isMaskSupported;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_BFMatcher_infoDelegate(IntPtr obj);
        [NativeDelegate("features2d_BFMatcher_info")] public static features2d_BFMatcher_infoDelegate features2d_BFMatcher_info;
        */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_Ptr_BFMatcher_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_BFMatcher_get")] public static ObjFunc features2d_Ptr_BFMatcher_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_BFMatcher_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_BFMatcher_delete")] public static ReleaseFunc features2d_Ptr_BFMatcher_delete;

        // FlannBasedMatcher
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_FlannBasedMatcher_newDelegate(
            IntPtr indexParams, IntPtr searchParams);
        [NativeDelegate("features2d_FlannBasedMatcher_new")] public static features2d_FlannBasedMatcher_newDelegate features2d_FlannBasedMatcher_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_FlannBasedMatcher_deleteDelegate(IntPtr obj);
        [NativeDelegate("features2d_FlannBasedMatcher_delete")] public static features2d_FlannBasedMatcher_deleteDelegate features2d_FlannBasedMatcher_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_FlannBasedMatcher_addDelegate(
            IntPtr obj, IntPtr[] descriptors, int descriptorsSize);
        [NativeDelegate("features2d_FlannBasedMatcher_add")] public static features2d_FlannBasedMatcher_addDelegate features2d_FlannBasedMatcher_add;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_FlannBasedMatcher_clearDelegate(IntPtr obj);
        [NativeDelegate("features2d_FlannBasedMatcher_clear")] public static features2d_FlannBasedMatcher_clearDelegate features2d_FlannBasedMatcher_clear;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_FlannBasedMatcher_trainDelegate(IntPtr obj);
        [NativeDelegate("features2d_FlannBasedMatcher_train")] public static features2d_FlannBasedMatcher_trainDelegate features2d_FlannBasedMatcher_train;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_FlannBasedMatcher_isMaskSupportedDelegate(IntPtr obj);
        [NativeDelegate("features2d_FlannBasedMatcher_isMaskSupported")] public static features2d_FlannBasedMatcher_isMaskSupportedDelegate features2d_FlannBasedMatcher_isMaskSupported;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_FlannBasedMatcher_infoDelegate(IntPtr obj);
        [NativeDelegate("features2d_FlannBasedMatcher_info")] public static features2d_FlannBasedMatcher_infoDelegate features2d_FlannBasedMatcher_info;
        */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_Ptr_FlannBasedMatcher_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_FlannBasedMatcher_get")] public static ObjFunc features2d_Ptr_FlannBasedMatcher_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_FlannBasedMatcher_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_FlannBasedMatcher_delete")] public static ReleaseFunc features2d_Ptr_FlannBasedMatcher_delete;

    }
}
