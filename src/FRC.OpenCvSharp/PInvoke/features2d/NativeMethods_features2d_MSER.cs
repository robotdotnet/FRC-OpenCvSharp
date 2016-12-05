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
        public delegate IntPtr features2d_MSER_createDelegate(int delta, int minArea, int maxArea,
                                                        double maxVariation, double minDiversity, int maxEvolution,
                                                        double areaThreshold, double minMargin, int edgeBlurSize);
        [NativeDelegate("features2d_MSER_create")] public static features2d_MSER_createDelegate features2d_MSER_create;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_MSER_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_MSER_delete")] public static ReleaseFunc features2d_Ptr_MSER_delete;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_MSER_detectDelegate(IntPtr obj, IntPtr image, out IntPtr msers, IntPtr mask);
        [NativeDelegate("features2d_MSER_detect")] public static features2d_MSER_detectDelegate features2d_MSER_detect;
        */
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_MSER_infoDelegate(IntPtr obj);
        [NativeDelegate("features2d_MSER_info")] public static features2d_MSER_infoDelegate features2d_MSER_info;
        */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_Ptr_MSER_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_MSER_get")] public static ObjFunc features2d_Ptr_MSER_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_MSER_detectRegionsDelegate(
            IntPtr obj, IntPtr image,
            IntPtr msers,
            IntPtr bboxes);
        [NativeDelegate("features2d_MSER_detectRegions")] public static features2d_MSER_detectRegionsDelegate features2d_MSER_detectRegions;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_MSER_setDeltaDelegate(IntPtr obj, int delta);
        [NativeDelegate("features2d_MSER_setDelta")] public static features2d_MSER_setDeltaDelegate features2d_MSER_setDelta;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_MSER_getDeltaDelegate(IntPtr obj);
        [NativeDelegate("features2d_MSER_getDelta")] public static features2d_MSER_getDeltaDelegate features2d_MSER_getDelta;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_MSER_setMinAreaDelegate(IntPtr obj, int minArea);
        [NativeDelegate("features2d_MSER_setMinArea")] public static features2d_MSER_setMinAreaDelegate features2d_MSER_setMinArea;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_MSER_getMinAreaDelegate(IntPtr obj);
        [NativeDelegate("features2d_MSER_getMinArea")] public static features2d_MSER_getMinAreaDelegate features2d_MSER_getMinArea;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_MSER_setMaxAreaDelegate(IntPtr obj, int maxArea);
        [NativeDelegate("features2d_MSER_setMaxArea")] public static features2d_MSER_setMaxAreaDelegate features2d_MSER_setMaxArea;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_MSER_getMaxAreaDelegate(IntPtr obj);
        [NativeDelegate("features2d_MSER_getMaxArea")] public static features2d_MSER_getMaxAreaDelegate features2d_MSER_getMaxArea;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_MSER_setPass2OnlyDelegate(IntPtr obj, int f);
        [NativeDelegate("features2d_MSER_setPass2Only")] public static features2d_MSER_setPass2OnlyDelegate features2d_MSER_setPass2Only;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_MSER_getPass2OnlyDelegate(IntPtr obj);
        [NativeDelegate("features2d_MSER_getPass2Only")] public static features2d_MSER_getPass2OnlyDelegate features2d_MSER_getPass2Only;
    }
}
