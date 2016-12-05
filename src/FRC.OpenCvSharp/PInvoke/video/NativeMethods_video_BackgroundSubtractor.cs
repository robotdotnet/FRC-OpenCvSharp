using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        #region BackgroundSubtractor

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractor_getBackgroundImageDelegate(IntPtr self, IntPtr backgroundImage);
        [NativeDelegate("video_BackgroundSubtractor_getBackgroundImage")] public static video_BackgroundSubtractor_getBackgroundImageDelegate video_BackgroundSubtractor_getBackgroundImage;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractor_applyDelegate(IntPtr self, IntPtr image, IntPtr fgmask, double learningRate);
        [NativeDelegate("video_BackgroundSubtractor_apply")] public static video_BackgroundSubtractor_applyDelegate video_BackgroundSubtractor_apply;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_Ptr_BackgroundSubtractor_deleteDelegate(IntPtr ptr);
        [NativeDelegate("video_Ptr_BackgroundSubtractor_delete")] public static ReleaseFunc video_Ptr_BackgroundSubtractor_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_Ptr_BackgroundSubtractor_getDelegate(IntPtr ptr);
        [NativeDelegate("video_Ptr_BackgroundSubtractor_get")] public static ObjFunc video_Ptr_BackgroundSubtractor_get;

        #endregion

        #region BackgroundSubtractorMOG2
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_createBackgroundSubtractorMOG2Delegate(
            int history, double varThreshold, int detectShadows);
        [NativeDelegate("video_createBackgroundSubtractorMOG2")] public static video_createBackgroundSubtractorMOG2Delegate video_createBackgroundSubtractorMOG2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_Ptr_BackgroundSubtractorMOG2_deleteDelegate(IntPtr ptr);
        [NativeDelegate("video_Ptr_BackgroundSubtractorMOG2_delete")] public static ReleaseFunc video_Ptr_BackgroundSubtractorMOG2_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_Ptr_BackgroundSubtractorMOG2_getDelegate(IntPtr ptr);
        [NativeDelegate("video_Ptr_BackgroundSubtractorMOG2_get")] public static ObjFunc video_Ptr_BackgroundSubtractorMOG2_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int video_BackgroundSubtractorMOG2_getHistoryDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorMOG2_getHistory")] public static video_BackgroundSubtractorMOG2_getHistoryDelegate video_BackgroundSubtractorMOG2_getHistory;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorMOG2_setHistoryDelegate(IntPtr ptr, int value);
        [NativeDelegate("video_BackgroundSubtractorMOG2_setHistory")] public static video_BackgroundSubtractorMOG2_setHistoryDelegate video_BackgroundSubtractorMOG2_setHistory;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int video_BackgroundSubtractorMOG2_getNMixturesDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorMOG2_getNMixtures")] public static video_BackgroundSubtractorMOG2_getNMixturesDelegate video_BackgroundSubtractorMOG2_getNMixtures;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorMOG2_setNMixturesDelegate(IntPtr ptr, int value);
        [NativeDelegate("video_BackgroundSubtractorMOG2_setNMixtures")] public static video_BackgroundSubtractorMOG2_setNMixturesDelegate video_BackgroundSubtractorMOG2_setNMixtures;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double video_BackgroundSubtractorMOG2_getBackgroundRatioDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorMOG2_getBackgroundRatio")] public static video_BackgroundSubtractorMOG2_getBackgroundRatioDelegate video_BackgroundSubtractorMOG2_getBackgroundRatio;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorMOG2_setBackgroundRatioDelegate(IntPtr ptr, double value);
        [NativeDelegate("video_BackgroundSubtractorMOG2_setBackgroundRatio")] public static video_BackgroundSubtractorMOG2_setBackgroundRatioDelegate video_BackgroundSubtractorMOG2_setBackgroundRatio;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double video_BackgroundSubtractorMOG2_getVarThresholdDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorMOG2_getVarThreshold")] public static video_BackgroundSubtractorMOG2_getVarThresholdDelegate video_BackgroundSubtractorMOG2_getVarThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorMOG2_setVarThresholdDelegate(IntPtr ptr, double value);
        [NativeDelegate("video_BackgroundSubtractorMOG2_setVarThreshold")] public static video_BackgroundSubtractorMOG2_setVarThresholdDelegate video_BackgroundSubtractorMOG2_setVarThreshold;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double video_BackgroundSubtractorMOG2_getVarThresholdGenDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorMOG2_getVarThresholdGen")] public static video_BackgroundSubtractorMOG2_getVarThresholdGenDelegate video_BackgroundSubtractorMOG2_getVarThresholdGen;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorMOG2_setVarThresholdGenDelegate(IntPtr ptr, double value);
        [NativeDelegate("video_BackgroundSubtractorMOG2_setVarThresholdGen")] public static video_BackgroundSubtractorMOG2_setVarThresholdGenDelegate video_BackgroundSubtractorMOG2_setVarThresholdGen;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double video_BackgroundSubtractorMOG2_getVarInitDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorMOG2_getVarInit")] public static video_BackgroundSubtractorMOG2_getVarInitDelegate video_BackgroundSubtractorMOG2_getVarInit;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorMOG2_setVarInitDelegate(IntPtr ptr, double value);
        [NativeDelegate("video_BackgroundSubtractorMOG2_setVarInit")] public static video_BackgroundSubtractorMOG2_setVarInitDelegate video_BackgroundSubtractorMOG2_setVarInit;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double video_BackgroundSubtractorMOG2_getVarMinDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorMOG2_getVarMin")] public static video_BackgroundSubtractorMOG2_getVarMinDelegate video_BackgroundSubtractorMOG2_getVarMin;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorMOG2_setVarMinDelegate(IntPtr ptr, double value);
        [NativeDelegate("video_BackgroundSubtractorMOG2_setVarMin")] public static video_BackgroundSubtractorMOG2_setVarMinDelegate video_BackgroundSubtractorMOG2_setVarMin;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double video_BackgroundSubtractorMOG2_getVarMaxDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorMOG2_getVarMax")] public static video_BackgroundSubtractorMOG2_getVarMaxDelegate video_BackgroundSubtractorMOG2_getVarMax;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorMOG2_setVarMaxDelegate(IntPtr ptr, double value);
        [NativeDelegate("video_BackgroundSubtractorMOG2_setVarMax")] public static video_BackgroundSubtractorMOG2_setVarMaxDelegate video_BackgroundSubtractorMOG2_setVarMax;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double video_BackgroundSubtractorMOG2_getComplexityReductionThresholdDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorMOG2_getComplexityReductionThreshold")] public static video_BackgroundSubtractorMOG2_getComplexityReductionThresholdDelegate video_BackgroundSubtractorMOG2_getComplexityReductionThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorMOG2_setComplexityReductionThresholdDelegate(IntPtr ptr, double value);
        [NativeDelegate("video_BackgroundSubtractorMOG2_setComplexityReductionThreshold")] public static video_BackgroundSubtractorMOG2_setComplexityReductionThresholdDelegate video_BackgroundSubtractorMOG2_setComplexityReductionThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int video_BackgroundSubtractorMOG2_getDetectShadowsDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorMOG2_getDetectShadows")] public static video_BackgroundSubtractorMOG2_getDetectShadowsDelegate video_BackgroundSubtractorMOG2_getDetectShadows;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorMOG2_setDetectShadowsDelegate(IntPtr ptr, int value);
        [NativeDelegate("video_BackgroundSubtractorMOG2_setDetectShadows")] public static video_BackgroundSubtractorMOG2_setDetectShadowsDelegate video_BackgroundSubtractorMOG2_setDetectShadows;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int video_BackgroundSubtractorMOG2_getShadowValueDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorMOG2_getShadowValue")] public static video_BackgroundSubtractorMOG2_getShadowValueDelegate video_BackgroundSubtractorMOG2_getShadowValue;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorMOG2_setShadowValueDelegate(IntPtr ptr, int value);
        [NativeDelegate("video_BackgroundSubtractorMOG2_setShadowValue")] public static video_BackgroundSubtractorMOG2_setShadowValueDelegate video_BackgroundSubtractorMOG2_setShadowValue;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double video_BackgroundSubtractorMOG2_getShadowThresholdDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorMOG2_getShadowThreshold")] public static video_BackgroundSubtractorMOG2_getShadowThresholdDelegate video_BackgroundSubtractorMOG2_getShadowThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorMOG2_setShadowThresholdDelegate(IntPtr ptr, double value);
        [NativeDelegate("video_BackgroundSubtractorMOG2_setShadowThreshold")] public static video_BackgroundSubtractorMOG2_setShadowThresholdDelegate video_BackgroundSubtractorMOG2_setShadowThreshold;

        #endregion

        #region BackgroundSubtractorKNN

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_createBackgroundSubtractorKNNDelegate(
            int history, double dist2Threshold, int detectShadows);
        [NativeDelegate("video_createBackgroundSubtractorKNN")] public static video_createBackgroundSubtractorKNNDelegate video_createBackgroundSubtractorKNN;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_Ptr_BackgroundSubtractorKNN_deleteDelegate(IntPtr obj);
        [NativeDelegate("video_Ptr_BackgroundSubtractorKNN_delete")] public static ReleaseFunc video_Ptr_BackgroundSubtractorKNN_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_Ptr_BackgroundSubtractorKNN_getDelegate(IntPtr ptr);
        [NativeDelegate("video_Ptr_BackgroundSubtractorKNN_get")] public static ObjFunc video_Ptr_BackgroundSubtractorKNN_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int video_BackgroundSubtractorKNN_getHistoryDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorKNN_getHistory")] public static video_BackgroundSubtractorKNN_getHistoryDelegate video_BackgroundSubtractorKNN_getHistory;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorKNN_setHistoryDelegate(IntPtr ptr, int value);
        [NativeDelegate("video_BackgroundSubtractorKNN_setHistory")] public static video_BackgroundSubtractorKNN_setHistoryDelegate video_BackgroundSubtractorKNN_setHistory;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int video_BackgroundSubtractorKNN_getNSamplesDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorKNN_getNSamples")] public static video_BackgroundSubtractorKNN_getNSamplesDelegate video_BackgroundSubtractorKNN_getNSamples;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorKNN_setNSamplesDelegate(IntPtr ptr, int value);
        [NativeDelegate("video_BackgroundSubtractorKNN_setNSamples")] public static video_BackgroundSubtractorKNN_setNSamplesDelegate video_BackgroundSubtractorKNN_setNSamples;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int video_BackgroundSubtractorKNN_getDist2ThresholdDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorKNN_getDist2Threshold")] public static video_BackgroundSubtractorKNN_getDist2ThresholdDelegate video_BackgroundSubtractorKNN_getDist2Threshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorKNN_setDist2ThresholdDelegate(IntPtr ptr, double value);
        [NativeDelegate("video_BackgroundSubtractorKNN_setDist2Threshold")] public static video_BackgroundSubtractorKNN_setDist2ThresholdDelegate video_BackgroundSubtractorKNN_setDist2Threshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int video_BackgroundSubtractorKNN_getkNNSamplesDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorKNN_getkNNSamples")] public static video_BackgroundSubtractorKNN_getkNNSamplesDelegate video_BackgroundSubtractorKNN_getkNNSamples;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorKNN_setkNNSamplesDelegate(IntPtr ptr, int value);
        [NativeDelegate("video_BackgroundSubtractorKNN_setkNNSamples")] public static video_BackgroundSubtractorKNN_setkNNSamplesDelegate video_BackgroundSubtractorKNN_setkNNSamples;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int video_BackgroundSubtractorKNN_getDetectShadowsDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorKNN_getDetectShadows")] public static video_BackgroundSubtractorKNN_getDetectShadowsDelegate video_BackgroundSubtractorKNN_getDetectShadows;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorKNN_setDetectShadowsDelegate(IntPtr ptr, int value);
        [NativeDelegate("video_BackgroundSubtractorKNN_setDetectShadows")] public static video_BackgroundSubtractorKNN_setDetectShadowsDelegate video_BackgroundSubtractorKNN_setDetectShadows;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int video_BackgroundSubtractorKNN_getShadowValueDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorKNN_getShadowValue")] public static video_BackgroundSubtractorKNN_getShadowValueDelegate video_BackgroundSubtractorKNN_getShadowValue;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorKNN_setShadowValueDelegate(IntPtr ptr, int value);
        [NativeDelegate("video_BackgroundSubtractorKNN_setShadowValue")] public static video_BackgroundSubtractorKNN_setShadowValueDelegate video_BackgroundSubtractorKNN_setShadowValue;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double video_BackgroundSubtractorKNN_getShadowThresholdDelegate(IntPtr ptr);
        [NativeDelegate("video_BackgroundSubtractorKNN_getShadowThreshold")] public static video_BackgroundSubtractorKNN_getShadowThresholdDelegate video_BackgroundSubtractorKNN_getShadowThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_BackgroundSubtractorKNN_setShadowThresholdDelegate(IntPtr ptr, double value);
        [NativeDelegate("video_BackgroundSubtractorKNN_setShadowThreshold")] public static video_BackgroundSubtractorKNN_setShadowThresholdDelegate video_BackgroundSubtractorKNN_setShadowThreshold;

        #endregion
    }
}
