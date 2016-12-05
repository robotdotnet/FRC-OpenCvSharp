using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate RotatedRect video_CamShiftDelegate(
            IntPtr probImage, ref Rect window, TermCriteria criteria);
        [NativeDelegate("video_CamShift")] public static video_CamShiftDelegate video_CamShift;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int video_meanShiftDelegate(
            IntPtr probImage, ref Rect window, TermCriteria criteria);
        [NativeDelegate("video_meanShift")] public static video_meanShiftDelegate video_meanShift;
        
        // Kalman filter
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_KalmanFilter_new1Delegate();
        [NativeDelegate("video_KalmanFilter_new1")] public static video_KalmanFilter_new1Delegate video_KalmanFilter_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_KalmanFilter_new2Delegate(int dynamParams, int measureParams, int controlParams,
            int type);
        [NativeDelegate("video_KalmanFilter_new2")] public static video_KalmanFilter_new2Delegate video_KalmanFilter_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_KalmanFilter_initDelegate(IntPtr obj, int dynamParams, int measureParams,
            int controlParams, int type);
        [NativeDelegate("video_KalmanFilter_init")] public static video_KalmanFilter_initDelegate video_KalmanFilter_init;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_KalmanFilter_deleteDelegate(IntPtr obj);
        [NativeDelegate("video_KalmanFilter_delete")] public static video_KalmanFilter_deleteDelegate video_KalmanFilter_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_KalmanFilter_predictDelegate(IntPtr obj, IntPtr control);
        [NativeDelegate("video_KalmanFilter_predict")] public static video_KalmanFilter_predictDelegate video_KalmanFilter_predict;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_KalmanFilter_correctDelegate(IntPtr obj, IntPtr measurement);
        [NativeDelegate("video_KalmanFilter_correct")] public static video_KalmanFilter_correctDelegate video_KalmanFilter_correct;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_KalmanFilter_statePreDelegate(IntPtr obj);
        [NativeDelegate("video_KalmanFilter_statePre")] public static video_KalmanFilter_statePreDelegate video_KalmanFilter_statePre;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_KalmanFilter_statePostDelegate(IntPtr obj);
        [NativeDelegate("video_KalmanFilter_statePost")] public static video_KalmanFilter_statePostDelegate video_KalmanFilter_statePost;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_KalmanFilter_transitionMatrixDelegate(IntPtr obj);
        [NativeDelegate("video_KalmanFilter_transitionMatrix")] public static video_KalmanFilter_transitionMatrixDelegate video_KalmanFilter_transitionMatrix;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_KalmanFilter_controlMatrixDelegate(IntPtr obj);
        [NativeDelegate("video_KalmanFilter_controlMatrix")] public static video_KalmanFilter_controlMatrixDelegate video_KalmanFilter_controlMatrix;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_KalmanFilter_measurementMatrixDelegate(IntPtr obj);
        [NativeDelegate("video_KalmanFilter_measurementMatrix")] public static video_KalmanFilter_measurementMatrixDelegate video_KalmanFilter_measurementMatrix;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_KalmanFilter_processNoiseCovDelegate(IntPtr obj);
        [NativeDelegate("video_KalmanFilter_processNoiseCov")] public static video_KalmanFilter_processNoiseCovDelegate video_KalmanFilter_processNoiseCov;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_KalmanFilter_measurementNoiseCovDelegate(IntPtr obj);
        [NativeDelegate("video_KalmanFilter_measurementNoiseCov")] public static video_KalmanFilter_measurementNoiseCovDelegate video_KalmanFilter_measurementNoiseCov;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_KalmanFilter_errorCovPreDelegate(IntPtr obj);
        [NativeDelegate("video_KalmanFilter_errorCovPre")] public static video_KalmanFilter_errorCovPreDelegate video_KalmanFilter_errorCovPre;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_KalmanFilter_gainDelegate(IntPtr obj);
        [NativeDelegate("video_KalmanFilter_gain")] public static video_KalmanFilter_gainDelegate video_KalmanFilter_gain;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_KalmanFilter_errorCovPostDelegate(IntPtr obj);
        [NativeDelegate("video_KalmanFilter_errorCovPost")] public static video_KalmanFilter_errorCovPostDelegate video_KalmanFilter_errorCovPost;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int video_buildOpticalFlowPyramid1Delegate(
            IntPtr img, IntPtr pyramid,
            Size winSize, int maxLevel, int withDerivatives,
            int pyrBorder, int derivBorder, int tryReuseInputImage);
        [NativeDelegate("video_buildOpticalFlowPyramid1")] public static video_buildOpticalFlowPyramid1Delegate video_buildOpticalFlowPyramid1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int video_buildOpticalFlowPyramid2Delegate(
            IntPtr img, IntPtr pyramidVec,
            Size winSize, int maxLevel, int withDerivatives,
            int pyrBorder, int derivBorder, int tryReuseInputImage);
        [NativeDelegate("video_buildOpticalFlowPyramid2")] public static video_buildOpticalFlowPyramid2Delegate video_buildOpticalFlowPyramid2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_calcOpticalFlowPyrLK_InputArrayDelegate(
            IntPtr prevImg, IntPtr nextImg,
            IntPtr prevPts, IntPtr nextPts,
            IntPtr status, IntPtr err,
            Size winSize, int maxLevel, TermCriteria criteria,
            int flags, double minEigThreshold);
        [NativeDelegate("video_calcOpticalFlowPyrLK_InputArray")] public static video_calcOpticalFlowPyrLK_InputArrayDelegate video_calcOpticalFlowPyrLK_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_calcOpticalFlowPyrLK_vectorDelegate(
            IntPtr prevImg, IntPtr nextImg,
            Point2f[] prevPts, int prevPtsSize,
            IntPtr nextPts, IntPtr status, IntPtr err,
            Size winSize, int maxLevel, TermCriteria criteria,
            int flags, double minEigThreshold);
        [NativeDelegate("video_calcOpticalFlowPyrLK_vector")] public static video_calcOpticalFlowPyrLK_vectorDelegate video_calcOpticalFlowPyrLK_vector;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_calcOpticalFlowFarnebackDelegate(
            IntPtr prev, IntPtr next,
            IntPtr flow, double pyrScale, int levels, int winSize,
            int iterations, int polyN, double polySigma, int flags);
        [NativeDelegate("video_calcOpticalFlowFarneback")] public static video_calcOpticalFlowFarnebackDelegate video_calcOpticalFlowFarneback;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_estimateRigidTransformDelegate(
            IntPtr src, IntPtr dst, int fullAffine);
        [NativeDelegate("video_estimateRigidTransform")] public static video_estimateRigidTransformDelegate video_estimateRigidTransform;
        

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_DenseOpticalFlow_calcDelegate(
            IntPtr obj, IntPtr i0, IntPtr i1, IntPtr flow);
        [NativeDelegate("video_DenseOpticalFlow_calc")] public static video_DenseOpticalFlow_calcDelegate video_DenseOpticalFlow_calc;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_DenseOpticalFlow_collectGarbageDelegate(IntPtr obj);
        [NativeDelegate("video_DenseOpticalFlow_collectGarbage")] public static video_DenseOpticalFlow_collectGarbageDelegate video_DenseOpticalFlow_collectGarbage;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_DenseOpticalFlow_infoDelegate(IntPtr obj);
        [NativeDelegate("video_DenseOpticalFlow_info")] public static video_DenseOpticalFlow_infoDelegate video_DenseOpticalFlow_info;
        */
        // TODO
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_createOptFlow_DualTVL1Delegate();
        [NativeDelegate("video_createOptFlow_DualTVL1")] public static video_createOptFlow_DualTVL1Delegate video_createOptFlow_DualTVL1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr video_Ptr_DenseOpticalFlow_getDelegate(IntPtr ptr);
        [NativeDelegate("video_Ptr_DenseOpticalFlow_get")] public static ObjFunc video_Ptr_DenseOpticalFlow_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void video_Ptr_DenseOpticalFlow_deleteDelegate(IntPtr ptr);
        [NativeDelegate("video_Ptr_DenseOpticalFlow_delete")] public static ReleaseFunc video_Ptr_DenseOpticalFlow_delete;
    }
}
