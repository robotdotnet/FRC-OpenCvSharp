using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_ANN_MLP_setTrainMethodDelegate(IntPtr obj, int method, double param1, double param2);
        [NativeDelegate("ml_ANN_MLP_setTrainMethod")] public static ml_ANN_MLP_setTrainMethodDelegate ml_ANN_MLP_setTrainMethod;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_ANN_MLP_getTrainMethodDelegate(IntPtr obj);
        [NativeDelegate("ml_ANN_MLP_getTrainMethod")] public static ml_ANN_MLP_getTrainMethodDelegate ml_ANN_MLP_getTrainMethod;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_ANN_MLP_setActivationFunctionDelegate(IntPtr obj, int type, double param1, double param2);
        [NativeDelegate("ml_ANN_MLP_setActivationFunction")] public static ml_ANN_MLP_setActivationFunctionDelegate ml_ANN_MLP_setActivationFunction;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_ANN_MLP_setLayerSizesDelegate(IntPtr obj, IntPtr layerSizes);
        [NativeDelegate("ml_ANN_MLP_setLayerSizes")] public static ml_ANN_MLP_setLayerSizesDelegate ml_ANN_MLP_setLayerSizes;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_ANN_MLP_getLayerSizesDelegate(IntPtr obj);
        [NativeDelegate("ml_ANN_MLP_getLayerSizes")] public static ml_ANN_MLP_getLayerSizesDelegate ml_ANN_MLP_getLayerSizes;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate TermCriteria ml_ANN_MLP_getTermCriteriaDelegate(IntPtr obj);
        [NativeDelegate("ml_ANN_MLP_getTermCriteria")] public static ml_ANN_MLP_getTermCriteriaDelegate ml_ANN_MLP_getTermCriteria;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_ANN_MLP_setTermCriteriaDelegate(IntPtr obj, TermCriteria val);
        [NativeDelegate("ml_ANN_MLP_setTermCriteria")] public static ml_ANN_MLP_setTermCriteriaDelegate ml_ANN_MLP_setTermCriteria;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_ANN_MLP_getBackpropWeightScaleDelegate(IntPtr obj);
        [NativeDelegate("ml_ANN_MLP_getBackpropWeightScale")] public static ml_ANN_MLP_getBackpropWeightScaleDelegate ml_ANN_MLP_getBackpropWeightScale;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_ANN_MLP_setBackpropWeightScaleDelegate(IntPtr obj, double val);
        [NativeDelegate("ml_ANN_MLP_setBackpropWeightScale")] public static ml_ANN_MLP_setBackpropWeightScaleDelegate ml_ANN_MLP_setBackpropWeightScale;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_ANN_MLP_getBackpropMomentumScaleDelegate(IntPtr obj);
        [NativeDelegate("ml_ANN_MLP_getBackpropMomentumScale")] public static ml_ANN_MLP_getBackpropMomentumScaleDelegate ml_ANN_MLP_getBackpropMomentumScale;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_ANN_MLP_setBackpropMomentumScaleDelegate(IntPtr obj, double val);
        [NativeDelegate("ml_ANN_MLP_setBackpropMomentumScale")] public static ml_ANN_MLP_setBackpropMomentumScaleDelegate ml_ANN_MLP_setBackpropMomentumScale;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_ANN_MLP_getRpropDW0Delegate(IntPtr obj);
        [NativeDelegate("ml_ANN_MLP_getRpropDW0")] public static ml_ANN_MLP_getRpropDW0Delegate ml_ANN_MLP_getRpropDW0;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_ANN_MLP_setRpropDW0Delegate(IntPtr obj, double val);
        [NativeDelegate("ml_ANN_MLP_setRpropDW0")] public static ml_ANN_MLP_setRpropDW0Delegate ml_ANN_MLP_setRpropDW0;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_ANN_MLP_getRpropDWPlusDelegate(IntPtr obj);
        [NativeDelegate("ml_ANN_MLP_getRpropDWPlus")] public static ml_ANN_MLP_getRpropDWPlusDelegate ml_ANN_MLP_getRpropDWPlus;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_ANN_MLP_setRpropDWPlusDelegate(IntPtr obj, double val);
        [NativeDelegate("ml_ANN_MLP_setRpropDWPlus")] public static ml_ANN_MLP_setRpropDWPlusDelegate ml_ANN_MLP_setRpropDWPlus;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_ANN_MLP_getRpropDWMinusDelegate(IntPtr obj);
        [NativeDelegate("ml_ANN_MLP_getRpropDWMinus")] public static ml_ANN_MLP_getRpropDWMinusDelegate ml_ANN_MLP_getRpropDWMinus;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_ANN_MLP_setRpropDWMinusDelegate(IntPtr obj, double val);
        [NativeDelegate("ml_ANN_MLP_setRpropDWMinus")] public static ml_ANN_MLP_setRpropDWMinusDelegate ml_ANN_MLP_setRpropDWMinus;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_ANN_MLP_getRpropDWMinDelegate(IntPtr obj);
        [NativeDelegate("ml_ANN_MLP_getRpropDWMin")] public static ml_ANN_MLP_getRpropDWMinDelegate ml_ANN_MLP_getRpropDWMin;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_ANN_MLP_setRpropDWMinDelegate(IntPtr obj, double val);
        [NativeDelegate("ml_ANN_MLP_setRpropDWMin")] public static ml_ANN_MLP_setRpropDWMinDelegate ml_ANN_MLP_setRpropDWMin;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_ANN_MLP_getRpropDWMaxDelegate(IntPtr obj);
        [NativeDelegate("ml_ANN_MLP_getRpropDWMax")] public static ml_ANN_MLP_getRpropDWMaxDelegate ml_ANN_MLP_getRpropDWMax;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_ANN_MLP_setRpropDWMaxDelegate(IntPtr obj, double val);
        [NativeDelegate("ml_ANN_MLP_setRpropDWMax")] public static ml_ANN_MLP_setRpropDWMaxDelegate ml_ANN_MLP_setRpropDWMax;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_ANN_MLP_getWeightsDelegate(IntPtr obj, int layerIdx);
        [NativeDelegate("ml_ANN_MLP_getWeights")] public static ml_ANN_MLP_getWeightsDelegate ml_ANN_MLP_getWeights;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_ANN_MLP_createDelegate();
        [NativeDelegate("ml_ANN_MLP_create")] public static ml_ANN_MLP_createDelegate ml_ANN_MLP_create;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_Ptr_ANN_MLP_deleteDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_ANN_MLP_delete")] public static ReleaseFunc ml_Ptr_ANN_MLP_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_Ptr_ANN_MLP_getDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_ANN_MLP_get")] public static ObjFunc ml_Ptr_ANN_MLP_get;
    }
}
