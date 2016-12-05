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
        public delegate void features2d_AGASTDelegate(IntPtr image, IntPtr keypoints,
            int threshold, int nonmaxSuppression, int type);
        [NativeDelegate("features2d_AGAST")] public static features2d_AGASTDelegate features2d_AGAST;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_AgastFeatureDetector_createDelegate(
            int threshold, int nonmaxSuppression, int type);
        [NativeDelegate("features2d_AgastFeatureDetector_create")] public static features2d_AgastFeatureDetector_createDelegate features2d_AgastFeatureDetector_create;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_AgastFeatureDetector_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_AgastFeatureDetector_delete")] public static ReleaseFunc features2d_Ptr_AgastFeatureDetector_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_Ptr_AgastFeatureDetector_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_AgastFeatureDetector_get")] public static ObjFunc features2d_Ptr_AgastFeatureDetector_get;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_AgastFeatureDetector_setThresholdDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_AgastFeatureDetector_setThreshold")] public static features2d_AgastFeatureDetector_setThresholdDelegate features2d_AgastFeatureDetector_setThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_AgastFeatureDetector_getThresholdDelegate(IntPtr obj);
        [NativeDelegate("features2d_AgastFeatureDetector_getThreshold")] public static features2d_AgastFeatureDetector_getThresholdDelegate features2d_AgastFeatureDetector_getThreshold;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_AgastFeatureDetector_setNonmaxSuppressionDelegate(IntPtr obj,int val);
        [NativeDelegate("features2d_AgastFeatureDetector_setNonmaxSuppression")] public static features2d_AgastFeatureDetector_setNonmaxSuppressionDelegate features2d_AgastFeatureDetector_setNonmaxSuppression;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_AgastFeatureDetector_getNonmaxSuppressionDelegate(IntPtr obj);
        [NativeDelegate("features2d_AgastFeatureDetector_getNonmaxSuppression")] public static features2d_AgastFeatureDetector_getNonmaxSuppressionDelegate features2d_AgastFeatureDetector_getNonmaxSuppression;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_AgastFeatureDetector_setTypeDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_AgastFeatureDetector_setType")] public static features2d_AgastFeatureDetector_setTypeDelegate features2d_AgastFeatureDetector_setType;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_AgastFeatureDetector_getTypeDelegate(IntPtr obj);
        [NativeDelegate("features2d_AgastFeatureDetector_getType")] public static features2d_AgastFeatureDetector_getTypeDelegate features2d_AgastFeatureDetector_getType;
    }
}
