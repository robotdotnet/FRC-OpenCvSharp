using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;
using System.Text;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        #region Algorithm
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Algorithm_newDelegate();
        [NativeDelegate("core_Algorithm_new")] public static core_Algorithm_newDelegate core_Algorithm_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Algorithm_deleteDelegate(IntPtr self);
        [NativeDelegate("core_Algorithm_delete")] public static core_Algorithm_deleteDelegate core_Algorithm_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Algorithm_nameDelegate(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] StringBuilder buf, int bufLength);
        [NativeDelegate("core_Algorithm_name")] public static core_Algorithm_nameDelegate core_Algorithm_name;
        
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Ptr_Algorithm_newDelegate(IntPtr rawPtr);
        [NativeDelegate("core_Ptr_Algorithm_new")] public static core_Ptr_Algorithm_newDelegate core_Ptr_Algorithm_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Ptr_Algorithm_deleteDelegate(IntPtr ptr);
        [NativeDelegate("core_Ptr_Algorithm_delete")] public static ReleaseFunc core_Ptr_Algorithm_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_Ptr_Algorithm_getDelegate(IntPtr ptr);
        [NativeDelegate("core_Ptr_Algorithm_get")] public static ObjFunc core_Ptr_Algorithm_get;
        */

        #endregion

        #region InputArray / OutputArray
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_InputArray_new_byMatDelegate(IntPtr mat);
        [NativeDelegate("core_InputArray_new_byMat")] public static core_InputArray_new_byMatDelegate core_InputArray_new_byMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_InputArray_new_byMatExprDelegate(IntPtr mat);
        [NativeDelegate("core_InputArray_new_byMatExpr")] public static core_InputArray_new_byMatExprDelegate core_InputArray_new_byMatExpr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_InputArray_new_byScalarDelegate(Scalar val);
        [NativeDelegate("core_InputArray_new_byScalar")] public static core_InputArray_new_byScalarDelegate core_InputArray_new_byScalar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_InputArray_new_byDoubleDelegate(double val);
        [NativeDelegate("core_InputArray_new_byDouble")] public static core_InputArray_new_byDoubleDelegate core_InputArray_new_byDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_InputArray_new_byGpuMatDelegate(IntPtr mat);
        [NativeDelegate("core_InputArray_new_byGpuMat")] public static core_InputArray_new_byGpuMatDelegate core_InputArray_new_byGpuMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_InputArray_new_byVectorOfMatDelegate(IntPtr vector);
        [NativeDelegate("core_InputArray_new_byVectorOfMat")] public static core_InputArray_new_byVectorOfMatDelegate core_InputArray_new_byVectorOfMat;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_InputArray_deleteDelegate(IntPtr ia);
        [NativeDelegate("core_InputArray_delete")] public static core_InputArray_deleteDelegate core_InputArray_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_OutputArray_new_byMatDelegate(IntPtr mat);
        [NativeDelegate("core_OutputArray_new_byMat")] public static core_OutputArray_new_byMatDelegate core_OutputArray_new_byMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_OutputArray_new_byGpuMatDelegate(IntPtr mat);
        [NativeDelegate("core_OutputArray_new_byGpuMat")] public static core_OutputArray_new_byGpuMatDelegate core_OutputArray_new_byGpuMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_OutputArray_new_byScalarDelegate(Scalar val);
        [NativeDelegate("core_OutputArray_new_byScalar")] public static core_OutputArray_new_byScalarDelegate core_OutputArray_new_byScalar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_OutputArray_new_byVectorOfMatDelegate(IntPtr vector);
        [NativeDelegate("core_OutputArray_new_byVectorOfMat")] public static core_OutputArray_new_byVectorOfMatDelegate core_OutputArray_new_byVectorOfMat;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_OutputArray_deleteDelegate(IntPtr oa);
        [NativeDelegate("core_OutputArray_delete")] public static core_OutputArray_deleteDelegate core_OutputArray_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_InputArray_kindDelegate(IntPtr ia);
        [NativeDelegate("core_InputArray_kind")] public static core_InputArray_kindDelegate core_InputArray_kind;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_OutputArray_getMatDelegate(IntPtr oa);
        [NativeDelegate("core_OutputArray_getMat")] public static core_OutputArray_getMatDelegate core_OutputArray_getMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Scalar core_OutputArray_getScalarDelegate(IntPtr oa);
        [NativeDelegate("core_OutputArray_getScalar")] public static core_OutputArray_getScalarDelegate core_OutputArray_getScalar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_OutputArray_getVectorOfMatDelegate(IntPtr oa, IntPtr vector);
        [NativeDelegate("core_OutputArray_getVectorOfMat")] public static core_OutputArray_getVectorOfMatDelegate core_OutputArray_getVectorOfMat;
        
        #endregion

        #region FileStorage

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileStorage_new1Delegate();
        [NativeDelegate("core_FileStorage_new1")] public static core_FileStorage_new1Delegate core_FileStorage_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileStorage_new2Delegate(
            [MarshalAs(UnmanagedType.LPStr)] string source, 
            int flags, [MarshalAs(UnmanagedType.LPStr)] string encoding);
        [NativeDelegate("core_FileStorage_new2")] public static core_FileStorage_new2Delegate core_FileStorage_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileStorage_newFromLegacyDelegate(IntPtr fs);
        [NativeDelegate("core_FileStorage_newFromLegacy")] public static core_FileStorage_newFromLegacyDelegate core_FileStorage_newFromLegacy;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_deleteDelegate(IntPtr obj);
        [NativeDelegate("core_FileStorage_delete")] public static core_FileStorage_deleteDelegate core_FileStorage_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_FileStorage_openDelegate(
            IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string filename, 
            int flags, [MarshalAs(UnmanagedType.LPStr)] string encoding);
        [NativeDelegate("core_FileStorage_open")] public static core_FileStorage_openDelegate core_FileStorage_open;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_FileStorage_isOpenedDelegate(IntPtr obj);
        [NativeDelegate("core_FileStorage_isOpened")] public static core_FileStorage_isOpenedDelegate core_FileStorage_isOpened;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_releaseDelegate(IntPtr obj);
        [NativeDelegate("core_FileStorage_release")] public static core_FileStorage_releaseDelegate core_FileStorage_release;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_releaseAndGetStringDelegate(
            IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] StringBuilder buf, int bufLength);
        [NativeDelegate("core_FileStorage_releaseAndGetString")] public static core_FileStorage_releaseAndGetStringDelegate core_FileStorage_releaseAndGetString;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileStorage_getFirstTopLevelNodeDelegate(IntPtr obj);
        [NativeDelegate("core_FileStorage_getFirstTopLevelNode")] public static core_FileStorage_getFirstTopLevelNodeDelegate core_FileStorage_getFirstTopLevelNode;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileStorage_rootDelegate(IntPtr obj, int streamIdx);
        [NativeDelegate("core_FileStorage_root")] public static core_FileStorage_rootDelegate core_FileStorage_root;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileStorage_indexerDelegate(
            IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string nodeName);
        [NativeDelegate("core_FileStorage_indexer")] public static core_FileStorage_indexerDelegate core_FileStorage_indexer;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileStorage_toLegacyDelegate(IntPtr obj);
        [NativeDelegate("core_FileStorage_toLegacy")] public static core_FileStorage_toLegacyDelegate core_FileStorage_toLegacy;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_writeRawDelegate(
            IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string fmt, IntPtr vec, IntPtr len);
        [NativeDelegate("core_FileStorage_writeRaw")] public static core_FileStorage_writeRawDelegate core_FileStorage_writeRaw;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_writeObjDelegate(
            IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string name, IntPtr value);
        [NativeDelegate("core_FileStorage_writeObj")] public static core_FileStorage_writeObjDelegate core_FileStorage_writeObj;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_getDefaultObjectNameDelegate(
            [MarshalAs(UnmanagedType.LPStr)] string filename, 
            [MarshalAs(UnmanagedType.LPStr)] StringBuilder buf, int bufLength);
        [NativeDelegate("core_FileStorage_getDefaultObjectName")] public static core_FileStorage_getDefaultObjectNameDelegate core_FileStorage_getDefaultObjectName;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate sbyte* core_FileStorage_elnameDelegate(IntPtr obj);
        [NativeDelegate("core_FileStorage_elname")] public static core_FileStorage_elnameDelegate core_FileStorage_elname;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileStorage_structsDelegate(IntPtr obj, out IntPtr resultLength);
        [NativeDelegate("core_FileStorage_structs")] public static core_FileStorage_structsDelegate core_FileStorage_structs;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_FileStorage_stateDelegate(IntPtr obj);
        [NativeDelegate("core_FileStorage_state")] public static core_FileStorage_stateDelegate core_FileStorage_state;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_write_intDelegate(
            IntPtr fs, [MarshalAs(UnmanagedType.LPStr)] string name, int value);
        [NativeDelegate("core_FileStorage_write_int")] public static core_FileStorage_write_intDelegate core_FileStorage_write_int;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_write_floatDelegate(
            IntPtr fs, [MarshalAs(UnmanagedType.LPStr)] string name, float value);
        [NativeDelegate("core_FileStorage_write_float")] public static core_FileStorage_write_floatDelegate core_FileStorage_write_float;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_write_doubleDelegate(
            IntPtr fs, [MarshalAs(UnmanagedType.LPStr)] string name, double value);
        [NativeDelegate("core_FileStorage_write_double")] public static core_FileStorage_write_doubleDelegate core_FileStorage_write_double;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_write_StringDelegate(
            IntPtr fs, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value);
        [NativeDelegate("core_FileStorage_write_String")] public static core_FileStorage_write_StringDelegate core_FileStorage_write_String;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_write_MatDelegate(
            IntPtr fs, [MarshalAs(UnmanagedType.LPStr)] string name, IntPtr value);
        [NativeDelegate("core_FileStorage_write_Mat")] public static core_FileStorage_write_MatDelegate core_FileStorage_write_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_write_SparseMatDelegate(
            IntPtr fs, [MarshalAs(UnmanagedType.LPStr)] string name, IntPtr value);
        [NativeDelegate("core_FileStorage_write_SparseMat")] public static core_FileStorage_write_SparseMatDelegate core_FileStorage_write_SparseMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_write_vectorOfKeyPointDelegate(
            IntPtr fs, [MarshalAs(UnmanagedType.LPStr)] string name, IntPtr value);
        [NativeDelegate("core_FileStorage_write_vectorOfKeyPoint")] public static core_FileStorage_write_vectorOfKeyPointDelegate core_FileStorage_write_vectorOfKeyPoint;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_write_vectorOfDMatchDelegate(
            IntPtr fs, [MarshalAs(UnmanagedType.LPStr)] string name, IntPtr value);
        [NativeDelegate("core_FileStorage_write_vectorOfDMatch")] public static core_FileStorage_write_vectorOfDMatchDelegate core_FileStorage_write_vectorOfDMatch;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_writeScalar_intDelegate(IntPtr fs, int value);
        [NativeDelegate("core_FileStorage_writeScalar_int")] public static core_FileStorage_writeScalar_intDelegate core_FileStorage_writeScalar_int;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_writeScalar_floatDelegate(IntPtr fs, float value);
        [NativeDelegate("core_FileStorage_writeScalar_float")] public static core_FileStorage_writeScalar_floatDelegate core_FileStorage_writeScalar_float;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_writeScalar_doubleDelegate(IntPtr fs, double value);
        [NativeDelegate("core_FileStorage_writeScalar_double")] public static core_FileStorage_writeScalar_doubleDelegate core_FileStorage_writeScalar_double;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileStorage_writeScalar_StringDelegate(IntPtr fs, [MarshalAs(UnmanagedType.LPStr)] string value);
        [NativeDelegate("core_FileStorage_writeScalar_String")] public static core_FileStorage_writeScalar_StringDelegate core_FileStorage_writeScalar_String;

        #endregion

        #region FileNode

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileNode_new1Delegate();
        [NativeDelegate("core_FileNode_new1")] public static core_FileNode_new1Delegate core_FileNode_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileNode_new2Delegate(IntPtr fs, IntPtr node);
        [NativeDelegate("core_FileNode_new2")] public static core_FileNode_new2Delegate core_FileNode_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileNode_new3Delegate(IntPtr node);
        [NativeDelegate("core_FileNode_new3")] public static core_FileNode_new3Delegate core_FileNode_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileNode_deleteDelegate(IntPtr node);
        [NativeDelegate("core_FileNode_delete")] public static core_FileNode_deleteDelegate core_FileNode_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileNode_operatorThis_byStringDelegate(
            IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string nodeName);
        [NativeDelegate("core_FileNode_operatorThis_byString")] public static core_FileNode_operatorThis_byStringDelegate core_FileNode_operatorThis_byString;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileNode_operatorThis_byIntDelegate(IntPtr obj, int i);
        [NativeDelegate("core_FileNode_operatorThis_byInt")] public static core_FileNode_operatorThis_byIntDelegate core_FileNode_operatorThis_byInt;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_FileNode_typeDelegate(IntPtr obj);
        [NativeDelegate("core_FileNode_type")] public static core_FileNode_typeDelegate core_FileNode_type;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_FileNode_emptyDelegate(IntPtr obj);
        [NativeDelegate("core_FileNode_empty")] public static core_FileNode_emptyDelegate core_FileNode_empty;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_FileNode_isNoneDelegate(IntPtr obj);
        [NativeDelegate("core_FileNode_isNone")] public static core_FileNode_isNoneDelegate core_FileNode_isNone;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_FileNode_isSeqDelegate(IntPtr obj);
        [NativeDelegate("core_FileNode_isSeq")] public static core_FileNode_isSeqDelegate core_FileNode_isSeq;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_FileNode_isMapDelegate(IntPtr obj);
        [NativeDelegate("core_FileNode_isMap")] public static core_FileNode_isMapDelegate core_FileNode_isMap;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_FileNode_isIntDelegate(IntPtr obj);
        [NativeDelegate("core_FileNode_isInt")] public static core_FileNode_isIntDelegate core_FileNode_isInt;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_FileNode_isRealDelegate(IntPtr obj);
        [NativeDelegate("core_FileNode_isReal")] public static core_FileNode_isRealDelegate core_FileNode_isReal;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_FileNode_isStringDelegate(IntPtr obj);
        [NativeDelegate("core_FileNode_isString")] public static core_FileNode_isStringDelegate core_FileNode_isString;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_FileNode_isNamedDelegate(IntPtr obj);
        [NativeDelegate("core_FileNode_isNamed")] public static core_FileNode_isNamedDelegate core_FileNode_isNamed;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileNode_nameDelegate(
            IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] StringBuilder buf, int bufLength);
        [NativeDelegate("core_FileNode_name")] public static core_FileNode_nameDelegate core_FileNode_name;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileNode_sizeDelegate(IntPtr obj);
        [NativeDelegate("core_FileNode_size")] public static core_FileNode_sizeDelegate core_FileNode_size;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_FileNode_toIntDelegate(IntPtr obj);
        [NativeDelegate("core_FileNode_toInt")] public static core_FileNode_toIntDelegate core_FileNode_toInt;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float core_FileNode_toFloatDelegate(IntPtr obj);
        [NativeDelegate("core_FileNode_toFloat")] public static core_FileNode_toFloatDelegate core_FileNode_toFloat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double core_FileNode_toDoubleDelegate(IntPtr obj);
        [NativeDelegate("core_FileNode_toDouble")] public static core_FileNode_toDoubleDelegate core_FileNode_toDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileNode_toStringDelegate(
            IntPtr obj, StringBuilder buf, int bufLength);
        [NativeDelegate("core_FileNode_toString")] public static core_FileNode_toStringDelegate core_FileNode_toString;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileNode_toMatDelegate(IntPtr obj, IntPtr m);
        [NativeDelegate("core_FileNode_toMat")] public static core_FileNode_toMatDelegate core_FileNode_toMat;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileNode_readRawDelegate(
            IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string fmt, IntPtr vec, IntPtr len);
        [NativeDelegate("core_FileNode_readRaw")] public static core_FileNode_readRawDelegate core_FileNode_readRaw;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_FileNode_readObjDelegate(IntPtr obj);
        [NativeDelegate("core_FileNode_readObj")] public static core_FileNode_readObjDelegate core_FileNode_readObj;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileNode_read_intDelegate(IntPtr node, out int value, int defaultValue);
        [NativeDelegate("core_FileNode_read_int")] public static core_FileNode_read_intDelegate core_FileNode_read_int;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileNode_read_floatDelegate(IntPtr node, out float value, float defaultValue);
        [NativeDelegate("core_FileNode_read_float")] public static core_FileNode_read_floatDelegate core_FileNode_read_float;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileNode_read_doubleDelegate(IntPtr node, out double value, double defaultValue);
        [NativeDelegate("core_FileNode_read_double")] public static core_FileNode_read_doubleDelegate core_FileNode_read_double;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileNode_read_StringDelegate(
            IntPtr node, [MarshalAs(UnmanagedType.LPStr)] StringBuilder value, int valueCapacity,
            [MarshalAs(UnmanagedType.LPStr)] string defaultValue);
        [NativeDelegate("core_FileNode_read_String")] public static core_FileNode_read_StringDelegate core_FileNode_read_String;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileNode_read_MatDelegate(IntPtr node, IntPtr mat, IntPtr defaultMat);
        [NativeDelegate("core_FileNode_read_Mat")] public static core_FileNode_read_MatDelegate core_FileNode_read_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileNode_read_SparseMatDelegate(IntPtr node, IntPtr mat, IntPtr defaultMat);
        [NativeDelegate("core_FileNode_read_SparseMat")] public static core_FileNode_read_SparseMatDelegate core_FileNode_read_SparseMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileNode_read_vectorOfKeyPointDelegate(IntPtr node, IntPtr keypoints);
        [NativeDelegate("core_FileNode_read_vectorOfKeyPoint")] public static core_FileNode_read_vectorOfKeyPointDelegate core_FileNode_read_vectorOfKeyPoint;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_FileNode_read_vectorOfDMatchDelegate(IntPtr node, IntPtr matches);
        [NativeDelegate("core_FileNode_read_vectorOfDMatch")] public static core_FileNode_read_vectorOfDMatchDelegate core_FileNode_read_vectorOfDMatch;

        #endregion

        #region PCA
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_PCA_new1Delegate();
        [NativeDelegate("core_PCA_new1")] public static core_PCA_new1Delegate core_PCA_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_PCA_new2Delegate(IntPtr data, IntPtr mean, int flags,
            int maxComponents);
        [NativeDelegate("core_PCA_new2")] public static core_PCA_new2Delegate core_PCA_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_PCA_new3Delegate(IntPtr data, IntPtr mean, int flags,
            double retainedVariance);
        [NativeDelegate("core_PCA_new3")] public static core_PCA_new3Delegate core_PCA_new3;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_PCA_deleteDelegate(IntPtr obj);
        [NativeDelegate("core_PCA_delete")] public static core_PCA_deleteDelegate core_PCA_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_PCA_operatorThisDelegate(IntPtr obj, IntPtr data, IntPtr mean,
            int flags, int maxComponents);
        [NativeDelegate("core_PCA_operatorThis")] public static core_PCA_operatorThisDelegate core_PCA_operatorThis;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_PCA_computeVarDelegate(IntPtr obj, IntPtr data, IntPtr mean,
            int flags, double retainedVariance);
        [NativeDelegate("core_PCA_computeVar")] public static core_PCA_computeVarDelegate core_PCA_computeVar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_PCA_project1Delegate(IntPtr obj, IntPtr vec);
        [NativeDelegate("core_PCA_project1")] public static core_PCA_project1Delegate core_PCA_project1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_PCA_project2Delegate(IntPtr obj, IntPtr vec, IntPtr result);
        [NativeDelegate("core_PCA_project2")] public static core_PCA_project2Delegate core_PCA_project2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_PCA_backProject1Delegate(IntPtr obj, IntPtr vec);
        [NativeDelegate("core_PCA_backProject1")] public static core_PCA_backProject1Delegate core_PCA_backProject1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_PCA_backProject2Delegate(IntPtr obj, IntPtr vec, IntPtr result);
        [NativeDelegate("core_PCA_backProject2")] public static core_PCA_backProject2Delegate core_PCA_backProject2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_PCA_eigenvectorsDelegate(IntPtr obj);
        [NativeDelegate("core_PCA_eigenvectors")] public static core_PCA_eigenvectorsDelegate core_PCA_eigenvectors;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_PCA_eigenvaluesDelegate(IntPtr obj);
        [NativeDelegate("core_PCA_eigenvalues")] public static core_PCA_eigenvaluesDelegate core_PCA_eigenvalues;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_PCA_meanDelegate(IntPtr obj);
        [NativeDelegate("core_PCA_mean")] public static core_PCA_meanDelegate core_PCA_mean;
        #endregion

        #region RNG
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong core_RNG_new1Delegate();
        [NativeDelegate("core_RNG_new1")] public static core_RNG_new1Delegate core_RNG_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong core_RNG_new2Delegate(ulong state);
        [NativeDelegate("core_RNG_new2")] public static core_RNG_new2Delegate core_RNG_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint core_RNG_nextDelegate(ulong state);
        [NativeDelegate("core_RNG_next")] public static core_RNG_nextDelegate core_RNG_next;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate byte core_RNG_operator_ucharDelegate(ulong state);
        [NativeDelegate("core_RNG_operator_uchar")] public static core_RNG_operator_ucharDelegate core_RNG_operator_uchar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate sbyte core_RNG_operator_scharDelegate(ulong state);
        [NativeDelegate("core_RNG_operator_schar")] public static core_RNG_operator_scharDelegate core_RNG_operator_schar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ushort core_RNG_operator_ushortDelegate(ulong state);
        [NativeDelegate("core_RNG_operator_ushort")] public static core_RNG_operator_ushortDelegate core_RNG_operator_ushort;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate short core_RNG_operator_shortDelegate(ulong state);
        [NativeDelegate("core_RNG_operator_short")] public static core_RNG_operator_shortDelegate core_RNG_operator_short;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint core_RNG_operator_uintDelegate(ulong state);
        [NativeDelegate("core_RNG_operator_uint")] public static core_RNG_operator_uintDelegate core_RNG_operator_uint;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint core_RNG_operatorThis1Delegate(ulong state, uint n);
        [NativeDelegate("core_RNG_operatorThis1")] public static core_RNG_operatorThis1Delegate core_RNG_operatorThis1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint core_RNG_operatorThis2Delegate(ulong state);
        [NativeDelegate("core_RNG_operatorThis2")] public static core_RNG_operatorThis2Delegate core_RNG_operatorThis2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_RNG_operator_intDelegate(ulong state);
        [NativeDelegate("core_RNG_operator_int")] public static core_RNG_operator_intDelegate core_RNG_operator_int;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float core_RNG_operator_floatDelegate(ulong state);
        [NativeDelegate("core_RNG_operator_float")] public static core_RNG_operator_floatDelegate core_RNG_operator_float;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double core_RNG_operator_doubleDelegate(ulong state);
        [NativeDelegate("core_RNG_operator_double")] public static core_RNG_operator_doubleDelegate core_RNG_operator_double;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_RNG_uniform_intDelegate(ulong state, int a, int b);
        [NativeDelegate("core_RNG_uniform_int")] public static core_RNG_uniform_intDelegate core_RNG_uniform_int;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float core_RNG_uniform_floatDelegate(ulong state, float a, float b);
        [NativeDelegate("core_RNG_uniform_float")] public static core_RNG_uniform_floatDelegate core_RNG_uniform_float;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double core_RNG_uniform_doubleDelegate(ulong state, double a, double b);
        [NativeDelegate("core_RNG_uniform_double")] public static core_RNG_uniform_doubleDelegate core_RNG_uniform_double;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_RNG_fillDelegate(ulong state, IntPtr mat, int distType, IntPtr a, IntPtr b, int saturateRange);
        [NativeDelegate("core_RNG_fill")] public static core_RNG_fillDelegate core_RNG_fill;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double core_RNG_gaussianDelegate(ulong state, double sigma);
        [NativeDelegate("core_RNG_gaussian")] public static core_RNG_gaussianDelegate core_RNG_gaussian;
        #endregion

        #region SVD
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SVD_new1Delegate();
        [NativeDelegate("core_SVD_new1")] public static core_SVD_new1Delegate core_SVD_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SVD_new2Delegate(IntPtr src, int flags);
        [NativeDelegate("core_SVD_new2")] public static core_SVD_new2Delegate core_SVD_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SVD_deleteDelegate(IntPtr obj);
        [NativeDelegate("core_SVD_delete")] public static core_SVD_deleteDelegate core_SVD_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SVD_operatorThisDelegate(IntPtr obj, IntPtr src, int flags);
        [NativeDelegate("core_SVD_operatorThis")] public static core_SVD_operatorThisDelegate core_SVD_operatorThis;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SVD_backSubstDelegate(IntPtr obj, IntPtr rhs, IntPtr dst);
        [NativeDelegate("core_SVD_backSubst")] public static core_SVD_backSubstDelegate core_SVD_backSubst;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SVD_static_compute1Delegate(IntPtr src, IntPtr w, IntPtr u, IntPtr vt, int flags);
        [NativeDelegate("core_SVD_static_compute1")] public static core_SVD_static_compute1Delegate core_SVD_static_compute1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SVD_static_compute2Delegate(IntPtr src, IntPtr w, int flags);
        [NativeDelegate("core_SVD_static_compute2")] public static core_SVD_static_compute2Delegate core_SVD_static_compute2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SVD_static_backSubstDelegate(IntPtr w, IntPtr u, IntPtr vt, IntPtr rhs, IntPtr dst);
        [NativeDelegate("core_SVD_static_backSubst")] public static core_SVD_static_backSubstDelegate core_SVD_static_backSubst;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SVD_static_solveZDelegate(IntPtr src, IntPtr dst);
        [NativeDelegate("core_SVD_static_solveZ")] public static core_SVD_static_solveZDelegate core_SVD_static_solveZ;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SVD_uDelegate(IntPtr obj);
        [NativeDelegate("core_SVD_u")] public static core_SVD_uDelegate core_SVD_u;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SVD_wDelegate(IntPtr obj);
        [NativeDelegate("core_SVD_w")] public static core_SVD_wDelegate core_SVD_w;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_SVD_vtDelegate(IntPtr obj);
        [NativeDelegate("core_SVD_vt")] public static core_SVD_vtDelegate core_SVD_vt;
        #endregion
    }
}
