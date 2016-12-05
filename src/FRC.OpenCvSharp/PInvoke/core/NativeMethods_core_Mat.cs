using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong core_Mat_sizeofDelegate();
        [NativeDelegate("core_Mat_sizeof")] public static core_Mat_sizeofDelegate core_Mat_sizeof;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_new1Delegate();
        [NativeDelegate("core_Mat_new1")] public static core_Mat_new1Delegate core_Mat_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_new2Delegate(int rows, int cols, int type);
        [NativeDelegate("core_Mat_new2")] public static core_Mat_new2Delegate core_Mat_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_new3Delegate(int rows, int cols, int type, Scalar scalar);
        [NativeDelegate("core_Mat_new3")] public static core_Mat_new3Delegate core_Mat_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_new4Delegate(IntPtr mat, Range rowRange, Range colRange);
        [NativeDelegate("core_Mat_new4")] public static core_Mat_new4Delegate core_Mat_new4;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_new5Delegate(IntPtr mat, Range rowRange);
        [NativeDelegate("core_Mat_new5")] public static core_Mat_new5Delegate core_Mat_new5;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_new6Delegate(IntPtr mat, [MarshalAs(UnmanagedType.LPArray)] Range[] rowRange);
        [NativeDelegate("core_Mat_new6")] public static core_Mat_new6Delegate core_Mat_new6;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_new7Delegate(IntPtr mat, Rect roi);
        [NativeDelegate("core_Mat_new7")] public static core_Mat_new7Delegate core_Mat_new7;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_new8Delegate(int rows, int cols, int type, IntPtr data, IntPtr step);
        [NativeDelegate("core_Mat_new8")] public static core_Mat_new8Delegate core_Mat_new8;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_new9Delegate(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sizes,
            int type, IntPtr data, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] steps);
        [NativeDelegate("core_Mat_new9")] public static core_Mat_new9Delegate core_Mat_new9;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_new9Delegate2(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sizes,
                                int type, IntPtr data, IntPtr steps);
        [NativeDelegate("core_Mat_new9")] public static core_Mat_new9Delegate2 core_Mat_new92;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_new10Delegate(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sizes, int type);
        [NativeDelegate("core_Mat_new10")] public static core_Mat_new10Delegate core_Mat_new10;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_new11Delegate(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sizes, int type, Scalar s);
        [NativeDelegate("core_Mat_new11")] public static core_Mat_new11Delegate core_Mat_new11;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_new_FromIplImageDelegate(IntPtr img, int copyData);
        [NativeDelegate("core_Mat_new_FromIplImage")] public static core_Mat_new_FromIplImageDelegate core_Mat_new_FromIplImage;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_new_FromCvMatDelegate(IntPtr mat, int copyData);
        [NativeDelegate("core_Mat_new_FromCvMat")] public static core_Mat_new_FromCvMatDelegate core_Mat_new_FromCvMat;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_releaseDelegate(IntPtr mat);
        [NativeDelegate("core_Mat_release")] public static core_Mat_releaseDelegate core_Mat_release;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_deleteDelegate(IntPtr mat);
        [NativeDelegate("core_Mat_delete")] public static core_Mat_deleteDelegate core_Mat_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_adjustROIDelegate(IntPtr nativeObj, int dtop, int dbottom, int dleft, int dright);
        [NativeDelegate("core_Mat_adjustROI")] public static core_Mat_adjustROIDelegate core_Mat_adjustROI;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_assignTo1Delegate(IntPtr self, IntPtr m);
        [NativeDelegate("core_Mat_assignTo1")] public static core_Mat_assignTo1Delegate core_Mat_assignTo1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_assignTo2Delegate(IntPtr self, IntPtr m, int type);
        [NativeDelegate("core_Mat_assignTo2")] public static core_Mat_assignTo2Delegate core_Mat_assignTo2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_channelsDelegate(IntPtr self);
        [NativeDelegate("core_Mat_channels")] public static core_Mat_channelsDelegate core_Mat_channels;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_checkVector1Delegate(IntPtr self, int elemChannels);
        [NativeDelegate("core_Mat_checkVector1")] public static core_Mat_checkVector1Delegate core_Mat_checkVector1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_checkVector2Delegate(IntPtr self, int elemChannels, int depth);
        [NativeDelegate("core_Mat_checkVector2")] public static core_Mat_checkVector2Delegate core_Mat_checkVector2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_checkVector3Delegate(IntPtr self, int elemChannels, int depth, int requireContinuous);
        [NativeDelegate("core_Mat_checkVector3")] public static core_Mat_checkVector3Delegate core_Mat_checkVector3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_cloneDelegate(IntPtr self);
        [NativeDelegate("core_Mat_clone")] public static core_Mat_cloneDelegate core_Mat_clone;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_col_toMatDelegate(IntPtr self, int x);
        [NativeDelegate("core_Mat_col_toMat")] public static core_Mat_col_toMatDelegate core_Mat_col_toMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_col_toMatExprDelegate(IntPtr self, int x);
        [NativeDelegate("core_Mat_col_toMatExpr")] public static core_Mat_col_toMatExprDelegate core_Mat_col_toMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_colsDelegate(IntPtr self);
        [NativeDelegate("core_Mat_cols")] public static core_Mat_colsDelegate core_Mat_cols;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_colRange_toMatDelegate(IntPtr self, int startCol, int endCol);
        [NativeDelegate("core_Mat_colRange_toMat")] public static core_Mat_colRange_toMatDelegate core_Mat_colRange_toMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_colRange_toMatExprDelegate(IntPtr self, int startCol, int endCol);
        [NativeDelegate("core_Mat_colRange_toMatExpr")] public static core_Mat_colRange_toMatExprDelegate core_Mat_colRange_toMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_dimsDelegate(IntPtr self);
        [NativeDelegate("core_Mat_dims")] public static core_Mat_dimsDelegate core_Mat_dims;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_convertToDelegate(IntPtr self, IntPtr m, int rtype, double alpha, double beta);
        [NativeDelegate("core_Mat_convertTo")] public static core_Mat_convertToDelegate core_Mat_convertTo;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_copyToDelegate(IntPtr self, IntPtr m, IntPtr mask);
        [NativeDelegate("core_Mat_copyTo")] public static core_Mat_copyToDelegate core_Mat_copyTo;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_create1Delegate(IntPtr self, int rows, int cols, int type);
        [NativeDelegate("core_Mat_create1")] public static core_Mat_create1Delegate core_Mat_create1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_create2Delegate(IntPtr self, int ndims,
            [MarshalAs(UnmanagedType.LPArray)] int[] sizes, int type);
        [NativeDelegate("core_Mat_create2")] public static core_Mat_create2Delegate core_Mat_create2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_crossDelegate(IntPtr self, IntPtr m);
        [NativeDelegate("core_Mat_cross")] public static core_Mat_crossDelegate core_Mat_cross;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate byte* core_Mat_dataDelegate(IntPtr self);
        [NativeDelegate("core_Mat_data")] public static core_Mat_dataDelegate core_Mat_data;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_datastartDelegate(IntPtr self);
        [NativeDelegate("core_Mat_datastart")] public static core_Mat_datastartDelegate core_Mat_datastart;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_dataendDelegate(IntPtr self);
        [NativeDelegate("core_Mat_dataend")] public static core_Mat_dataendDelegate core_Mat_dataend;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_datalimitDelegate(IntPtr self);
        [NativeDelegate("core_Mat_datalimit")] public static core_Mat_datalimitDelegate core_Mat_datalimit;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_depthDelegate(IntPtr self);
        [NativeDelegate("core_Mat_depth")] public static core_Mat_depthDelegate core_Mat_depth;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_diag1Delegate(IntPtr self);
        [NativeDelegate("core_Mat_diag1")] public static core_Mat_diag1Delegate core_Mat_diag1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_diag2Delegate(IntPtr self, int d);
        [NativeDelegate("core_Mat_diag2")] public static core_Mat_diag2Delegate core_Mat_diag2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double core_Mat_dotDelegate(IntPtr self, IntPtr m);
        [NativeDelegate("core_Mat_dot")] public static core_Mat_dotDelegate core_Mat_dot;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong core_Mat_elemSizeDelegate(IntPtr self);
        [NativeDelegate("core_Mat_elemSize")] public static core_Mat_elemSizeDelegate core_Mat_elemSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong core_Mat_elemSize1Delegate(IntPtr self);
        [NativeDelegate("core_Mat_elemSize1")] public static core_Mat_elemSize1Delegate core_Mat_elemSize1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_emptyDelegate(IntPtr self);
        [NativeDelegate("core_Mat_empty")] public static core_Mat_emptyDelegate core_Mat_empty;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_eyeDelegate(int rows, int cols, int type);
        [NativeDelegate("core_Mat_eye")] public static core_Mat_eyeDelegate core_Mat_eye;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_inv1Delegate(IntPtr self);
        [NativeDelegate("core_Mat_inv1")] public static core_Mat_inv1Delegate core_Mat_inv1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_inv2Delegate(IntPtr self, int method);
        [NativeDelegate("core_Mat_inv2")] public static core_Mat_inv2Delegate core_Mat_inv2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_isContinuousDelegate(IntPtr self);
        [NativeDelegate("core_Mat_isContinuous")] public static core_Mat_isContinuousDelegate core_Mat_isContinuous;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_isSubmatrixDelegate(IntPtr self);
        [NativeDelegate("core_Mat_isSubmatrix")] public static core_Mat_isSubmatrixDelegate core_Mat_isSubmatrix;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_locateROIDelegate(IntPtr self, out Size wholeSize, out Point ofs);
        [NativeDelegate("core_Mat_locateROI")] public static core_Mat_locateROIDelegate core_Mat_locateROI;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_mul1Delegate(IntPtr self, IntPtr m);
        [NativeDelegate("core_Mat_mul1")] public static core_Mat_mul1Delegate core_Mat_mul1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_mul2Delegate(IntPtr self, IntPtr m, double scale);
        [NativeDelegate("core_Mat_mul2")] public static core_Mat_mul2Delegate core_Mat_mul2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_ones1Delegate(int rows, int cols, int type);
        [NativeDelegate("core_Mat_ones1")] public static core_Mat_ones1Delegate core_Mat_ones1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_ones2Delegate(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sz, int type);
        [NativeDelegate("core_Mat_ones2")] public static core_Mat_ones2Delegate core_Mat_ones2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_reshape1Delegate(IntPtr self, int cn);
        [NativeDelegate("core_Mat_reshape1")] public static core_Mat_reshape1Delegate core_Mat_reshape1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_reshape2Delegate(IntPtr self, int cn, int rows);
        [NativeDelegate("core_Mat_reshape2")] public static core_Mat_reshape2Delegate core_Mat_reshape2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_reshape3Delegate(IntPtr self, int cn, int newndims, [MarshalAs(UnmanagedType.LPArray)] int[] newsz);
        [NativeDelegate("core_Mat_reshape3")] public static core_Mat_reshape3Delegate core_Mat_reshape3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_rowsDelegate(IntPtr self);
        [NativeDelegate("core_Mat_rows")] public static core_Mat_rowsDelegate core_Mat_rows;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_row_toMatDelegate(IntPtr self, int y);
        [NativeDelegate("core_Mat_row_toMat")] public static core_Mat_row_toMatDelegate core_Mat_row_toMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_row_toMatExprDelegate(IntPtr self, int y);
        [NativeDelegate("core_Mat_row_toMatExpr")] public static core_Mat_row_toMatExprDelegate core_Mat_row_toMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_rowRange_toMatDelegate(IntPtr self, int startRow, int endRow);
        [NativeDelegate("core_Mat_rowRange_toMat")] public static core_Mat_rowRange_toMatDelegate core_Mat_rowRange_toMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_rowRange_toMatExprDelegate(IntPtr self, int startRow, int endRow);
        [NativeDelegate("core_Mat_rowRange_toMatExpr")] public static core_Mat_rowRange_toMatExprDelegate core_Mat_rowRange_toMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_setTo_ScalarDelegate(IntPtr self, Scalar value, IntPtr mask);
        [NativeDelegate("core_Mat_setTo_Scalar")] public static core_Mat_setTo_ScalarDelegate core_Mat_setTo_Scalar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_setTo_InputArrayDelegate(IntPtr self, IntPtr value, IntPtr mask);
        [NativeDelegate("core_Mat_setTo_InputArray")] public static core_Mat_setTo_InputArrayDelegate core_Mat_setTo_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size core_Mat_sizeDelegate(IntPtr self);
        [NativeDelegate("core_Mat_size")] public static core_Mat_sizeDelegate core_Mat_size;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_sizeAtDelegate(IntPtr self, int i);
        [NativeDelegate("core_Mat_sizeAt")] public static core_Mat_sizeAtDelegate core_Mat_sizeAt;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong core_Mat_step11Delegate(IntPtr self);
        [NativeDelegate("core_Mat_step11")] public static core_Mat_step11Delegate core_Mat_step11;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong core_Mat_step12Delegate(IntPtr self, int i);
        [NativeDelegate("core_Mat_step12")] public static core_Mat_step12Delegate core_Mat_step12;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate long core_Mat_stepDelegate(IntPtr self);
        [NativeDelegate("core_Mat_step")] public static core_Mat_stepDelegate core_Mat_step;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong core_Mat_stepAtDelegate(IntPtr self, int i);
        [NativeDelegate("core_Mat_stepAt")] public static core_Mat_stepAtDelegate core_Mat_stepAt;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_subMat1Delegate(IntPtr self, int rowStart, int rowEnd, int colStart, int colEnd);
        [NativeDelegate("core_Mat_subMat1")] public static core_Mat_subMat1Delegate core_Mat_subMat1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_subMatDelegate2(IntPtr self, int nRanges, Range[] ranges);
        [NativeDelegate("core_Mat_subMat2")] public static core_Mat_subMatDelegate2 core_Mat_subMat2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_tDelegate(IntPtr self);
        [NativeDelegate("core_Mat_t")] public static core_Mat_tDelegate core_Mat_t;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong core_Mat_totalDelegate(IntPtr self);
        [NativeDelegate("core_Mat_total")] public static core_Mat_totalDelegate core_Mat_total;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_typeDelegate(IntPtr self);
        [NativeDelegate("core_Mat_type")] public static core_Mat_typeDelegate core_Mat_type;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_zeros1Delegate(int rows, int cols, int type);
        [NativeDelegate("core_Mat_zeros1")] public static core_Mat_zeros1Delegate core_Mat_zeros1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_zeros2Delegate(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sz, int type);
        [NativeDelegate("core_Mat_zeros2")] public static core_Mat_zeros2Delegate core_Mat_zeros2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate sbyte* core_Mat_dumpDelegate(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string format);
        [NativeDelegate("core_Mat_dump")] public static core_Mat_dumpDelegate core_Mat_dump;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void core_Mat_dump_deleteDelegate(sbyte* buf);
        [NativeDelegate("core_Mat_dump_delete")] public static core_Mat_dump_deleteDelegate core_Mat_dump_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_ptr1dDelegate(IntPtr self, int i0);
        [NativeDelegate("core_Mat_ptr1d")] public static core_Mat_ptr1dDelegate core_Mat_ptr1d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_ptr2dDelegate(IntPtr self, int i0, int i1);
        [NativeDelegate("core_Mat_ptr2d")] public static core_Mat_ptr2dDelegate core_Mat_ptr2d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_ptr3dDelegate(IntPtr self, int i0, int i1, int i2);
        [NativeDelegate("core_Mat_ptr3d")] public static core_Mat_ptr3dDelegate core_Mat_ptr3d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_ptrndDelegate(IntPtr self, [MarshalAs(UnmanagedType.LPArray)] int[] idx);
        [NativeDelegate("core_Mat_ptrnd")] public static core_Mat_ptrndDelegate core_Mat_ptrnd;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_assignment_FromMatDelegate(IntPtr self, IntPtr newMat);
        [NativeDelegate("core_Mat_assignment_FromMat")] public static core_Mat_assignment_FromMatDelegate core_Mat_assignment_FromMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_assignment_FromMatExprDelegate(IntPtr self, IntPtr newMatExpr);
        [NativeDelegate("core_Mat_assignment_FromMatExpr")] public static core_Mat_assignment_FromMatExprDelegate core_Mat_assignment_FromMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_assignment_FromScalarDelegate(IntPtr self, Scalar scalar);
        [NativeDelegate("core_Mat_assignment_FromScalar")] public static core_Mat_assignment_FromScalarDelegate core_Mat_assignment_FromScalar;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_IplImageDelegate(IntPtr self, IntPtr outImage);
        [NativeDelegate("core_Mat_IplImage")] public static core_Mat_IplImageDelegate core_Mat_IplImage;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_IplImage_alignmentDelegate(IntPtr self, out IntPtr outImage);
        [NativeDelegate("core_Mat_IplImage_alignment")] public static core_Mat_IplImage_alignmentDelegate core_Mat_IplImage_alignment;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_CvMatDelegate(IntPtr self, IntPtr outMat);
        [NativeDelegate("core_Mat_CvMat")] public static core_Mat_CvMatDelegate core_Mat_CvMat;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorUnaryMinusDelegate(IntPtr mat);
        [NativeDelegate("core_Mat_operatorUnaryMinus")] public static core_Mat_operatorUnaryMinusDelegate core_Mat_operatorUnaryMinus;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorAdd_MatMatDelegate(IntPtr a, IntPtr b);
        [NativeDelegate("core_Mat_operatorAdd_MatMat")] public static core_Mat_operatorAdd_MatMatDelegate core_Mat_operatorAdd_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorAdd_MatScalarDelegate(IntPtr a, Scalar s);
        [NativeDelegate("core_Mat_operatorAdd_MatScalar")] public static core_Mat_operatorAdd_MatScalarDelegate core_Mat_operatorAdd_MatScalar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorAdd_ScalarMatDelegate(Scalar s, IntPtr a);
        [NativeDelegate("core_Mat_operatorAdd_ScalarMat")] public static core_Mat_operatorAdd_ScalarMatDelegate core_Mat_operatorAdd_ScalarMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorMinus_MatDelegate(IntPtr a);
        [NativeDelegate("core_Mat_operatorMinus_Mat")] public static core_Mat_operatorMinus_MatDelegate core_Mat_operatorMinus_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorSubtract_MatMatDelegate(IntPtr a, IntPtr b);
        [NativeDelegate("core_Mat_operatorSubtract_MatMat")] public static core_Mat_operatorSubtract_MatMatDelegate core_Mat_operatorSubtract_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorSubtract_MatScalarDelegate(IntPtr a, Scalar s);
        [NativeDelegate("core_Mat_operatorSubtract_MatScalar")] public static core_Mat_operatorSubtract_MatScalarDelegate core_Mat_operatorSubtract_MatScalar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorSubtract_ScalarMatDelegate(Scalar s, IntPtr a);
        [NativeDelegate("core_Mat_operatorSubtract_ScalarMat")] public static core_Mat_operatorSubtract_ScalarMatDelegate core_Mat_operatorSubtract_ScalarMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorMultiply_MatMatDelegate(IntPtr a, IntPtr b);
        [NativeDelegate("core_Mat_operatorMultiply_MatMat")] public static core_Mat_operatorMultiply_MatMatDelegate core_Mat_operatorMultiply_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorMultiply_MatDoubleDelegate(IntPtr a, double s);
        [NativeDelegate("core_Mat_operatorMultiply_MatDouble")] public static core_Mat_operatorMultiply_MatDoubleDelegate core_Mat_operatorMultiply_MatDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorMultiply_DoubleMatDelegate(double s, IntPtr a);
        [NativeDelegate("core_Mat_operatorMultiply_DoubleMat")] public static core_Mat_operatorMultiply_DoubleMatDelegate core_Mat_operatorMultiply_DoubleMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorDivide_MatMatDelegate(IntPtr a, IntPtr b);
        [NativeDelegate("core_Mat_operatorDivide_MatMat")] public static core_Mat_operatorDivide_MatMatDelegate core_Mat_operatorDivide_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorDivide_MatDoubleDelegate(IntPtr a, double s);
        [NativeDelegate("core_Mat_operatorDivide_MatDouble")] public static core_Mat_operatorDivide_MatDoubleDelegate core_Mat_operatorDivide_MatDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorDivide_DoubleMatDelegate(double s, IntPtr a);
        [NativeDelegate("core_Mat_operatorDivide_DoubleMat")] public static core_Mat_operatorDivide_DoubleMatDelegate core_Mat_operatorDivide_DoubleMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorAnd_MatMatDelegate(IntPtr a, IntPtr b);
        [NativeDelegate("core_Mat_operatorAnd_MatMat")] public static core_Mat_operatorAnd_MatMatDelegate core_Mat_operatorAnd_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorAnd_MatDoubleDelegate(IntPtr a, double s);
        [NativeDelegate("core_Mat_operatorAnd_MatDouble")] public static core_Mat_operatorAnd_MatDoubleDelegate core_Mat_operatorAnd_MatDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorAnd_DoubleMatDelegate(double s, IntPtr a);
        [NativeDelegate("core_Mat_operatorAnd_DoubleMat")] public static core_Mat_operatorAnd_DoubleMatDelegate core_Mat_operatorAnd_DoubleMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorOr_MatMatDelegate(IntPtr a, IntPtr b);
        [NativeDelegate("core_Mat_operatorOr_MatMat")] public static core_Mat_operatorOr_MatMatDelegate core_Mat_operatorOr_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorOr_MatDoubleDelegate(IntPtr a, double s);
        [NativeDelegate("core_Mat_operatorOr_MatDouble")] public static core_Mat_operatorOr_MatDoubleDelegate core_Mat_operatorOr_MatDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorOr_DoubleMatDelegate(double s, IntPtr a);
        [NativeDelegate("core_Mat_operatorOr_DoubleMat")] public static core_Mat_operatorOr_DoubleMatDelegate core_Mat_operatorOr_DoubleMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorXor_MatMatDelegate(IntPtr a, IntPtr b);
        [NativeDelegate("core_Mat_operatorXor_MatMat")] public static core_Mat_operatorXor_MatMatDelegate core_Mat_operatorXor_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorXor_MatDoubleDelegate(IntPtr a, double s);
        [NativeDelegate("core_Mat_operatorXor_MatDouble")] public static core_Mat_operatorXor_MatDoubleDelegate core_Mat_operatorXor_MatDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorXor_DoubleMatDelegate(double s, IntPtr a);
        [NativeDelegate("core_Mat_operatorXor_DoubleMat")] public static core_Mat_operatorXor_DoubleMatDelegate core_Mat_operatorXor_DoubleMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorNotDelegate(IntPtr a);
        [NativeDelegate("core_Mat_operatorNot")] public static core_Mat_operatorNotDelegate core_Mat_operatorNot;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorLT_MatMatDelegate(IntPtr a, IntPtr b);
        [NativeDelegate("core_Mat_operatorLT_MatMat")] public static core_Mat_operatorLT_MatMatDelegate core_Mat_operatorLT_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorLT_DoubleMatDelegate(double a, IntPtr b);
        [NativeDelegate("core_Mat_operatorLT_DoubleMat")] public static core_Mat_operatorLT_DoubleMatDelegate core_Mat_operatorLT_DoubleMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorLT_MatDoubleDelegate(IntPtr a, double b);
        [NativeDelegate("core_Mat_operatorLT_MatDouble")] public static core_Mat_operatorLT_MatDoubleDelegate core_Mat_operatorLT_MatDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorLE_MatMatDelegate(IntPtr a, IntPtr b);
        [NativeDelegate("core_Mat_operatorLE_MatMat")] public static core_Mat_operatorLE_MatMatDelegate core_Mat_operatorLE_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorLE_DoubleMatDelegate(double a, IntPtr b);
        [NativeDelegate("core_Mat_operatorLE_DoubleMat")] public static core_Mat_operatorLE_DoubleMatDelegate core_Mat_operatorLE_DoubleMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorLE_MatDoubleDelegate(IntPtr a, double b);
        [NativeDelegate("core_Mat_operatorLE_MatDouble")] public static core_Mat_operatorLE_MatDoubleDelegate core_Mat_operatorLE_MatDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorGT_MatMatDelegate(IntPtr a, IntPtr b);
        [NativeDelegate("core_Mat_operatorGT_MatMat")] public static core_Mat_operatorGT_MatMatDelegate core_Mat_operatorGT_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorGT_DoubleMatDelegate(double a, IntPtr b);
        [NativeDelegate("core_Mat_operatorGT_DoubleMat")] public static core_Mat_operatorGT_DoubleMatDelegate core_Mat_operatorGT_DoubleMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorGT_MatDoubleDelegate(IntPtr a, double b);
        [NativeDelegate("core_Mat_operatorGT_MatDouble")] public static core_Mat_operatorGT_MatDoubleDelegate core_Mat_operatorGT_MatDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorGE_MatMatDelegate(IntPtr a, IntPtr b);
        [NativeDelegate("core_Mat_operatorGE_MatMat")] public static core_Mat_operatorGE_MatMatDelegate core_Mat_operatorGE_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorGE_DoubleMatDelegate(double a, IntPtr b);
        [NativeDelegate("core_Mat_operatorGE_DoubleMat")] public static core_Mat_operatorGE_DoubleMatDelegate core_Mat_operatorGE_DoubleMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorGE_MatDoubleDelegate(IntPtr a, double b);
        [NativeDelegate("core_Mat_operatorGE_MatDouble")] public static core_Mat_operatorGE_MatDoubleDelegate core_Mat_operatorGE_MatDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorEQ_MatMatDelegate(IntPtr a, IntPtr b);
        [NativeDelegate("core_Mat_operatorEQ_MatMat")] public static core_Mat_operatorEQ_MatMatDelegate core_Mat_operatorEQ_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorEQ_DoubleMatDelegate(double a, IntPtr b);
        [NativeDelegate("core_Mat_operatorEQ_DoubleMat")] public static core_Mat_operatorEQ_DoubleMatDelegate core_Mat_operatorEQ_DoubleMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorEQ_MatDoubleDelegate(IntPtr a, double b);
        [NativeDelegate("core_Mat_operatorEQ_MatDouble")] public static core_Mat_operatorEQ_MatDoubleDelegate core_Mat_operatorEQ_MatDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorNE_MatMatDelegate(IntPtr a, IntPtr b);
        [NativeDelegate("core_Mat_operatorNE_MatMat")] public static core_Mat_operatorNE_MatMatDelegate core_Mat_operatorNE_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorNE_DoubleMatDelegate(double a, IntPtr b);
        [NativeDelegate("core_Mat_operatorNE_DoubleMat")] public static core_Mat_operatorNE_DoubleMatDelegate core_Mat_operatorNE_DoubleMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Mat_operatorNE_MatDoubleDelegate(IntPtr a, double b);
        [NativeDelegate("core_Mat_operatorNE_MatDouble")] public static core_Mat_operatorNE_MatDoubleDelegate core_Mat_operatorNE_MatDouble;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_abs_MatDelegate(IntPtr e);
        [NativeDelegate("core_abs_Mat")] public static core_abs_MatDelegate core_abs_Mat;

        #region nSet
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetBDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] byte[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetB")] public static core_Mat_nSetBDelegate core_Mat_nSetB;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetBDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] byte[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetB")] public static core_Mat_nSetBDelegate2 core_Mat_nSetB2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetSDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] short[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetS")] public static core_Mat_nSetSDelegate core_Mat_nSetS;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetSDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] short[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetS")] public static core_Mat_nSetSDelegate2 core_Mat_nSetS2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetSDelegate3(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] ushort[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetS")] public static core_Mat_nSetSDelegate3 core_Mat_nSetS3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetSDelegate4(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] ushort[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetS")] public static core_Mat_nSetSDelegate4 core_Mat_nSetS4;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetIDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] int[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetI")] public static core_Mat_nSetIDelegate core_Mat_nSetI;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetIDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] int[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetI")] public static core_Mat_nSetIDelegate2 core_Mat_nSetI2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetFDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] float[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetF")] public static core_Mat_nSetFDelegate core_Mat_nSetF;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetFDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] float[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetF")] public static core_Mat_nSetFDelegate2 core_Mat_nSetF2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetDDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] double[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetD")] public static core_Mat_nSetDDelegate core_Mat_nSetD;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetDDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] double[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetD")] public static core_Mat_nSetDDelegate2 core_Mat_nSetD2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetVec3bDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec3b[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetVec3b")] public static core_Mat_nSetVec3bDelegate core_Mat_nSetVec3b;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetVec3bDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec3b[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetVec3b")] public static core_Mat_nSetVec3bDelegate2 core_Mat_nSetVec3b2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetVec3dDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec3d[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetVec3d")] public static core_Mat_nSetVec3dDelegate core_Mat_nSetVec3d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetVec3dDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec3d[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetVec3d")] public static core_Mat_nSetVec3dDelegate2 core_Mat_nSetVec3d2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetVec4fDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec4f[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetVec4f")] public static core_Mat_nSetVec4fDelegate core_Mat_nSetVec4f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetVec4fDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec4f[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetVec4f")] public static core_Mat_nSetVec4fDelegate2 core_Mat_nSetVec4f2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetVec6fDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec6f[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetVec6f")] public static core_Mat_nSetVec6fDelegate core_Mat_nSetVec6f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetVec6fDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec6f[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetVec6f")] public static core_Mat_nSetVec6fDelegate2 core_Mat_nSetVec6f2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetVec4iDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec4i[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetVec4i")] public static core_Mat_nSetVec4iDelegate core_Mat_nSetVec4i;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetVec4iDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec4i[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetVec4i")] public static core_Mat_nSetVec4iDelegate2 core_Mat_nSetVec4i2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetPointDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetPoint")] public static core_Mat_nSetPointDelegate core_Mat_nSetPoint;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetPointDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetPoint")] public static core_Mat_nSetPointDelegate2 core_Mat_nSetPoint2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetPoint2fDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point2f[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetPoint2f")] public static core_Mat_nSetPoint2fDelegate core_Mat_nSetPoint2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetPoint2fDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point2f[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetPoint2f")] public static core_Mat_nSetPoint2fDelegate2 core_Mat_nSetPoint2f2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetPoint2dDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point2d[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetPoint2d")] public static core_Mat_nSetPoint2dDelegate core_Mat_nSetPoint2d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetPoint2dDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point2d[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetPoint2d")] public static core_Mat_nSetPoint2dDelegate2 core_Mat_nSetPoint2d2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetPoint3iDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point3i[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetPoint3i")] public static core_Mat_nSetPoint3iDelegate core_Mat_nSetPoint3i;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetPoint3iDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point3i[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetPoint3i")] public static core_Mat_nSetPoint3iDelegate2 core_Mat_nSetPoint3i2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetPoint3fDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point3f[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetPoint3f")] public static core_Mat_nSetPoint3fDelegate core_Mat_nSetPoint3f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetPoint3fDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point3f[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetPoint3f")] public static core_Mat_nSetPoint3fDelegate2 core_Mat_nSetPoint3f2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetPoint3dDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point3d[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetPoint3d")] public static core_Mat_nSetPoint3dDelegate core_Mat_nSetPoint3d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetPoint3dDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point3d[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetPoint3d")] public static core_Mat_nSetPoint3dDelegate2 core_Mat_nSetPoint3d2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetRectDelegate(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Rect[] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetRect")] public static core_Mat_nSetRectDelegate core_Mat_nSetRect;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nSetRectDelegate2(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Rect[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nSetRect")] public static core_Mat_nSetRectDelegate2 core_Mat_nSetRect2;
        #endregion

        #region nGet
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetBDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] byte[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetB")] public static core_Mat_nGetBDelegate core_Mat_nGetB;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetBDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] byte[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetB")] public static core_Mat_nGetBDelegate2 core_Mat_nGetB2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetSDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] short[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetS")] public static core_Mat_nGetSDelegate core_Mat_nGetS;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetSDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] short[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetS")] public static core_Mat_nGetSDelegate2 core_Mat_nGetS2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetSDelegate3(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] ushort[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetS")] public static core_Mat_nGetSDelegate3 core_Mat_nGetS3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetSDelegate4(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] ushort[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetS")] public static core_Mat_nGetSDelegate4 core_Mat_nGetS4;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetIDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] int[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetI")] public static core_Mat_nGetIDelegate core_Mat_nGetI;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetIDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] int[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetI")] public static core_Mat_nGetIDelegate2 core_Mat_nGetI2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetFDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetF")] public static core_Mat_nGetFDelegate core_Mat_nGetF;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetFDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] float[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetF")] public static core_Mat_nGetFDelegate2 core_Mat_nGetF2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetDDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] double[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetD")] public static core_Mat_nGetDDelegate core_Mat_nGetD;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetDDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] double[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetD")] public static core_Mat_nGetDDelegate2 core_Mat_nGetD2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetVec3bDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec3b[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetVec3b")] public static core_Mat_nGetVec3bDelegate core_Mat_nGetVec3b;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetVec3bDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec3b[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetVec3b")] public static core_Mat_nGetVec3bDelegate2 core_Mat_nGetVec3b2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetVec3dDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec3d[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetVec3d")] public static core_Mat_nGetVec3dDelegate core_Mat_nGetVec3d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetVec3dDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec3d[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetVec3d")] public static core_Mat_nGetVec3dDelegate2 core_Mat_nGetVec3d2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetVec4fDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec4f[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetVec4f")] public static core_Mat_nGetVec4fDelegate core_Mat_nGetVec4f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetVec4fDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec4f[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetVec4f")] public static core_Mat_nGetVec4fDelegate2 core_Mat_nGetVec4f2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetVec6fDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec6f[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetVec6f")] public static core_Mat_nGetVec6fDelegate core_Mat_nGetVec6f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetVec6fDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec6f[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetVec6f")] public static core_Mat_nGetVec6fDelegate2 core_Mat_nGetVec6f2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetVec4iDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec4i[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetVec4i")] public static core_Mat_nGetVec4iDelegate core_Mat_nGetVec4i;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetVec4iDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec4i[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetVec4i")] public static core_Mat_nGetVec4iDelegate2 core_Mat_nGetVec4i2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetPointDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetPoint")] public static core_Mat_nGetPointDelegate core_Mat_nGetPoint;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetPointDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetPoint")] public static core_Mat_nGetPointDelegate2 core_Mat_nGetPoint2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetPoint2fDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point2f[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetPoint2f")] public static core_Mat_nGetPoint2fDelegate core_Mat_nGetPoint2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetPoint2fDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point2f[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetPoint2f")] public static core_Mat_nGetPoint2fDelegate2 core_Mat_nGetPoint2f2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetPoint2dDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point2d[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetPoint2d")] public static core_Mat_nGetPoint2dDelegate core_Mat_nGetPoint2d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetPoint2dDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point2d[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetPoint2d")] public static core_Mat_nGetPoint2dDelegate2 core_Mat_nGetPoint2d2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetPoint3iDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point3i[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetPoint3i")] public static core_Mat_nGetPoint3iDelegate core_Mat_nGetPoint3i;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetPoint3iDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point3i[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetPoint3i")] public static core_Mat_nGetPoint3iDelegate2 core_Mat_nGetPoint3i2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetPoint3fDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point3f[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetPoint3f")] public static core_Mat_nGetPoint3fDelegate core_Mat_nGetPoint3f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetPoint3fDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point3f[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetPoint3f")] public static core_Mat_nGetPoint3fDelegate2 core_Mat_nGetPoint3f2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetPoint3dDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point3d[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetPoint3d")] public static core_Mat_nGetPoint3dDelegate core_Mat_nGetPoint3d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetPoint3dDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point3d[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetPoint3d")] public static core_Mat_nGetPoint3dDelegate2 core_Mat_nGetPoint3d2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetRectDelegate(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Rect[] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetRect")] public static core_Mat_nGetRectDelegate core_Mat_nGetRect;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Mat_nGetRectDelegate2(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Rect[,] vals, int valsLength);
        [NativeDelegate("core_Mat_nGetRect")] public static core_Mat_nGetRectDelegate2 core_Mat_nGetRect2;
        #endregion

        #region push_back
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_MatDelegate(IntPtr self, IntPtr m);
        [NativeDelegate("core_Mat_push_back_Mat")] public static core_Mat_push_back_MatDelegate core_Mat_push_back_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_charDelegate(IntPtr self, sbyte v);
        [NativeDelegate("core_Mat_push_back_char")] public static core_Mat_push_back_charDelegate core_Mat_push_back_char;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_ucharDelegate(IntPtr self, byte v);
        [NativeDelegate("core_Mat_push_back_uchar")] public static core_Mat_push_back_ucharDelegate core_Mat_push_back_uchar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_shortDelegate(IntPtr self, short v);
        [NativeDelegate("core_Mat_push_back_short")] public static core_Mat_push_back_shortDelegate core_Mat_push_back_short;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_ushortDelegate(IntPtr self, ushort v);
        [NativeDelegate("core_Mat_push_back_ushort")] public static core_Mat_push_back_ushortDelegate core_Mat_push_back_ushort;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_intDelegate(IntPtr self, int v);
        [NativeDelegate("core_Mat_push_back_int")] public static core_Mat_push_back_intDelegate core_Mat_push_back_int;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_floatDelegate(IntPtr self, float v);
        [NativeDelegate("core_Mat_push_back_float")] public static core_Mat_push_back_floatDelegate core_Mat_push_back_float;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_doubleDelegate(IntPtr self, double v);
        [NativeDelegate("core_Mat_push_back_double")] public static core_Mat_push_back_doubleDelegate core_Mat_push_back_double;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec2bDelegate(IntPtr self, Vec2b v);
        [NativeDelegate("core_Mat_push_back_Vec2b")] public static core_Mat_push_back_Vec2bDelegate core_Mat_push_back_Vec2b;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec3bDelegate(IntPtr self, Vec3b v);
        [NativeDelegate("core_Mat_push_back_Vec3b")] public static core_Mat_push_back_Vec3bDelegate core_Mat_push_back_Vec3b;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec4bDelegate(IntPtr self, Vec4b v);
        [NativeDelegate("core_Mat_push_back_Vec4b")] public static core_Mat_push_back_Vec4bDelegate core_Mat_push_back_Vec4b;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec6bDelegate(IntPtr self, Vec6b v);
        [NativeDelegate("core_Mat_push_back_Vec6b")] public static core_Mat_push_back_Vec6bDelegate core_Mat_push_back_Vec6b;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec2sDelegate(IntPtr self, Vec2s v);
        [NativeDelegate("core_Mat_push_back_Vec2s")] public static core_Mat_push_back_Vec2sDelegate core_Mat_push_back_Vec2s;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec3sDelegate(IntPtr self, Vec3s v);
        [NativeDelegate("core_Mat_push_back_Vec3s")] public static core_Mat_push_back_Vec3sDelegate core_Mat_push_back_Vec3s;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec4sDelegate(IntPtr self, Vec4s v);
        [NativeDelegate("core_Mat_push_back_Vec4s")] public static core_Mat_push_back_Vec4sDelegate core_Mat_push_back_Vec4s;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec6sDelegate(IntPtr self, Vec6s v);
        [NativeDelegate("core_Mat_push_back_Vec6s")] public static core_Mat_push_back_Vec6sDelegate core_Mat_push_back_Vec6s;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec2wDelegate(IntPtr self, Vec2w v);
        [NativeDelegate("core_Mat_push_back_Vec2w")] public static core_Mat_push_back_Vec2wDelegate core_Mat_push_back_Vec2w;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec3wDelegate(IntPtr self, Vec3w v);
        [NativeDelegate("core_Mat_push_back_Vec3w")] public static core_Mat_push_back_Vec3wDelegate core_Mat_push_back_Vec3w;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec4wDelegate(IntPtr self, Vec4w v);
        [NativeDelegate("core_Mat_push_back_Vec4w")] public static core_Mat_push_back_Vec4wDelegate core_Mat_push_back_Vec4w;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec6wDelegate(IntPtr self, Vec6w v);
        [NativeDelegate("core_Mat_push_back_Vec6w")] public static core_Mat_push_back_Vec6wDelegate core_Mat_push_back_Vec6w;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec2iDelegate(IntPtr self, Vec2i v);
        [NativeDelegate("core_Mat_push_back_Vec2i")] public static core_Mat_push_back_Vec2iDelegate core_Mat_push_back_Vec2i;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec3iDelegate(IntPtr self, Vec3i v);
        [NativeDelegate("core_Mat_push_back_Vec3i")] public static core_Mat_push_back_Vec3iDelegate core_Mat_push_back_Vec3i;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec4iDelegate(IntPtr self, Vec4i v);
        [NativeDelegate("core_Mat_push_back_Vec4i")] public static core_Mat_push_back_Vec4iDelegate core_Mat_push_back_Vec4i;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec6iDelegate(IntPtr self, Vec6i v);
        [NativeDelegate("core_Mat_push_back_Vec6i")] public static core_Mat_push_back_Vec6iDelegate core_Mat_push_back_Vec6i;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec2fDelegate(IntPtr self, Vec2f v);
        [NativeDelegate("core_Mat_push_back_Vec2f")] public static core_Mat_push_back_Vec2fDelegate core_Mat_push_back_Vec2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec3fDelegate(IntPtr self, Vec3f v);
        [NativeDelegate("core_Mat_push_back_Vec3f")] public static core_Mat_push_back_Vec3fDelegate core_Mat_push_back_Vec3f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec4fDelegate(IntPtr self, Vec4f v);
        [NativeDelegate("core_Mat_push_back_Vec4f")] public static core_Mat_push_back_Vec4fDelegate core_Mat_push_back_Vec4f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec6fDelegate(IntPtr self, Vec6f v);
        [NativeDelegate("core_Mat_push_back_Vec6f")] public static core_Mat_push_back_Vec6fDelegate core_Mat_push_back_Vec6f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec2dDelegate(IntPtr self, Vec2d v);
        [NativeDelegate("core_Mat_push_back_Vec2d")] public static core_Mat_push_back_Vec2dDelegate core_Mat_push_back_Vec2d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec3dDelegate(IntPtr self, Vec3d v);
        [NativeDelegate("core_Mat_push_back_Vec3d")] public static core_Mat_push_back_Vec3dDelegate core_Mat_push_back_Vec3d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Vec6dDelegate(IntPtr self, Vec6d v);
        [NativeDelegate("core_Mat_push_back_Vec6d")] public static core_Mat_push_back_Vec6dDelegate core_Mat_push_back_Vec6d;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_PointDelegate(IntPtr self, Point v);
        [NativeDelegate("core_Mat_push_back_Point")] public static core_Mat_push_back_PointDelegate core_Mat_push_back_Point;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Point2fDelegate(IntPtr self, Point2f v);
        [NativeDelegate("core_Mat_push_back_Point2f")] public static core_Mat_push_back_Point2fDelegate core_Mat_push_back_Point2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Point2dDelegate(IntPtr self, Point2d v);
        [NativeDelegate("core_Mat_push_back_Point2d")] public static core_Mat_push_back_Point2dDelegate core_Mat_push_back_Point2d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Point3iDelegate(IntPtr self, Point3i v);
        [NativeDelegate("core_Mat_push_back_Point3i")] public static core_Mat_push_back_Point3iDelegate core_Mat_push_back_Point3i;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Point3fDelegate(IntPtr self, Point3f v);
        [NativeDelegate("core_Mat_push_back_Point3f")] public static core_Mat_push_back_Point3fDelegate core_Mat_push_back_Point3f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Point3dDelegate(IntPtr self, Point3d v);
        [NativeDelegate("core_Mat_push_back_Point3d")] public static core_Mat_push_back_Point3dDelegate core_Mat_push_back_Point3d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_SizeDelegate(IntPtr self, Size v);
        [NativeDelegate("core_Mat_push_back_Size")] public static core_Mat_push_back_SizeDelegate core_Mat_push_back_Size;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_Size2fDelegate(IntPtr self, Size2f v);
        [NativeDelegate("core_Mat_push_back_Size2f")] public static core_Mat_push_back_Size2fDelegate core_Mat_push_back_Size2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_push_back_RectDelegate(IntPtr self, Rect v);
        [NativeDelegate("core_Mat_push_back_Rect")] public static core_Mat_push_back_RectDelegate core_Mat_push_back_Rect;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_reserveDelegate(IntPtr obj, IntPtr sz);
        [NativeDelegate("core_Mat_reserve")] public static core_Mat_reserveDelegate core_Mat_reserve;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_resize1Delegate(IntPtr obj, IntPtr sz);
        [NativeDelegate("core_Mat_resize1")] public static core_Mat_resize1Delegate core_Mat_resize1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_resize2Delegate(IntPtr obj, IntPtr sz, Scalar s);
        [NativeDelegate("core_Mat_resize2")] public static core_Mat_resize2Delegate core_Mat_resize2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_pop_backDelegate(IntPtr obj, IntPtr nelems);
        [NativeDelegate("core_Mat_pop_back")] public static core_Mat_pop_backDelegate core_Mat_pop_back;
        #endregion

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_ucharDelegate(IntPtr m, MatForeachFunctionByte proc);
        [NativeDelegate("core_Mat_forEach_uchar")] public static core_Mat_forEach_ucharDelegate core_Mat_forEach_uchar;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec2bDelegate(IntPtr m, MatForeachFunctionVec2b proc);
        [NativeDelegate("core_Mat_forEach_Vec2b")] public static core_Mat_forEach_Vec2bDelegate core_Mat_forEach_Vec2b;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec3bDelegate(IntPtr m, MatForeachFunctionVec3b proc);
        [NativeDelegate("core_Mat_forEach_Vec3b")] public static core_Mat_forEach_Vec3bDelegate core_Mat_forEach_Vec3b;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec4bDelegate(IntPtr m, MatForeachFunctionVec4b proc);
        [NativeDelegate("core_Mat_forEach_Vec4b")] public static core_Mat_forEach_Vec4bDelegate core_Mat_forEach_Vec4b;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec6bDelegate(IntPtr m, MatForeachFunctionVec6b proc);
        [NativeDelegate("core_Mat_forEach_Vec6b")] public static core_Mat_forEach_Vec6bDelegate core_Mat_forEach_Vec6b;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_shortDelegate(IntPtr m, MatForeachFunctionInt16 proc);
        [NativeDelegate("core_Mat_forEach_short")] public static core_Mat_forEach_shortDelegate core_Mat_forEach_short;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec2sDelegate(IntPtr m, MatForeachFunctionVec2s proc);
        [NativeDelegate("core_Mat_forEach_Vec2s")] public static core_Mat_forEach_Vec2sDelegate core_Mat_forEach_Vec2s;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec3sDelegate(IntPtr m, MatForeachFunctionVec3s proc);
        [NativeDelegate("core_Mat_forEach_Vec3s")] public static core_Mat_forEach_Vec3sDelegate core_Mat_forEach_Vec3s;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec4sDelegate(IntPtr m, MatForeachFunctionVec4s proc);
        [NativeDelegate("core_Mat_forEach_Vec4s")] public static core_Mat_forEach_Vec4sDelegate core_Mat_forEach_Vec4s;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec6sDelegate(IntPtr m, MatForeachFunctionVec6s proc);
        [NativeDelegate("core_Mat_forEach_Vec6s")] public static core_Mat_forEach_Vec6sDelegate core_Mat_forEach_Vec6s;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_intDelegate(IntPtr m, MatForeachFunctionInt32 proc);
        [NativeDelegate("core_Mat_forEach_int")] public static core_Mat_forEach_intDelegate core_Mat_forEach_int;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec2iDelegate(IntPtr m, MatForeachFunctionVec2i proc);
        [NativeDelegate("core_Mat_forEach_Vec2i")] public static core_Mat_forEach_Vec2iDelegate core_Mat_forEach_Vec2i;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec3iDelegate(IntPtr m, MatForeachFunctionVec3i proc);
        [NativeDelegate("core_Mat_forEach_Vec3i")] public static core_Mat_forEach_Vec3iDelegate core_Mat_forEach_Vec3i;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec4iDelegate(IntPtr m, MatForeachFunctionVec4i proc);
        [NativeDelegate("core_Mat_forEach_Vec4i")] public static core_Mat_forEach_Vec4iDelegate core_Mat_forEach_Vec4i;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec6iDelegate(IntPtr m, MatForeachFunctionVec6i proc);
        [NativeDelegate("core_Mat_forEach_Vec6i")] public static core_Mat_forEach_Vec6iDelegate core_Mat_forEach_Vec6i;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_floatDelegate(IntPtr m, MatForeachFunctionFloat proc);
        [NativeDelegate("core_Mat_forEach_float")] public static core_Mat_forEach_floatDelegate core_Mat_forEach_float;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec2fDelegate(IntPtr m, MatForeachFunctionVec2f proc);
        [NativeDelegate("core_Mat_forEach_Vec2f")] public static core_Mat_forEach_Vec2fDelegate core_Mat_forEach_Vec2f;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec3fDelegate(IntPtr m, MatForeachFunctionVec3f proc);
        [NativeDelegate("core_Mat_forEach_Vec3f")] public static core_Mat_forEach_Vec3fDelegate core_Mat_forEach_Vec3f;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec4fDelegate(IntPtr m, MatForeachFunctionVec4f proc);
        [NativeDelegate("core_Mat_forEach_Vec4f")] public static core_Mat_forEach_Vec4fDelegate core_Mat_forEach_Vec4f;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec6fDelegate(IntPtr m, MatForeachFunctionVec6f proc);
        [NativeDelegate("core_Mat_forEach_Vec6f")] public static core_Mat_forEach_Vec6fDelegate core_Mat_forEach_Vec6f;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_doubleDelegate(IntPtr m, MatForeachFunctionDouble proc);
        [NativeDelegate("core_Mat_forEach_double")] public static core_Mat_forEach_doubleDelegate core_Mat_forEach_double;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec2dDelegate(IntPtr m, MatForeachFunctionVec2d proc);
        [NativeDelegate("core_Mat_forEach_Vec2d")] public static core_Mat_forEach_Vec2dDelegate core_Mat_forEach_Vec2d;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec3dDelegate(IntPtr m, MatForeachFunctionVec3d proc);
        [NativeDelegate("core_Mat_forEach_Vec3d")] public static core_Mat_forEach_Vec3dDelegate core_Mat_forEach_Vec3d;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec4dDelegate(IntPtr m, MatForeachFunctionVec4d proc);
        [NativeDelegate("core_Mat_forEach_Vec4d")] public static core_Mat_forEach_Vec4dDelegate core_Mat_forEach_Vec4d;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Mat_forEach_Vec6dDelegate(IntPtr m, MatForeachFunctionVec6d proc);
        [NativeDelegate("core_Mat_forEach_Vec6d")] public static core_Mat_forEach_Vec6dDelegate core_Mat_forEach_Vec6d;
    }
}
