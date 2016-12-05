using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_LineIterator_newDelegate(
            IntPtr img, Point pt1, Point pt2, int connectivity, int leftToRight);
        [NativeDelegate("imgproc_LineIterator_new")] public static imgproc_LineIterator_newDelegate imgproc_LineIterator_new;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LineIterator_deleteDelegate(IntPtr obj);
        [NativeDelegate("imgproc_LineIterator_delete")] public static imgproc_LineIterator_deleteDelegate imgproc_LineIterator_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_LineIterator_operatorEntityDelegate(IntPtr obj);
        [NativeDelegate("imgproc_LineIterator_operatorEntity")] public static imgproc_LineIterator_operatorEntityDelegate imgproc_LineIterator_operatorEntity;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LineIterator_operatorPPDelegate(IntPtr obj);
        [NativeDelegate("imgproc_LineIterator_operatorPP")] public static imgproc_LineIterator_operatorPPDelegate imgproc_LineIterator_operatorPP;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Point imgproc_LineIterator_posDelegate(IntPtr obj);
        [NativeDelegate("imgproc_LineIterator_pos")] public static imgproc_LineIterator_posDelegate imgproc_LineIterator_pos;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_LineIterator_ptr_getDelegate(IntPtr obj);
        [NativeDelegate("imgproc_LineIterator_ptr_get")] public static imgproc_LineIterator_ptr_getDelegate imgproc_LineIterator_ptr_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LineIterator_ptr_setDelegate(IntPtr obj, IntPtr val);
        [NativeDelegate("imgproc_LineIterator_ptr_set")] public static imgproc_LineIterator_ptr_setDelegate imgproc_LineIterator_ptr_set;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_LineIterator_ptr0_getDelegate(IntPtr obj);
        [NativeDelegate("imgproc_LineIterator_ptr0_get")] public static imgproc_LineIterator_ptr0_getDelegate imgproc_LineIterator_ptr0_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_LineIterator_step_getDelegate(IntPtr obj);
        [NativeDelegate("imgproc_LineIterator_step_get")] public static imgproc_LineIterator_step_getDelegate imgproc_LineIterator_step_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LineIterator_step_setDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_LineIterator_step_set")] public static imgproc_LineIterator_step_setDelegate imgproc_LineIterator_step_set;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_LineIterator_elemSize_getDelegate(IntPtr obj);
        [NativeDelegate("imgproc_LineIterator_elemSize_get")] public static imgproc_LineIterator_elemSize_getDelegate imgproc_LineIterator_elemSize_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LineIterator_elemSize_setDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_LineIterator_elemSize_set")] public static imgproc_LineIterator_elemSize_setDelegate imgproc_LineIterator_elemSize_set;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_LineIterator_err_getDelegate(IntPtr obj);
        [NativeDelegate("imgproc_LineIterator_err_get")] public static imgproc_LineIterator_err_getDelegate imgproc_LineIterator_err_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LineIterator_err_setDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_LineIterator_err_set")] public static imgproc_LineIterator_err_setDelegate imgproc_LineIterator_err_set;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_LineIterator_count_getDelegate(IntPtr obj);
        [NativeDelegate("imgproc_LineIterator_count_get")] public static imgproc_LineIterator_count_getDelegate imgproc_LineIterator_count_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LineIterator_count_setDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_LineIterator_count_set")] public static imgproc_LineIterator_count_setDelegate imgproc_LineIterator_count_set;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_LineIterator_minusDelta_getDelegate(IntPtr obj);
        [NativeDelegate("imgproc_LineIterator_minusDelta_get")] public static imgproc_LineIterator_minusDelta_getDelegate imgproc_LineIterator_minusDelta_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LineIterator_minusDelta_setDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_LineIterator_minusDelta_set")] public static imgproc_LineIterator_minusDelta_setDelegate imgproc_LineIterator_minusDelta_set;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_LineIterator_plusDelta_getDelegate(IntPtr obj);
        [NativeDelegate("imgproc_LineIterator_plusDelta_get")] public static imgproc_LineIterator_plusDelta_getDelegate imgproc_LineIterator_plusDelta_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LineIterator_plusDelta_setDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_LineIterator_plusDelta_set")] public static imgproc_LineIterator_plusDelta_setDelegate imgproc_LineIterator_plusDelta_set;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_LineIterator_minusStep_getDelegate(IntPtr obj);
        [NativeDelegate("imgproc_LineIterator_minusStep_get")] public static imgproc_LineIterator_minusStep_getDelegate imgproc_LineIterator_minusStep_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LineIterator_minusStep_setDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_LineIterator_minusStep_set")] public static imgproc_LineIterator_minusStep_setDelegate imgproc_LineIterator_minusStep_set;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_LineIterator_plusStep_getDelegate(IntPtr obj);
        [NativeDelegate("imgproc_LineIterator_plusStep_get")] public static imgproc_LineIterator_plusStep_getDelegate imgproc_LineIterator_plusStep_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LineIterator_plusStep_setDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_LineIterator_plusStep_set")] public static imgproc_LineIterator_plusStep_setDelegate imgproc_LineIterator_plusStep_set;
    }
}
