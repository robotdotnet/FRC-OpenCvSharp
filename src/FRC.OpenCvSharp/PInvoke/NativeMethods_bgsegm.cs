using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {/*
        #region BackgroundSubtractorMOG

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr bgsegm_createBackgroundSubtractorMOGDelegate(
            int history, int nmixtures, double backgroundRatio, double noiseSigma);
        [NativeDelegate("bgsegm_createBackgroundSubtractorMOG")] public static bgsegm_createBackgroundSubtractorMOGDelegate bgsegm_createBackgroundSubtractorMOG;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_Ptr_BackgroundSubtractorMOG_deleteDelegate(IntPtr obj);
        [NativeDelegate("bgsegm_Ptr_BackgroundSubtractorMOG_delete")] public static ReleaseFunc bgsegm_Ptr_BackgroundSubtractorMOG_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr bgsegm_Ptr_BackgroundSubtractorMOG_getDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_Ptr_BackgroundSubtractorMOG_get")] public static ObjFunc bgsegm_Ptr_BackgroundSubtractorMOG_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int bgsegm_BackgroundSubtractorMOG_getHistoryDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_BackgroundSubtractorMOG_getHistory")] public static bgsegm_BackgroundSubtractorMOG_getHistoryDelegate bgsegm_BackgroundSubtractorMOG_getHistory;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_BackgroundSubtractorMOG_setHistoryDelegate(IntPtr ptr, int value);
        [NativeDelegate("bgsegm_BackgroundSubtractorMOG_setHistory")] public static bgsegm_BackgroundSubtractorMOG_setHistoryDelegate bgsegm_BackgroundSubtractorMOG_setHistory;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int bgsegm_BackgroundSubtractorMOG_getNMixturesDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_BackgroundSubtractorMOG_getNMixtures")] public static bgsegm_BackgroundSubtractorMOG_getNMixturesDelegate bgsegm_BackgroundSubtractorMOG_getNMixtures;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_BackgroundSubtractorMOG_setNMixturesDelegate(IntPtr ptr, int value);
        [NativeDelegate("bgsegm_BackgroundSubtractorMOG_setNMixtures")] public static bgsegm_BackgroundSubtractorMOG_setNMixturesDelegate bgsegm_BackgroundSubtractorMOG_setNMixtures;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double bgsegm_BackgroundSubtractorMOG_getBackgroundRatioDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_BackgroundSubtractorMOG_getBackgroundRatio")] public static bgsegm_BackgroundSubtractorMOG_getBackgroundRatioDelegate bgsegm_BackgroundSubtractorMOG_getBackgroundRatio;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_BackgroundSubtractorMOG_setBackgroundRatioDelegate(IntPtr ptr, double value);
        [NativeDelegate("bgsegm_BackgroundSubtractorMOG_setBackgroundRatio")] public static bgsegm_BackgroundSubtractorMOG_setBackgroundRatioDelegate bgsegm_BackgroundSubtractorMOG_setBackgroundRatio;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double bgsegm_BackgroundSubtractorMOG_getNoiseSigmaDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_BackgroundSubtractorMOG_getNoiseSigma")] public static bgsegm_BackgroundSubtractorMOG_getNoiseSigmaDelegate bgsegm_BackgroundSubtractorMOG_getNoiseSigma;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_BackgroundSubtractorMOG_setNoiseSigmaDelegate(IntPtr ptr, double value);
        [NativeDelegate("bgsegm_BackgroundSubtractorMOG_setNoiseSigma")] public static bgsegm_BackgroundSubtractorMOG_setNoiseSigmaDelegate bgsegm_BackgroundSubtractorMOG_setNoiseSigma;

        #endregion

        #region BackgroundSubtractorGMG

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr bgsegm_createBackgroundSubtractorGMGDelegate(
            int initializationFrames, double decisionThreshold);
        [NativeDelegate("bgsegm_createBackgroundSubtractorGMG")] public static bgsegm_createBackgroundSubtractorGMGDelegate bgsegm_createBackgroundSubtractorGMG;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_Ptr_BackgroundSubtractorGMG_deleteDelegate(IntPtr obj);
        [NativeDelegate("bgsegm_Ptr_BackgroundSubtractorGMG_delete")] public static ReleaseFunc bgsegm_Ptr_BackgroundSubtractorGMG_delete;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr bgsegm_Ptr_BackgroundSubtractorGMG_getDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_Ptr_BackgroundSubtractorGMG_get")] public static ObjFunc bgsegm_Ptr_BackgroundSubtractorGMG_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int bgsegm_BackgroundSubtractorGMG_getMaxFeaturesDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_getMaxFeatures")] public static bgsegm_BackgroundSubtractorGMG_getMaxFeaturesDelegate bgsegm_BackgroundSubtractorGMG_getMaxFeatures;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_BackgroundSubtractorGMG_setMaxFeaturesDelegate(IntPtr ptr, int value);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_setMaxFeatures")] public static bgsegm_BackgroundSubtractorGMG_setMaxFeaturesDelegate bgsegm_BackgroundSubtractorGMG_setMaxFeatures;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double bgsegm_BackgroundSubtractorGMG_getDefaultLearningRateDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_getDefaultLearningRate")] public static bgsegm_BackgroundSubtractorGMG_getDefaultLearningRateDelegate bgsegm_BackgroundSubtractorGMG_getDefaultLearningRate;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_BackgroundSubtractorGMG_setDefaultLearningRateDelegate(IntPtr ptr, double value);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_setDefaultLearningRate")] public static bgsegm_BackgroundSubtractorGMG_setDefaultLearningRateDelegate bgsegm_BackgroundSubtractorGMG_setDefaultLearningRate;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int bgsegm_BackgroundSubtractorGMG_getNumFramesDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_getNumFrames")] public static bgsegm_BackgroundSubtractorGMG_getNumFramesDelegate bgsegm_BackgroundSubtractorGMG_getNumFrames;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_BackgroundSubtractorGMG_setNumFramesDelegate(IntPtr ptr, int value);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_setNumFrames")] public static bgsegm_BackgroundSubtractorGMG_setNumFramesDelegate bgsegm_BackgroundSubtractorGMG_setNumFrames;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int bgsegm_BackgroundSubtractorGMG_getQuantizationLevelsDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_getQuantizationLevels")] public static bgsegm_BackgroundSubtractorGMG_getQuantizationLevelsDelegate bgsegm_BackgroundSubtractorGMG_getQuantizationLevels;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_BackgroundSubtractorGMG_setQuantizationLevelsDelegate(IntPtr ptr, int value);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_setQuantizationLevels")] public static bgsegm_BackgroundSubtractorGMG_setQuantizationLevelsDelegate bgsegm_BackgroundSubtractorGMG_setQuantizationLevels;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double bgsegm_BackgroundSubtractorGMG_getBackgroundPriorDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_getBackgroundPrior")] public static bgsegm_BackgroundSubtractorGMG_getBackgroundPriorDelegate bgsegm_BackgroundSubtractorGMG_getBackgroundPrior;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_BackgroundSubtractorGMG_setBackgroundPriorDelegate(IntPtr ptr, double value);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_setBackgroundPrior")] public static bgsegm_BackgroundSubtractorGMG_setBackgroundPriorDelegate bgsegm_BackgroundSubtractorGMG_setBackgroundPrior;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int bgsegm_BackgroundSubtractorGMG_getSmoothingRadiusDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_getSmoothingRadius")] public static bgsegm_BackgroundSubtractorGMG_getSmoothingRadiusDelegate bgsegm_BackgroundSubtractorGMG_getSmoothingRadius;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_BackgroundSubtractorGMG_setSmoothingRadiusDelegate(IntPtr ptr, int value);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_setSmoothingRadius")] public static bgsegm_BackgroundSubtractorGMG_setSmoothingRadiusDelegate bgsegm_BackgroundSubtractorGMG_setSmoothingRadius;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double bgsegm_BackgroundSubtractorGMG_getDecisionThresholdDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_getDecisionThreshold")] public static bgsegm_BackgroundSubtractorGMG_getDecisionThresholdDelegate bgsegm_BackgroundSubtractorGMG_getDecisionThreshold;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_BackgroundSubtractorGMG_setDecisionThresholdDelegate(IntPtr ptr, double value);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_setDecisionThreshold")] public static bgsegm_BackgroundSubtractorGMG_setDecisionThresholdDelegate bgsegm_BackgroundSubtractorGMG_setDecisionThreshold;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int bgsegm_BackgroundSubtractorGMG_getUpdateBackgroundModelDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_getUpdateBackgroundModel")] public static bgsegm_BackgroundSubtractorGMG_getUpdateBackgroundModelDelegate bgsegm_BackgroundSubtractorGMG_getUpdateBackgroundModel;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_BackgroundSubtractorGMG_setUpdateBackgroundModelDelegate(IntPtr ptr, int value);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_setUpdateBackgroundModel")] public static bgsegm_BackgroundSubtractorGMG_setUpdateBackgroundModelDelegate bgsegm_BackgroundSubtractorGMG_setUpdateBackgroundModel;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double bgsegm_BackgroundSubtractorGMG_getMinValDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_getMinVal")] public static bgsegm_BackgroundSubtractorGMG_getMinValDelegate bgsegm_BackgroundSubtractorGMG_getMinVal;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_BackgroundSubtractorGMG_setMinValDelegate(IntPtr ptr, double value);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_setMinVal")] public static bgsegm_BackgroundSubtractorGMG_setMinValDelegate bgsegm_BackgroundSubtractorGMG_setMinVal;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double bgsegm_BackgroundSubtractorGMG_getMaxValDelegate(IntPtr ptr);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_getMaxVal")] public static bgsegm_BackgroundSubtractorGMG_getMaxValDelegate bgsegm_BackgroundSubtractorGMG_getMaxVal;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void bgsegm_BackgroundSubtractorGMG_setMaxValDelegate(IntPtr ptr, double value);
        [NativeDelegate("bgsegm_BackgroundSubtractorGMG_setMaxVal")] public static bgsegm_BackgroundSubtractorGMG_setMaxValDelegate bgsegm_BackgroundSubtractorGMG_setMaxVal;

        #endregion
        */
        }
}
