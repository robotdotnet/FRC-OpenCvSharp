using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void optflow_motempl_updateMotionHistoryDelegate(
            IntPtr silhouette, IntPtr mhi,
            double timestamp, double duration);
        [NativeDelegate("optflow_motempl_updateMotionHistory")] public static optflow_motempl_updateMotionHistoryDelegate optflow_motempl_updateMotionHistory;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void optflow_motempl_calcMotionGradientDelegate(
            IntPtr mhi, IntPtr mask, IntPtr orientation,
            double delta1, double delta2, int apertureSize);
        [NativeDelegate("optflow_motempl_calcMotionGradient")] public static optflow_motempl_calcMotionGradientDelegate optflow_motempl_calcMotionGradient;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double optflow_motempl_calcGlobalOrientationDelegate(
            IntPtr orientation, IntPtr mask,
            IntPtr mhi, double timestamp, double duration);
        [NativeDelegate("optflow_motempl_calcGlobalOrientation")] public static optflow_motempl_calcGlobalOrientationDelegate optflow_motempl_calcGlobalOrientation;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void optflow_motempl_segmentMotionDelegate(
            IntPtr mhi, IntPtr segmask, IntPtr boundingRects,
            double timestamp, double segThresh);
        [NativeDelegate("optflow_motempl_segmentMotion")] public static optflow_motempl_segmentMotionDelegate optflow_motempl_segmentMotion;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void optflow_calcOpticalFlowSF1Delegate(
            IntPtr from,
            IntPtr to,
            IntPtr flow,
            int layers,
            int averagingBlockSize,
            int maxFlow);
        [NativeDelegate("optflow_calcOpticalFlowSF1")] public static optflow_calcOpticalFlowSF1Delegate optflow_calcOpticalFlowSF1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void optflow_calcOpticalFlowSF2Delegate(
            IntPtr from,
            IntPtr to,
            IntPtr flow,
            int layers,
            int averagingBlockSize,
            int maxFlow,
            double sigmaDist,
            double sigmaColor,
            int postprocessWindow,
            double sigmaDistFix,
            double sigmaColorFix,
            double occThr,
            int upscaleAveragingRadius,
            double upscaleSigmaDist,
            double upscaleSigmaColor,
            double speedUpThr);
        [NativeDelegate("optflow_calcOpticalFlowSF2")] public static optflow_calcOpticalFlowSF2Delegate optflow_calcOpticalFlowSF2;
        */
    }
}
