using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        // ReSharper disable InconsistentNaming

        // DenseFeatureDetector
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_DenseFeatureDetector_newDelegate(
            float initFeatureScale, int featureScaleLevels, float featureScaleMul,
            int initXyStep, int initImgBound, int varyXyStepWithScale, int varyImgBoundWithScale);
        [NativeDelegate("features2d_DenseFeatureDetector_new")] public static features2d_DenseFeatureDetector_newDelegate features2d_DenseFeatureDetector_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_DenseFeatureDetector_deleteDelegate(IntPtr obj);
        [NativeDelegate("features2d_DenseFeatureDetector_delete")] public static features2d_DenseFeatureDetector_deleteDelegate features2d_DenseFeatureDetector_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_DenseFeatureDetector_infoDelegate(IntPtr obj);
        [NativeDelegate("features2d_DenseFeatureDetector_info")] public static features2d_DenseFeatureDetector_infoDelegate features2d_DenseFeatureDetector_info;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_Ptr_DenseFeatureDetector_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_DenseFeatureDetector_get")] public static features2d_Ptr_DenseFeatureDetector_getDelegate features2d_Ptr_DenseFeatureDetector_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_DenseFeatureDetector_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_DenseFeatureDetector_delete")] public static features2d_Ptr_DenseFeatureDetector_deleteDelegate features2d_Ptr_DenseFeatureDetector_delete;
        */
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_drawKeypointsDelegate(IntPtr image, KeyPoint[] keypoints, int keypointsLength,
            IntPtr outImage, Scalar color, int flags);
        [NativeDelegate("features2d_drawKeypoints")] public static features2d_drawKeypointsDelegate features2d_drawKeypoints;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_drawMatches1Delegate(IntPtr img1, KeyPoint[] keypoints1, int keypoints1Length,
            IntPtr img2, KeyPoint[] keypoints2, int keypoints2Length,
            DMatch[] matches1to2, int matches1to2Length, IntPtr outImg,
            Scalar matchColor, Scalar singlePointColor,
            byte[] matchesMask, int matchesMaskLength, int flags);
        [NativeDelegate("features2d_drawMatches1")] public static features2d_drawMatches1Delegate features2d_drawMatches1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_drawMatches2Delegate(IntPtr img1, KeyPoint[] keypoints1, int keypoints1Length,
            IntPtr img2, KeyPoint[] keypoints2, int keypoints2Length,
            IntPtr[] matches1to2, int matches1to2Size1, int[] matches1to2Size2,
            IntPtr outImg, Scalar matchColor, Scalar singlePointColor,
            IntPtr[] matchesMask, int matchesMaskSize1, int[] matchesMaskSize2, int flags);
        [NativeDelegate("features2d_drawMatches2")] public static features2d_drawMatches2Delegate features2d_drawMatches2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_evaluateFeatureDetectorDelegate(
            IntPtr img1, IntPtr img2, IntPtr H1to2,
            IntPtr keypoints1, IntPtr keypoints2,
            out float repeatability, out int correspCount);
        [NativeDelegate("features2d_evaluateFeatureDetector")] public static features2d_evaluateFeatureDetectorDelegate features2d_evaluateFeatureDetector;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_computeRecallPrecisionCurveDelegate(
            IntPtr[] matches1to2, int matches1to2Size1, int[] matches1to2Size2,
            IntPtr[] correctMatches1to2Mask, int correctMatches1to2MaskSize1, int[] correctMatches1to2MaskSize2,
            IntPtr recallPrecisionCurve);
        [NativeDelegate("features2d_computeRecallPrecisionCurve")] public static features2d_computeRecallPrecisionCurveDelegate features2d_computeRecallPrecisionCurve;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float features2d_getRecallDelegate(
            Point2f[] recallPrecisionCurve, int recallPrecisionCurveSize, float l_precision);
        [NativeDelegate("features2d_getRecall")] public static features2d_getRecallDelegate features2d_getRecall;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_getNearestPointDelegate(
            Point2f[] recallPrecisionCurve, int recallPrecisionCurveSize, float l_precision);
        [NativeDelegate("features2d_getNearestPoint")] public static features2d_getNearestPointDelegate features2d_getNearestPoint;
    }
}
