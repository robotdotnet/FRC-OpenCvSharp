using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_EM_getClustersNumberDelegate(IntPtr obj);
        [NativeDelegate("ml_EM_getClustersNumber")] public static ml_EM_getClustersNumberDelegate ml_EM_getClustersNumber;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_EM_setClustersNumberDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_EM_setClustersNumber")] public static ml_EM_setClustersNumberDelegate ml_EM_setClustersNumber;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_EM_getCovarianceMatrixTypeDelegate(IntPtr obj);
        [NativeDelegate("ml_EM_getCovarianceMatrixType")] public static ml_EM_getCovarianceMatrixTypeDelegate ml_EM_getCovarianceMatrixType;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_EM_setCovarianceMatrixTypeDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_EM_setCovarianceMatrixType")] public static ml_EM_setCovarianceMatrixTypeDelegate ml_EM_setCovarianceMatrixType;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate TermCriteria ml_EM_getTermCriteriaDelegate(IntPtr obj);
        [NativeDelegate("ml_EM_getTermCriteria")] public static ml_EM_getTermCriteriaDelegate ml_EM_getTermCriteria;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_EM_setTermCriteriaDelegate(IntPtr obj, TermCriteria val);
        [NativeDelegate("ml_EM_setTermCriteria")] public static ml_EM_setTermCriteriaDelegate ml_EM_setTermCriteria;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_EM_getWeightsDelegate(IntPtr obj);
        [NativeDelegate("ml_EM_getWeights")] public static ml_EM_getWeightsDelegate ml_EM_getWeights;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_EM_getMeansDelegate(IntPtr obj);
        [NativeDelegate("ml_EM_getMeans")] public static ml_EM_getMeansDelegate ml_EM_getMeans;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_EM_getCovsDelegate(IntPtr obj, IntPtr covs);
        [NativeDelegate("ml_EM_getCovs")] public static ml_EM_getCovsDelegate ml_EM_getCovs;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Vec2d ml_EM_predict2Delegate(IntPtr model, IntPtr sample, IntPtr probs);
        [NativeDelegate("ml_EM_predict2")] public static ml_EM_predict2Delegate ml_EM_predict2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_EM_trainEMDelegate(
            IntPtr obj, IntPtr samples, IntPtr logLikelihoods, IntPtr labels, IntPtr probs);
        [NativeDelegate("ml_EM_trainEM")] public static ml_EM_trainEMDelegate ml_EM_trainEM;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_EM_trainEDelegate(
            IntPtr model, IntPtr samples, IntPtr means0, IntPtr covs0, IntPtr weights0,
            IntPtr logLikelihoods, IntPtr labels, IntPtr probs);
        [NativeDelegate("ml_EM_trainE")] public static ml_EM_trainEDelegate ml_EM_trainE;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_EM_trainMDelegate(
            IntPtr model, IntPtr samples, IntPtr probs0, IntPtr logLikelihoods, 
            IntPtr labels, IntPtr probs);
        [NativeDelegate("ml_EM_trainM")] public static ml_EM_trainMDelegate ml_EM_trainM;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_EM_createDelegate();
        [NativeDelegate("ml_EM_create")] public static ml_EM_createDelegate ml_EM_create;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_Ptr_EM_getDelegate(IntPtr ptr);
        [NativeDelegate("ml_Ptr_EM_get")] public static ObjFunc ml_Ptr_EM_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_EM_deleteDelegate(IntPtr ptr);
        [NativeDelegate("ml_EM_delete")] public static ReleaseFunc ml_EM_delete;
    }
}
