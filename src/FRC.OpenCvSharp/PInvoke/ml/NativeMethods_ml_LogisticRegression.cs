using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_LogisticRegression_getLearningRateDelegate(IntPtr obj);
        [NativeDelegate("ml_LogisticRegression_getLearningRate")] public static ml_LogisticRegression_getLearningRateDelegate ml_LogisticRegression_getLearningRate;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_LogisticRegression_setLearningRateDelegate(IntPtr obj, double val);
        [NativeDelegate("ml_LogisticRegression_setLearningRate")] public static ml_LogisticRegression_setLearningRateDelegate ml_LogisticRegression_setLearningRate;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_LogisticRegression_getIterationsDelegate(IntPtr obj);
        [NativeDelegate("ml_LogisticRegression_getIterations")] public static ml_LogisticRegression_getIterationsDelegate ml_LogisticRegression_getIterations;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_LogisticRegression_setIterationsDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_LogisticRegression_setIterations")] public static ml_LogisticRegression_setIterationsDelegate ml_LogisticRegression_setIterations;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_LogisticRegression_getRegularizationDelegate(IntPtr obj);
        [NativeDelegate("ml_LogisticRegression_getRegularization")] public static ml_LogisticRegression_getRegularizationDelegate ml_LogisticRegression_getRegularization;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_LogisticRegression_setRegularizationDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_LogisticRegression_setRegularization")] public static ml_LogisticRegression_setRegularizationDelegate ml_LogisticRegression_setRegularization;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_LogisticRegression_getTrainMethodDelegate(IntPtr obj);
        [NativeDelegate("ml_LogisticRegression_getTrainMethod")] public static ml_LogisticRegression_getTrainMethodDelegate ml_LogisticRegression_getTrainMethod;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_LogisticRegression_setTrainMethodDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_LogisticRegression_setTrainMethod")] public static ml_LogisticRegression_setTrainMethodDelegate ml_LogisticRegression_setTrainMethod;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_LogisticRegression_getMiniBatchSizeDelegate(IntPtr obj);
        [NativeDelegate("ml_LogisticRegression_getMiniBatchSize")] public static ml_LogisticRegression_getMiniBatchSizeDelegate ml_LogisticRegression_getMiniBatchSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_LogisticRegression_setMiniBatchSizeDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_LogisticRegression_setMiniBatchSize")] public static ml_LogisticRegression_setMiniBatchSizeDelegate ml_LogisticRegression_setMiniBatchSize;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate TermCriteria ml_LogisticRegression_getTermCriteriaDelegate(IntPtr obj);
        [NativeDelegate("ml_LogisticRegression_getTermCriteria")] public static ml_LogisticRegression_getTermCriteriaDelegate ml_LogisticRegression_getTermCriteria;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_LogisticRegression_setTermCriteriaDelegate(IntPtr obj, TermCriteria val);
        [NativeDelegate("ml_LogisticRegression_setTermCriteria")] public static ml_LogisticRegression_setTermCriteriaDelegate ml_LogisticRegression_setTermCriteria;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float ml_LogisticRegression_predictDelegate(
            IntPtr obj, IntPtr samples, IntPtr results, int flags);
        [NativeDelegate("ml_LogisticRegression_predict")] public static ml_LogisticRegression_predictDelegate ml_LogisticRegression_predict;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_LogisticRegression_get_learnt_thetasDelegate(IntPtr obj);
        [NativeDelegate("ml_LogisticRegression_get_learnt_thetas")] public static ml_LogisticRegression_get_learnt_thetasDelegate ml_LogisticRegression_get_learnt_thetas;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_LogisticRegression_createDelegate();
        [NativeDelegate("ml_LogisticRegression_create")] public static ml_LogisticRegression_createDelegate ml_LogisticRegression_create;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_Ptr_LogisticRegression_deleteDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_LogisticRegression_delete")] public static ReleaseFunc ml_Ptr_LogisticRegression_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_Ptr_LogisticRegression_getDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_LogisticRegression_get")] public static ObjFunc ml_Ptr_LogisticRegression_get;
    }
}
