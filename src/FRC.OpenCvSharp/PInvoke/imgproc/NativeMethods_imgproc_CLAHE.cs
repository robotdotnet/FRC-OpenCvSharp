using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_createCLAHEDelegate(double clipLimit, Size tileGridSize);
        [NativeDelegate("imgproc_createCLAHE")] public static imgproc_createCLAHEDelegate imgproc_createCLAHE;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_Ptr_CLAHE_deleteDelegate(IntPtr obj);
        [NativeDelegate("imgproc_Ptr_CLAHE_delete")] public static ReleaseFunc imgproc_Ptr_CLAHE_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_Ptr_CLAHE_getDelegate(IntPtr obj);
        [NativeDelegate("imgproc_Ptr_CLAHE_get")] public static ObjFunc imgproc_Ptr_CLAHE_get;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_CLAHE_infoDelegate(IntPtr obj);
        [NativeDelegate("imgproc_CLAHE_info")] public static imgproc_CLAHE_infoDelegate imgproc_CLAHE_info;
        */

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_CLAHE_applyDelegate(IntPtr obj, IntPtr src, IntPtr dst);
        [NativeDelegate("imgproc_CLAHE_apply")] public static imgproc_CLAHE_applyDelegate imgproc_CLAHE_apply;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_CLAHE_setClipLimitDelegate(IntPtr obj, double clipLimit);
        [NativeDelegate("imgproc_CLAHE_setClipLimit")] public static imgproc_CLAHE_setClipLimitDelegate imgproc_CLAHE_setClipLimit;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_CLAHE_getClipLimitDelegate(IntPtr obj);
        [NativeDelegate("imgproc_CLAHE_getClipLimit")] public static imgproc_CLAHE_getClipLimitDelegate imgproc_CLAHE_getClipLimit;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_CLAHE_setTilesGridSizeDelegate(IntPtr obj, Size tileGridSize);
        [NativeDelegate("imgproc_CLAHE_setTilesGridSize")] public static imgproc_CLAHE_setTilesGridSizeDelegate imgproc_CLAHE_setTilesGridSize;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size imgproc_CLAHE_getTilesGridSizeDelegate(IntPtr obj);
        [NativeDelegate("imgproc_CLAHE_getTilesGridSize")] public static imgproc_CLAHE_getTilesGridSizeDelegate imgproc_CLAHE_getTilesGridSize;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_CLAHE_collectGarbageDelegate(IntPtr obj);
        [NativeDelegate("imgproc_CLAHE_collectGarbage")] public static imgproc_CLAHE_collectGarbageDelegate imgproc_CLAHE_collectGarbage;
    }
}
