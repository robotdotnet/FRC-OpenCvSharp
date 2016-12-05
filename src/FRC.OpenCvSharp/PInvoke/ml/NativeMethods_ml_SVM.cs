using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;
using OpenCvSharp.ML;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_SVM_getTypeDelegate(IntPtr obj);
        [NativeDelegate("ml_SVM_getType")] public static ml_SVM_getTypeDelegate ml_SVM_getType;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_SVM_setTypeDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_SVM_setType")] public static ml_SVM_setTypeDelegate ml_SVM_setType;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_SVM_getGammaDelegate(IntPtr obj);
        [NativeDelegate("ml_SVM_getGamma")] public static ml_SVM_getGammaDelegate ml_SVM_getGamma;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_SVM_setGammaDelegate(IntPtr obj, double val);
        [NativeDelegate("ml_SVM_setGamma")] public static ml_SVM_setGammaDelegate ml_SVM_setGamma;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_SVM_getCoef0Delegate(IntPtr obj);
        [NativeDelegate("ml_SVM_getCoef0")] public static ml_SVM_getCoef0Delegate ml_SVM_getCoef0;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_SVM_setCoef0Delegate(IntPtr obj, double val);
        [NativeDelegate("ml_SVM_setCoef0")] public static ml_SVM_setCoef0Delegate ml_SVM_setCoef0;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_SVM_getDegreeDelegate(IntPtr obj);
        [NativeDelegate("ml_SVM_getDegree")] public static ml_SVM_getDegreeDelegate ml_SVM_getDegree;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_SVM_setDegreeDelegate(IntPtr obj, double val);
        [NativeDelegate("ml_SVM_setDegree")] public static ml_SVM_setDegreeDelegate ml_SVM_setDegree;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_SVM_getCDelegate(IntPtr obj);
        [NativeDelegate("ml_SVM_getC")] public static ml_SVM_getCDelegate ml_SVM_getC;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_SVM_setCDelegate(IntPtr obj, double val);
        [NativeDelegate("ml_SVM_setC")] public static ml_SVM_setCDelegate ml_SVM_setC;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_SVM_getPDelegate(IntPtr obj);
        [NativeDelegate("ml_SVM_getP")] public static ml_SVM_getPDelegate ml_SVM_getP;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_SVM_setPDelegate(IntPtr obj, double val);
        [NativeDelegate("ml_SVM_setP")] public static ml_SVM_setPDelegate ml_SVM_setP;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_SVM_getNuDelegate(IntPtr obj);
        [NativeDelegate("ml_SVM_getNu")] public static ml_SVM_getNuDelegate ml_SVM_getNu;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_SVM_setNuDelegate(IntPtr obj, double val);
        [NativeDelegate("ml_SVM_setNu")] public static ml_SVM_setNuDelegate ml_SVM_setNu;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_SVM_getClassWeightsDelegate(IntPtr obj);
        [NativeDelegate("ml_SVM_getClassWeights")] public static ml_SVM_getClassWeightsDelegate ml_SVM_getClassWeights;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_SVM_setClassWeightsDelegate(IntPtr obj, IntPtr val);
        [NativeDelegate("ml_SVM_setClassWeights")] public static ml_SVM_setClassWeightsDelegate ml_SVM_setClassWeights;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate TermCriteria ml_SVM_getTermCriteriaDelegate(IntPtr obj);
        [NativeDelegate("ml_SVM_getTermCriteria")] public static ml_SVM_getTermCriteriaDelegate ml_SVM_getTermCriteria;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_SVM_setTermCriteriaDelegate(IntPtr obj, TermCriteria val);
        [NativeDelegate("ml_SVM_setTermCriteria")] public static ml_SVM_setTermCriteriaDelegate ml_SVM_setTermCriteria;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_SVM_getKernelTypeDelegate(IntPtr obj);
        [NativeDelegate("ml_SVM_getKernelType")] public static ml_SVM_getKernelTypeDelegate ml_SVM_getKernelType;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_SVM_setKernelDelegate(IntPtr obj, int kernelType);
        [NativeDelegate("ml_SVM_setKernel")] public static ml_SVM_setKernelDelegate ml_SVM_setKernel;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_SVM_getSupportVectorsDelegate(IntPtr obj);
        [NativeDelegate("ml_SVM_getSupportVectors")] public static ml_SVM_getSupportVectorsDelegate ml_SVM_getSupportVectors;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_SVM_getDecisionFunctionDelegate(
            IntPtr obj, int i, IntPtr alpha, IntPtr svidx);
        [NativeDelegate("ml_SVM_getDecisionFunction")] public static ml_SVM_getDecisionFunctionDelegate ml_SVM_getDecisionFunction;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ParamGrid ml_SVM_getDefaultGridDelegate(int paramId);
        [NativeDelegate("ml_SVM_getDefaultGrid")] public static ml_SVM_getDefaultGridDelegate ml_SVM_getDefaultGrid;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_SVM_createDelegate();
        [NativeDelegate("ml_SVM_create")] public static ml_SVM_createDelegate ml_SVM_create;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_Ptr_SVM_deleteDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_SVM_delete")] public static ReleaseFunc ml_Ptr_SVM_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_Ptr_SVM_getDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_SVM_get")] public static ObjFunc ml_Ptr_SVM_get;
    }
}
