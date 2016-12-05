using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr stitching_createStitcherDelegate(int try_use_cpu);
        [NativeDelegate("stitching_createStitcher")] public static stitching_createStitcherDelegate stitching_createStitcher;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void stitching_Ptr_Stitcher_deleteDelegate(IntPtr obj);
        [NativeDelegate("stitching_Ptr_Stitcher_delete")] public static ReleaseFunc stitching_Ptr_Stitcher_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr stitching_Ptr_Stitcher_getDelegate(IntPtr obj);
        [NativeDelegate("stitching_Ptr_Stitcher_get")] public static ObjFunc stitching_Ptr_Stitcher_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double stitching_Stitcher_registrationResolDelegate(IntPtr obj);
        [NativeDelegate("stitching_Stitcher_registrationResol")] public static stitching_Stitcher_registrationResolDelegate stitching_Stitcher_registrationResol;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void stitching_Stitcher_setRegistrationResolDelegate(IntPtr obj, double resolMpx);
        [NativeDelegate("stitching_Stitcher_setRegistrationResol")] public static stitching_Stitcher_setRegistrationResolDelegate stitching_Stitcher_setRegistrationResol;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double stitching_Stitcher_seamEstimationResolDelegate(IntPtr obj);
        [NativeDelegate("stitching_Stitcher_seamEstimationResol")] public static stitching_Stitcher_seamEstimationResolDelegate stitching_Stitcher_seamEstimationResol;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void stitching_Stitcher_setSeamEstimationResolDelegate(IntPtr obj, double resolMpx);
        [NativeDelegate("stitching_Stitcher_setSeamEstimationResol")] public static stitching_Stitcher_setSeamEstimationResolDelegate stitching_Stitcher_setSeamEstimationResol;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double stitching_Stitcher_compositingResolDelegate(IntPtr obj);
        [NativeDelegate("stitching_Stitcher_compositingResol")] public static stitching_Stitcher_compositingResolDelegate stitching_Stitcher_compositingResol;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void stitching_Stitcher_setCompositingResolDelegate(IntPtr obj, double resolMpx);
        [NativeDelegate("stitching_Stitcher_setCompositingResol")] public static stitching_Stitcher_setCompositingResolDelegate stitching_Stitcher_setCompositingResol;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double stitching_Stitcher_panoConfidenceThreshDelegate(IntPtr obj);
        [NativeDelegate("stitching_Stitcher_panoConfidenceThresh")] public static stitching_Stitcher_panoConfidenceThreshDelegate stitching_Stitcher_panoConfidenceThresh;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void stitching_Stitcher_setPanoConfidenceThreshDelegate(IntPtr obj, double confThresh);
        [NativeDelegate("stitching_Stitcher_setPanoConfidenceThresh")] public static stitching_Stitcher_setPanoConfidenceThreshDelegate stitching_Stitcher_setPanoConfidenceThresh;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int stitching_Stitcher_waveCorrectionDelegate(IntPtr obj);
        [NativeDelegate("stitching_Stitcher_waveCorrection")] public static stitching_Stitcher_waveCorrectionDelegate stitching_Stitcher_waveCorrection;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void stitching_Stitcher_setWaveCorrectionDelegate(IntPtr obj, int flag);
        [NativeDelegate("stitching_Stitcher_setWaveCorrection")] public static stitching_Stitcher_setWaveCorrectionDelegate stitching_Stitcher_setWaveCorrection;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int stitching_Stitcher_waveCorrectKindDelegate(IntPtr obj);
        [NativeDelegate("stitching_Stitcher_waveCorrectKind")] public static stitching_Stitcher_waveCorrectKindDelegate stitching_Stitcher_waveCorrectKind;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void stitching_Stitcher_setWaveCorrectKindDelegate(IntPtr obj, int kind);
        [NativeDelegate("stitching_Stitcher_setWaveCorrectKind")] public static stitching_Stitcher_setWaveCorrectKindDelegate stitching_Stitcher_setWaveCorrectKind;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int stitching_Stitcher_estimateTransform_InputArray1Delegate(
            IntPtr obj, IntPtr images);
        [NativeDelegate("stitching_Stitcher_estimateTransform_InputArray1")] public static stitching_Stitcher_estimateTransform_InputArray1Delegate stitching_Stitcher_estimateTransform_InputArray1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int stitching_Stitcher_estimateTransform_InputArray2Delegate(
            IntPtr obj, IntPtr images,
            IntPtr[] rois, int roisSize1, int[] roisSize2);
        [NativeDelegate("stitching_Stitcher_estimateTransform_InputArray2")] public static stitching_Stitcher_estimateTransform_InputArray2Delegate stitching_Stitcher_estimateTransform_InputArray2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int stitching_Stitcher_estimateTransform_MatArray1Delegate(
            IntPtr obj, IntPtr[] images, int imagesSize);
        [NativeDelegate("stitching_Stitcher_estimateTransform_MatArray1")] public static stitching_Stitcher_estimateTransform_MatArray1Delegate stitching_Stitcher_estimateTransform_MatArray1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int stitching_Stitcher_estimateTransform_MatArray2Delegate(
            IntPtr obj, IntPtr[] images, int imagesSize,
            IntPtr[] rois, int roisSize1, int[] roisSize2);
        [NativeDelegate("stitching_Stitcher_estimateTransform_MatArray2")] public static stitching_Stitcher_estimateTransform_MatArray2Delegate stitching_Stitcher_estimateTransform_MatArray2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int stitching_Stitcher_composePanorama1Delegate(
            IntPtr obj, IntPtr pano);
        [NativeDelegate("stitching_Stitcher_composePanorama1")] public static stitching_Stitcher_composePanorama1Delegate stitching_Stitcher_composePanorama1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int stitching_Stitcher_composePanorama2_InputArrayDelegate(
            IntPtr obj, IntPtr images, IntPtr pano);
        [NativeDelegate("stitching_Stitcher_composePanorama2_InputArray")] public static stitching_Stitcher_composePanorama2_InputArrayDelegate stitching_Stitcher_composePanorama2_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int stitching_Stitcher_composePanorama2_MatArrayDelegate(
            IntPtr obj, IntPtr[] images, int imagesSize, IntPtr pano);
        [NativeDelegate("stitching_Stitcher_composePanorama2_MatArray")] public static stitching_Stitcher_composePanorama2_MatArrayDelegate stitching_Stitcher_composePanorama2_MatArray;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int stitching_Stitcher_stitch1_InputArrayDelegate(
            IntPtr obj, IntPtr images, IntPtr pano);
        [NativeDelegate("stitching_Stitcher_stitch1_InputArray")] public static stitching_Stitcher_stitch1_InputArrayDelegate stitching_Stitcher_stitch1_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int stitching_Stitcher_stitch1_MatArrayDelegate(
            IntPtr obj, IntPtr[] images, int imagesSize, IntPtr pano);
        [NativeDelegate("stitching_Stitcher_stitch1_MatArray")] public static stitching_Stitcher_stitch1_MatArrayDelegate stitching_Stitcher_stitch1_MatArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int stitching_Stitcher_stitch2_InputArrayDelegate(
            IntPtr obj, IntPtr images,
            IntPtr[] rois, int roisSize1, int[] roisSize2,
            IntPtr pano);
        [NativeDelegate("stitching_Stitcher_stitch2_InputArray")] public static stitching_Stitcher_stitch2_InputArrayDelegate stitching_Stitcher_stitch2_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int stitching_Stitcher_stitch2_MatArrayDelegate(
            IntPtr obj, IntPtr[] images, int imagesSize,
            IntPtr[] rois, int roisSize1, int[] roisSize2,
            IntPtr pano);
        [NativeDelegate("stitching_Stitcher_stitch2_MatArray")] public static stitching_Stitcher_stitch2_MatArrayDelegate stitching_Stitcher_stitch2_MatArray;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void stitching_Stitcher_componentDelegate(IntPtr obj, out IntPtr pointer, out int length);
        [NativeDelegate("stitching_Stitcher_component")] public static stitching_Stitcher_componentDelegate stitching_Stitcher_component;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double stitching_Stitcher_workScaleDelegate(IntPtr obj);
        [NativeDelegate("stitching_Stitcher_workScale")] public static stitching_Stitcher_workScaleDelegate stitching_Stitcher_workScale;
    }
}
