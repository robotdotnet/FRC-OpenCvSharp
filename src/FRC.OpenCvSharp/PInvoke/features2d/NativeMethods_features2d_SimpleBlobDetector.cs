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
        public delegate IntPtr features2d_SimpleBlobDetector_createDelegate(
            ref SimpleBlobDetector.WParams parameters);
        [NativeDelegate("features2d_SimpleBlobDetector_create")] public static features2d_SimpleBlobDetector_createDelegate features2d_SimpleBlobDetector_create;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_Ptr_SimpleBlobDetector_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_SimpleBlobDetector_get")] public static ObjFunc features2d_Ptr_SimpleBlobDetector_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_SimpleBlobDetector_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_SimpleBlobDetector_delete")] public static ReleaseFunc features2d_Ptr_SimpleBlobDetector_delete;
    }
}
