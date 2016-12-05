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
        public delegate IntPtr features2d_Ptr_Feature2D_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_Feature2D_get")] public static ObjFunc features2d_Ptr_Feature2D_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_Feature2D_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_Feature2D_delete")] public static ReleaseFunc features2d_Ptr_Feature2D_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Feature2D_detect_Mat1Delegate(IntPtr detector, IntPtr image, IntPtr keypoints, IntPtr mask);
        [NativeDelegate("features2d_Feature2D_detect_Mat1")] public static features2d_Feature2D_detect_Mat1Delegate features2d_Feature2D_detect_Mat1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Feature2D_detect_Mat2Delegate(IntPtr detector, IntPtr[] images, int imageLength, IntPtr keypoints, IntPtr[] mask);
        [NativeDelegate("features2d_Feature2D_detect_Mat2")] public static features2d_Feature2D_detect_Mat2Delegate features2d_Feature2D_detect_Mat2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Feature2D_detect_InputArrayDelegate(IntPtr detector, IntPtr image, IntPtr keypoints, IntPtr mask);
        [NativeDelegate("features2d_Feature2D_detect_InputArray")] public static features2d_Feature2D_detect_InputArrayDelegate features2d_Feature2D_detect_InputArray;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Feature2D_compute1Delegate(IntPtr obj, IntPtr image, IntPtr keypoints, IntPtr descriptors);
        [NativeDelegate("features2d_Feature2D_compute1")] public static features2d_Feature2D_compute1Delegate features2d_Feature2D_compute1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Feature2D_compute2Delegate(
            IntPtr detector, IntPtr[] images, int imageLength,
            IntPtr keypoints, IntPtr[] descriptors, int descriptorsLength);
        [NativeDelegate("features2d_Feature2D_compute2")] public static features2d_Feature2D_compute2Delegate features2d_Feature2D_compute2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Feature2D_detectAndComputeDelegate(
            IntPtr detector, IntPtr image, IntPtr mask,
            IntPtr keypoints, IntPtr descriptors, int useProvidedKeypoints);
        [NativeDelegate("features2d_Feature2D_detectAndCompute")] public static features2d_Feature2D_detectAndComputeDelegate features2d_Feature2D_detectAndCompute;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_Feature2D_descriptorSizeDelegate(IntPtr obj);
        [NativeDelegate("features2d_Feature2D_descriptorSize")] public static features2d_Feature2D_descriptorSizeDelegate features2d_Feature2D_descriptorSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_Feature2D_descriptorTypeDelegate(IntPtr obj);
        [NativeDelegate("features2d_Feature2D_descriptorType")] public static features2d_Feature2D_descriptorTypeDelegate features2d_Feature2D_descriptorType;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_Feature2D_defaultNormDelegate(IntPtr obj);
        [NativeDelegate("features2d_Feature2D_defaultNorm")] public static features2d_Feature2D_defaultNormDelegate features2d_Feature2D_defaultNorm;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_Feature2D_emptyDelegate(IntPtr obj);
        [NativeDelegate("features2d_Feature2D_empty")] public static features2d_Feature2D_emptyDelegate features2d_Feature2D_empty;
    }
}
