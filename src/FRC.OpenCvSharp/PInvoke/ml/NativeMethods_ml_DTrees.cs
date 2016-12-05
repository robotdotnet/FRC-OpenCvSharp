using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_DTrees_getMaxCategoriesDelegate(IntPtr obj);
        [NativeDelegate("ml_DTrees_getMaxCategories")] public static ml_DTrees_getMaxCategoriesDelegate ml_DTrees_getMaxCategories;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_DTrees_setMaxCategoriesDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_DTrees_setMaxCategories")] public static ml_DTrees_setMaxCategoriesDelegate ml_DTrees_setMaxCategories;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_DTrees_getMaxDepthDelegate(IntPtr obj);
        [NativeDelegate("ml_DTrees_getMaxDepth")] public static ml_DTrees_getMaxDepthDelegate ml_DTrees_getMaxDepth;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_DTrees_setMaxDepthDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_DTrees_setMaxDepth")] public static ml_DTrees_setMaxDepthDelegate ml_DTrees_setMaxDepth;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_DTrees_getMinSampleCountDelegate(IntPtr obj);
        [NativeDelegate("ml_DTrees_getMinSampleCount")] public static ml_DTrees_getMinSampleCountDelegate ml_DTrees_getMinSampleCount;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_DTrees_setMinSampleCountDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_DTrees_setMinSampleCount")] public static ml_DTrees_setMinSampleCountDelegate ml_DTrees_setMinSampleCount;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_DTrees_getCVFoldsDelegate(IntPtr obj);
        [NativeDelegate("ml_DTrees_getCVFolds")] public static ml_DTrees_getCVFoldsDelegate ml_DTrees_getCVFolds;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_DTrees_setCVFoldsDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_DTrees_setCVFolds")] public static ml_DTrees_setCVFoldsDelegate ml_DTrees_setCVFolds;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_DTrees_getUseSurrogatesDelegate(IntPtr obj);
        [NativeDelegate("ml_DTrees_getUseSurrogates")] public static ml_DTrees_getUseSurrogatesDelegate ml_DTrees_getUseSurrogates;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_DTrees_setUseSurrogatesDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_DTrees_setUseSurrogates")] public static ml_DTrees_setUseSurrogatesDelegate ml_DTrees_setUseSurrogates;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_DTrees_getUse1SERuleDelegate(IntPtr obj);
        [NativeDelegate("ml_DTrees_getUse1SERule")] public static ml_DTrees_getUse1SERuleDelegate ml_DTrees_getUse1SERule;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_DTrees_setUse1SERuleDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_DTrees_setUse1SERule")] public static ml_DTrees_setUse1SERuleDelegate ml_DTrees_setUse1SERule;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_DTrees_getTruncatePrunedTreeDelegate(IntPtr obj);
        [NativeDelegate("ml_DTrees_getTruncatePrunedTree")] public static ml_DTrees_getTruncatePrunedTreeDelegate ml_DTrees_getTruncatePrunedTree;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_DTrees_setTruncatePrunedTreeDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_DTrees_setTruncatePrunedTree")] public static ml_DTrees_setTruncatePrunedTreeDelegate ml_DTrees_setTruncatePrunedTree;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float ml_DTrees_getRegressionAccuracyDelegate(IntPtr obj);
        [NativeDelegate("ml_DTrees_getRegressionAccuracy")] public static ml_DTrees_getRegressionAccuracyDelegate ml_DTrees_getRegressionAccuracy;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_DTrees_setRegressionAccuracyDelegate(IntPtr obj, float val);
        [NativeDelegate("ml_DTrees_setRegressionAccuracy")] public static ml_DTrees_setRegressionAccuracyDelegate ml_DTrees_setRegressionAccuracy;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_DTrees_getPriorsDelegate(IntPtr obj);
        [NativeDelegate("ml_DTrees_getPriors")] public static ml_DTrees_getPriorsDelegate ml_DTrees_getPriors;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_DTrees_setPriorsDelegate(IntPtr obj, IntPtr val);
        [NativeDelegate("ml_DTrees_setPriors")] public static ml_DTrees_setPriorsDelegate ml_DTrees_setPriors;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_DTrees_getRootsDelegate(IntPtr obj, IntPtr result);
        [NativeDelegate("ml_DTrees_getRoots")] public static ml_DTrees_getRootsDelegate ml_DTrees_getRoots;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_DTrees_getNodesDelegate(IntPtr obj, IntPtr result);
        [NativeDelegate("ml_DTrees_getNodes")] public static ml_DTrees_getNodesDelegate ml_DTrees_getNodes;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_DTrees_getSplitsDelegate(IntPtr obj, IntPtr result);
        [NativeDelegate("ml_DTrees_getSplits")] public static ml_DTrees_getSplitsDelegate ml_DTrees_getSplits;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_DTrees_getSubsetsDelegate(IntPtr obj, IntPtr result);
        [NativeDelegate("ml_DTrees_getSubsets")] public static ml_DTrees_getSubsetsDelegate ml_DTrees_getSubsets;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_DTrees_createDelegate();
        [NativeDelegate("ml_DTrees_create")] public static ml_DTrees_createDelegate ml_DTrees_create;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_Ptr_DTrees_deleteDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_DTrees_delete")] public static ReleaseFunc ml_Ptr_DTrees_delete;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_Ptr_DTrees_getDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_DTrees_get")] public static ObjFunc ml_Ptr_DTrees_get;
    }
}
