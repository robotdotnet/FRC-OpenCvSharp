using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    // ReSharper disable InconsistentNaming

    partial class NativeMethods
    {
        #region Init & Disposal
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_GpuMat_deleteDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_delete")] public static cuda_GpuMat_deleteDelegate cuda_GpuMat_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_new1Delegate();
        [NativeDelegate("cuda_GpuMat_new1")] public static cuda_GpuMat_new1Delegate cuda_GpuMat_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_new2Delegate(int rows, int cols, int type);
        [NativeDelegate("cuda_GpuMat_new2")] public static cuda_GpuMat_new2Delegate cuda_GpuMat_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_new3Delegate(int rows, int cols, int type, IntPtr data, ulong step);
        [NativeDelegate("cuda_GpuMat_new3")] public static cuda_GpuMat_new3Delegate cuda_GpuMat_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_new4Delegate(IntPtr mat);
        [NativeDelegate("cuda_GpuMat_new4")] public static cuda_GpuMat_new4Delegate cuda_GpuMat_new4;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_new5Delegate(IntPtr gpumat);
        [NativeDelegate("cuda_GpuMat_new5")] public static cuda_GpuMat_new5Delegate cuda_GpuMat_new5;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_new6Delegate(Size size, int type);
        [NativeDelegate("cuda_GpuMat_new6")] public static cuda_GpuMat_new6Delegate cuda_GpuMat_new6;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_new7Delegate(Size size, int type, IntPtr data, ulong step);
        [NativeDelegate("cuda_GpuMat_new7")] public static cuda_GpuMat_new7Delegate cuda_GpuMat_new7;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_new8Delegate(int rows, int cols, int type, Scalar s);
        [NativeDelegate("cuda_GpuMat_new8")] public static cuda_GpuMat_new8Delegate cuda_GpuMat_new8;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_new9Delegate(IntPtr m, Range rowRange, Range colRange);
        [NativeDelegate("cuda_GpuMat_new9")] public static cuda_GpuMat_new9Delegate cuda_GpuMat_new9;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_new10Delegate(IntPtr m, Rect roi);
        [NativeDelegate("cuda_GpuMat_new10")] public static cuda_GpuMat_new10Delegate cuda_GpuMat_new10;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_new11Delegate(Size size, int type, Scalar s);
        [NativeDelegate("cuda_GpuMat_new11")] public static cuda_GpuMat_new11Delegate cuda_GpuMat_new11;
        
        #endregion

        #region Operators

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_opToMatDelegate(IntPtr src);
        [NativeDelegate("cuda_GpuMat_opToMat")] public static cuda_GpuMat_opToMatDelegate cuda_GpuMat_opToMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_opToGpuMatDelegate(IntPtr src);
        [NativeDelegate("cuda_GpuMat_opToGpuMat")] public static cuda_GpuMat_opToGpuMatDelegate cuda_GpuMat_opToGpuMat;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_GpuMat_opAssignDelegate(IntPtr left, IntPtr right);
        [NativeDelegate("cuda_GpuMat_opAssign")] public static cuda_GpuMat_opAssignDelegate cuda_GpuMat_opAssign;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_opRange1Delegate(IntPtr src, Rect roi);
        [NativeDelegate("cuda_GpuMat_opRange1")] public static cuda_GpuMat_opRange1Delegate cuda_GpuMat_opRange1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_opRange2Delegate(IntPtr src, Range rowRange, Range colRange);
        [NativeDelegate("cuda_GpuMat_opRange2")] public static cuda_GpuMat_opRange2Delegate cuda_GpuMat_opRange2;
        
        #endregion

        #region Fields

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_GpuMat_flagsDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_flags")] public static cuda_GpuMat_flagsDelegate cuda_GpuMat_flags;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_GpuMat_rowsDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_rows")] public static cuda_GpuMat_rowsDelegate cuda_GpuMat_rows;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_GpuMat_colsDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_cols")] public static cuda_GpuMat_colsDelegate cuda_GpuMat_cols;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong cuda_GpuMat_stepDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_step")] public static cuda_GpuMat_stepDelegate cuda_GpuMat_step;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate byte* cuda_GpuMat_dataDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_data")] public static cuda_GpuMat_dataDelegate cuda_GpuMat_data;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_refcountDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_refcount")] public static cuda_GpuMat_refcountDelegate cuda_GpuMat_refcount;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_datastartDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_datastart")] public static cuda_GpuMat_datastartDelegate cuda_GpuMat_datastart;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_dataendDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_dataend")] public static cuda_GpuMat_dataendDelegate cuda_GpuMat_dataend;
        #endregion

        #region Methods
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_GpuMat_uploadDelegate(IntPtr obj, IntPtr mat);
        [NativeDelegate("cuda_GpuMat_upload")] public static cuda_GpuMat_uploadDelegate cuda_GpuMat_upload;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_GpuMat_downloadDelegate(IntPtr obj, IntPtr mat);
        [NativeDelegate("cuda_GpuMat_download")] public static cuda_GpuMat_downloadDelegate cuda_GpuMat_download;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_rowDelegate(IntPtr obj, int y);
        [NativeDelegate("cuda_GpuMat_row")] public static cuda_GpuMat_rowDelegate cuda_GpuMat_row;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_colDelegate(IntPtr obj, int x);
        [NativeDelegate("cuda_GpuMat_col")] public static cuda_GpuMat_colDelegate cuda_GpuMat_col;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_rowRangeDelegate(IntPtr obj, int startrow, int endrow);
        [NativeDelegate("cuda_GpuMat_rowRange")] public static cuda_GpuMat_rowRangeDelegate cuda_GpuMat_rowRange;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_colRangeDelegate(IntPtr obj, int startcol, int endcol);
        [NativeDelegate("cuda_GpuMat_colRange")] public static cuda_GpuMat_colRangeDelegate cuda_GpuMat_colRange;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_cloneDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_clone")] public static cuda_GpuMat_cloneDelegate cuda_GpuMat_clone;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_GpuMat_copyTo1Delegate(IntPtr obj, IntPtr m);
        [NativeDelegate("cuda_GpuMat_copyTo1")] public static cuda_GpuMat_copyTo1Delegate cuda_GpuMat_copyTo1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_GpuMat_copyTo2Delegate(IntPtr obj, IntPtr m, IntPtr mask);
        [NativeDelegate("cuda_GpuMat_copyTo2")] public static cuda_GpuMat_copyTo2Delegate cuda_GpuMat_copyTo2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_GpuMat_convertToDelegate(IntPtr obj, IntPtr m, int rtype, double alpha, double beta);
        [NativeDelegate("cuda_GpuMat_convertTo")] public static cuda_GpuMat_convertToDelegate cuda_GpuMat_convertTo;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_GpuMat_assignToDelegate(IntPtr obj, IntPtr m, int type);
        [NativeDelegate("cuda_GpuMat_assignTo")] public static cuda_GpuMat_assignToDelegate cuda_GpuMat_assignTo;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_setToDelegate(IntPtr obj, Scalar s, IntPtr mask);
        [NativeDelegate("cuda_GpuMat_setTo")] public static cuda_GpuMat_setToDelegate cuda_GpuMat_setTo;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_reshapeDelegate(IntPtr obj, int cn, int rows);
        [NativeDelegate("cuda_GpuMat_reshape")] public static cuda_GpuMat_reshapeDelegate cuda_GpuMat_reshape;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_GpuMat_create1Delegate(IntPtr obj, int rows, int cols, int type);
        [NativeDelegate("cuda_GpuMat_create1")] public static cuda_GpuMat_create1Delegate cuda_GpuMat_create1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_GpuMat_create2Delegate(IntPtr obj, Size size, int type);
        [NativeDelegate("cuda_GpuMat_create2")] public static cuda_GpuMat_create2Delegate cuda_GpuMat_create2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_GpuMat_releaseDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_release")] public static cuda_GpuMat_releaseDelegate cuda_GpuMat_release;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_GpuMat_swapDelegate(IntPtr obj, IntPtr mat);
        [NativeDelegate("cuda_GpuMat_swap")] public static cuda_GpuMat_swapDelegate cuda_GpuMat_swap;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_GpuMat_locateROIDelegate(IntPtr obj, out Size wholeSize, out Point ofs);
        [NativeDelegate("cuda_GpuMat_locateROI")] public static cuda_GpuMat_locateROIDelegate cuda_GpuMat_locateROI;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_GpuMat_adjustROIDelegate(IntPtr obj, int dtop, int dbottom, int dleft, int drightt);
        [NativeDelegate("cuda_GpuMat_adjustROI")] public static cuda_GpuMat_adjustROIDelegate cuda_GpuMat_adjustROI;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_GpuMat_isContinuousDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_isContinuous")] public static cuda_GpuMat_isContinuousDelegate cuda_GpuMat_isContinuous;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong cuda_GpuMat_elemSizeDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_elemSize")] public static cuda_GpuMat_elemSizeDelegate cuda_GpuMat_elemSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong cuda_GpuMat_elemSize1Delegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_elemSize1")] public static cuda_GpuMat_elemSize1Delegate cuda_GpuMat_elemSize1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_GpuMat_typeDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_type")] public static cuda_GpuMat_typeDelegate cuda_GpuMat_type;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_GpuMat_depthDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_depth")] public static cuda_GpuMat_depthDelegate cuda_GpuMat_depth;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_GpuMat_channelsDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_channels")] public static cuda_GpuMat_channelsDelegate cuda_GpuMat_channels;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong cuda_GpuMat_step1Delegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_step1")] public static cuda_GpuMat_step1Delegate cuda_GpuMat_step1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size cuda_GpuMat_sizeDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_size")] public static cuda_GpuMat_sizeDelegate cuda_GpuMat_size;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_GpuMat_emptyDelegate(IntPtr obj);
        [NativeDelegate("cuda_GpuMat_empty")] public static cuda_GpuMat_emptyDelegate cuda_GpuMat_empty;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate byte* cuda_GpuMat_ptrDelegate(IntPtr obj, int y);
        [NativeDelegate("cuda_GpuMat_ptr")] public static cuda_GpuMat_ptrDelegate cuda_GpuMat_ptr;
        #endregion

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_createContinuous1Delegate(
            int rows, int cols, int type, IntPtr gm);
        [NativeDelegate("cuda_createContinuous1")] public static cuda_createContinuous1Delegate cuda_createContinuous1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_createContinuous2Delegate(
            int rows, int cols, int type);
        [NativeDelegate("cuda_createContinuous2")] public static cuda_createContinuous2Delegate cuda_createContinuous2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_ensureSizeIsEnoughDelegate(
            int rows, int cols, int type, IntPtr m);
        [NativeDelegate("cuda_ensureSizeIsEnough")] public static cuda_ensureSizeIsEnoughDelegate cuda_ensureSizeIsEnough;
    }
}
