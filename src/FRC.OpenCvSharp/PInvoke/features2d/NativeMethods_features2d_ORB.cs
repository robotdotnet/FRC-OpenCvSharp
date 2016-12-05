using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        // ReSharper disable InconsistentNaming

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_ORB_createDelegate(int nFeatures, float scaleFactor, int nlevels,
            int edgeThreshold,
            int firstLevel, int wtaK, int scoreType, int patchSize);
        [NativeDelegate("features2d_ORB_create")] public static features2d_ORB_createDelegate features2d_ORB_create;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_ORB_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_ORB_delete")] public static ReleaseFunc features2d_Ptr_ORB_delete;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_ORB_infoDelegate(IntPtr obj);
        [NativeDelegate("features2d_ORB_info")] public static features2d_ORB_infoDelegate features2d_ORB_info;
        */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_Ptr_ORB_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_ORB_get")] public static ObjFunc features2d_Ptr_ORB_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_ORB_setMaxFeaturesDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_ORB_setMaxFeatures")] public static features2d_ORB_setMaxFeaturesDelegate features2d_ORB_setMaxFeatures;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_ORB_getMaxFeaturesDelegate(IntPtr obj);
        [NativeDelegate("features2d_ORB_getMaxFeatures")] public static features2d_ORB_getMaxFeaturesDelegate features2d_ORB_getMaxFeatures;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_ORB_setScaleFactorDelegate(IntPtr obj, double val);
        [NativeDelegate("features2d_ORB_setScaleFactor")] public static features2d_ORB_setScaleFactorDelegate features2d_ORB_setScaleFactor;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double features2d_ORB_getScaleFactorDelegate(IntPtr obj);
        [NativeDelegate("features2d_ORB_getScaleFactor")] public static features2d_ORB_getScaleFactorDelegate features2d_ORB_getScaleFactor;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_ORB_setNLevelsDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_ORB_setNLevels")] public static features2d_ORB_setNLevelsDelegate features2d_ORB_setNLevels;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_ORB_getNLevelsDelegate(IntPtr obj);
        [NativeDelegate("features2d_ORB_getNLevels")] public static features2d_ORB_getNLevelsDelegate features2d_ORB_getNLevels;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_ORB_setEdgeThresholdDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_ORB_setEdgeThreshold")] public static features2d_ORB_setEdgeThresholdDelegate features2d_ORB_setEdgeThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_ORB_getEdgeThresholdDelegate(IntPtr obj);
        [NativeDelegate("features2d_ORB_getEdgeThreshold")] public static features2d_ORB_getEdgeThresholdDelegate features2d_ORB_getEdgeThreshold;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_ORB_setFirstLevelDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_ORB_setFirstLevel")] public static features2d_ORB_setFirstLevelDelegate features2d_ORB_setFirstLevel;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_ORB_getFirstLevelDelegate(IntPtr obj);
        [NativeDelegate("features2d_ORB_getFirstLevel")] public static features2d_ORB_getFirstLevelDelegate features2d_ORB_getFirstLevel;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_ORB_setWTA_KDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_ORB_setWTA_K")] public static features2d_ORB_setWTA_KDelegate features2d_ORB_setWTA_K;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_ORB_getWTA_KDelegate(IntPtr obj);
        [NativeDelegate("features2d_ORB_getWTA_K")] public static features2d_ORB_getWTA_KDelegate features2d_ORB_getWTA_K;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_ORB_setScoreTypeDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_ORB_setScoreType")] public static features2d_ORB_setScoreTypeDelegate features2d_ORB_setScoreType;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_ORB_getScoreTypeDelegate(IntPtr obj);
        [NativeDelegate("features2d_ORB_getScoreType")] public static features2d_ORB_getScoreTypeDelegate features2d_ORB_getScoreType;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_ORB_setPatchSizeDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_ORB_setPatchSize")] public static features2d_ORB_setPatchSizeDelegate features2d_ORB_setPatchSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_ORB_getPatchSizeDelegate(IntPtr obj);
        [NativeDelegate("features2d_ORB_getPatchSize")] public static features2d_ORB_getPatchSizeDelegate features2d_ORB_getPatchSize;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_ORB_setFastThresholdDelegate(IntPtr obj, int val);
        [NativeDelegate("features2d_ORB_setFastThreshold")] public static features2d_ORB_setFastThresholdDelegate features2d_ORB_setFastThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_ORB_getFastThresholdDelegate(IntPtr obj);
        [NativeDelegate("features2d_ORB_getFastThreshold")] public static features2d_ORB_getFastThresholdDelegate features2d_ORB_getFastThreshold;
    }
}
