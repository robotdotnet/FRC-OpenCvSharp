using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_getGaussianKernelDelegate(
            int ksize, double sigma, int ktype);
        [NativeDelegate("imgproc_getGaussianKernel")] public static imgproc_getGaussianKernelDelegate imgproc_getGaussianKernel;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_getDerivKernelsDelegate(
            IntPtr kx, IntPtr ky,int dx, int dy, int ksize, int normalize, int ktype);
        [NativeDelegate("imgproc_getDerivKernels")] public static imgproc_getDerivKernelsDelegate imgproc_getDerivKernels;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_getGaborKernelDelegate(Size ksize, double sigma, double theta, double lambd, double gamma, double psi, int ktype);
        [NativeDelegate("imgproc_getGaborKernel")] public static imgproc_getGaborKernelDelegate imgproc_getGaborKernel;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_getStructuringElementDelegate(int shape, Size ksize, Point anchor);
        [NativeDelegate("imgproc_getStructuringElement")] public static imgproc_getStructuringElementDelegate imgproc_getStructuringElement;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_copyMakeBorderDelegate(IntPtr src, IntPtr dst, int top, int bottom, int left,
                                                         int right, int borderType, Scalar value);
        [NativeDelegate("imgproc_copyMakeBorder")] public static imgproc_copyMakeBorderDelegate imgproc_copyMakeBorder;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_medianBlurDelegate(IntPtr src, IntPtr dst, int ksize);
        [NativeDelegate("imgproc_medianBlur")] public static imgproc_medianBlurDelegate imgproc_medianBlur;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_GaussianBlurDelegate(IntPtr src, IntPtr dst, Size ksize, double sigmaX,
                                                       double sigmaY, int borderType);
        [NativeDelegate("imgproc_GaussianBlur")] public static imgproc_GaussianBlurDelegate imgproc_GaussianBlur;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_bilateralFilterDelegate(IntPtr src, IntPtr dst, int d, double sigmaColor,
                                                          double sigmaSpace, int borderType);
        [NativeDelegate("imgproc_bilateralFilter")] public static imgproc_bilateralFilterDelegate imgproc_bilateralFilter;
        
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_adaptiveBilateralFilterDelegate(IntPtr src, IntPtr dst, Size ksize,
            double sigmaSpace, double maxSigmaColor, CvPoint anchor, int borderType);
        [NativeDelegate("imgproc_adaptiveBilateralFilter")] public static imgproc_adaptiveBilateralFilterDelegate imgproc_adaptiveBilateralFilter;
        */

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_boxFilterDelegate(IntPtr src, IntPtr dst, int ddepth, Size ksize, Point anchor,
                                                    int normalize, int borderType);
        [NativeDelegate("imgproc_boxFilter")] public static imgproc_boxFilterDelegate imgproc_boxFilter;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_blurDelegate(IntPtr src, IntPtr dst, Size ksize, Point anchor, int borderType);
        [NativeDelegate("imgproc_blur")] public static imgproc_blurDelegate imgproc_blur;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_filter2DDelegate(IntPtr src, IntPtr dst, int ddepth, IntPtr kernel, Point anchor, double delta, int borderType);
        [NativeDelegate("imgproc_filter2D")] public static imgproc_filter2DDelegate imgproc_filter2D;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_sepFilter2DDelegate(IntPtr src, IntPtr dst, int ddepth, IntPtr kernelX, IntPtr kernelY, Point anchor, double delta, int borderType);
        [NativeDelegate("imgproc_sepFilter2D")] public static imgproc_sepFilter2DDelegate imgproc_sepFilter2D;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_SobelDelegate(IntPtr src, IntPtr dst, int ddepth,
            int dx, int dy, int ksize, double scale, double delta, int borderType);
        [NativeDelegate("imgproc_Sobel")] public static imgproc_SobelDelegate imgproc_Sobel;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_ScharrDelegate(IntPtr src, IntPtr dst, int ddepth,
            int dx, int dy, double scale, double delta, int borderType);
        [NativeDelegate("imgproc_Scharr")] public static imgproc_ScharrDelegate imgproc_Scharr;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_LaplacianDelegate(IntPtr src, IntPtr dst, int ddepth,
            int ksize, double scale, double delta, int borderType);
        [NativeDelegate("imgproc_Laplacian")] public static imgproc_LaplacianDelegate imgproc_Laplacian;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_CannyDelegate(IntPtr src, IntPtr edges,
            double threshold1, double threshold2, int apertureSize, int L2gradient);
        [NativeDelegate("imgproc_Canny")] public static imgproc_CannyDelegate imgproc_Canny;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_cornerEigenValsAndVecsDelegate(IntPtr src, IntPtr dst,int blockSize, int ksize, int borderType);
        [NativeDelegate("imgproc_cornerEigenValsAndVecs")] public static imgproc_cornerEigenValsAndVecsDelegate imgproc_cornerEigenValsAndVecs;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_preCornerDetectDelegate(IntPtr src, IntPtr dst, int ksize, int borderType);
        [NativeDelegate("imgproc_preCornerDetect")] public static imgproc_preCornerDetectDelegate imgproc_preCornerDetect;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_cornerSubPixDelegate(IntPtr image, IntPtr corners,
            Size winSize, Size zeroZone, TermCriteria criteria);
        [NativeDelegate("imgproc_cornerSubPix")] public static imgproc_cornerSubPixDelegate imgproc_cornerSubPix;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_goodFeaturesToTrackDelegate(IntPtr src, IntPtr corners,
            int maxCorners, double qualityLevel, double minDistance, IntPtr mask, int blockSize, int useHarrisDetector, double k);
        [NativeDelegate("imgproc_goodFeaturesToTrack")] public static imgproc_goodFeaturesToTrackDelegate imgproc_goodFeaturesToTrack;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_HoughLinesDelegate(IntPtr src, IntPtr lines,
            double rho, double theta, int threshold, double srn, double stn);
        [NativeDelegate("imgproc_HoughLines")] public static imgproc_HoughLinesDelegate imgproc_HoughLines;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_HoughLinesPDelegate(IntPtr src, IntPtr lines,
            double rho, double theta, int threshold, double minLineLength, double maxLineG);
        [NativeDelegate("imgproc_HoughLinesP")] public static imgproc_HoughLinesPDelegate imgproc_HoughLinesP;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_HoughCirclesDelegate(IntPtr src, IntPtr circles,
            int method, double dp, double minDist, double param1, double param2, int minRadius, int maxRadius);
        [NativeDelegate("imgproc_HoughCircles")] public static imgproc_HoughCirclesDelegate imgproc_HoughCircles;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_erodeDelegate(IntPtr src, IntPtr dst, IntPtr kernel, Point anchor, int iterations, int borderType, Scalar borderValue);
        [NativeDelegate("imgproc_erode")] public static imgproc_erodeDelegate imgproc_erode;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_dilateDelegate(IntPtr src, IntPtr dst, IntPtr kernel, Point anchor, int iterations, int borderType, Scalar borderValue);
        [NativeDelegate("imgproc_dilate")] public static imgproc_dilateDelegate imgproc_dilate;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_morphologyExDelegate(IntPtr src, IntPtr dst, int op, IntPtr kernel, Point anchor, int iterations, int borderType, Scalar borderValue);
        [NativeDelegate("imgproc_morphologyEx")] public static imgproc_morphologyExDelegate imgproc_morphologyEx;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_resizeDelegate(IntPtr src, IntPtr dst, Size dsize, double fx, double fy, int interpolation);
        [NativeDelegate("imgproc_resize")] public static imgproc_resizeDelegate imgproc_resize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_warpAffineDelegate(IntPtr src, IntPtr dst, IntPtr m, Size dsize, int flags, int borderMode, Scalar borderValue);
        [NativeDelegate("imgproc_warpAffine")] public static imgproc_warpAffineDelegate imgproc_warpAffine;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_warpPerspective_MisInputArrayDelegate(
            IntPtr src, IntPtr dst, IntPtr m, Size dsize, int flags, int borderMode, Scalar borderValue);
        [NativeDelegate("imgproc_warpPerspective_MisInputArray")] public static imgproc_warpPerspective_MisInputArrayDelegate imgproc_warpPerspective_MisInputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_warpPerspective_MisArrayDelegate(
            IntPtr src, IntPtr dst, [MarshalAs(UnmanagedType.LPArray)] float[,] m, int mRow, int mCol, 
            Size dsize, int flags, int borderMode, Scalar borderValue);
        [NativeDelegate("imgproc_warpPerspective_MisArray")] public static imgproc_warpPerspective_MisArrayDelegate imgproc_warpPerspective_MisArray;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_remapDelegate(IntPtr src, IntPtr dst, IntPtr map1, IntPtr map2, int interpolation, int borderMode, Scalar borderValue);
        [NativeDelegate("imgproc_remap")] public static imgproc_remapDelegate imgproc_remap;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_convertMapsDelegate(IntPtr map1, IntPtr map2, IntPtr dstmap1, IntPtr dstmap2, int dstmap1Type, int nninterpolation);
        [NativeDelegate("imgproc_convertMaps")] public static imgproc_convertMapsDelegate imgproc_convertMaps;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_getRotationMatrix2DDelegate(Point2f center, double angle, double scale);
        [NativeDelegate("imgproc_getRotationMatrix2D")] public static imgproc_getRotationMatrix2DDelegate imgproc_getRotationMatrix2D;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_invertAffineTransformDelegate(IntPtr m, IntPtr im);
        [NativeDelegate("imgproc_invertAffineTransform")] public static imgproc_invertAffineTransformDelegate imgproc_invertAffineTransform;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_getPerspectiveTransform1Delegate(Point2f[] src, Point2f[] dst);
        [NativeDelegate("imgproc_getPerspectiveTransform1")] public static imgproc_getPerspectiveTransform1Delegate imgproc_getPerspectiveTransform1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_getPerspectiveTransform2Delegate(IntPtr src, IntPtr dst);
        [NativeDelegate("imgproc_getPerspectiveTransform2")] public static imgproc_getPerspectiveTransform2Delegate imgproc_getPerspectiveTransform2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_getAffineTransform1Delegate(Point2f[] src, Point2f[] dst);
        [NativeDelegate("imgproc_getAffineTransform1")] public static imgproc_getAffineTransform1Delegate imgproc_getAffineTransform1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_getAffineTransform2Delegate(IntPtr src, IntPtr dst);
        [NativeDelegate("imgproc_getAffineTransform2")] public static imgproc_getAffineTransform2Delegate imgproc_getAffineTransform2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_getRectSubPixDelegate(IntPtr image, Size patchSize, Point2f center, IntPtr patch, int patchType);
        [NativeDelegate("imgproc_getRectSubPix")] public static imgproc_getRectSubPixDelegate imgproc_getRectSubPix;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_logPolarDelegate(
            IntPtr src, IntPtr dst, Point2f center, double m, int flags);
        [NativeDelegate("imgproc_logPolar")] public static imgproc_logPolarDelegate imgproc_logPolar;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_linearPolarDelegate(
            IntPtr src, IntPtr dst, Point2f center, double maxRadius, int flags);
        [NativeDelegate("imgproc_linearPolar")] public static imgproc_linearPolarDelegate imgproc_linearPolar;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_integral1Delegate(IntPtr src, IntPtr sum, int sdepth);
        [NativeDelegate("imgproc_integral1")] public static imgproc_integral1Delegate imgproc_integral1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_integral2Delegate(IntPtr src, IntPtr sum, IntPtr sqsum, int sdepth);
        [NativeDelegate("imgproc_integral2")] public static imgproc_integral2Delegate imgproc_integral2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_integral3Delegate(IntPtr src, IntPtr sum, IntPtr sqsum, IntPtr tilted, int sdepth);
        [NativeDelegate("imgproc_integral3")] public static imgproc_integral3Delegate imgproc_integral3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_accumulateDelegate(IntPtr src, IntPtr dst, IntPtr mask);
        [NativeDelegate("imgproc_accumulate")] public static imgproc_accumulateDelegate imgproc_accumulate;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_accumulateSquareDelegate(IntPtr src, IntPtr dst, IntPtr mask);
        [NativeDelegate("imgproc_accumulateSquare")] public static imgproc_accumulateSquareDelegate imgproc_accumulateSquare;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_accumulateProductDelegate(IntPtr src1, IntPtr src2, IntPtr dst, IntPtr mask);
        [NativeDelegate("imgproc_accumulateProduct")] public static imgproc_accumulateProductDelegate imgproc_accumulateProduct;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_accumulateWeightedDelegate(IntPtr src, IntPtr dst, double alpha, IntPtr mask);
        [NativeDelegate("imgproc_accumulateWeighted")] public static imgproc_accumulateWeightedDelegate imgproc_accumulateWeighted;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_PSNRDelegate(IntPtr src1, IntPtr src2);
        [NativeDelegate("imgproc_PSNR")] public static imgproc_PSNRDelegate imgproc_PSNR;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Point2d imgproc_phaseCorrelateDelegate(IntPtr src1, IntPtr src2, IntPtr window);
        [NativeDelegate("imgproc_phaseCorrelate")] public static imgproc_phaseCorrelateDelegate imgproc_phaseCorrelate;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Point2d imgproc_phaseCorrelateResDelegate(IntPtr src1, IntPtr src2, IntPtr window, out double response);
        [NativeDelegate("imgproc_phaseCorrelateRes")] public static imgproc_phaseCorrelateResDelegate imgproc_phaseCorrelateRes;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_createHanningWindowDelegate(IntPtr dst, Size winSize, int type);
        [NativeDelegate("imgproc_createHanningWindow")] public static imgproc_createHanningWindowDelegate imgproc_createHanningWindow;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_thresholdDelegate(IntPtr src, IntPtr dst, double thresh, double maxval, int type);
        [NativeDelegate("imgproc_threshold")] public static imgproc_thresholdDelegate imgproc_threshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_adaptiveThresholdDelegate(IntPtr src, IntPtr dst,
            double maxValue, int adaptiveMethod, int thresholdType, int blockSize, double c);
        [NativeDelegate("imgproc_adaptiveThreshold")] public static imgproc_adaptiveThresholdDelegate imgproc_adaptiveThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_pyrDownDelegate(IntPtr src, IntPtr dst, Size dstsize, int borderType);
        [NativeDelegate("imgproc_pyrDown")] public static imgproc_pyrDownDelegate imgproc_pyrDown;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_pyrUpDelegate(IntPtr src, IntPtr dst, Size dstsize, int borderType);
        [NativeDelegate("imgproc_pyrUp")] public static imgproc_pyrUpDelegate imgproc_pyrUp;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_undistortDelegate(IntPtr src, IntPtr dst,
            IntPtr cameraMatrix, IntPtr distCoeffs, IntPtr newCameraMatrix);
        [NativeDelegate("imgproc_undistort")] public static imgproc_undistortDelegate imgproc_undistort;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_initUndistortRectifyMapDelegate(IntPtr cameraMatrix,IntPtr distCoeffs,
            IntPtr r, IntPtr newCameraMatrix, Size size, int m1Type, IntPtr map1, IntPtr map2);
        [NativeDelegate("imgproc_initUndistortRectifyMap")] public static imgproc_initUndistortRectifyMapDelegate imgproc_initUndistortRectifyMap;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float imgproc_initWideAngleProjMapDelegate(IntPtr cameraMatrix, IntPtr distCoeffs,
            Size imageSize, int destImageWidth, int m1Type, IntPtr map1, IntPtr map2,
            int projType, double alpha);
        [NativeDelegate("imgproc_initWideAngleProjMap")] public static imgproc_initWideAngleProjMapDelegate imgproc_initWideAngleProjMap;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_getDefaultNewCameraMatrixDelegate(IntPtr cameraMatrix, Size imgSize,
            int centerPrincipalPoint);
        [NativeDelegate("imgproc_getDefaultNewCameraMatrix")] public static imgproc_getDefaultNewCameraMatrixDelegate imgproc_getDefaultNewCameraMatrix;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_undistortPointsDelegate(IntPtr src, IntPtr dst,
            IntPtr cameraMatrix, IntPtr distCoeffs, IntPtr r, IntPtr p);
        [NativeDelegate("imgproc_undistortPoints")] public static imgproc_undistortPointsDelegate imgproc_undistortPoints;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_calcHist1Delegate(IntPtr[] images, int nimages,
            int[] channels, IntPtr mask, IntPtr hist, int dims, int[] histSize,
            IntPtr[] ranges, int uniform, int accumulate);
        [NativeDelegate("imgproc_calcHist1")] public static imgproc_calcHist1Delegate imgproc_calcHist1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_calcBackProjectDelegate(IntPtr[] images, int nimages,
                                                          int[] channels, IntPtr hist, IntPtr backProject,
                                                          IntPtr[] ranges, int uniform);
        [NativeDelegate("imgproc_calcBackProject")] public static imgproc_calcBackProjectDelegate imgproc_calcBackProject;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_compareHist1Delegate(IntPtr h1, IntPtr h2, int method);
        [NativeDelegate("imgproc_compareHist1")] public static imgproc_compareHist1Delegate imgproc_compareHist1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_equalizeHistDelegate(IntPtr src, IntPtr dst);
        [NativeDelegate("imgproc_equalizeHist")] public static imgproc_equalizeHistDelegate imgproc_equalizeHist;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float imgproc_EMDDelegate(IntPtr signature1, IntPtr signature2,
            int distType, IntPtr cost, out float lowerBound, IntPtr flow);
        [NativeDelegate("imgproc_EMD")] public static imgproc_EMDDelegate imgproc_EMD;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_watershedDelegate(IntPtr image, IntPtr markers);
        [NativeDelegate("imgproc_watershed")] public static imgproc_watershedDelegate imgproc_watershed;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_pyrMeanShiftFilteringDelegate(IntPtr src, IntPtr dst,
            double sp, double sr, int maxLevel, TermCriteria termcrit);
        [NativeDelegate("imgproc_pyrMeanShiftFiltering")] public static imgproc_pyrMeanShiftFilteringDelegate imgproc_pyrMeanShiftFiltering;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_grabCutDelegate(IntPtr img, IntPtr mask, Rect rect,
                                                  IntPtr bgdModel, IntPtr fgdModel,
                                                  int iterCount, int mode);
        [NativeDelegate("imgproc_grabCut")] public static imgproc_grabCutDelegate imgproc_grabCut;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_distanceTransformWithLabelsDelegate(IntPtr src, IntPtr dst, IntPtr labels,
                                                              int distanceType, int maskSize, int labelType);
        [NativeDelegate("imgproc_distanceTransformWithLabels")] public static imgproc_distanceTransformWithLabelsDelegate imgproc_distanceTransformWithLabels;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_distanceTransformDelegate(IntPtr src, IntPtr dst,
                                                    int distanceType, int maskSize);
        [NativeDelegate("imgproc_distanceTransform")] public static imgproc_distanceTransformDelegate imgproc_distanceTransform;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_floodFill1Delegate(IntPtr image,
                                                    Point seedPoint, Scalar newVal, out Rect rect,
                                                    Scalar loDiff, Scalar upDiff, int flags);
        [NativeDelegate("imgproc_floodFill1")] public static imgproc_floodFill1Delegate imgproc_floodFill1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_floodFill2Delegate(IntPtr image, IntPtr mask,
                                                    Point seedPoint, Scalar newVal, out Rect rect,
                                                    Scalar loDiff, Scalar upDiff, int flags);
        [NativeDelegate("imgproc_floodFill2")] public static imgproc_floodFill2Delegate imgproc_floodFill2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_cvtColorDelegate(IntPtr src, IntPtr dst, int code, int dstCn);
        [NativeDelegate("imgproc_cvtColor")] public static imgproc_cvtColorDelegate imgproc_cvtColor;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Moments.NativeStruct imgproc_momentsDelegate(IntPtr arr, int binaryImage);
        [NativeDelegate("imgproc_moments")] public static imgproc_momentsDelegate imgproc_moments;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_matchTemplateDelegate(
            IntPtr image, IntPtr templ, IntPtr result, int method, IntPtr mask);
        [NativeDelegate("imgproc_matchTemplate")] public static imgproc_matchTemplateDelegate imgproc_matchTemplate;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_connectedComponentsDelegate(
            IntPtr image, IntPtr labels, int connectivity, int ltype);
        [NativeDelegate("imgproc_connectedComponents")] public static imgproc_connectedComponentsDelegate imgproc_connectedComponents;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_connectedComponentsWithStatsDelegate(
            IntPtr image, IntPtr labels, IntPtr stats, IntPtr centroids, int connectivity, int ltype);
        [NativeDelegate("imgproc_connectedComponentsWithStats")] public static imgproc_connectedComponentsWithStatsDelegate imgproc_connectedComponentsWithStats;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_findContours1_vectorDelegate(IntPtr image, out IntPtr contours,
            out IntPtr hierarchy, int mode, int method, Point offset);
        [NativeDelegate("imgproc_findContours1_vector")] public static imgproc_findContours1_vectorDelegate imgproc_findContours1_vector;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_findContours1_OutputArrayDelegate(IntPtr image, out IntPtr contours,
            IntPtr hierarchy, int mode, int method, Point offset);
        [NativeDelegate("imgproc_findContours1_OutputArray")] public static imgproc_findContours1_OutputArrayDelegate imgproc_findContours1_OutputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_findContours2_vectorDelegate(IntPtr image, out IntPtr contours,
            int mode, int method, Point offset);
        [NativeDelegate("imgproc_findContours2_vector")] public static imgproc_findContours2_vectorDelegate imgproc_findContours2_vector;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_findContours2_OutputArrayDelegate(IntPtr image, out IntPtr contours,
            int mode, int method, Point offset);
        [NativeDelegate("imgproc_findContours2_OutputArray")] public static imgproc_findContours2_OutputArrayDelegate imgproc_findContours2_OutputArray;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_drawContours_vectorDelegate(IntPtr image,
            IntPtr[] contours, int contoursSize1, int[] contoursSize2,
            int contourIdx, Scalar color, int thickness, int lineType,
            Vec4i[] hierarchy, int hiearchyLength, int maxLevel, Point offset);
        [NativeDelegate("imgproc_drawContours_vector")] public static imgproc_drawContours_vectorDelegate imgproc_drawContours_vector;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_drawContours_vectorDelegate2(IntPtr image,
            IntPtr[] contours, int contoursSize1, int[] contoursSize2,
            int contourIdx, Scalar color, int thickness, int lineType,
            IntPtr hierarchy, int hiearchyLength, int maxLevel, Point offset);
        [NativeDelegate("imgproc_drawContours_vector")] public static imgproc_drawContours_vectorDelegate2 imgproc_drawContours_vector2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_drawContours_InputArrayDelegate(IntPtr image,
            IntPtr[] contours, int contoursLength,
            int contourIdx, Scalar color, int thickness, int lineType,
            IntPtr hierarchy, int maxLevel, Point offset);
        [NativeDelegate("imgproc_drawContours_InputArray")] public static imgproc_drawContours_InputArrayDelegate imgproc_drawContours_InputArray;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_approxPolyDP_InputArrayDelegate(IntPtr curve, IntPtr approxCurve,
                                                                  double epsilon, int closed);
        [NativeDelegate("imgproc_approxPolyDP_InputArray")] public static imgproc_approxPolyDP_InputArrayDelegate imgproc_approxPolyDP_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_approxPolyDP_PointDelegate(Point[] curve, int curveLength,
            out IntPtr approxCurve, double epsilon, int closed);
        [NativeDelegate("imgproc_approxPolyDP_Point")] public static imgproc_approxPolyDP_PointDelegate imgproc_approxPolyDP_Point;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_approxPolyDP_Point2fDelegate(Point2f[] curve, int curveLength,
            out IntPtr approxCurve, double epsilon, int closed);
        [NativeDelegate("imgproc_approxPolyDP_Point2f")] public static imgproc_approxPolyDP_Point2fDelegate imgproc_approxPolyDP_Point2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_arcLength_InputArrayDelegate(IntPtr curve, int closed);
        [NativeDelegate("imgproc_arcLength_InputArray")] public static imgproc_arcLength_InputArrayDelegate imgproc_arcLength_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_arcLength_PointDelegate(Point[] curve, int curveLength, int closed);
        [NativeDelegate("imgproc_arcLength_Point")] public static imgproc_arcLength_PointDelegate imgproc_arcLength_Point;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_arcLength_Point2fDelegate(Point2f[] curve, int curveLength, int closed);
        [NativeDelegate("imgproc_arcLength_Point2f")] public static imgproc_arcLength_Point2fDelegate imgproc_arcLength_Point2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Rect imgproc_boundingRect_InputArrayDelegate(IntPtr curve);
        [NativeDelegate("imgproc_boundingRect_InputArray")] public static imgproc_boundingRect_InputArrayDelegate imgproc_boundingRect_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Rect imgproc_boundingRect_PointDelegate(Point[] curve, int curveLength);
        [NativeDelegate("imgproc_boundingRect_Point")] public static imgproc_boundingRect_PointDelegate imgproc_boundingRect_Point;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Rect imgproc_boundingRect_Point2fDelegate(Point2f[] curve, int curveLength);
        [NativeDelegate("imgproc_boundingRect_Point2f")] public static imgproc_boundingRect_Point2fDelegate imgproc_boundingRect_Point2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_contourArea_InputArrayDelegate(IntPtr contour, int oriented);
        [NativeDelegate("imgproc_contourArea_InputArray")] public static imgproc_contourArea_InputArrayDelegate imgproc_contourArea_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_contourArea_PointDelegate(Point[] contour, int contourLength, int oriented);
        [NativeDelegate("imgproc_contourArea_Point")] public static imgproc_contourArea_PointDelegate imgproc_contourArea_Point;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_contourArea_Point2fDelegate(Point2f[] contour, int contourLength, int oriented);
        [NativeDelegate("imgproc_contourArea_Point2f")] public static imgproc_contourArea_Point2fDelegate imgproc_contourArea_Point2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate RotatedRect imgproc_minAreaRect_InputArrayDelegate(IntPtr points);
        [NativeDelegate("imgproc_minAreaRect_InputArray")] public static imgproc_minAreaRect_InputArrayDelegate imgproc_minAreaRect_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate RotatedRect imgproc_minAreaRect_PointDelegate(Point[] points, int pointsLength);
        [NativeDelegate("imgproc_minAreaRect_Point")] public static imgproc_minAreaRect_PointDelegate imgproc_minAreaRect_Point;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate RotatedRect imgproc_minAreaRect_Point2fDelegate(Point2f[] points, int pointsLength);
        [NativeDelegate("imgproc_minAreaRect_Point2f")] public static imgproc_minAreaRect_Point2fDelegate imgproc_minAreaRect_Point2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_minEnclosingCircle_InputArrayDelegate(IntPtr points, out Point2f center, out float radius);
        [NativeDelegate("imgproc_minEnclosingCircle_InputArray")] public static imgproc_minEnclosingCircle_InputArrayDelegate imgproc_minEnclosingCircle_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_minEnclosingCircle_PointDelegate(Point[] points, int pointsLength,
            out Point2f center, out float radius);
        [NativeDelegate("imgproc_minEnclosingCircle_Point")] public static imgproc_minEnclosingCircle_PointDelegate imgproc_minEnclosingCircle_Point;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_minEnclosingCircle_Point2fDelegate(Point2f[] points, int pointsLength,
            out Point2f center, out float radius);
        [NativeDelegate("imgproc_minEnclosingCircle_Point2f")] public static imgproc_minEnclosingCircle_Point2fDelegate imgproc_minEnclosingCircle_Point2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_matchShapes_InputArrayDelegate(IntPtr contour1, IntPtr contour2,
            int method, double parameter);
        [NativeDelegate("imgproc_matchShapes_InputArray")] public static imgproc_matchShapes_InputArrayDelegate imgproc_matchShapes_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_matchShapes_PointDelegate(Point[] contour1, int contour1Length,
            Point[] contour2, int contour2Length, int method, double parameter);
        [NativeDelegate("imgproc_matchShapes_Point")] public static imgproc_matchShapes_PointDelegate imgproc_matchShapes_Point;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_convexHull_InputArrayDelegate(IntPtr points, IntPtr hull,
                                                                int clockwise, int returnPoints);
        [NativeDelegate("imgproc_convexHull_InputArray")] public static imgproc_convexHull_InputArrayDelegate imgproc_convexHull_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_convexHull_Point_ReturnsPointsDelegate(Point[] points, int pointsLength,
            out IntPtr hull, int clockwise);
        [NativeDelegate("imgproc_convexHull_Point_ReturnsPoints")] public static imgproc_convexHull_Point_ReturnsPointsDelegate imgproc_convexHull_Point_ReturnsPoints;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_convexHull_Point2f_ReturnsPointsDelegate(Point2f[] points, int pointsLength,
            out IntPtr hull, int clockwise);
        [NativeDelegate("imgproc_convexHull_Point2f_ReturnsPoints")] public static imgproc_convexHull_Point2f_ReturnsPointsDelegate imgproc_convexHull_Point2f_ReturnsPoints;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_convexHull_Point_ReturnsIndicesDelegate(Point[] points, int pointsLength,
            out IntPtr hull, int clockwise);
        [NativeDelegate("imgproc_convexHull_Point_ReturnsIndices")] public static imgproc_convexHull_Point_ReturnsIndicesDelegate imgproc_convexHull_Point_ReturnsIndices;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_convexHull_Point2f_ReturnsIndicesDelegate(Point2f[] points, int pointsLength,
            out IntPtr hull, int clockwise);
        [NativeDelegate("imgproc_convexHull_Point2f_ReturnsIndices")] public static imgproc_convexHull_Point2f_ReturnsIndicesDelegate imgproc_convexHull_Point2f_ReturnsIndices;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_convexityDefects_InputArrayDelegate(IntPtr contour, IntPtr convexHull,
                                                                      IntPtr convexityDefects);
        [NativeDelegate("imgproc_convexityDefects_InputArray")] public static imgproc_convexityDefects_InputArrayDelegate imgproc_convexityDefects_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_convexityDefects_PointDelegate(Point[] contour, int contourLength, int[] convexHull,
            int convexHullLength, out IntPtr convexityDefects);
        [NativeDelegate("imgproc_convexityDefects_Point")] public static imgproc_convexityDefects_PointDelegate imgproc_convexityDefects_Point;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_convexityDefects_Point2fDelegate(Point2f[] contour, int contourLength,
            int[] convexHull, int convexHullLength, out IntPtr convexityDefects);
        [NativeDelegate("imgproc_convexityDefects_Point2f")] public static imgproc_convexityDefects_Point2fDelegate imgproc_convexityDefects_Point2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_isContourConvex_InputArrayDelegate(IntPtr contour);
        [NativeDelegate("imgproc_isContourConvex_InputArray")] public static imgproc_isContourConvex_InputArrayDelegate imgproc_isContourConvex_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_isContourConvex_PointDelegate(Point[] contour, int contourLength);
        [NativeDelegate("imgproc_isContourConvex_Point")] public static imgproc_isContourConvex_PointDelegate imgproc_isContourConvex_Point;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_isContourConvex_Point2fDelegate(Point2f[] contour, int contourLength);
        [NativeDelegate("imgproc_isContourConvex_Point2f")] public static imgproc_isContourConvex_Point2fDelegate imgproc_isContourConvex_Point2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float imgproc_intersectConvexConvex_InputArrayDelegate(IntPtr p1, IntPtr p2,
                                                                            IntPtr p12, int handleNested);
        [NativeDelegate("imgproc_intersectConvexConvex_InputArray")] public static imgproc_intersectConvexConvex_InputArrayDelegate imgproc_intersectConvexConvex_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float imgproc_intersectConvexConvex_PointDelegate(Point[] p1, int p1Length, Point[] p2,
            int p2Length,out IntPtr p12, int handleNested);
        [NativeDelegate("imgproc_intersectConvexConvex_Point")] public static imgproc_intersectConvexConvex_PointDelegate imgproc_intersectConvexConvex_Point;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float imgproc_intersectConvexConvex_Point2fDelegate(Point2f[] p1, int p1Length, Point2f[] p2,
            int p2Length,out IntPtr p12, int handleNested);
        [NativeDelegate("imgproc_intersectConvexConvex_Point2f")] public static imgproc_intersectConvexConvex_Point2fDelegate imgproc_intersectConvexConvex_Point2f;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate RotatedRect imgproc_fitEllipse_InputArrayDelegate(IntPtr points);
        [NativeDelegate("imgproc_fitEllipse_InputArray")] public static imgproc_fitEllipse_InputArrayDelegate imgproc_fitEllipse_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate RotatedRect imgproc_fitEllipse_PointDelegate(Point[] points, int pointsLength);
        [NativeDelegate("imgproc_fitEllipse_Point")] public static imgproc_fitEllipse_PointDelegate imgproc_fitEllipse_Point;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate RotatedRect imgproc_fitEllipse_Point2fDelegate(Point2f[] points, int pointsLength);
        [NativeDelegate("imgproc_fitEllipse_Point2f")] public static imgproc_fitEllipse_Point2fDelegate imgproc_fitEllipse_Point2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_fitLine_InputArrayDelegate(IntPtr points, IntPtr line,
                                                             int distType, double param, double reps, double aeps);
        [NativeDelegate("imgproc_fitLine_InputArray")] public static imgproc_fitLine_InputArrayDelegate imgproc_fitLine_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_fitLine_PointDelegate(Point[] points, int pointsLength, [In, Out] float[] line, int distType,
            double param, double reps, double aeps);
        [NativeDelegate("imgproc_fitLine_Point")] public static imgproc_fitLine_PointDelegate imgproc_fitLine_Point;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_fitLine_Point2fDelegate(Point2f[] points, int pointsLength, [In, Out] float[] line,
            int distType,double param, double reps, double aeps);
        [NativeDelegate("imgproc_fitLine_Point2f")] public static imgproc_fitLine_Point2fDelegate imgproc_fitLine_Point2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_fitLine_Point3iDelegate(Point3i[] points, int pointsLength, [In, Out] float[] line,
            int distType,double param, double reps, double aeps);
        [NativeDelegate("imgproc_fitLine_Point3i")] public static imgproc_fitLine_Point3iDelegate imgproc_fitLine_Point3i;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_fitLine_Point3fDelegate(Point3f[] points, int pointsLength, [In, Out] float[] line,
            int distType,double param, double reps, double aeps);
        [NativeDelegate("imgproc_fitLine_Point3f")] public static imgproc_fitLine_Point3fDelegate imgproc_fitLine_Point3f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_pointPolygonTest_InputArrayDelegate(IntPtr contour, Point2f pt, int measureDist);
        [NativeDelegate("imgproc_pointPolygonTest_InputArray")] public static imgproc_pointPolygonTest_InputArrayDelegate imgproc_pointPolygonTest_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_pointPolygonTest_PointDelegate(Point[] contour, int contourLength, Point2f pt,
            int measureDist);
        [NativeDelegate("imgproc_pointPolygonTest_Point")] public static imgproc_pointPolygonTest_PointDelegate imgproc_pointPolygonTest_Point;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double imgproc_pointPolygonTest_Point2fDelegate(Point2f[] contour, int contourLength,
            Point2f pt, int measureDist);
        [NativeDelegate("imgproc_pointPolygonTest_Point2f")] public static imgproc_pointPolygonTest_Point2fDelegate imgproc_pointPolygonTest_Point2f;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_rotatedRectangleIntersection_OutputArrayDelegate(
            RotatedRect rect1, RotatedRect rect2, IntPtr intersectingRegion);
        [NativeDelegate("imgproc_rotatedRectangleIntersection_OutputArray")] public static imgproc_rotatedRectangleIntersection_OutputArrayDelegate imgproc_rotatedRectangleIntersection_OutputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_rotatedRectangleIntersection_vectorDelegate(
            RotatedRect rect1, RotatedRect rect2, IntPtr intersectingRegion);
        [NativeDelegate("imgproc_rotatedRectangleIntersection_vector")] public static imgproc_rotatedRectangleIntersection_vectorDelegate imgproc_rotatedRectangleIntersection_vector;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_applyColorMapDelegate(IntPtr src, IntPtr dst, int colormap);
        [NativeDelegate("imgproc_applyColorMap")] public static imgproc_applyColorMapDelegate imgproc_applyColorMap;


        #region Drawing

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_lineDelegate(
            IntPtr img, Point pt1, Point pt2, Scalar color, int thickness, int lineType, int shift);
        [NativeDelegate("imgproc_line")] public static imgproc_lineDelegate imgproc_line;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_arrowedLineDelegate(
            IntPtr img, Point pt1, Point pt2, Scalar color, int thickness, int lineType, int shift, double tipLength);
        [NativeDelegate("imgproc_arrowedLine")] public static imgproc_arrowedLineDelegate imgproc_arrowedLine;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_rectangle_InputOutputArrayDelegate(
            IntPtr img, Point pt1, Point pt2, Scalar color, int thickness, int lineType, int shift);
        [NativeDelegate("imgproc_rectangle_InputOutputArray")] public static imgproc_rectangle_InputOutputArrayDelegate imgproc_rectangle_InputOutputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_rectangle_MatDelegate(
            IntPtr img, Rect rect, Scalar color, int thickness, int lineType, int shift);
        [NativeDelegate("imgproc_rectangle_Mat")] public static imgproc_rectangle_MatDelegate imgproc_rectangle_Mat;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_circleDelegate(IntPtr img, Point center, int radius, Scalar color, int thickness, int lineType, int shift);
        [NativeDelegate("imgproc_circle")] public static imgproc_circleDelegate imgproc_circle;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_ellipse1Delegate(IntPtr img, Point center, Size axes,
            double angle, double startAngle, double endAngle, Scalar color, int thickness, int lineType, int shift);
        [NativeDelegate("imgproc_ellipse1")] public static imgproc_ellipse1Delegate imgproc_ellipse1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_ellipse2Delegate(IntPtr img, RotatedRect box, Scalar color, int thickness, int lineType);
        [NativeDelegate("imgproc_ellipse2")] public static imgproc_ellipse2Delegate imgproc_ellipse2;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_fillConvexPoly_MatDelegate(
            IntPtr img, Point[] pts, int npts, Scalar color, int lineType, int shift);
        [NativeDelegate("imgproc_fillConvexPoly_Mat")] public static imgproc_fillConvexPoly_MatDelegate imgproc_fillConvexPoly_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_fillConvexPoly_InputOutputArrayDelegate(
            IntPtr img, IntPtr points, Scalar color, int lineType, int shift);
        [NativeDelegate("imgproc_fillConvexPoly_InputOutputArray")] public static imgproc_fillConvexPoly_InputOutputArrayDelegate imgproc_fillConvexPoly_InputOutputArray;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_fillPoly_MatDelegate(
            IntPtr img, IntPtr[] pts, int[] npts, int ncontours,
            Scalar color, int lineType, int shift, Point offset);
        [NativeDelegate("imgproc_fillPoly_Mat")] public static imgproc_fillPoly_MatDelegate imgproc_fillPoly_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_fillPoly_InputOutputArrayDelegate(
            IntPtr img, IntPtr pts, Scalar color, int lineType, int shift, Point offset);
        [NativeDelegate("imgproc_fillPoly_InputOutputArray")] public static imgproc_fillPoly_InputOutputArrayDelegate imgproc_fillPoly_InputOutputArray;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_polylines_MatDelegate(
            IntPtr img, IntPtr[] pts, int[] npts,
            int ncontours, int isClosed, Scalar color, int thickness, int lineType, int shift);
        [NativeDelegate("imgproc_polylines_Mat")] public static imgproc_polylines_MatDelegate imgproc_polylines_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_polylines_InputOutputArrayDelegate(
            IntPtr img, IntPtr pts, int isClosed, Scalar color, int thickness, int lineType, int shift);
        [NativeDelegate("imgproc_polylines_InputOutputArray")] public static imgproc_polylines_InputOutputArrayDelegate imgproc_polylines_InputOutputArray;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_clipLine1Delegate(Size imgSize, ref Point pt1, ref Point pt2);
        [NativeDelegate("imgproc_clipLine1")] public static imgproc_clipLine1Delegate imgproc_clipLine1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_clipLine2Delegate(Rect imgRect, ref Point pt1, ref Point pt2);
        [NativeDelegate("imgproc_clipLine2")] public static imgproc_clipLine2Delegate imgproc_clipLine2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_ellipse2PolyDelegate(
            Point center, Size axes, int angle, int arcStart, int arcEnd, int delta, IntPtr pts);
        [NativeDelegate("imgproc_ellipse2Poly")] public static imgproc_ellipse2PolyDelegate imgproc_ellipse2Poly;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_putTextDelegate(IntPtr img, [MarshalAs(UnmanagedType.LPStr)] string text, Point org,
            int fontFace, double fontScale, Scalar color,
            int thickness, int lineType, int bottomLeftOrigin);
        [NativeDelegate("core_putText")] public static core_putTextDelegate core_putText;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size core_getTextSizeDelegate([MarshalAs(UnmanagedType.LPStr)] string text, int fontFace,
            double fontScale, int thickness, out int baseLine);
        [NativeDelegate("core_getTextSize")] public static core_getTextSizeDelegate core_getTextSize;

        #endregion
    }
}
