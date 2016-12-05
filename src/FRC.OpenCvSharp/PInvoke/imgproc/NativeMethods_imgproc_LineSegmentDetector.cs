using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591
// ReSharper disable InconsistentNaming

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LineSegmentDetector_detect_OutputArrayDelegate(IntPtr obj, IntPtr image, IntPtr lines,
            IntPtr width, IntPtr prec, IntPtr nfa);
        [NativeDelegate("imgproc_LineSegmentDetector_detect_OutputArray")] public static imgproc_LineSegmentDetector_detect_OutputArrayDelegate imgproc_LineSegmentDetector_detect_OutputArray;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LineSegmentDetector_detect_vectorDelegate(IntPtr obj, IntPtr image, IntPtr lines,
            IntPtr width, IntPtr prec, IntPtr nfa);
        [NativeDelegate("imgproc_LineSegmentDetector_detect_vector")] public static imgproc_LineSegmentDetector_detect_vectorDelegate imgproc_LineSegmentDetector_detect_vector;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LineSegmentDetector_drawSegmentsDelegate(IntPtr obj, IntPtr image, IntPtr lines);
        [NativeDelegate("imgproc_LineSegmentDetector_drawSegments")] public static imgproc_LineSegmentDetector_drawSegmentsDelegate imgproc_LineSegmentDetector_drawSegments;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_LineSegmentDetector_compareSegmentsDelegate(IntPtr obj, Size size,
            IntPtr lines1, IntPtr lines2, IntPtr image);
        [NativeDelegate("imgproc_LineSegmentDetector_compareSegments")] public static imgproc_LineSegmentDetector_compareSegmentsDelegate imgproc_LineSegmentDetector_compareSegments;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_createLineSegmentDetectorDelegate(
            int refine, double scale, double sigma_scale, double quant, double ang_th,
            double log_eps, double density_th, int n_bins);
        [NativeDelegate("imgproc_createLineSegmentDetector")] public static imgproc_createLineSegmentDetectorDelegate imgproc_createLineSegmentDetector;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_Ptr_LineSegmentDetector_deleteDelegate(IntPtr obj);
        [NativeDelegate("imgproc_Ptr_LineSegmentDetector_delete")] public static ReleaseFunc imgproc_Ptr_LineSegmentDetector_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_Ptr_LineSegmentDetector_getDelegate(IntPtr obj);
        [NativeDelegate("imgproc_Ptr_LineSegmentDetector_get")] public static ObjFunc imgproc_Ptr_LineSegmentDetector_get;
    }
}
