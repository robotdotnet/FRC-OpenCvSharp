using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong core_SparseMat_sizeofDelegate();
        [NativeDelegate("core_SparseMat_sizeof")] public static core_SparseMat_sizeofDelegate core_SparseMat_sizeof;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_new1Delegate();
        [NativeDelegate("core_SparseMat_new1")] public static core_SparseMat_new1Delegate core_SparseMat_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_new2Delegate(int dims, int[] sizes, int type);
        [NativeDelegate("core_SparseMat_new2")] public static core_SparseMat_new2Delegate core_SparseMat_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_new3Delegate(IntPtr m);
        [NativeDelegate("core_SparseMat_new3")] public static core_SparseMat_new3Delegate core_SparseMat_new3;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SparseMat_deleteDelegate(IntPtr obj);
        [NativeDelegate("core_SparseMat_delete")] public static core_SparseMat_deleteDelegate core_SparseMat_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SparseMat_operatorAssign_SparseMatDelegate(IntPtr obj, IntPtr m);
        [NativeDelegate("core_SparseMat_operatorAssign_SparseMat")] public static core_SparseMat_operatorAssign_SparseMatDelegate core_SparseMat_operatorAssign_SparseMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SparseMat_operatorAssign_MatDelegate(IntPtr obj, IntPtr m);
        [NativeDelegate("core_SparseMat_operatorAssign_Mat")] public static core_SparseMat_operatorAssign_MatDelegate core_SparseMat_operatorAssign_Mat;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_cloneDelegate(IntPtr obj);
        [NativeDelegate("core_SparseMat_clone")] public static core_SparseMat_cloneDelegate core_SparseMat_clone;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SparseMat_copyTo_SparseMatDelegate(IntPtr obj, IntPtr m);
        [NativeDelegate("core_SparseMat_copyTo_SparseMat")] public static core_SparseMat_copyTo_SparseMatDelegate core_SparseMat_copyTo_SparseMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SparseMat_copyTo_MatDelegate(IntPtr obj, IntPtr m);
        [NativeDelegate("core_SparseMat_copyTo_Mat")] public static core_SparseMat_copyTo_MatDelegate core_SparseMat_copyTo_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SparseMat_convertTo_SparseMatDelegate(IntPtr obj, IntPtr m,
            int rtype, double alpha);
        [NativeDelegate("core_SparseMat_convertTo_SparseMat")] public static core_SparseMat_convertTo_SparseMatDelegate core_SparseMat_convertTo_SparseMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SparseMat_convertTo_MatDelegate(IntPtr obj, IntPtr m, int rtype,
            double alpha, double beta);
        [NativeDelegate("core_SparseMat_convertTo_Mat")] public static core_SparseMat_convertTo_MatDelegate core_SparseMat_convertTo_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SparseMat_assignToDelegate(IntPtr obj, IntPtr m, int type);
        [NativeDelegate("core_SparseMat_assignTo")] public static core_SparseMat_assignToDelegate core_SparseMat_assignTo;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SparseMat_createDelegate(IntPtr obj, int dims, int[] sizes, int type);
        [NativeDelegate("core_SparseMat_create")] public static core_SparseMat_createDelegate core_SparseMat_create;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SparseMat_clearDelegate(IntPtr obj);
        [NativeDelegate("core_SparseMat_clear")] public static core_SparseMat_clearDelegate core_SparseMat_clear;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SparseMat_addrefDelegate(IntPtr obj);
        [NativeDelegate("core_SparseMat_addref")] public static core_SparseMat_addrefDelegate core_SparseMat_addref;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SparseMat_releaseDelegate(IntPtr obj);
        [NativeDelegate("core_SparseMat_release")] public static core_SparseMat_releaseDelegate core_SparseMat_release;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_SparseMat_elemSizeDelegate(IntPtr obj);
        [NativeDelegate("core_SparseMat_elemSize")] public static core_SparseMat_elemSizeDelegate core_SparseMat_elemSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_SparseMat_elemSize1Delegate(IntPtr obj);
        [NativeDelegate("core_SparseMat_elemSize1")] public static core_SparseMat_elemSize1Delegate core_SparseMat_elemSize1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_SparseMat_typeDelegate(IntPtr obj);
        [NativeDelegate("core_SparseMat_type")] public static core_SparseMat_typeDelegate core_SparseMat_type;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_SparseMat_depthDelegate(IntPtr obj);
        [NativeDelegate("core_SparseMat_depth")] public static core_SparseMat_depthDelegate core_SparseMat_depth;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_SparseMat_channelsDelegate(IntPtr obj);
        [NativeDelegate("core_SparseMat_channels")] public static core_SparseMat_channelsDelegate core_SparseMat_channels;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_size1Delegate(IntPtr obj);
        [NativeDelegate("core_SparseMat_size1")] public static core_SparseMat_size1Delegate core_SparseMat_size1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_SparseMat_size2Delegate(IntPtr obj, int i);
        [NativeDelegate("core_SparseMat_size2")] public static core_SparseMat_size2Delegate core_SparseMat_size2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_SparseMat_dimsDelegate(IntPtr obj);
        [NativeDelegate("core_SparseMat_dims")] public static core_SparseMat_dimsDelegate core_SparseMat_dims;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_nzcountDelegate(IntPtr obj);
        [NativeDelegate("core_SparseMat_nzcount")] public static core_SparseMat_nzcountDelegate core_SparseMat_nzcount;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_hash_1dDelegate(IntPtr obj, int i0);
        [NativeDelegate("core_SparseMat_hash_1d")] public static core_SparseMat_hash_1dDelegate core_SparseMat_hash_1d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_hash_2dDelegate(IntPtr obj, int i0, int i1);
        [NativeDelegate("core_SparseMat_hash_2d")] public static core_SparseMat_hash_2dDelegate core_SparseMat_hash_2d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_hash_3dDelegate(IntPtr obj, int i0, int i1, int i2);
        [NativeDelegate("core_SparseMat_hash_3d")] public static core_SparseMat_hash_3dDelegate core_SparseMat_hash_3d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_hash_ndDelegate(IntPtr obj, int[] idx);
        [NativeDelegate("core_SparseMat_hash_nd")] public static core_SparseMat_hash_ndDelegate core_SparseMat_hash_nd;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_ptr_1dDelegate(IntPtr obj, int i0,
            int createMissing, ref ulong hashval);
        [NativeDelegate("core_SparseMat_ptr_1d")] public static core_SparseMat_ptr_1dDelegate core_SparseMat_ptr_1d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_ptr_1dDelegate2(IntPtr obj, int i0,
            int createMissing, IntPtr hashval);
        [NativeDelegate("core_SparseMat_ptr_1d")] public static core_SparseMat_ptr_1dDelegate2 core_SparseMat_ptr_1d2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_ptr_2dDelegate(IntPtr obj, int i0, int i1,
            int createMissing, ref ulong hashval);
        [NativeDelegate("core_SparseMat_ptr_2d")] public static core_SparseMat_ptr_2dDelegate core_SparseMat_ptr_2d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_ptr_2dDelegate2(IntPtr obj, int i0, int i1,
            int createMissing, IntPtr hashval);
        [NativeDelegate("core_SparseMat_ptr_2d")] public static core_SparseMat_ptr_2dDelegate2 core_SparseMat_ptr_2d2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_ptr_3dDelegate(IntPtr obj, int i0, int i1, int i2,
            int createMissing, ref ulong hashval);
        [NativeDelegate("core_SparseMat_ptr_3d")] public static core_SparseMat_ptr_3dDelegate core_SparseMat_ptr_3d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_ptr_3dDelegate2(IntPtr obj, int i0, int i1, int i2,
            int createMissing, IntPtr hashval);
        [NativeDelegate("core_SparseMat_ptr_3d")] public static core_SparseMat_ptr_3dDelegate2 core_SparseMat_ptr_3d2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_ptr_ndDelegate(IntPtr obj, int[] idx,
            int createMissing, ref ulong hashval);
        [NativeDelegate("core_SparseMat_ptr_nd")] public static core_SparseMat_ptr_ndDelegate core_SparseMat_ptr_nd;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SparseMat_ptr_ndDelegate2(IntPtr obj, int[] idx,
            int createMissing, IntPtr hashval);
        [NativeDelegate("core_SparseMat_ptr_nd")] public static core_SparseMat_ptr_ndDelegate2 core_SparseMat_ptr_nd2;
    }
}
