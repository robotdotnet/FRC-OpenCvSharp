using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        /*
        // DescriptorExtractor
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_DescriptorExtractor_deleteDelegate(IntPtr obj);
        [NativeDelegate("features2d_DescriptorExtractor_delete")] public static features2d_DescriptorExtractor_deleteDelegate features2d_DescriptorExtractor_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_DescriptorExtractor_compute1Delegate(
            IntPtr obj, IntPtr image, IntPtr keypoint, IntPtr descriptors);
        [NativeDelegate("features2d_DescriptorExtractor_compute1")] public static features2d_DescriptorExtractor_compute1Delegate features2d_DescriptorExtractor_compute1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_DescriptorExtractor_compute2Delegate(
            IntPtr obj, IntPtr[] images, int imagesSize, IntPtr keypoints, 
            IntPtr[] descriptors, int descriptorsSize);
        [NativeDelegate("features2d_DescriptorExtractor_compute2")] public static features2d_DescriptorExtractor_compute2Delegate features2d_DescriptorExtractor_compute2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_DescriptorExtractor_descriptorSizeDelegate(IntPtr obj);
        [NativeDelegate("features2d_DescriptorExtractor_descriptorSize")] public static features2d_DescriptorExtractor_descriptorSizeDelegate features2d_DescriptorExtractor_descriptorSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_DescriptorExtractor_descriptorTypeDelegate(IntPtr obj);
        [NativeDelegate("features2d_DescriptorExtractor_descriptorType")] public static features2d_DescriptorExtractor_descriptorTypeDelegate features2d_DescriptorExtractor_descriptorType;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_DescriptorExtractor_emptyDelegate(IntPtr obj);
        [NativeDelegate("features2d_DescriptorExtractor_empty")] public static features2d_DescriptorExtractor_emptyDelegate features2d_DescriptorExtractor_empty;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_DescriptorExtractor_infoDelegate(IntPtr obj);
        [NativeDelegate("features2d_DescriptorExtractor_info")] public static features2d_DescriptorExtractor_infoDelegate features2d_DescriptorExtractor_info;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_DescriptorExtractor_createDelegate(
            [MarshalAs(UnmanagedType.LPStr)] string descriptorExtractorType);
        [NativeDelegate("features2d_DescriptorExtractor_create")] public static features2d_DescriptorExtractor_createDelegate features2d_DescriptorExtractor_create;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_Ptr_DescriptorExtractor_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_DescriptorExtractor_get")] public static features2d_Ptr_DescriptorExtractor_getDelegate features2d_Ptr_DescriptorExtractor_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_DescriptorExtractor_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_DescriptorExtractor_delete")] public static features2d_Ptr_DescriptorExtractor_deleteDelegate features2d_Ptr_DescriptorExtractor_delete;
        */
    }
}
