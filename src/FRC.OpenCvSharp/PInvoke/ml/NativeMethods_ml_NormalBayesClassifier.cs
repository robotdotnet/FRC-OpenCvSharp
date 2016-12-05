using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float ml_NormalBayesClassifier_predictProbDelegate(
            IntPtr obj, IntPtr inputs,
            IntPtr samples, IntPtr outputProbs, int flags);
        [NativeDelegate("ml_NormalBayesClassifier_predictProb")] public static ml_NormalBayesClassifier_predictProbDelegate ml_NormalBayesClassifier_predictProb;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_NormalBayesClassifier_createDelegate();
        [NativeDelegate("ml_NormalBayesClassifier_create")] public static ml_NormalBayesClassifier_createDelegate ml_NormalBayesClassifier_create;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_Ptr_NormalBayesClassifier_deleteDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_NormalBayesClassifier_delete")] public static ReleaseFunc ml_Ptr_NormalBayesClassifier_delete;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_Ptr_NormalBayesClassifier_getDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_NormalBayesClassifier_get")] public static ObjFunc ml_Ptr_NormalBayesClassifier_get;
    }
}
