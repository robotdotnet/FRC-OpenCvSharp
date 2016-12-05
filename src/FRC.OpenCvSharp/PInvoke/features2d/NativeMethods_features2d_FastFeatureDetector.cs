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
        public delegate void features2d_FAST1Delegate(IntPtr image, IntPtr keypoints, int threshold, int nonmaxSupression);
        [NativeDelegate("features2d_FAST1")] public static features2d_FAST1Delegate features2d_FAST1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_FAST2Delegate(IntPtr image, IntPtr keypoints, int threshold, int nonmaxSupression, int type);
        [NativeDelegate("features2d_FAST2")] public static features2d_FAST2Delegate features2d_FAST2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_FastFeatureDetector_createDelegate(int threshold, int nonmaxSuppression);
        [NativeDelegate("features2d_FastFeatureDetector_create")] public static features2d_FastFeatureDetector_createDelegate features2d_FastFeatureDetector_create;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_FastFeatureDetector_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_FastFeatureDetector_delete")] public static ReleaseFunc features2d_Ptr_FastFeatureDetector_delete;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_FastFeatureDetector_infoDelegate(IntPtr obj);
        [NativeDelegate("features2d_FastFeatureDetector_info")] public static features2d_FastFeatureDetector_infoDelegate features2d_FastFeatureDetector_info;
        */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_Ptr_FastFeatureDetector_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_FastFeatureDetector_get")] public static ObjFunc features2d_Ptr_FastFeatureDetector_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_FastFeatureDetector_setThresholdDelegate(IntPtr obj, int threshold);
        [NativeDelegate("features2d_FastFeatureDetector_setThreshold")] public static features2d_FastFeatureDetector_setThresholdDelegate features2d_FastFeatureDetector_setThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_FastFeatureDetector_getThresholdDelegate(IntPtr obj);
        [NativeDelegate("features2d_FastFeatureDetector_getThreshold")] public static features2d_FastFeatureDetector_getThresholdDelegate features2d_FastFeatureDetector_getThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_FastFeatureDetector_setNonmaxSuppressionDelegate(IntPtr obj, int f);
        [NativeDelegate("features2d_FastFeatureDetector_setNonmaxSuppression")] public static features2d_FastFeatureDetector_setNonmaxSuppressionDelegate features2d_FastFeatureDetector_setNonmaxSuppression;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_FastFeatureDetector_getNonmaxSuppressionDelegate(IntPtr obj);
        [NativeDelegate("features2d_FastFeatureDetector_getNonmaxSuppression")] public static features2d_FastFeatureDetector_getNonmaxSuppressionDelegate features2d_FastFeatureDetector_getNonmaxSuppression;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_FastFeatureDetector_setTypeDelegate(IntPtr obj, int type);
        [NativeDelegate("features2d_FastFeatureDetector_setType")] public static features2d_FastFeatureDetector_setTypeDelegate features2d_FastFeatureDetector_setType;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_FastFeatureDetector_getTypeDelegate(IntPtr obj);
        [NativeDelegate("features2d_FastFeatureDetector_getType")] public static features2d_FastFeatureDetector_getTypeDelegate features2d_FastFeatureDetector_getType;
    }
}
