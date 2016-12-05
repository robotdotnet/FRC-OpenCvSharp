using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        // GeneralizedHough

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHough_setTemplate1Delegate(
            IntPtr obj, IntPtr templ, Point templCenter);
        [NativeDelegate("imgproc_GeneralizedHough_setTemplate1")] public static imgproc_GeneralizedHough_setTemplate1Delegate imgproc_GeneralizedHough_setTemplate1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHough_setTemplate2Delegate(
            IntPtr obj, IntPtr edges, IntPtr dx, IntPtr dy, Point templCenter);
        [NativeDelegate("imgproc_GeneralizedHough_setTemplate2")] public static imgproc_GeneralizedHough_setTemplate2Delegate imgproc_GeneralizedHough_setTemplate2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHough_detect1Delegate(
            IntPtr obj, IntPtr image, IntPtr positions, IntPtr votes);
        [NativeDelegate("imgproc_GeneralizedHough_detect1")] public static imgproc_GeneralizedHough_detect1Delegate imgproc_GeneralizedHough_detect1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHough_detect2Delegate(
            IntPtr obj, IntPtr edges, IntPtr dx, IntPtr dy, IntPtr positions, IntPtr votes);
        [NativeDelegate("imgproc_GeneralizedHough_detect2")] public static imgproc_GeneralizedHough_detect2Delegate imgproc_GeneralizedHough_detect2;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHough_setCannyLowThreshDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_GeneralizedHough_setCannyLowThresh")] public static imgproc_GeneralizedHough_setCannyLowThreshDelegate imgproc_GeneralizedHough_setCannyLowThresh;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_GeneralizedHough_getCannyLowThreshDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHough_getCannyLowThresh")] public static imgproc_GeneralizedHough_getCannyLowThreshDelegate imgproc_GeneralizedHough_getCannyLowThresh;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHough_setCannyHighThreshDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_GeneralizedHough_setCannyHighThresh")] public static imgproc_GeneralizedHough_setCannyHighThreshDelegate imgproc_GeneralizedHough_setCannyHighThresh;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_GeneralizedHough_getCannyHighThreshDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHough_getCannyHighThresh")] public static imgproc_GeneralizedHough_getCannyHighThreshDelegate imgproc_GeneralizedHough_getCannyHighThresh;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHough_setMinDistDelegate(IntPtr obj, double val);
        [NativeDelegate("imgproc_GeneralizedHough_setMinDist")] public static imgproc_GeneralizedHough_setMinDistDelegate imgproc_GeneralizedHough_setMinDist;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_GeneralizedHough_getMinDistDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHough_getMinDist")] public static imgproc_GeneralizedHough_getMinDistDelegate imgproc_GeneralizedHough_getMinDist;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHough_setDpDelegate(IntPtr obj, double val);
        [NativeDelegate("imgproc_GeneralizedHough_setDp")] public static imgproc_GeneralizedHough_setDpDelegate imgproc_GeneralizedHough_setDp;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_GeneralizedHough_getDpDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHough_getDp")] public static imgproc_GeneralizedHough_getDpDelegate imgproc_GeneralizedHough_getDp;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHough_setMaxBufferSizeDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_GeneralizedHough_setMaxBufferSize")] public static imgproc_GeneralizedHough_setMaxBufferSizeDelegate imgproc_GeneralizedHough_setMaxBufferSize;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_GeneralizedHough_getMaxBufferSizeDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHough_getMaxBufferSize")] public static imgproc_GeneralizedHough_getMaxBufferSizeDelegate imgproc_GeneralizedHough_getMaxBufferSize;



        // GeneralizedHoughBallard

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_createGeneralizedHoughBallardDelegate();
        [NativeDelegate("imgproc_createGeneralizedHoughBallard")] public static imgproc_createGeneralizedHoughBallardDelegate imgproc_createGeneralizedHoughBallard;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_Ptr_GeneralizedHoughBallard_getDelegate(IntPtr obj);
        [NativeDelegate("imgproc_Ptr_GeneralizedHoughBallard_get")] public static ObjFunc imgproc_Ptr_GeneralizedHoughBallard_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_Ptr_GeneralizedHoughBallard_deleteDelegate(IntPtr obj);
        [NativeDelegate("imgproc_Ptr_GeneralizedHoughBallard_delete")] public static ReleaseFunc imgproc_Ptr_GeneralizedHoughBallard_delete;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHoughBallard_setLevelsDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_GeneralizedHoughBallard_setLevels")] public static imgproc_GeneralizedHoughBallard_setLevelsDelegate imgproc_GeneralizedHoughBallard_setLevels;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_GeneralizedHoughBallard_getLevelsDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHoughBallard_getLevels")] public static imgproc_GeneralizedHoughBallard_getLevelsDelegate imgproc_GeneralizedHoughBallard_getLevels;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHoughBallard_setVotesThresholdDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_GeneralizedHoughBallard_setVotesThreshold")] public static imgproc_GeneralizedHoughBallard_setVotesThresholdDelegate imgproc_GeneralizedHoughBallard_setVotesThreshold;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_GeneralizedHoughBallard_getVotesThresholdDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHoughBallard_getVotesThreshold")] public static imgproc_GeneralizedHoughBallard_getVotesThresholdDelegate imgproc_GeneralizedHoughBallard_getVotesThreshold;



        // GeneralizedHoughGuil

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_createGeneralizedHoughGuilDelegate();
        [NativeDelegate("imgproc_createGeneralizedHoughGuil")] public static imgproc_createGeneralizedHoughGuilDelegate imgproc_createGeneralizedHoughGuil;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_Ptr_GeneralizedHoughGuil_getDelegate(IntPtr obj);
        [NativeDelegate("imgproc_Ptr_GeneralizedHoughGuil_get")] public static ObjFunc imgproc_Ptr_GeneralizedHoughGuil_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_Ptr_GeneralizedHoughGuil_deleteDelegate(IntPtr obj);
        [NativeDelegate("imgproc_Ptr_GeneralizedHoughGuil_delete")] public static ReleaseFunc imgproc_Ptr_GeneralizedHoughGuil_delete;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHoughGuil_setXiDelegate(IntPtr obj, double val);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_setXi")] public static imgproc_GeneralizedHoughGuil_setXiDelegate imgproc_GeneralizedHoughGuil_setXi;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_GeneralizedHoughGuil_getXiDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_getXi")] public static imgproc_GeneralizedHoughGuil_getXiDelegate imgproc_GeneralizedHoughGuil_getXi;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHoughGuil_setLevelsDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_setLevels")] public static imgproc_GeneralizedHoughGuil_setLevelsDelegate imgproc_GeneralizedHoughGuil_setLevels;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_GeneralizedHoughGuil_getLevelsDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_getLevels")] public static imgproc_GeneralizedHoughGuil_getLevelsDelegate imgproc_GeneralizedHoughGuil_getLevels;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHoughGuil_setAngleEpsilonDelegate(IntPtr obj, double val);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_setAngleEpsilon")] public static imgproc_GeneralizedHoughGuil_setAngleEpsilonDelegate imgproc_GeneralizedHoughGuil_setAngleEpsilon;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_GeneralizedHoughGuil_getAngleEpsilonDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_getAngleEpsilon")] public static imgproc_GeneralizedHoughGuil_getAngleEpsilonDelegate imgproc_GeneralizedHoughGuil_getAngleEpsilon;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHoughGuil_setMinAngleDelegate(IntPtr obj, double val);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_setMinAngle")] public static imgproc_GeneralizedHoughGuil_setMinAngleDelegate imgproc_GeneralizedHoughGuil_setMinAngle;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_GeneralizedHoughGuil_getMinAngleDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_getMinAngle")] public static imgproc_GeneralizedHoughGuil_getMinAngleDelegate imgproc_GeneralizedHoughGuil_getMinAngle;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHoughGuil_setMaxAngleDelegate(IntPtr obj, double val);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_setMaxAngle")] public static imgproc_GeneralizedHoughGuil_setMaxAngleDelegate imgproc_GeneralizedHoughGuil_setMaxAngle;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_GeneralizedHoughGuil_getMaxAngleDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_getMaxAngle")] public static imgproc_GeneralizedHoughGuil_getMaxAngleDelegate imgproc_GeneralizedHoughGuil_getMaxAngle;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHoughGuil_setAngleStepDelegate(IntPtr obj, double val);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_setAngleStep")] public static imgproc_GeneralizedHoughGuil_setAngleStepDelegate imgproc_GeneralizedHoughGuil_setAngleStep;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_GeneralizedHoughGuil_getAngleStepDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_getAngleStep")] public static imgproc_GeneralizedHoughGuil_getAngleStepDelegate imgproc_GeneralizedHoughGuil_getAngleStep;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHoughGuil_setAngleThreshDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_setAngleThresh")] public static imgproc_GeneralizedHoughGuil_setAngleThreshDelegate imgproc_GeneralizedHoughGuil_setAngleThresh;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_GeneralizedHoughGuil_getAngleThreshDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_getAngleThresh")] public static imgproc_GeneralizedHoughGuil_getAngleThreshDelegate imgproc_GeneralizedHoughGuil_getAngleThresh;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHoughGuil_setMinScaleDelegate(IntPtr obj, double val);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_setMinScale")] public static imgproc_GeneralizedHoughGuil_setMinScaleDelegate imgproc_GeneralizedHoughGuil_setMinScale;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_GeneralizedHoughGuil_getMinScaleDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_getMinScale")] public static imgproc_GeneralizedHoughGuil_getMinScaleDelegate imgproc_GeneralizedHoughGuil_getMinScale;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHoughGuil_setMaxScaleDelegate(IntPtr obj, double val);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_setMaxScale")] public static imgproc_GeneralizedHoughGuil_setMaxScaleDelegate imgproc_GeneralizedHoughGuil_setMaxScale;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_GeneralizedHoughGuil_getMaxScaleDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_getMaxScale")] public static imgproc_GeneralizedHoughGuil_getMaxScaleDelegate imgproc_GeneralizedHoughGuil_getMaxScale;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHoughGuil_setScaleStepDelegate(IntPtr obj, double val);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_setScaleStep")] public static imgproc_GeneralizedHoughGuil_setScaleStepDelegate imgproc_GeneralizedHoughGuil_setScaleStep;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_GeneralizedHoughGuil_getScaleStepDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_getScaleStep")] public static imgproc_GeneralizedHoughGuil_getScaleStepDelegate imgproc_GeneralizedHoughGuil_getScaleStep;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHoughGuil_setScaleThreshDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_setScaleThresh")] public static imgproc_GeneralizedHoughGuil_setScaleThreshDelegate imgproc_GeneralizedHoughGuil_setScaleThresh;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_GeneralizedHoughGuil_getScaleThreshDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_getScaleThresh")] public static imgproc_GeneralizedHoughGuil_getScaleThreshDelegate imgproc_GeneralizedHoughGuil_getScaleThresh;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GeneralizedHoughGuil_setPosThreshDelegate(IntPtr obj, int val);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_setPosThresh")] public static imgproc_GeneralizedHoughGuil_setPosThreshDelegate imgproc_GeneralizedHoughGuil_setPosThresh;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_GeneralizedHoughGuil_getPosThreshDelegate(IntPtr obj);
        [NativeDelegate("imgproc_GeneralizedHoughGuil_getPosThresh")] public static imgproc_GeneralizedHoughGuil_getPosThreshDelegate imgproc_GeneralizedHoughGuil_getPosThresh;
    }
}
