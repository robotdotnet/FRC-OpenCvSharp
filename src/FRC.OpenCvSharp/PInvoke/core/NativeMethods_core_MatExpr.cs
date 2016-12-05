using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_MatExpr_new1Delegate();
        [NativeDelegate("core_MatExpr_new1")] public static core_MatExpr_new1Delegate core_MatExpr_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_MatExpr_new2Delegate(IntPtr mat);
        [NativeDelegate("core_MatExpr_new2")] public static core_MatExpr_new2Delegate core_MatExpr_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_MatExpr_deleteDelegate(IntPtr expr);
        [NativeDelegate("core_MatExpr_delete")] public static core_MatExpr_deleteDelegate core_MatExpr_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_MatExpr_toMatDelegate(IntPtr expr);
        [NativeDelegate("core_MatExpr_toMat")] public static core_MatExpr_toMatDelegate core_MatExpr_toMat;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorUnaryMinus_MatExprDelegate(IntPtr e);
        [NativeDelegate("core_operatorUnaryMinus_MatExpr")] public static core_operatorUnaryMinus_MatExprDelegate core_operatorUnaryMinus_MatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorUnaryNot_MatExprDelegate(IntPtr e);
        [NativeDelegate("core_operatorUnaryNot_MatExpr")] public static core_operatorUnaryNot_MatExprDelegate core_operatorUnaryNot_MatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorAdd_MatExprMatDelegate(IntPtr e, IntPtr m);
        [NativeDelegate("core_operatorAdd_MatExprMat")] public static core_operatorAdd_MatExprMatDelegate core_operatorAdd_MatExprMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorAdd_MatMatExprDelegate(IntPtr m, IntPtr e);
        [NativeDelegate("core_operatorAdd_MatMatExpr")] public static core_operatorAdd_MatMatExprDelegate core_operatorAdd_MatMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorAdd_MatExprScalarDelegate(IntPtr e, Scalar s);
        [NativeDelegate("core_operatorAdd_MatExprScalar")] public static core_operatorAdd_MatExprScalarDelegate core_operatorAdd_MatExprScalar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorAdd_ScalarMatExprDelegate(Scalar s, IntPtr e);
        [NativeDelegate("core_operatorAdd_ScalarMatExpr")] public static core_operatorAdd_ScalarMatExprDelegate core_operatorAdd_ScalarMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorAdd_MatExprMatExprDelegate(IntPtr e1, IntPtr e2);
        [NativeDelegate("core_operatorAdd_MatExprMatExpr")] public static core_operatorAdd_MatExprMatExprDelegate core_operatorAdd_MatExprMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorSubtract_MatExprMatDelegate(IntPtr e, IntPtr m);
        [NativeDelegate("core_operatorSubtract_MatExprMat")] public static core_operatorSubtract_MatExprMatDelegate core_operatorSubtract_MatExprMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorSubtract_MatMatExprDelegate(IntPtr m, IntPtr e);
        [NativeDelegate("core_operatorSubtract_MatMatExpr")] public static core_operatorSubtract_MatMatExprDelegate core_operatorSubtract_MatMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorSubtract_MatExprScalarDelegate(IntPtr e, Scalar s);
        [NativeDelegate("core_operatorSubtract_MatExprScalar")] public static core_operatorSubtract_MatExprScalarDelegate core_operatorSubtract_MatExprScalar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorSubtract_ScalarMatExprDelegate(Scalar s, IntPtr e);
        [NativeDelegate("core_operatorSubtract_ScalarMatExpr")] public static core_operatorSubtract_ScalarMatExprDelegate core_operatorSubtract_ScalarMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorSubtract_MatExprMatExprDelegate(IntPtr e1, IntPtr e2);
        [NativeDelegate("core_operatorSubtract_MatExprMatExpr")] public static core_operatorSubtract_MatExprMatExprDelegate core_operatorSubtract_MatExprMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorMultiply_MatExprMatDelegate(IntPtr e, IntPtr m);
        [NativeDelegate("core_operatorMultiply_MatExprMat")] public static core_operatorMultiply_MatExprMatDelegate core_operatorMultiply_MatExprMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorMultiply_MatMatExprDelegate(IntPtr m, IntPtr e);
        [NativeDelegate("core_operatorMultiply_MatMatExpr")] public static core_operatorMultiply_MatMatExprDelegate core_operatorMultiply_MatMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorMultiply_MatExprDoubleDelegate(IntPtr e, double s);
        [NativeDelegate("core_operatorMultiply_MatExprDouble")] public static core_operatorMultiply_MatExprDoubleDelegate core_operatorMultiply_MatExprDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorMultiply_DoubleMatExprDelegate(double s, IntPtr e);
        [NativeDelegate("core_operatorMultiply_DoubleMatExpr")] public static core_operatorMultiply_DoubleMatExprDelegate core_operatorMultiply_DoubleMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorMultiply_MatExprMatExprDelegate(IntPtr e1, IntPtr e2);
        [NativeDelegate("core_operatorMultiply_MatExprMatExpr")] public static core_operatorMultiply_MatExprMatExprDelegate core_operatorMultiply_MatExprMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorDivide_MatExprMatDelegate(IntPtr e, IntPtr m);
        [NativeDelegate("core_operatorDivide_MatExprMat")] public static core_operatorDivide_MatExprMatDelegate core_operatorDivide_MatExprMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorDivide_MatMatExprDelegate(IntPtr m, IntPtr e);
        [NativeDelegate("core_operatorDivide_MatMatExpr")] public static core_operatorDivide_MatMatExprDelegate core_operatorDivide_MatMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorDivide_MatExprDoubleDelegate(IntPtr e, double s);
        [NativeDelegate("core_operatorDivide_MatExprDouble")] public static core_operatorDivide_MatExprDoubleDelegate core_operatorDivide_MatExprDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorDivide_DoubleMatExprDelegate(double s, IntPtr e);
        [NativeDelegate("core_operatorDivide_DoubleMatExpr")] public static core_operatorDivide_DoubleMatExprDelegate core_operatorDivide_DoubleMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_operatorDivide_MatExprMatExprDelegate(IntPtr e1, IntPtr e2);
        [NativeDelegate("core_operatorDivide_MatExprMatExpr")] public static core_operatorDivide_MatExprMatExprDelegate core_operatorDivide_MatExprMatExpr;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_MatExpr_rowDelegate(IntPtr self, int y);
        [NativeDelegate("core_MatExpr_row")] public static core_MatExpr_rowDelegate core_MatExpr_row;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_MatExpr_colDelegate(IntPtr self, int x);
        [NativeDelegate("core_MatExpr_col")] public static core_MatExpr_colDelegate core_MatExpr_col;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_MatExpr_diag1Delegate(IntPtr self);
        [NativeDelegate("core_MatExpr_diag1")] public static core_MatExpr_diag1Delegate core_MatExpr_diag1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_MatExpr_diag2Delegate(IntPtr self, int d);
        [NativeDelegate("core_MatExpr_diag2")] public static core_MatExpr_diag2Delegate core_MatExpr_diag2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_MatExpr_submatDelegate(IntPtr self, int rowStart, int rowEnd, int colStart, int colEnd);
        [NativeDelegate("core_MatExpr_submat")] public static core_MatExpr_submatDelegate core_MatExpr_submat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_MatExpr_crossDelegate(IntPtr self, IntPtr m);
        [NativeDelegate("core_MatExpr_cross")] public static core_MatExpr_crossDelegate core_MatExpr_cross;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double core_MatExpr_dotDelegate(IntPtr self, IntPtr m);
        [NativeDelegate("core_MatExpr_dot")] public static core_MatExpr_dotDelegate core_MatExpr_dot;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_MatExpr_tDelegate(IntPtr self);
        [NativeDelegate("core_MatExpr_t")] public static core_MatExpr_tDelegate core_MatExpr_t;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_MatExpr_inv1Delegate(IntPtr self);
        [NativeDelegate("core_MatExpr_inv1")] public static core_MatExpr_inv1Delegate core_MatExpr_inv1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_MatExpr_inv2Delegate(IntPtr self, int method);
        [NativeDelegate("core_MatExpr_inv2")] public static core_MatExpr_inv2Delegate core_MatExpr_inv2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_MatExpr_mul_toMatExprDelegate(IntPtr self, IntPtr e, double scale);
        [NativeDelegate("core_MatExpr_mul_toMatExpr")] public static core_MatExpr_mul_toMatExprDelegate core_MatExpr_mul_toMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_MatExpr_mul_toMatDelegate(IntPtr self, IntPtr m, double scale);
        [NativeDelegate("core_MatExpr_mul_toMat")] public static core_MatExpr_mul_toMatDelegate core_MatExpr_mul_toMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size core_MatExpr_sizeDelegate(IntPtr self);
        [NativeDelegate("core_MatExpr_size")] public static core_MatExpr_sizeDelegate core_MatExpr_size;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_MatExpr_typeDelegate(IntPtr self);
        [NativeDelegate("core_MatExpr_type")] public static core_MatExpr_typeDelegate core_MatExpr_type;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_abs_MatExprDelegate(IntPtr e);
        [NativeDelegate("core_abs_MatExpr")] public static core_abs_MatExprDelegate core_abs_MatExpr;
    }
}
