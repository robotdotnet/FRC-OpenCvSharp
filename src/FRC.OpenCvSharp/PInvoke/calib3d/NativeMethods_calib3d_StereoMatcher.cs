using OpenCvSharp.PInvoke.NativeLibraryUtilties;

using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    // ReSharper disable InconsistentNaming

    partial class NativeMethods
    {
        #region StereoMatcher

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoMatcher_computeDelegate(
            IntPtr obj, IntPtr left, IntPtr right, IntPtr disparity);
        [NativeDelegate("calib3d_StereoMatcher_compute")] public static calib3d_StereoMatcher_computeDelegate calib3d_StereoMatcher_compute;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr calib3d_Ptr_StereoMatcher_infoDelegate(IntPtr obj);
        [NativeDelegate("calib3d_Ptr_StereoMatcher_info")] public static calib3d_Ptr_StereoMatcher_infoDelegate calib3d_Ptr_StereoMatcher_info;
        */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoMatcher_getMinDisparityDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoMatcher_getMinDisparity")] public static calib3d_StereoMatcher_getMinDisparityDelegate calib3d_StereoMatcher_getMinDisparity;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoMatcher_setMinDisparityDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoMatcher_setMinDisparity")] public static calib3d_StereoMatcher_setMinDisparityDelegate calib3d_StereoMatcher_setMinDisparity;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoMatcher_getNumDisparitiesDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoMatcher_getNumDisparities")] public static calib3d_StereoMatcher_getNumDisparitiesDelegate calib3d_StereoMatcher_getNumDisparities;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoMatcher_setNumDisparitiesDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoMatcher_setNumDisparities")] public static calib3d_StereoMatcher_setNumDisparitiesDelegate calib3d_StereoMatcher_setNumDisparities;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoMatcher_getBlockSizeDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoMatcher_getBlockSize")] public static calib3d_StereoMatcher_getBlockSizeDelegate calib3d_StereoMatcher_getBlockSize;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoMatcher_setBlockSizeDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoMatcher_setBlockSize")] public static calib3d_StereoMatcher_setBlockSizeDelegate calib3d_StereoMatcher_setBlockSize;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoMatcher_getSpeckleWindowSizeDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoMatcher_getSpeckleWindowSize")] public static calib3d_StereoMatcher_getSpeckleWindowSizeDelegate calib3d_StereoMatcher_getSpeckleWindowSize;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoMatcher_setSpeckleWindowSizeDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoMatcher_setSpeckleWindowSize")] public static calib3d_StereoMatcher_setSpeckleWindowSizeDelegate calib3d_StereoMatcher_setSpeckleWindowSize;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoMatcher_getSpeckleRangeDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoMatcher_getSpeckleRange")] public static calib3d_StereoMatcher_getSpeckleRangeDelegate calib3d_StereoMatcher_getSpeckleRange;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoMatcher_setSpeckleRangeDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoMatcher_setSpeckleRange")] public static calib3d_StereoMatcher_setSpeckleRangeDelegate calib3d_StereoMatcher_setSpeckleRange;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoMatcher_getDisp12MaxDiffDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoMatcher_getDisp12MaxDiff")] public static calib3d_StereoMatcher_getDisp12MaxDiffDelegate calib3d_StereoMatcher_getDisp12MaxDiff;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoMatcher_setDisp12MaxDiffDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoMatcher_setDisp12MaxDiff")] public static calib3d_StereoMatcher_setDisp12MaxDiffDelegate calib3d_StereoMatcher_setDisp12MaxDiff;

        #endregion

        #region StereoBM

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_Ptr_StereoBM_deleteDelegate(IntPtr obj);
        [NativeDelegate("calib3d_Ptr_StereoBM_delete")] public static ReleaseFunc calib3d_Ptr_StereoBM_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr calib3d_StereoBM_createDelegate(int numDisparities, int blockSize);
        [NativeDelegate("calib3d_StereoBM_create")] public static calib3d_StereoBM_createDelegate calib3d_StereoBM_create;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr calib3d_Ptr_StereoBM_infoDelegate(IntPtr obj);
        [NativeDelegate("calib3d_Ptr_StereoBM_info")] public static calib3d_Ptr_StereoBM_infoDelegate calib3d_Ptr_StereoBM_info;
        */

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoBM_getPreFilterTypeDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoBM_getPreFilterType")] public static calib3d_StereoBM_getPreFilterTypeDelegate calib3d_StereoBM_getPreFilterType;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoBM_setPreFilterTypeDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoBM_setPreFilterType")] public static calib3d_StereoBM_setPreFilterTypeDelegate calib3d_StereoBM_setPreFilterType;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoBM_getPreFilterSizeDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoBM_getPreFilterSize")] public static calib3d_StereoBM_getPreFilterSizeDelegate calib3d_StereoBM_getPreFilterSize;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoBM_setPreFilterSizeDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoBM_setPreFilterSize")] public static calib3d_StereoBM_setPreFilterSizeDelegate calib3d_StereoBM_setPreFilterSize;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoBM_getPreFilterCapDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoBM_getPreFilterCap")] public static calib3d_StereoBM_getPreFilterCapDelegate calib3d_StereoBM_getPreFilterCap;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoBM_setPreFilterCapDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoBM_setPreFilterCap")] public static calib3d_StereoBM_setPreFilterCapDelegate calib3d_StereoBM_setPreFilterCap;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoBM_getTextureThresholdDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoBM_getTextureThreshold")] public static calib3d_StereoBM_getTextureThresholdDelegate calib3d_StereoBM_getTextureThreshold;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoBM_setTextureThresholdDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoBM_setTextureThreshold")] public static calib3d_StereoBM_setTextureThresholdDelegate calib3d_StereoBM_setTextureThreshold;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoBM_getUniquenessRatioDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoBM_getUniquenessRatio")] public static calib3d_StereoBM_getUniquenessRatioDelegate calib3d_StereoBM_getUniquenessRatio;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoBM_setUniquenessRatioDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoBM_setUniquenessRatio")] public static calib3d_StereoBM_setUniquenessRatioDelegate calib3d_StereoBM_setUniquenessRatio;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoBM_getSmallerBlockSizeDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoBM_getSmallerBlockSize")] public static calib3d_StereoBM_getSmallerBlockSizeDelegate calib3d_StereoBM_getSmallerBlockSize;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoBM_setSmallerBlockSizeDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoBM_setSmallerBlockSize")] public static calib3d_StereoBM_setSmallerBlockSizeDelegate calib3d_StereoBM_setSmallerBlockSize;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Rect calib3d_StereoBM_getROI1Delegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoBM_getROI1")] public static calib3d_StereoBM_getROI1Delegate calib3d_StereoBM_getROI1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoBM_setROI1Delegate(IntPtr obj, Rect value);
        [NativeDelegate("calib3d_StereoBM_setROI1")] public static calib3d_StereoBM_setROI1Delegate calib3d_StereoBM_setROI1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Rect calib3d_StereoBM_getROI2Delegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoBM_getROI2")] public static calib3d_StereoBM_getROI2Delegate calib3d_StereoBM_getROI2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoBM_setROI2Delegate(IntPtr obj, Rect value);
        [NativeDelegate("calib3d_StereoBM_setROI2")] public static calib3d_StereoBM_setROI2Delegate calib3d_StereoBM_setROI2;

        #endregion

        #region StereoSGBM

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_Ptr_StereoSGBM_deleteDelegate(IntPtr obj);
        [NativeDelegate("calib3d_Ptr_StereoSGBM_delete")] public static ReleaseFunc calib3d_Ptr_StereoSGBM_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr calib3d_StereoSGBM_createDelegate(
            int minDisparity, int numDisparities, int blockSize,
            int P1, int P2, int disp12MaxDiff,
            int preFilterCap, int uniquenessRatio,
            int speckleWindowSize, int speckleRange, int mode);
        [NativeDelegate("calib3d_StereoSGBM_create")] public static calib3d_StereoSGBM_createDelegate calib3d_StereoSGBM_create;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr calib3d_Ptr_StereoSGBM_infoDelegate(IntPtr obj);
        [NativeDelegate("calib3d_Ptr_StereoSGBM_info")] public static calib3d_Ptr_StereoSGBM_infoDelegate calib3d_Ptr_StereoSGBM_info;
        */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoSGBM_getPreFilterCapDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoSGBM_getPreFilterCap")] public static calib3d_StereoSGBM_getPreFilterCapDelegate calib3d_StereoSGBM_getPreFilterCap;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoSGBM_setPreFilterCapDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoSGBM_setPreFilterCap")] public static calib3d_StereoSGBM_setPreFilterCapDelegate calib3d_StereoSGBM_setPreFilterCap;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoSGBM_getUniquenessRatioDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoSGBM_getUniquenessRatio")] public static calib3d_StereoSGBM_getUniquenessRatioDelegate calib3d_StereoSGBM_getUniquenessRatio;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoSGBM_setUniquenessRatioDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoSGBM_setUniquenessRatio")] public static calib3d_StereoSGBM_setUniquenessRatioDelegate calib3d_StereoSGBM_setUniquenessRatio;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoSGBM_getP1Delegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoSGBM_getP1")] public static calib3d_StereoSGBM_getP1Delegate calib3d_StereoSGBM_getP1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoSGBM_setP1Delegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoSGBM_setP1")] public static calib3d_StereoSGBM_setP1Delegate calib3d_StereoSGBM_setP1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoSGBM_getP2Delegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoSGBM_getP2")] public static calib3d_StereoSGBM_getP2Delegate calib3d_StereoSGBM_getP2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoSGBM_setP2Delegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoSGBM_setP2")] public static calib3d_StereoSGBM_setP2Delegate calib3d_StereoSGBM_setP2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_StereoSGBM_getModeDelegate(IntPtr obj);
        [NativeDelegate("calib3d_StereoSGBM_getMode")] public static calib3d_StereoSGBM_getModeDelegate calib3d_StereoSGBM_getMode;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_StereoSGBM_setModeDelegate(IntPtr obj, int value);
        [NativeDelegate("calib3d_StereoSGBM_setMode")] public static calib3d_StereoSGBM_setModeDelegate calib3d_StereoSGBM_setMode;

        #endregion
    }
}
