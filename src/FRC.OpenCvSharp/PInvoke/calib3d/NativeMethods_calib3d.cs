using OpenCvSharp.PInvoke.NativeLibraryUtilties;

using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    // ReSharper disable InconsistentNaming

    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_RodriguesDelegate(IntPtr src, IntPtr dst, IntPtr jacobian);
        [NativeDelegate("calib3d_Rodrigues")] public static calib3d_RodriguesDelegate calib3d_Rodrigues;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_Rodrigues_VecToMatDelegate(IntPtr vector, IntPtr matrix, IntPtr jacobian);
        [NativeDelegate("calib3d_Rodrigues_VecToMat")] public static calib3d_Rodrigues_VecToMatDelegate calib3d_Rodrigues_VecToMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_Rodrigues_MatToVecDelegate(IntPtr vector, IntPtr matrix, IntPtr jacobian);
        [NativeDelegate("calib3d_Rodrigues_MatToVec")] public static calib3d_Rodrigues_MatToVecDelegate calib3d_Rodrigues_MatToVec;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr calib3d_findHomography_InputArrayDelegate(IntPtr srcPoints, IntPtr dstPoints,
            int method, double ransacReprojThreshold, IntPtr mask);
        [NativeDelegate("calib3d_findHomography_InputArray")] public static calib3d_findHomography_InputArrayDelegate calib3d_findHomography_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr calib3d_findHomography_vectorDelegate(Point2d[] srcPoints, int srcPointsLength,
            Point2d[] dstPoints, int dstPointsLength, int method, double ransacReprojThreshold, IntPtr mask);
        [NativeDelegate("calib3d_findHomography_vector")] public static calib3d_findHomography_vectorDelegate calib3d_findHomography_vector;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_RQDecomp3x3_InputArrayDelegate(IntPtr src, IntPtr mtxR,
            IntPtr mtxQ, IntPtr qx, IntPtr qy, IntPtr qz, out Vec3d outVal);
        [NativeDelegate("calib3d_RQDecomp3x3_InputArray")] public static calib3d_RQDecomp3x3_InputArrayDelegate calib3d_RQDecomp3x3_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_RQDecomp3x3_MatDelegate(IntPtr src, IntPtr mtxR, IntPtr mtxQ,
            IntPtr qx, IntPtr qy, IntPtr qz, out Vec3d outVal);
        [NativeDelegate("calib3d_RQDecomp3x3_Mat")] public static calib3d_RQDecomp3x3_MatDelegate calib3d_RQDecomp3x3_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_decomposeProjectionMatrix_InputArrayDelegate(IntPtr projMatrix,
            IntPtr cameraMatrix, IntPtr rotMatrix, IntPtr transVect, IntPtr rotMatrixX,
            IntPtr rotMatrixY, IntPtr rotMatrixZ, IntPtr eulerAngles);
        [NativeDelegate("calib3d_decomposeProjectionMatrix_InputArray")] public static calib3d_decomposeProjectionMatrix_InputArrayDelegate calib3d_decomposeProjectionMatrix_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_decomposeProjectionMatrix_MatDelegate(IntPtr projMatrix,
            IntPtr cameraMatrix, IntPtr rotMatrix, IntPtr transVect, IntPtr rotMatrixX,
            IntPtr rotMatrixY, IntPtr rotMatrixZ, IntPtr eulerAngles);
        [NativeDelegate("calib3d_decomposeProjectionMatrix_Mat")] public static calib3d_decomposeProjectionMatrix_MatDelegate calib3d_decomposeProjectionMatrix_Mat;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_matMulDerivDelegate(IntPtr a, IntPtr b,
                                                      IntPtr dABdA, IntPtr dABdB);
        [NativeDelegate("calib3d_matMulDeriv")] public static calib3d_matMulDerivDelegate calib3d_matMulDeriv;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_composeRT_InputArrayDelegate(IntPtr rvec1, IntPtr tvec1,
                                                               IntPtr rvec2, IntPtr tvec2,
                                                               IntPtr rvec3, IntPtr tvec3,
                                                               IntPtr dr3dr1, IntPtr dr3dt1,
                                                               IntPtr dr3dr2, IntPtr dr3dt2,
                                                               IntPtr dt3dr1, IntPtr dt3dt1,
                                                               IntPtr dt3dr2, IntPtr dt3dt2);
        [NativeDelegate("calib3d_composeRT_InputArray")] public static calib3d_composeRT_InputArrayDelegate calib3d_composeRT_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_composeRT_MatDelegate(IntPtr rvec1, IntPtr tvec1,
                                                        IntPtr rvec2, IntPtr tvec2,
                                                        IntPtr rvec3, IntPtr tvec3,
                                                        IntPtr dr3dr1, IntPtr dr3dt1,
                                                        IntPtr dr3dr2, IntPtr dr3dt2,
                                                        IntPtr dt3dr1, IntPtr dt3dt1,
                                                        IntPtr dt3dr2, IntPtr dt3dt2);
        [NativeDelegate("calib3d_composeRT_Mat")] public static calib3d_composeRT_MatDelegate calib3d_composeRT_Mat;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_projectPoints_InputArrayDelegate(IntPtr objectPoints,
                                                                   IntPtr rvec, IntPtr tvec,
                                                                   IntPtr cameraMatrix, IntPtr distCoeffs,
                                                                   IntPtr imagePoints, IntPtr jacobian,
                                                                   double aspectRatio);
        [NativeDelegate("calib3d_projectPoints_InputArray")] public static calib3d_projectPoints_InputArrayDelegate calib3d_projectPoints_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_projectPoints_MatDelegate(IntPtr objectPoints,
                                                            IntPtr rvec, IntPtr tvec,
                                                            IntPtr cameraMatrix, IntPtr distCoeffs,
                                                            IntPtr imagePoints, IntPtr jacobian,
                                                            double aspectRatio);
        [NativeDelegate("calib3d_projectPoints_Mat")] public static calib3d_projectPoints_MatDelegate calib3d_projectPoints_Mat;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_solvePnP_InputArrayDelegate(IntPtr selfectPoints, IntPtr imagePoints, IntPtr cameraMatrix,
            IntPtr distCoeffs, IntPtr rvec, IntPtr tvec, int useExtrinsicGuess, int flags);
        [NativeDelegate("calib3d_solvePnP_InputArray")] public static calib3d_solvePnP_InputArrayDelegate calib3d_solvePnP_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_solvePnP_vectorDelegate(Point3f[] objectPoints, int objectPointsLength,
                                                          Point2f[] imagePoints, int imagePointsLength,
                                                          double[,] cameraMatrix, double[] distCoeffs, int distCoeffsLength,
                                                          [Out] double[] rvec, [Out] double[] tvec, int useExtrinsicGuess, int flags);
        [NativeDelegate("calib3d_solvePnP_vector")] public static calib3d_solvePnP_vectorDelegate calib3d_solvePnP_vector;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_solvePnPRansac_InputArrayDelegate(IntPtr objectPoints, IntPtr imagePoints,
            IntPtr cameraMatrix, IntPtr distCoeffs, IntPtr rvec, IntPtr tvec,
            int useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence,
            IntPtr inliers, int flags);
        [NativeDelegate("calib3d_solvePnPRansac_InputArray")] public static calib3d_solvePnPRansac_InputArrayDelegate calib3d_solvePnPRansac_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_solvePnPRansac_vectorDelegate(Point3f[] objectPoints, int objectPointsLength,
            Point2f[] imagePoints, int imagePointsLength, double[,] cameraMatrix, double[] distCoeffs, int distCoeffsLength,
            [Out] double[] rvec, [Out] double[] tvec, int useExtrinsicGuess, int iterationsCount, float reprojectionError, 
            double confidence, IntPtr inliers, int flags);
        [NativeDelegate("calib3d_solvePnPRansac_vector")] public static calib3d_solvePnPRansac_vectorDelegate calib3d_solvePnPRansac_vector;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr calib3d_initCameraMatrix2D_MatDelegate(IntPtr[] objectPoints, int objectPointsLength,
            IntPtr[] imagePoints, int imagePointsLength,
            Size imageSize, double aspectRatio);
        [NativeDelegate("calib3d_initCameraMatrix2D_Mat")] public static calib3d_initCameraMatrix2D_MatDelegate calib3d_initCameraMatrix2D_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr calib3d_initCameraMatrix2D_arrayDelegate(IntPtr[] objectPoints, int opSize1, int[] opSize2,
            IntPtr[] imagePoints, int ipSize1, int[] ipSize2,
            Size imageSize, double aspectRatio);
        [NativeDelegate("calib3d_initCameraMatrix2D_array")] public static calib3d_initCameraMatrix2D_arrayDelegate calib3d_initCameraMatrix2D_array;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_findChessboardCorners_InputArrayDelegate(IntPtr image, Size patternSize,
            IntPtr corners, int flags);
        [NativeDelegate("calib3d_findChessboardCorners_InputArray")] public static calib3d_findChessboardCorners_InputArrayDelegate calib3d_findChessboardCorners_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_findChessboardCorners_vectorDelegate(IntPtr image, Size patternSize,
            IntPtr corners, int flags);
        [NativeDelegate("calib3d_findChessboardCorners_vector")] public static calib3d_findChessboardCorners_vectorDelegate calib3d_findChessboardCorners_vector;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_find4QuadCornerSubpix_InputArrayDelegate(IntPtr img, IntPtr corners, Size regionSize);
        [NativeDelegate("calib3d_find4QuadCornerSubpix_InputArray")] public static calib3d_find4QuadCornerSubpix_InputArrayDelegate calib3d_find4QuadCornerSubpix_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_find4QuadCornerSubpix_vectorDelegate(IntPtr img, IntPtr corners, Size regionSize);
        [NativeDelegate("calib3d_find4QuadCornerSubpix_vector")] public static calib3d_find4QuadCornerSubpix_vectorDelegate calib3d_find4QuadCornerSubpix_vector;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_drawChessboardCorners_InputArrayDelegate(IntPtr image, Size patternSize,
            IntPtr corners, int patternWasFound);
        [NativeDelegate("calib3d_drawChessboardCorners_InputArray")] public static calib3d_drawChessboardCorners_InputArrayDelegate calib3d_drawChessboardCorners_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_drawChessboardCorners_arrayDelegate(IntPtr image, Size patternSize,
            Point2f[] corners, int cornersLength, int patternWasFound);
        [NativeDelegate("calib3d_drawChessboardCorners_array")] public static calib3d_drawChessboardCorners_arrayDelegate calib3d_drawChessboardCorners_array;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_findCirclesGrid_InputArrayDelegate(IntPtr image, Size patternSize,
            IntPtr centers, int flags, IntPtr blobDetector);
        [NativeDelegate("calib3d_findCirclesGrid_InputArray")] public static calib3d_findCirclesGrid_InputArrayDelegate calib3d_findCirclesGrid_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_findCirclesGrid_vectorDelegate(IntPtr image, Size patternSize,
            IntPtr centers, int flags, IntPtr blobDetector);
        [NativeDelegate("calib3d_findCirclesGrid_vector")] public static calib3d_findCirclesGrid_vectorDelegate calib3d_findCirclesGrid_vector;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double calib3d_calibrateCamera_InputArrayDelegate(
            IntPtr[] objectPoints, int objectPointsSize,
            IntPtr[] imagePoints, int imagePointsSize,
            Size imageSize,
            IntPtr cameraMatrix,IntPtr distCoeffs,
            IntPtr rvecs, IntPtr tvecs,
            int flags, TermCriteria criteria);
        [NativeDelegate("calib3d_calibrateCamera_InputArray")] public static calib3d_calibrateCamera_InputArrayDelegate calib3d_calibrateCamera_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double calib3d_calibrateCamera_vectorDelegate(
            IntPtr[] objectPoints, int opSize1, int[] opSize2,
            IntPtr[] imagePoints, int ipSize1, int[] ipSize2,
            Size imageSize,
            [In, Out] double[,] cameraMatrix,
            [In, Out] double[] distCoeffs, int distCoeffsSize,
            IntPtr rvecs, IntPtr tvecs,
            int flags, TermCriteria criteria);
        [NativeDelegate("calib3d_calibrateCamera_vector")] public static calib3d_calibrateCamera_vectorDelegate calib3d_calibrateCamera_vector;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_calibrationMatrixValues_InputArrayDelegate(
            IntPtr cameraMatrix,
            Size imageSize, double apertureWidth, double apertureHeight, out double fovx, out double fovy,
            out double focalLength, out Point2d principalPoint, out double aspectRatio);
        [NativeDelegate("calib3d_calibrationMatrixValues_InputArray")] public static calib3d_calibrationMatrixValues_InputArrayDelegate calib3d_calibrationMatrixValues_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_calibrationMatrixValues_arrayDelegate(
            double[,] cameraMatrix, Size imageSize,
            double apertureWidth, double apertureHeight, out double fovx, out double fovy, out double focalLength,
            out Point2d principalPoint, out double aspectRatio);
        [NativeDelegate("calib3d_calibrationMatrixValues_array")] public static calib3d_calibrationMatrixValues_arrayDelegate calib3d_calibrationMatrixValues_array;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double calib3d_stereoCalibrate_InputArrayDelegate(
            IntPtr[] objectPoints, int opSize,
            IntPtr[] imagePoints1, int ip1Size,
            IntPtr[] imagePoints2, int ip2Size,
            IntPtr cameraMatrix1,
            IntPtr distCoeffs1,
            IntPtr cameraMatrix2,
            IntPtr distCoeffs2,
            Size imageSize,
            IntPtr R, IntPtr T,
            IntPtr E, IntPtr F,
            int flags, TermCriteria criteria);
        [NativeDelegate("calib3d_stereoCalibrate_InputArray")] public static calib3d_stereoCalibrate_InputArrayDelegate calib3d_stereoCalibrate_InputArray;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double calib3d_stereoCalibrate_arrayDelegate(
            IntPtr[] objectPoints, int opSize1, int[] opSizes2,
            IntPtr[] imagePoints1, int ip1Size1, int[] ip1Sizes2,
            IntPtr[] imagePoints2, int ip2Size1, int[] ip2Sizes2,
            [In, Out] double[,] cameraMatrix1,
            [In, Out] double[] distCoeffs1, int dc1Size,
            [In, Out] double[,] cameraMatrix2,
            [In, Out] double[] distCoeffs2, int dc2Size,
            Size imageSize,
            IntPtr R, IntPtr T,
            IntPtr E, IntPtr F,
            int flags, TermCriteria criteria);
        [NativeDelegate("calib3d_stereoCalibrate_array")] public static calib3d_stereoCalibrate_arrayDelegate calib3d_stereoCalibrate_array;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_stereoRectify_InputArrayDelegate(
            IntPtr cameraMatrix1, IntPtr distCoeffs1,
            IntPtr cameraMatrix2, IntPtr distCoeffs2,
            Size imageSize, IntPtr R, IntPtr T,
            IntPtr R1, IntPtr R2,
            IntPtr P1, IntPtr P2,
            IntPtr Q, int flags,
            double alpha, Size newImageSize,
            out Rect validPixROI1, out Rect validPixROI2);
        [NativeDelegate("calib3d_stereoRectify_InputArray")] public static calib3d_stereoRectify_InputArrayDelegate calib3d_stereoRectify_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_stereoRectify_arrayDelegate(
            double[,] cameraMatrix1,
            double[] distCoeffs1, int dc1Size,
            double[,] cameraMatrix2,
            double[] distCoeffs2, int dc2Size,
            Size imageSize,
            double[,] R, double[] T,
            double[,] R1, double[,] R2, double[,] P1, double[,] P2,
            double[,] Q, int flags, double alpha, Size newImageSize,
            out Rect validPixROI1, out Rect validPixROI2);
        [NativeDelegate("calib3d_stereoRectify_array")] public static calib3d_stereoRectify_arrayDelegate calib3d_stereoRectify_array;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_stereoRectifyUncalibrated_InputArrayDelegate(
            IntPtr points1, IntPtr points2,
            IntPtr F, Size imgSize,
            IntPtr H1, IntPtr H2,
            double threshold);
        [NativeDelegate("calib3d_stereoRectifyUncalibrated_InputArray")] public static calib3d_stereoRectifyUncalibrated_InputArrayDelegate calib3d_stereoRectifyUncalibrated_InputArray;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_stereoRectifyUncalibrated_arrayDelegate(
            Point2d[] points1, int points1Size,
            Point2d[] points2, int points2Size,
            [In] double[,] F, Size imgSize,
            [In, Out] double[,] H1, [In, Out] double[,] H2,
            double threshold);
        [NativeDelegate("calib3d_stereoRectifyUncalibrated_array")] public static calib3d_stereoRectifyUncalibrated_arrayDelegate calib3d_stereoRectifyUncalibrated_array;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float calib3d_rectify3Collinear_InputArrayDelegate(
            IntPtr cameraMatrix1, IntPtr distCoeffs1,
            IntPtr cameraMatrix2, IntPtr distCoeffs2,
            IntPtr cameraMatrix3, IntPtr distCoeffs3,
            IntPtr[] imgpt1, int imgpt1Size,
            IntPtr[] imgpt3, int imgpt3Size,
            Size imageSize, IntPtr R12, IntPtr T12,
            IntPtr R13, IntPtr T13,
            IntPtr R1, IntPtr R2, IntPtr R3,
            IntPtr P1, IntPtr P2, IntPtr P3,
            IntPtr Q, double alpha, Size newImgSize,
            out Rect roi1, out Rect roi2, int flags);
        [NativeDelegate("calib3d_rectify3Collinear_InputArray")] public static calib3d_rectify3Collinear_InputArrayDelegate calib3d_rectify3Collinear_InputArray;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr calib3d_getOptimalNewCameraMatrix_InputArrayDelegate(
            IntPtr cameraMatrix, IntPtr distCoeffs,
            Size imageSize, double alpha, Size newImgSize,
            out Rect validPixROI, int centerPrincipalPoint);
        [NativeDelegate("calib3d_getOptimalNewCameraMatrix_InputArray")] public static calib3d_getOptimalNewCameraMatrix_InputArrayDelegate calib3d_getOptimalNewCameraMatrix_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_getOptimalNewCameraMatrix_arrayDelegate(
            [In] double[,] cameraMatrix,
            [In] double[] distCoeffs, int distCoeffsSize,
            Size imageSize, double alpha, Size newImgSize,
            out Rect validPixROI, int centerPrincipalPoint,
            [In, Out] double[,] outValues);
        [NativeDelegate("calib3d_getOptimalNewCameraMatrix_array")] public static calib3d_getOptimalNewCameraMatrix_arrayDelegate calib3d_getOptimalNewCameraMatrix_array;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_convertPointsToHomogeneous_InputArrayDelegate(
            IntPtr src, IntPtr dst);
        [NativeDelegate("calib3d_convertPointsToHomogeneous_InputArray")] public static calib3d_convertPointsToHomogeneous_InputArrayDelegate calib3d_convertPointsToHomogeneous_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_convertPointsToHomogeneous_array1Delegate(
            [In] Vec2f[] src, [In, Out] Vec3f[] dst, int length);
        [NativeDelegate("calib3d_convertPointsToHomogeneous_array1")] public static calib3d_convertPointsToHomogeneous_array1Delegate calib3d_convertPointsToHomogeneous_array1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_convertPointsToHomogeneous_array2Delegate(
            [In] Vec3f[] src, [In, Out] Vec4f[] dst, int length);
        [NativeDelegate("calib3d_convertPointsToHomogeneous_array2")] public static calib3d_convertPointsToHomogeneous_array2Delegate calib3d_convertPointsToHomogeneous_array2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_convertPointsFromHomogeneous_InputArrayDelegate(
            IntPtr src, IntPtr dst);
        [NativeDelegate("calib3d_convertPointsFromHomogeneous_InputArray")] public static calib3d_convertPointsFromHomogeneous_InputArrayDelegate calib3d_convertPointsFromHomogeneous_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_convertPointsFromHomogeneous_array1Delegate(
            [In] Vec3f[] src, [In, Out] Vec2f[] dst, int length);
        [NativeDelegate("calib3d_convertPointsFromHomogeneous_array1")] public static calib3d_convertPointsFromHomogeneous_array1Delegate calib3d_convertPointsFromHomogeneous_array1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_convertPointsFromHomogeneous_array2Delegate(
            [In] Vec4f[] src, [In, Out] Vec3f[] dst, int length);
        [NativeDelegate("calib3d_convertPointsFromHomogeneous_array2")] public static calib3d_convertPointsFromHomogeneous_array2Delegate calib3d_convertPointsFromHomogeneous_array2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_convertPointsHomogeneousDelegate(
            IntPtr src, IntPtr dst);
        [NativeDelegate("calib3d_convertPointsHomogeneous")] public static calib3d_convertPointsHomogeneousDelegate calib3d_convertPointsHomogeneous;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr calib3d_findFundamentalMat_InputArrayDelegate(
            IntPtr points1, IntPtr points2,
            int method, double param1, double param2, IntPtr mask);
        [NativeDelegate("calib3d_findFundamentalMat_InputArray")] public static calib3d_findFundamentalMat_InputArrayDelegate calib3d_findFundamentalMat_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr calib3d_findFundamentalMat_arrayDelegate(
            Point2d[] points1, int points1Size,
            Point2d[] points2, int points2Size,
            int method, double param1, double param2, IntPtr mask);
        [NativeDelegate("calib3d_findFundamentalMat_array")] public static calib3d_findFundamentalMat_arrayDelegate calib3d_findFundamentalMat_array;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_computeCorrespondEpilines_InputArrayDelegate(
            IntPtr points, int whichImage, IntPtr F, IntPtr lines);
        [NativeDelegate("calib3d_computeCorrespondEpilines_InputArray")] public static calib3d_computeCorrespondEpilines_InputArrayDelegate calib3d_computeCorrespondEpilines_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_computeCorrespondEpilines_array2dDelegate(
            [In] Point2d[] points, int pointsSize,
            int whichImage, double[,] F, [In, Out] Point3f[] lines);
        [NativeDelegate("calib3d_computeCorrespondEpilines_array2d")] public static calib3d_computeCorrespondEpilines_array2dDelegate calib3d_computeCorrespondEpilines_array2d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_computeCorrespondEpilines_array3dDelegate(
            [In] Point3d[] points, int pointsSize,
            int whichImage, double[,] F, [In, Out] Point3f[] lines);
        [NativeDelegate("calib3d_computeCorrespondEpilines_array3d")] public static calib3d_computeCorrespondEpilines_array3dDelegate calib3d_computeCorrespondEpilines_array3d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_triangulatePoints_InputArrayDelegate(
            IntPtr projMatr1, IntPtr projMatr2,
            IntPtr projPoints1, IntPtr projPoints2,
            IntPtr points4D);
        [NativeDelegate("calib3d_triangulatePoints_InputArray")] public static calib3d_triangulatePoints_InputArrayDelegate calib3d_triangulatePoints_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_triangulatePoints_arrayDelegate(
            [In] double[,] projMatr1, [In] double[,] projMatr2,
            [In] Point2d[] projPoints1, int projPoints1Size,
            [In] Point2d[] projPoints2, int projPoints2Size,
            [In, Out] Vec4d[] points4D);
        [NativeDelegate("calib3d_triangulatePoints_array")] public static calib3d_triangulatePoints_arrayDelegate calib3d_triangulatePoints_array;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_correctMatches_InputArrayDelegate(
            IntPtr F, IntPtr points1, IntPtr points2,
            IntPtr newPoints1, IntPtr newPoints2);
        [NativeDelegate("calib3d_correctMatches_InputArray")] public static calib3d_correctMatches_InputArrayDelegate calib3d_correctMatches_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_correctMatches_arrayDelegate(
            double[,] F, Point2d[] points1, int points1Size,
            Point2d[] points2, int points2Size,
            Point2d[] newPoints1, Point2d[] newPoints2);
        [NativeDelegate("calib3d_correctMatches_array")] public static calib3d_correctMatches_arrayDelegate calib3d_correctMatches_array;

        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_filterSpecklesDelegate(IntPtr img, double newVal, int maxSpeckleSize,
            double maxDiff, IntPtr buf);
        [NativeDelegate("calib3d_filterSpeckles")] public static calib3d_filterSpecklesDelegate calib3d_filterSpeckles;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Rect calib3d_getValidDisparityROIDelegate(Rect roi1, Rect roi2,
            int minDisparity, int numberOfDisparities, int SADWindowSize);
        [NativeDelegate("calib3d_getValidDisparityROI")] public static calib3d_getValidDisparityROIDelegate calib3d_getValidDisparityROI;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_validateDisparityDelegate(IntPtr disparity, IntPtr cost,
            int minDisparity, int numberOfDisparities, int disp12MaxDisp);
        [NativeDelegate("calib3d_validateDisparity")] public static calib3d_validateDisparityDelegate calib3d_validateDisparity;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void calib3d_reprojectImageTo3DDelegate(IntPtr disparity, IntPtr _3dImage,
            IntPtr Q, int handleMissingValues, int ddepth);
        [NativeDelegate("calib3d_reprojectImageTo3D")] public static calib3d_reprojectImageTo3DDelegate calib3d_reprojectImageTo3D;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int calib3d_estimateAffine3DDelegate(IntPtr src, IntPtr dst,
            IntPtr outVal, IntPtr inliers, double ransacThreshold, double confidence);
        [NativeDelegate("calib3d_estimateAffine3D")] public static calib3d_estimateAffine3DDelegate calib3d_estimateAffine3D;
    }
}
