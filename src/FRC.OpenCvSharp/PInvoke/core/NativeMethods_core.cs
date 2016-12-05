using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;
using System.Text;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        #region Miscellaneous
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_setNumThreadsDelegate(int nthreads);
        [NativeDelegate("core_setNumThreads")] public static core_setNumThreadsDelegate core_setNumThreads;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_getNumThreadsDelegate();
        [NativeDelegate("core_getNumThreads")] public static core_getNumThreadsDelegate core_getNumThreads;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_getThreadNumDelegate();
        [NativeDelegate("core_getThreadNum")] public static core_getThreadNumDelegate core_getThreadNum;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_getBuildInformationDelegate([MarshalAs(UnmanagedType.LPStr)] StringBuilder buf, int maxLength);
        [NativeDelegate("core_getBuildInformation")] public static core_getBuildInformationDelegate core_getBuildInformation;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_getBuildInformation_lengthDelegate();
        [NativeDelegate("core_getBuildInformation_length")] public static core_getBuildInformation_lengthDelegate core_getBuildInformation_length;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate long core_getTickCountDelegate();
        [NativeDelegate("core_getTickCount")] public static core_getTickCountDelegate core_getTickCount;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double core_getTickFrequencyDelegate();
        [NativeDelegate("core_getTickFrequency")] public static core_getTickFrequencyDelegate core_getTickFrequency;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate long core_getCPUTickCountDelegate();
        [NativeDelegate("core_getCPUTickCount")] public static core_getCPUTickCountDelegate core_getCPUTickCount;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_checkHardwareSupportDelegate(int feature);
        [NativeDelegate("core_checkHardwareSupport")] public static core_checkHardwareSupportDelegate core_checkHardwareSupport;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_getNumberOfCPUsDelegate();
        [NativeDelegate("core_getNumberOfCPUs")] public static core_getNumberOfCPUsDelegate core_getNumberOfCPUs;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_fastMallocDelegate(IntPtr bufSize);
        [NativeDelegate("core_fastMalloc")] public static core_fastMallocDelegate core_fastMalloc;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_fastFreeDelegate(IntPtr ptr);
        [NativeDelegate("core_fastFree")] public static core_fastFreeDelegate core_fastFree;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_setUseOptimizedDelegate(int onoff);
        [NativeDelegate("core_setUseOptimized")] public static core_setUseOptimizedDelegate core_setUseOptimized;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_useOptimizedDelegate();
        [NativeDelegate("core_useOptimized")] public static core_useOptimizedDelegate core_useOptimized;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr redirectErrorDelegate(CvErrorCallback errCallback, IntPtr userdata, ref IntPtr prevUserdata);
        [NativeDelegate("redirectError")] public static redirectErrorDelegate redirectError;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_cvarrToMatDelegate(IntPtr arr, int copyData, int allowND, int coiMode);
        [NativeDelegate("core_cvarrToMat")] public static core_cvarrToMatDelegate core_cvarrToMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_extractImageCOIDelegate(IntPtr arr, IntPtr coiimg, int coi);
        [NativeDelegate("core_extractImageCOI")] public static core_extractImageCOIDelegate core_extractImageCOI;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_insertImageCOIDelegate(IntPtr coiimg, IntPtr arr, int coi);
        [NativeDelegate("core_insertImageCOI")] public static core_insertImageCOIDelegate core_insertImageCOI;
        #endregion

        #region Array Operations

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_addDelegate(IntPtr src1, IntPtr src2, IntPtr dst, IntPtr mask, int dtype);
        [NativeDelegate("core_add")] public static core_addDelegate core_add;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_subtractDelegate(IntPtr src1, IntPtr src2, IntPtr dst, IntPtr mask, int dtype);
        [NativeDelegate("core_subtract")] public static core_subtractDelegate core_subtract;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_multiplyDelegate(IntPtr src1, IntPtr src2, IntPtr dst, double scale, int dtype);
        [NativeDelegate("core_multiply")] public static core_multiplyDelegate core_multiply;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_divide1Delegate(double scale, IntPtr src2, IntPtr dst, int dtype);
        [NativeDelegate("core_divide1")] public static core_divide1Delegate core_divide1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_divide2Delegate(IntPtr src1, IntPtr src2, IntPtr dst, double scale, int dtype);
        [NativeDelegate("core_divide2")] public static core_divide2Delegate core_divide2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_scaleAddDelegate(IntPtr src1, double alpha, IntPtr src2,IntPtr dst);
        [NativeDelegate("core_scaleAdd")] public static core_scaleAddDelegate core_scaleAdd;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_addWeightedDelegate(IntPtr src1, double alpha, IntPtr src2,
            double beta, double gamma, IntPtr dst, int dtype);
        [NativeDelegate("core_addWeighted")] public static core_addWeightedDelegate core_addWeighted;

        #endregion


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_convertScaleAbsDelegate(IntPtr src, IntPtr dst, double alpha, double beta);
        [NativeDelegate("core_convertScaleAbs")] public static core_convertScaleAbsDelegate core_convertScaleAbs;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_LUTDelegate(IntPtr src, IntPtr lut, IntPtr dst);
        [NativeDelegate("core_LUT")] public static core_LUTDelegate core_LUT;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Scalar core_sumDelegate(IntPtr src);
        [NativeDelegate("core_sum")] public static core_sumDelegate core_sum;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_countNonZeroDelegate(IntPtr src);
        [NativeDelegate("core_countNonZero")] public static core_countNonZeroDelegate core_countNonZero;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_findNonZeroDelegate(IntPtr src, IntPtr idx);
        [NativeDelegate("core_findNonZero")] public static core_findNonZeroDelegate core_findNonZero;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Scalar core_meanDelegate(IntPtr src, IntPtr mask);
        [NativeDelegate("core_mean")] public static core_meanDelegate core_mean;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_meanStdDev_OutputArrayDelegate(
            IntPtr src, IntPtr mean, IntPtr stddev, IntPtr mask);
        [NativeDelegate("core_meanStdDev_OutputArray")] public static core_meanStdDev_OutputArrayDelegate core_meanStdDev_OutputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_meanStdDev_ScalarDelegate(
            IntPtr src, out Scalar mean, out Scalar stddev, IntPtr mask);
        [NativeDelegate("core_meanStdDev_Scalar")] public static core_meanStdDev_ScalarDelegate core_meanStdDev_Scalar;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double core_norm1Delegate(IntPtr src1, int normType, IntPtr mask);
        [NativeDelegate("core_norm1")] public static core_norm1Delegate core_norm1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double core_norm2Delegate(IntPtr src1, IntPtr src2,
                                               int normType, IntPtr mask);
        [NativeDelegate("core_norm2")] public static core_norm2Delegate core_norm2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_batchDistanceDelegate(IntPtr src1, IntPtr src2,
                                                     IntPtr dist, int dtype, IntPtr nidx,
                                                     int normType, int k, IntPtr mask,
                                                     int update, int crosscheck);
        [NativeDelegate("core_batchDistance")] public static core_batchDistanceDelegate core_batchDistance;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_normalizeDelegate(IntPtr src, IntPtr dst, double alpha, double beta,
                             int normType, int dtype, IntPtr mask);
        [NativeDelegate("core_normalize")] public static core_normalizeDelegate core_normalize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_minMaxLoc1Delegate(IntPtr src, out double minVal, out double maxVal);
        [NativeDelegate("core_minMaxLoc1")] public static core_minMaxLoc1Delegate core_minMaxLoc1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_minMaxLoc2Delegate(IntPtr src, out double minVal, out double maxVal,
            out Point minLoc, out Point maxLoc, IntPtr mask);
        [NativeDelegate("core_minMaxLoc2")] public static core_minMaxLoc2Delegate core_minMaxLoc2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_minMaxIdx1Delegate(IntPtr src, out double minVal, out double maxVal);
        [NativeDelegate("core_minMaxIdx1")] public static core_minMaxIdx1Delegate core_minMaxIdx1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_minMaxIdx2Delegate(IntPtr src, out double minVal, out double maxVal,
            out int minIdx, out int maxIdx, IntPtr mask);
        [NativeDelegate("core_minMaxIdx2")] public static core_minMaxIdx2Delegate core_minMaxIdx2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_reduceDelegate(IntPtr src, IntPtr dst, int dim, int rtype, int dtype);
        [NativeDelegate("core_reduce")] public static core_reduceDelegate core_reduce;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_mergeDelegate([MarshalAs(UnmanagedType.LPArray)] IntPtr[] mv, uint count, IntPtr dst);
        [NativeDelegate("core_merge")] public static core_mergeDelegate core_merge;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_splitDelegate(IntPtr src, out IntPtr mv);
        [NativeDelegate("core_split")] public static core_splitDelegate core_split;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_mixChannelsDelegate(IntPtr[] src, uint nsrcs,
            IntPtr[] dst, uint ndsts, int[] fromTo, uint npairs);
        [NativeDelegate("core_mixChannels")] public static core_mixChannelsDelegate core_mixChannels;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_extractChannelDelegate(IntPtr src, IntPtr dst, int coi);
        [NativeDelegate("core_extractChannel")] public static core_extractChannelDelegate core_extractChannel;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_insertChannelDelegate(IntPtr src, IntPtr dst, int coi);
        [NativeDelegate("core_insertChannel")] public static core_insertChannelDelegate core_insertChannel;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_flipDelegate(IntPtr src, IntPtr dst, int flipCode);
        [NativeDelegate("core_flip")] public static core_flipDelegate core_flip;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_repeat1Delegate(IntPtr src, int ny, int nx, IntPtr dst);
        [NativeDelegate("core_repeat1")] public static core_repeat1Delegate core_repeat1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr core_repeat2Delegate(IntPtr src, int ny, int nx);
        [NativeDelegate("core_repeat2")] public static core_repeat2Delegate core_repeat2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_hconcat1Delegate([MarshalAs(UnmanagedType.LPArray)] IntPtr[] src, uint nsrc, IntPtr dst);
        [NativeDelegate("core_hconcat1")] public static core_hconcat1Delegate core_hconcat1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_hconcat2Delegate(IntPtr src1, IntPtr src2, IntPtr dst);
        [NativeDelegate("core_hconcat2")] public static core_hconcat2Delegate core_hconcat2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_vconcat1Delegate([MarshalAs(UnmanagedType.LPArray)] IntPtr[] src, uint nsrc, IntPtr dst);
        [NativeDelegate("core_vconcat1")] public static core_vconcat1Delegate core_vconcat1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_vconcat2Delegate(IntPtr src1, IntPtr src2, IntPtr dst);
        [NativeDelegate("core_vconcat2")] public static core_vconcat2Delegate core_vconcat2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_bitwise_andDelegate(IntPtr src1, IntPtr src2, IntPtr dst, IntPtr mask);
        [NativeDelegate("core_bitwise_and")] public static core_bitwise_andDelegate core_bitwise_and;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_bitwise_orDelegate(IntPtr src1, IntPtr src2, IntPtr dst, IntPtr mask);
        [NativeDelegate("core_bitwise_or")] public static core_bitwise_orDelegate core_bitwise_or;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_bitwise_xorDelegate(IntPtr src1, IntPtr src2, IntPtr dst, IntPtr mask);
        [NativeDelegate("core_bitwise_xor")] public static core_bitwise_xorDelegate core_bitwise_xor;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_bitwise_notDelegate(IntPtr src, IntPtr dst, IntPtr mask);
        [NativeDelegate("core_bitwise_not")] public static core_bitwise_notDelegate core_bitwise_not;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_absdiffDelegate(IntPtr src1, IntPtr src2, IntPtr dst);
        [NativeDelegate("core_absdiff")] public static core_absdiffDelegate core_absdiff;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_inRange_InputArrayDelegate(IntPtr src, IntPtr lowerb, IntPtr upperb, IntPtr dst);
        [NativeDelegate("core_inRange_InputArray")] public static core_inRange_InputArrayDelegate core_inRange_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_inRange_ScalarDelegate(IntPtr src, Scalar lowerb, Scalar upperb, IntPtr dst);
        [NativeDelegate("core_inRange_Scalar")] public static core_inRange_ScalarDelegate core_inRange_Scalar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_compareDelegate(IntPtr src1, IntPtr src2, IntPtr dst, int cmpop);
        [NativeDelegate("core_compare")] public static core_compareDelegate core_compare;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_min1Delegate(IntPtr src1, IntPtr src2, IntPtr dst);
        [NativeDelegate("core_min1")] public static core_min1Delegate core_min1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_max1Delegate(IntPtr src1, IntPtr src2, IntPtr dst);
        [NativeDelegate("core_max1")] public static core_max1Delegate core_max1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_min_MatMatDelegate(IntPtr src1, IntPtr src2, IntPtr dst);
        [NativeDelegate("core_min_MatMat")] public static core_min_MatMatDelegate core_min_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_min_MatDoubleDelegate(IntPtr src1, double src2, IntPtr dst);
        [NativeDelegate("core_min_MatDouble")] public static core_min_MatDoubleDelegate core_min_MatDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_max_MatMatDelegate(IntPtr src1, IntPtr src2, IntPtr dst);
        [NativeDelegate("core_max_MatMat")] public static core_max_MatMatDelegate core_max_MatMat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_max_MatDoubleDelegate(IntPtr src1, double src2, IntPtr dst);
        [NativeDelegate("core_max_MatDouble")] public static core_max_MatDoubleDelegate core_max_MatDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_sqrtDelegate(IntPtr src, IntPtr dst);
        [NativeDelegate("core_sqrt")] public static core_sqrtDelegate core_sqrt;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_pow_MatDelegate(IntPtr src, double power, IntPtr dst);
        [NativeDelegate("core_pow_Mat")] public static core_pow_MatDelegate core_pow_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_exp_MatDelegate(IntPtr src, IntPtr dst);
        [NativeDelegate("core_exp_Mat")] public static core_exp_MatDelegate core_exp_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_log_MatDelegate(IntPtr src, IntPtr dst);
        [NativeDelegate("core_log_Mat")] public static core_log_MatDelegate core_log_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float core_cubeRootDelegate(float val);
        [NativeDelegate("core_cubeRoot")] public static core_cubeRootDelegate core_cubeRoot;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float core_fastAtan2Delegate(float y, float x);
        [NativeDelegate("core_fastAtan2")] public static core_fastAtan2Delegate core_fastAtan2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_polarToCartDelegate(IntPtr magnitude, IntPtr angle, IntPtr x, IntPtr y, int angleInDegrees);
        [NativeDelegate("core_polarToCart")] public static core_polarToCartDelegate core_polarToCart;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_cartToPolarDelegate(IntPtr x, IntPtr y, IntPtr magnitude, IntPtr angle, int angleInDegrees);
        [NativeDelegate("core_cartToPolar")] public static core_cartToPolarDelegate core_cartToPolar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_phaseDelegate(IntPtr x, IntPtr y, IntPtr angle, int angleInDegrees);
        [NativeDelegate("core_phase")] public static core_phaseDelegate core_phase;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_magnitude_MatDelegate(IntPtr x, IntPtr y, IntPtr magnitude);
        [NativeDelegate("core_magnitude_Mat")] public static core_magnitude_MatDelegate core_magnitude_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_checkRangeDelegate(IntPtr a, int quiet, out Point pos, double minVal, double maxVal);
        [NativeDelegate("core_checkRange")] public static core_checkRangeDelegate core_checkRange;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_patchNaNsDelegate(IntPtr a, double val);
        [NativeDelegate("core_patchNaNs")] public static core_patchNaNsDelegate core_patchNaNs;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_gemmDelegate(IntPtr src1, IntPtr src2, double alpha, IntPtr src3, double gamma, IntPtr dst, int flags);
        [NativeDelegate("core_gemm")] public static core_gemmDelegate core_gemm;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_mulTransposedDelegate(IntPtr src, IntPtr dst, int aTa, IntPtr delta, double scale, int dtype);
        [NativeDelegate("core_mulTransposed")] public static core_mulTransposedDelegate core_mulTransposed;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_transposeDelegate(IntPtr src, IntPtr dst);
        [NativeDelegate("core_transpose")] public static core_transposeDelegate core_transpose;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_transformDelegate(IntPtr src, IntPtr dst, IntPtr m);
        [NativeDelegate("core_transform")] public static core_transformDelegate core_transform;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_perspectiveTransformDelegate(IntPtr src, IntPtr dst, IntPtr m);
        [NativeDelegate("core_perspectiveTransform")] public static core_perspectiveTransformDelegate core_perspectiveTransform;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_perspectiveTransform_MatDelegate(IntPtr src, IntPtr dst, IntPtr m);
        [NativeDelegate("core_perspectiveTransform_Mat")] public static core_perspectiveTransform_MatDelegate core_perspectiveTransform_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_perspectiveTransform_Point2fDelegate(IntPtr src, int srcLength, IntPtr dst, int dstLength, IntPtr m);
        [NativeDelegate("core_perspectiveTransform_Point2f")] public static core_perspectiveTransform_Point2fDelegate core_perspectiveTransform_Point2f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_perspectiveTransform_Point2dDelegate(IntPtr src, int srcLength, IntPtr dst, int dstLength, IntPtr m);
        [NativeDelegate("core_perspectiveTransform_Point2d")] public static core_perspectiveTransform_Point2dDelegate core_perspectiveTransform_Point2d;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_perspectiveTransform_Point3fDelegate(IntPtr src, int srcLength, IntPtr dst, int dstLength, IntPtr m);
        [NativeDelegate("core_perspectiveTransform_Point3f")] public static core_perspectiveTransform_Point3fDelegate core_perspectiveTransform_Point3f;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_perspectiveTransform_Point3dDelegate(IntPtr src, int srcLength, IntPtr dst, int dstLength, IntPtr m);
        [NativeDelegate("core_perspectiveTransform_Point3d")] public static core_perspectiveTransform_Point3dDelegate core_perspectiveTransform_Point3d;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_completeSymmDelegate(IntPtr mtx, int lowerToUpper);
        [NativeDelegate("core_completeSymm")] public static core_completeSymmDelegate core_completeSymm;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_setIdentityDelegate(IntPtr mtx, Scalar s);
        [NativeDelegate("core_setIdentity")] public static core_setIdentityDelegate core_setIdentity;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double core_determinantDelegate(IntPtr mtx);
        [NativeDelegate("core_determinant")] public static core_determinantDelegate core_determinant;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Scalar core_traceDelegate(IntPtr mtx);
        [NativeDelegate("core_trace")] public static core_traceDelegate core_trace;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double core_invertDelegate(IntPtr src, IntPtr dst, int flags);
        [NativeDelegate("core_invert")] public static core_invertDelegate core_invert;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_solveDelegate(IntPtr src1, IntPtr src2, IntPtr dst, int flags);
        [NativeDelegate("core_solve")] public static core_solveDelegate core_solve;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_sortDelegate(IntPtr src, IntPtr dst, int flags);
        [NativeDelegate("core_sort")] public static core_sortDelegate core_sort;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_sortIdxDelegate(IntPtr src, IntPtr dst, int flags);
        [NativeDelegate("core_sortIdx")] public static core_sortIdxDelegate core_sortIdx;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_solveCubicDelegate(IntPtr coeffs, IntPtr roots);
        [NativeDelegate("core_solveCubic")] public static core_solveCubicDelegate core_solveCubic;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double core_solvePolyDelegate(IntPtr coeffs, IntPtr roots, int maxIters);
        [NativeDelegate("core_solvePoly")] public static core_solvePolyDelegate core_solvePoly;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_eigenDelegate(IntPtr src, IntPtr eigenvalues, IntPtr eigenvectors);
        [NativeDelegate("core_eigen")] public static core_eigenDelegate core_eigen;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_calcCovarMatrix_MatDelegate([MarshalAs(UnmanagedType.LPArray)] IntPtr[] samples,
            int nsamples, IntPtr covar, IntPtr mean, int flags, int ctype);
        [NativeDelegate("core_calcCovarMatrix_Mat")] public static core_calcCovarMatrix_MatDelegate core_calcCovarMatrix_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_calcCovarMatrix_InputArrayDelegate(IntPtr samples, IntPtr covar,
            IntPtr mean, int flags, int ctype);
        [NativeDelegate("core_calcCovarMatrix_InputArray")] public static core_calcCovarMatrix_InputArrayDelegate core_calcCovarMatrix_InputArray;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_PCAComputeDelegate(IntPtr data, IntPtr mean, IntPtr eigenvectors, int maxComponents);
        [NativeDelegate("core_PCACompute")] public static core_PCAComputeDelegate core_PCACompute;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_PCAComputeVarDelegate(IntPtr data, IntPtr mean, IntPtr eigenvectors, double retainedVariance);
        [NativeDelegate("core_PCAComputeVar")] public static core_PCAComputeVarDelegate core_PCAComputeVar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_PCAProjectDelegate(IntPtr data, IntPtr mean, IntPtr eigenvectors, IntPtr result);
        [NativeDelegate("core_PCAProject")] public static core_PCAProjectDelegate core_PCAProject;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_PCABackProjectDelegate(IntPtr data, IntPtr mean, IntPtr eigenvectors, IntPtr result);
        [NativeDelegate("core_PCABackProject")] public static core_PCABackProjectDelegate core_PCABackProject;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SVDecompDelegate(IntPtr src, IntPtr w, IntPtr u, IntPtr vt, int flags);
        [NativeDelegate("core_SVDecomp")] public static core_SVDecompDelegate core_SVDecomp;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_SVBackSubstDelegate(IntPtr w, IntPtr u, IntPtr vt, IntPtr rhs, IntPtr dst);
        [NativeDelegate("core_SVBackSubst")] public static core_SVBackSubstDelegate core_SVBackSubst;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double core_MahalanobisDelegate(IntPtr v1, IntPtr v2, IntPtr icovar);
        [NativeDelegate("core_Mahalanobis")] public static core_MahalanobisDelegate core_Mahalanobis;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_dftDelegate(IntPtr src, IntPtr dst, int flags, int nonzeroRows);
        [NativeDelegate("core_dft")] public static core_dftDelegate core_dft;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_idftDelegate(IntPtr src, IntPtr dst, int flags, int nonzeroRows);
        [NativeDelegate("core_idft")] public static core_idftDelegate core_idft;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_dctDelegate(IntPtr src, IntPtr dst, int flags);
        [NativeDelegate("core_dct")] public static core_dctDelegate core_dct;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_idctDelegate(IntPtr src, IntPtr dst, int flags);
        [NativeDelegate("core_idct")] public static core_idctDelegate core_idct;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_mulSpectrumsDelegate(IntPtr a, IntPtr b, IntPtr c, int flags, int conjB);
        [NativeDelegate("core_mulSpectrums")] public static core_mulSpectrumsDelegate core_mulSpectrums;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_getOptimalDFTSizeDelegate(int vecsize);
        [NativeDelegate("core_getOptimalDFTSize")] public static core_getOptimalDFTSizeDelegate core_getOptimalDFTSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double core_kmeansDelegate(IntPtr data, int k, IntPtr bestLabels,
            TermCriteria criteria, int attempts, int flags, IntPtr centers);
        [NativeDelegate("core_kmeans")] public static core_kmeansDelegate core_kmeans;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong core_theRNGDelegate();
        [NativeDelegate("core_theRNG")] public static core_theRNGDelegate core_theRNG;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_randu_InputArrayDelegate(IntPtr dst, IntPtr low, IntPtr high);
        [NativeDelegate("core_randu_InputArray")] public static core_randu_InputArrayDelegate core_randu_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_randu_ScalarDelegate(IntPtr dst, Scalar low, Scalar high);
        [NativeDelegate("core_randu_Scalar")] public static core_randu_ScalarDelegate core_randu_Scalar;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_randn_InputArrayDelegate(IntPtr dst, IntPtr mean, IntPtr stddev);
        [NativeDelegate("core_randn_InputArray")] public static core_randn_InputArrayDelegate core_randn_InputArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_randn_ScalarDelegate(IntPtr dst, Scalar mean, Scalar stddev);
        [NativeDelegate("core_randn_Scalar")] public static core_randn_ScalarDelegate core_randn_Scalar;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_randShuffleDelegate(IntPtr dst, double iterFactor, ref ulong rng);
        [NativeDelegate("core_randShuffle")] public static core_randShuffleDelegate core_randShuffle;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_randShuffleDelegate2(IntPtr dst, double iterFactor, IntPtr rng);
        [NativeDelegate("core_randShuffle")] public static core_randShuffleDelegate2 core_randShuffle2;
    }
}
