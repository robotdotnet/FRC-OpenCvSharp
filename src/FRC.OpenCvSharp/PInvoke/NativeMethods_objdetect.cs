using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591
// ReSharper disable InconsistentNaming

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        /*
        #region LatendSvmDetector

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr objdetect_LatentSvmDetector_newDelegate();
        [NativeDelegate("objdetect_LatentSvmDetector_new")] public static objdetect_LatentSvmDetector_newDelegate objdetect_LatentSvmDetector_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_LatentSvmDetector_deleteDelegate(IntPtr obj);
        [NativeDelegate("objdetect_LatentSvmDetector_delete")] public static objdetect_LatentSvmDetector_deleteDelegate objdetect_LatentSvmDetector_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_LatentSvmDetector_clearDelegate(IntPtr obj);
        [NativeDelegate("objdetect_LatentSvmDetector_clear")] public static objdetect_LatentSvmDetector_clearDelegate objdetect_LatentSvmDetector_clear;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int objdetect_LatentSvmDetector_emptyDelegate(IntPtr obj);
        [NativeDelegate("objdetect_LatentSvmDetector_empty")] public static objdetect_LatentSvmDetector_emptyDelegate objdetect_LatentSvmDetector_empty;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int objdetect_LatentSvmDetector_loadDelegate(IntPtr obj,
            IntPtr[] fileNames, int fileNamesLength,
            IntPtr[] classNames, int classNamesLength);
        [NativeDelegate("objdetect_LatentSvmDetector_load")] public static objdetect_LatentSvmDetector_loadDelegate objdetect_LatentSvmDetector_load;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_LatentSvmDetector_detectDelegate(
            IntPtr obj, IntPtr image, IntPtr objectDetections,
            float overlapThreshold, int numThreads);
        [NativeDelegate("objdetect_LatentSvmDetector_detect")] public static objdetect_LatentSvmDetector_detectDelegate objdetect_LatentSvmDetector_detect;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_LatentSvmDetector_getClassNamesDelegate(IntPtr obj, IntPtr outValues);
        [NativeDelegate("objdetect_LatentSvmDetector_getClassNames")] public static objdetect_LatentSvmDetector_getClassNamesDelegate objdetect_LatentSvmDetector_getClassNames;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr objdetect_LatentSvmDetector_getClassCountDelegate(IntPtr obj);
        [NativeDelegate("objdetect_LatentSvmDetector_getClassCount")] public static objdetect_LatentSvmDetector_getClassCountDelegate objdetect_LatentSvmDetector_getClassCount;

        #endregion
        */

        #region CascadeClassfier

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr objdetect_CascadeClassifier_newDelegate();
        [NativeDelegate("objdetect_CascadeClassifier_new")] public static objdetect_CascadeClassifier_newDelegate objdetect_CascadeClassifier_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr objdetect_CascadeClassifier_newFromFileDelegate([MarshalAs(UnmanagedType.LPStr)] string fileName);
        [NativeDelegate("objdetect_CascadeClassifier_newFromFile")] public static objdetect_CascadeClassifier_newFromFileDelegate objdetect_CascadeClassifier_newFromFile;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_CascadeClassifier_deleteDelegate(IntPtr obj);
        [NativeDelegate("objdetect_CascadeClassifier_delete")] public static objdetect_CascadeClassifier_deleteDelegate objdetect_CascadeClassifier_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int objdetect_CascadeClassifier_emptyDelegate(IntPtr obj);
        [NativeDelegate("objdetect_CascadeClassifier_empty")] public static objdetect_CascadeClassifier_emptyDelegate objdetect_CascadeClassifier_empty;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int objdetect_CascadeClassifier_loadDelegate(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string fileName);
        [NativeDelegate("objdetect_CascadeClassifier_load")] public static objdetect_CascadeClassifier_loadDelegate objdetect_CascadeClassifier_load;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_CascadeClassifier_detectMultiScale1Delegate(
            IntPtr obj, IntPtr image, IntPtr objects,
            double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize);
        [NativeDelegate("objdetect_CascadeClassifier_detectMultiScale1")] public static objdetect_CascadeClassifier_detectMultiScale1Delegate objdetect_CascadeClassifier_detectMultiScale1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_CascadeClassifier_detectMultiScale2Delegate(
            IntPtr obj, IntPtr image, IntPtr objects,
            IntPtr rejectLevels, IntPtr levelWeights,
            double scaleFactor, int minNeighbors, int flags,
            Size minSize, Size maxSize, int outputRejectLevels);
        [NativeDelegate("objdetect_CascadeClassifier_detectMultiScale2")] public static objdetect_CascadeClassifier_detectMultiScale2Delegate objdetect_CascadeClassifier_detectMultiScale2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int objdetect_CascadeClassifier_isOldFormatCascadeDelegate(IntPtr obj);
        [NativeDelegate("objdetect_CascadeClassifier_isOldFormatCascade")] public static objdetect_CascadeClassifier_isOldFormatCascadeDelegate objdetect_CascadeClassifier_isOldFormatCascade;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size objdetect_CascadeClassifier_getOriginalWindowSizeDelegate(IntPtr obj);
        [NativeDelegate("objdetect_CascadeClassifier_getOriginalWindowSize")] public static objdetect_CascadeClassifier_getOriginalWindowSizeDelegate objdetect_CascadeClassifier_getOriginalWindowSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int objdetect_CascadeClassifier_getFeatureTypeDelegate(IntPtr obj);
        [NativeDelegate("objdetect_CascadeClassifier_getFeatureType")] public static objdetect_CascadeClassifier_getFeatureTypeDelegate objdetect_CascadeClassifier_getFeatureType;

        #endregion

        #region HOGDescriptor
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int objdetect_HOGDescriptor_sizeofDelegate();
        [NativeDelegate("objdetect_HOGDescriptor_sizeof")] public static objdetect_HOGDescriptor_sizeofDelegate objdetect_HOGDescriptor_sizeof;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr objdetect_HOGDescriptor_new1Delegate();
        [NativeDelegate("objdetect_HOGDescriptor_new1")] public static objdetect_HOGDescriptor_new1Delegate objdetect_HOGDescriptor_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr objdetect_HOGDescriptor_new2Delegate(Size winSize, Size blockSize, Size blockStride, Size cellSize,
            int nbins, int derivAperture, double winSigma, [MarshalAs(UnmanagedType.I4)] HistogramNormType histogramNormType,
            double l2HysThreshold, int gammaCorrection, int nlevels);
        [NativeDelegate("objdetect_HOGDescriptor_new2")] public static objdetect_HOGDescriptor_new2Delegate objdetect_HOGDescriptor_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr objdetect_HOGDescriptor_new3Delegate([MarshalAs(UnmanagedType.LPStr)] string fileName);
        [NativeDelegate("objdetect_HOGDescriptor_new3")] public static objdetect_HOGDescriptor_new3Delegate objdetect_HOGDescriptor_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_deleteDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_delete")] public static objdetect_HOGDescriptor_deleteDelegate objdetect_HOGDescriptor_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr objdetect_HOGDescriptor_getDescriptorSizeDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_getDescriptorSize")] public static objdetect_HOGDescriptor_getDescriptorSizeDelegate objdetect_HOGDescriptor_getDescriptorSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int objdetect_HOGDescriptor_checkDetectorSizeDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_checkDetectorSize")] public static objdetect_HOGDescriptor_checkDetectorSizeDelegate objdetect_HOGDescriptor_checkDetectorSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double objdetect_HOGDescriptor_getWinSigmaDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_getWinSigma")] public static objdetect_HOGDescriptor_getWinSigmaDelegate objdetect_HOGDescriptor_getWinSigma;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_setSVMDetectorDelegate(IntPtr self, IntPtr svmdetector);
        [NativeDelegate("objdetect_HOGDescriptor_setSVMDetector")] public static objdetect_HOGDescriptor_setSVMDetectorDelegate objdetect_HOGDescriptor_setSVMDetector;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool objdetect_HOGDescriptor_loadDelegate(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string filename, [MarshalAs(UnmanagedType.LPStr)] string objname);
        [NativeDelegate("objdetect_HOGDescriptor_load")] public static objdetect_HOGDescriptor_loadDelegate objdetect_HOGDescriptor_load;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_saveDelegate(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string filename, [MarshalAs(UnmanagedType.LPStr)] string objname);
        [NativeDelegate("objdetect_HOGDescriptor_save")] public static objdetect_HOGDescriptor_saveDelegate objdetect_HOGDescriptor_save;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_computeDelegate(
            IntPtr self, IntPtr img, IntPtr descriptors,
                         Size winStride, Size padding, [In] Point[] locations, int locationsLength);
        [NativeDelegate("objdetect_HOGDescriptor_compute")] public static objdetect_HOGDescriptor_computeDelegate objdetect_HOGDescriptor_compute;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_detectDelegate1(
            IntPtr self, IntPtr img, IntPtr foundLocations,
            double hitThreshold, Size winStride, Size padding, [In] Point[] searchLocations, int searchLocationsLength);
        [NativeDelegate("objdetect_HOGDescriptor_detect2")] public static objdetect_HOGDescriptor_detectDelegate1 objdetect_HOGDescriptor_detect1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_detectDelegate2(
            IntPtr self, IntPtr img, IntPtr foundLocations, IntPtr weights,
            double hitThreshold, Size winStride, Size padding, [In] Point[] searchLocations, int searchLocationsLength);
        [NativeDelegate("objdetect_HOGDescriptor_detect2")] public static objdetect_HOGDescriptor_detectDelegate2 objdetect_HOGDescriptor_detect2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_detectMultiScale1Delegate(
            IntPtr self, IntPtr img, IntPtr foundLocations,
            double hitThreshold, Size winStride, Size padding, double scale, int groupThreshold);
        [NativeDelegate("objdetect_HOGDescriptor_detectMultiScale1")] public static objdetect_HOGDescriptor_detectMultiScale1Delegate objdetect_HOGDescriptor_detectMultiScale1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_detectMultiScaleDelegate2(
            IntPtr self, IntPtr img, IntPtr foundLocations, IntPtr foundWeights,
            double hitThreshold, Size winStride, Size padding, double scale, int groupThreshold);
        [NativeDelegate("objdetect_HOGDescriptor_detectMultiScale2")] public static objdetect_HOGDescriptor_detectMultiScaleDelegate2 objdetect_HOGDescriptor_detectMultiScale2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_computeGradientDelegate(
            IntPtr self, IntPtr img, IntPtr grad, IntPtr angleOfs, Size paddingTL, Size paddingBR);
        [NativeDelegate("objdetect_HOGDescriptor_computeGradient")] public static objdetect_HOGDescriptor_computeGradientDelegate objdetect_HOGDescriptor_computeGradient;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_detectROIDelegate(
            IntPtr obj, IntPtr img,
            Point[] locations, int locationsLength,
            IntPtr foundLocations, IntPtr confidences,
            double hitThreshold, Size winStride, Size padding);
        [NativeDelegate("objdetect_HOGDescriptor_detectROI")] public static objdetect_HOGDescriptor_detectROIDelegate objdetect_HOGDescriptor_detectROI;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_detectMultiScaleROIDelegate(
            IntPtr obj, IntPtr img, IntPtr foundLocations,
            IntPtr roiScales, IntPtr roiLocations, IntPtr roiConfidences,
            double hitThreshold, int groupThreshold);
        [NativeDelegate("objdetect_HOGDescriptor_detectMultiScaleROI")] public static objdetect_HOGDescriptor_detectMultiScaleROIDelegate objdetect_HOGDescriptor_detectMultiScaleROI;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_readALTModelDelegate(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string modelfile);
        [NativeDelegate("objdetect_HOGDescriptor_readALTModel")] public static objdetect_HOGDescriptor_readALTModelDelegate objdetect_HOGDescriptor_readALTModel;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_groupRectanglesDelegate(IntPtr obj,
            IntPtr rectList, IntPtr weights, int groupThreshold, double eps);
        [NativeDelegate("objdetect_HOGDescriptor_groupRectangles")] public static objdetect_HOGDescriptor_groupRectanglesDelegate objdetect_HOGDescriptor_groupRectangles;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size objdetect_HOGDescriptor_winSize_getDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_winSize_get")] public static objdetect_HOGDescriptor_winSize_getDelegate objdetect_HOGDescriptor_winSize_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size objdetect_HOGDescriptor_blockSize_getDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_blockSize_get")] public static objdetect_HOGDescriptor_blockSize_getDelegate objdetect_HOGDescriptor_blockSize_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size objdetect_HOGDescriptor_blockStride_getDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_blockStride_get")] public static objdetect_HOGDescriptor_blockStride_getDelegate objdetect_HOGDescriptor_blockStride_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size objdetect_HOGDescriptor_cellSize_getDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_cellSize_get")] public static objdetect_HOGDescriptor_cellSize_getDelegate objdetect_HOGDescriptor_cellSize_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int objdetect_HOGDescriptor_nbins_getDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_nbins_get")] public static objdetect_HOGDescriptor_nbins_getDelegate objdetect_HOGDescriptor_nbins_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int objdetect_HOGDescriptor_derivAperture_getDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_derivAperture_get")] public static objdetect_HOGDescriptor_derivAperture_getDelegate objdetect_HOGDescriptor_derivAperture_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double objdetect_HOGDescriptor_winSigma_getDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_winSigma_get")] public static objdetect_HOGDescriptor_winSigma_getDelegate objdetect_HOGDescriptor_winSigma_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int objdetect_HOGDescriptor_histogramNormType_getDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_histogramNormType_get")] public static objdetect_HOGDescriptor_histogramNormType_getDelegate objdetect_HOGDescriptor_histogramNormType_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double objdetect_HOGDescriptor_L2HysThreshold_getDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_L2HysThreshold_get")] public static objdetect_HOGDescriptor_L2HysThreshold_getDelegate objdetect_HOGDescriptor_L2HysThreshold_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int objdetect_HOGDescriptor_gammaCorrection_getDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_gammaCorrection_get")] public static objdetect_HOGDescriptor_gammaCorrection_getDelegate objdetect_HOGDescriptor_gammaCorrection_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int objdetect_HOGDescriptor_nlevels_getDelegate(IntPtr self);
        [NativeDelegate("objdetect_HOGDescriptor_nlevels_get")] public static objdetect_HOGDescriptor_nlevels_getDelegate objdetect_HOGDescriptor_nlevels_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_winSize_setDelegate(IntPtr self, Size value);
        [NativeDelegate("objdetect_HOGDescriptor_winSize_set")] public static objdetect_HOGDescriptor_winSize_setDelegate objdetect_HOGDescriptor_winSize_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_blockSize_setDelegate(IntPtr self, Size value);
        [NativeDelegate("objdetect_HOGDescriptor_blockSize_set")] public static objdetect_HOGDescriptor_blockSize_setDelegate objdetect_HOGDescriptor_blockSize_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_blockStride_setDelegate(IntPtr self, Size value);
        [NativeDelegate("objdetect_HOGDescriptor_blockStride_set")] public static objdetect_HOGDescriptor_blockStride_setDelegate objdetect_HOGDescriptor_blockStride_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_cellSize_setDelegate(IntPtr self, Size value);
        [NativeDelegate("objdetect_HOGDescriptor_cellSize_set")] public static objdetect_HOGDescriptor_cellSize_setDelegate objdetect_HOGDescriptor_cellSize_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_nbins_setDelegate(IntPtr self, int value);
        [NativeDelegate("objdetect_HOGDescriptor_nbins_set")] public static objdetect_HOGDescriptor_nbins_setDelegate objdetect_HOGDescriptor_nbins_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_derivAperture_setDelegate(IntPtr self, int value);
        [NativeDelegate("objdetect_HOGDescriptor_derivAperture_set")] public static objdetect_HOGDescriptor_derivAperture_setDelegate objdetect_HOGDescriptor_derivAperture_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_winSigma_setDelegate(IntPtr self, double value);
        [NativeDelegate("objdetect_HOGDescriptor_winSigma_set")] public static objdetect_HOGDescriptor_winSigma_setDelegate objdetect_HOGDescriptor_winSigma_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_histogramNormType_setDelegate(IntPtr self, int value);
        [NativeDelegate("objdetect_HOGDescriptor_histogramNormType_set")] public static objdetect_HOGDescriptor_histogramNormType_setDelegate objdetect_HOGDescriptor_histogramNormType_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_L2HysThreshold_setDelegate(IntPtr self, double value);
        [NativeDelegate("objdetect_HOGDescriptor_L2HysThreshold_set")] public static objdetect_HOGDescriptor_L2HysThreshold_setDelegate objdetect_HOGDescriptor_L2HysThreshold_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_gammaCorrection_setDelegate(IntPtr self, int value);
        [NativeDelegate("objdetect_HOGDescriptor_gammaCorrection_set")] public static objdetect_HOGDescriptor_gammaCorrection_setDelegate objdetect_HOGDescriptor_gammaCorrection_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_HOGDescriptor_nlevels_setDelegate(IntPtr self, int value);
        [NativeDelegate("objdetect_HOGDescriptor_nlevels_set")] public static objdetect_HOGDescriptor_nlevels_setDelegate objdetect_HOGDescriptor_nlevels_set;
        #endregion

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_groupRectangles1Delegate(IntPtr rectList, int groupThreshold, double eps);
        [NativeDelegate("objdetect_groupRectangles1")] public static objdetect_groupRectangles1Delegate objdetect_groupRectangles1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_groupRectangles2Delegate(IntPtr rectList, IntPtr weights, int groupThreshold, double eps);
        [NativeDelegate("objdetect_groupRectangles2")] public static objdetect_groupRectangles2Delegate objdetect_groupRectangles2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_groupRectangles3Delegate(
            IntPtr rectList, int groupThreshold, double eps, IntPtr weights, IntPtr levelWeights);
        [NativeDelegate("objdetect_groupRectangles3")] public static objdetect_groupRectangles3Delegate objdetect_groupRectangles3;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_groupRectangles4Delegate(
            IntPtr rectList, IntPtr rejectLevels, IntPtr levelWeights, int groupThreshold, double eps);
        [NativeDelegate("objdetect_groupRectangles4")] public static objdetect_groupRectangles4Delegate objdetect_groupRectangles4;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void objdetect_groupRectangles_meanshiftDelegate(
            IntPtr rectList, IntPtr foundWeights, IntPtr foundScales, double detectThreshold, Size winDetSize);
        [NativeDelegate("objdetect_groupRectangles_meanshift")] public static objdetect_groupRectangles_meanshiftDelegate objdetect_groupRectangles_meanshift;
    }
}
