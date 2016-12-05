using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;
using System.Text;

#pragma warning disable 1591

namespace OpenCvSharp
{
    // ReSharper disable InconsistentNaming

    partial class NativeMethods
    {
        #region Device
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_getCudaEnabledDeviceCountDelegate();
        [NativeDelegate("cuda_getCudaEnabledDeviceCount")] public static cuda_getCudaEnabledDeviceCountDelegate cuda_getCudaEnabledDeviceCount;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_setDeviceDelegate(int device);
        [NativeDelegate("cuda_setDevice")] public static cuda_setDeviceDelegate cuda_setDevice;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_getDeviceDelegate();
        [NativeDelegate("cuda_getDevice")] public static cuda_getDeviceDelegate cuda_getDevice;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_resetDeviceDelegate();
        [NativeDelegate("cuda_resetDevice")] public static cuda_resetDeviceDelegate cuda_resetDevice;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_deviceSupportsDelegate(int feature_set);
        [NativeDelegate("cuda_deviceSupports")] public static cuda_deviceSupportsDelegate cuda_deviceSupports;

        // TargetArchs
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_TargetArchs_builtWithDelegate(int feature_set);
        [NativeDelegate("cuda_TargetArchs_builtWith")] public static cuda_TargetArchs_builtWithDelegate cuda_TargetArchs_builtWith;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_TargetArchs_hasDelegate(int major, int minor);
        [NativeDelegate("cuda_TargetArchs_has")] public static cuda_TargetArchs_hasDelegate cuda_TargetArchs_has;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_TargetArchs_hasPtxDelegate(int major, int minor);
        [NativeDelegate("cuda_TargetArchs_hasPtx")] public static cuda_TargetArchs_hasPtxDelegate cuda_TargetArchs_hasPtx;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_TargetArchs_hasBinDelegate(int major, int minor);
        [NativeDelegate("cuda_TargetArchs_hasBin")] public static cuda_TargetArchs_hasBinDelegate cuda_TargetArchs_hasBin;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_TargetArchs_hasEqualOrLessPtxDelegate(int major, int minor);
        [NativeDelegate("cuda_TargetArchs_hasEqualOrLessPtx")] public static cuda_TargetArchs_hasEqualOrLessPtxDelegate cuda_TargetArchs_hasEqualOrLessPtx;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_TargetArchs_hasEqualOrGreaterDelegate(int major, int minor);
        [NativeDelegate("cuda_TargetArchs_hasEqualOrGreater")] public static cuda_TargetArchs_hasEqualOrGreaterDelegate cuda_TargetArchs_hasEqualOrGreater;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_TargetArchs_hasEqualOrGreaterPtxDelegate(int major, int minor);
        [NativeDelegate("cuda_TargetArchs_hasEqualOrGreaterPtx")] public static cuda_TargetArchs_hasEqualOrGreaterPtxDelegate cuda_TargetArchs_hasEqualOrGreaterPtx;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_TargetArchs_hasEqualOrGreaterBinDelegate(int major, int minor);
        [NativeDelegate("cuda_TargetArchs_hasEqualOrGreaterBin")] public static cuda_TargetArchs_hasEqualOrGreaterBinDelegate cuda_TargetArchs_hasEqualOrGreaterBin;

        // DeviceInfo
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_DeviceInfo_new1Delegate();
        [NativeDelegate("cuda_DeviceInfo_new1")] public static cuda_DeviceInfo_new1Delegate cuda_DeviceInfo_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_DeviceInfo_new2Delegate(int deviceId);
        [NativeDelegate("cuda_DeviceInfo_new2")] public static cuda_DeviceInfo_new2Delegate cuda_DeviceInfo_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_DeviceInfo_deleteDelegate(IntPtr obj);
        [NativeDelegate("cuda_DeviceInfo_delete")] public static cuda_DeviceInfo_deleteDelegate cuda_DeviceInfo_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_DeviceInfo_nameDelegate(
            IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] StringBuilder buf, int bufLength);
        [NativeDelegate("cuda_DeviceInfo_name")] public static cuda_DeviceInfo_nameDelegate cuda_DeviceInfo_name;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_DeviceInfo_majorVersionDelegate(IntPtr obj);
        [NativeDelegate("cuda_DeviceInfo_majorVersion")] public static cuda_DeviceInfo_majorVersionDelegate cuda_DeviceInfo_majorVersion;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_DeviceInfo_minorVersionDelegate(IntPtr obj);
        [NativeDelegate("cuda_DeviceInfo_minorVersion")] public static cuda_DeviceInfo_minorVersionDelegate cuda_DeviceInfo_minorVersion;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_DeviceInfo_multiProcessorCountDelegate(IntPtr obj);
        [NativeDelegate("cuda_DeviceInfo_multiProcessorCount")] public static cuda_DeviceInfo_multiProcessorCountDelegate cuda_DeviceInfo_multiProcessorCount;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong cuda_DeviceInfo_sharedMemPerBlockDelegate(IntPtr obj);
        [NativeDelegate("cuda_DeviceInfo_sharedMemPerBlock")] public static cuda_DeviceInfo_sharedMemPerBlockDelegate cuda_DeviceInfo_sharedMemPerBlock;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_DeviceInfo_queryMemoryDelegate(
            IntPtr obj, out ulong totalMemory, out ulong freeMemory);
        [NativeDelegate("cuda_DeviceInfo_queryMemory")] public static cuda_DeviceInfo_queryMemoryDelegate cuda_DeviceInfo_queryMemory;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong cuda_DeviceInfo_freeMemoryDelegate(IntPtr obj);
        [NativeDelegate("cuda_DeviceInfo_freeMemory")] public static cuda_DeviceInfo_freeMemoryDelegate cuda_DeviceInfo_freeMemory;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong cuda_DeviceInfo_totalMemoryDelegate(IntPtr obj);
        [NativeDelegate("cuda_DeviceInfo_totalMemory")] public static cuda_DeviceInfo_totalMemoryDelegate cuda_DeviceInfo_totalMemory;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_DeviceInfo_supportsDelegate(IntPtr obj, int featureSet);
        [NativeDelegate("cuda_DeviceInfo_supports")] public static cuda_DeviceInfo_supportsDelegate cuda_DeviceInfo_supports;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_DeviceInfo_isCompatibleDelegate(IntPtr obj);
        [NativeDelegate("cuda_DeviceInfo_isCompatible")] public static cuda_DeviceInfo_isCompatibleDelegate cuda_DeviceInfo_isCompatible;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_DeviceInfo_deviceIDDelegate(IntPtr obj);
        [NativeDelegate("cuda_DeviceInfo_deviceID")] public static cuda_DeviceInfo_deviceIDDelegate cuda_DeviceInfo_deviceID;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_DeviceInfo_canMapHostMemoryDelegate(IntPtr obj);
        [NativeDelegate("cuda_DeviceInfo_canMapHostMemory")] public static cuda_DeviceInfo_canMapHostMemoryDelegate cuda_DeviceInfo_canMapHostMemory;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_printCudaDeviceInfoDelegate(int device);
        [NativeDelegate("cuda_printCudaDeviceInfo")] public static cuda_printCudaDeviceInfoDelegate cuda_printCudaDeviceInfo;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_printShortCudaDeviceInfoDelegate(int device);
        [NativeDelegate("cuda_printShortCudaDeviceInfo")] public static cuda_printShortCudaDeviceInfoDelegate cuda_printShortCudaDeviceInfo;
        #endregion

        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_registerPageLockedDelegate(IntPtr m);
        [NativeDelegate("cuda_registerPageLocked")] public static cuda_registerPageLockedDelegate cuda_registerPageLocked;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_unregisterPageLockedDelegate(IntPtr m);
        [NativeDelegate("cuda_unregisterPageLocked")] public static cuda_unregisterPageLockedDelegate cuda_unregisterPageLocked;
        */

        #region Stream

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_Stream_new1Delegate();
        [NativeDelegate("cuda_Stream_new1")] public static cuda_Stream_new1Delegate cuda_Stream_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_Stream_new2Delegate(IntPtr s);
        [NativeDelegate("cuda_Stream_new2")] public static cuda_Stream_new2Delegate cuda_Stream_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_Stream_deleteDelegate(IntPtr obj);
        [NativeDelegate("cuda_Stream_delete")] public static cuda_Stream_deleteDelegate cuda_Stream_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_Stream_opAssignDelegate(IntPtr left, IntPtr right);
        [NativeDelegate("cuda_Stream_opAssign")] public static cuda_Stream_opAssignDelegate cuda_Stream_opAssign;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_Stream_queryIfCompleteDelegate(IntPtr obj);
        [NativeDelegate("cuda_Stream_queryIfComplete")] public static cuda_Stream_queryIfCompleteDelegate cuda_Stream_queryIfComplete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_Stream_waitForCompletionDelegate(IntPtr obj);
        [NativeDelegate("cuda_Stream_waitForCompletion")] public static cuda_Stream_waitForCompletionDelegate cuda_Stream_waitForCompletion;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_Stream_enqueueDownload_CudaMemDelegate(IntPtr obj, IntPtr src, IntPtr dst);
        [NativeDelegate("cuda_Stream_enqueueDownload_CudaMem")] public static cuda_Stream_enqueueDownload_CudaMemDelegate cuda_Stream_enqueueDownload_CudaMem;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_Stream_enqueueDownload_MatDelegate(IntPtr obj, IntPtr src, IntPtr dst);
        [NativeDelegate("cuda_Stream_enqueueDownload_Mat")] public static cuda_Stream_enqueueDownload_MatDelegate cuda_Stream_enqueueDownload_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_Stream_enqueueUpload_CudaMemDelegate(IntPtr obj, IntPtr src, IntPtr dst);
        [NativeDelegate("cuda_Stream_enqueueUpload_CudaMem")] public static cuda_Stream_enqueueUpload_CudaMemDelegate cuda_Stream_enqueueUpload_CudaMem;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_Stream_enqueueUpload_MatDelegate(IntPtr obj, IntPtr src, IntPtr dst);
        [NativeDelegate("cuda_Stream_enqueueUpload_Mat")] public static cuda_Stream_enqueueUpload_MatDelegate cuda_Stream_enqueueUpload_Mat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_Stream_enqueueCopyDelegate(IntPtr obj, IntPtr src, IntPtr dst);
        [NativeDelegate("cuda_Stream_enqueueCopy")] public static cuda_Stream_enqueueCopyDelegate cuda_Stream_enqueueCopy;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_Stream_enqueueMemSetDelegate(IntPtr obj, IntPtr src, Scalar val);
        [NativeDelegate("cuda_Stream_enqueueMemSet")] public static cuda_Stream_enqueueMemSetDelegate cuda_Stream_enqueueMemSet;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_Stream_enqueueMemSet_WithMaskDelegate(IntPtr obj, IntPtr src, Scalar val, IntPtr mask);
        [NativeDelegate("cuda_Stream_enqueueMemSet_WithMask")] public static cuda_Stream_enqueueMemSet_WithMaskDelegate cuda_Stream_enqueueMemSet_WithMask;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_Stream_enqueueConvertDelegate(
            IntPtr obj, IntPtr src, IntPtr dst, int dtype, double a, double b);
        [NativeDelegate("cuda_Stream_enqueueConvert")] public static cuda_Stream_enqueueConvertDelegate cuda_Stream_enqueueConvert;
        */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_Stream_enqueueHostCallbackDelegate(
            IntPtr obj, IntPtr callback, IntPtr userData);
        [NativeDelegate("cuda_Stream_enqueueHostCallback")] public static cuda_Stream_enqueueHostCallbackDelegate cuda_Stream_enqueueHostCallback;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_Stream_NullDelegate();
        [NativeDelegate("cuda_Stream_Null")] public static cuda_Stream_NullDelegate cuda_Stream_Null;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_Stream_boolDelegate(IntPtr obj);
        [NativeDelegate("cuda_Stream_bool")] public static cuda_Stream_boolDelegate cuda_Stream_bool;

        #endregion
        /*
        #region CascadeClassifier_GPU

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_CascadeClassifier_GPU_deleteDelegate(IntPtr obj);
        [NativeDelegate("cuda_CascadeClassifier_GPU_delete")] public static cuda_CascadeClassifier_GPU_deleteDelegate cuda_CascadeClassifier_GPU_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_CascadeClassifier_GPU_new1Delegate();
        [NativeDelegate("cuda_CascadeClassifier_GPU_new1")] public static cuda_CascadeClassifier_GPU_new1Delegate cuda_CascadeClassifier_GPU_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_CascadeClassifier_GPU_new2Delegate(string filename);
        [NativeDelegate("cuda_CascadeClassifier_GPU_new2")] public static cuda_CascadeClassifier_GPU_new2Delegate cuda_CascadeClassifier_GPU_new2;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_CascadeClassifier_GPU_emptyDelegate(IntPtr obj);
        [NativeDelegate("cuda_CascadeClassifier_GPU_empty")] public static cuda_CascadeClassifier_GPU_emptyDelegate cuda_CascadeClassifier_GPU_empty;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_CascadeClassifier_GPU_loadDelegate(IntPtr obj, string filename);
        [NativeDelegate("cuda_CascadeClassifier_GPU_load")] public static cuda_CascadeClassifier_GPU_loadDelegate cuda_CascadeClassifier_GPU_load;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_CascadeClassifier_GPU_releaseDelegate(IntPtr obj);
        [NativeDelegate("cuda_CascadeClassifier_GPU_release")] public static cuda_CascadeClassifier_GPU_releaseDelegate cuda_CascadeClassifier_GPU_release;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_CascadeClassifier_GPU_detectMultiScale1Delegate(IntPtr obj,
            IntPtr image, IntPtr objectsBuf, double scaleFactor, int minNeighbors, Size minSize);
        [NativeDelegate("cuda_CascadeClassifier_GPU_detectMultiScale1")] public static cuda_CascadeClassifier_GPU_detectMultiScale1Delegate cuda_CascadeClassifier_GPU_detectMultiScale1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_CascadeClassifier_GPU_detectMultiScale2Delegate(IntPtr obj,
            IntPtr image, IntPtr objectsBuf, Size maxObjectSize, Size minSize, double scaleFactor,
            int minNeighbors);
        [NativeDelegate("cuda_CascadeClassifier_GPU_detectMultiScale2")] public static cuda_CascadeClassifier_GPU_detectMultiScale2Delegate cuda_CascadeClassifier_GPU_detectMultiScale2;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_CascadeClassifier_GPU_findLargestObject_getDelegate(IntPtr obj);
        [NativeDelegate("cuda_CascadeClassifier_GPU_findLargestObject_get")] public static cuda_CascadeClassifier_GPU_findLargestObject_getDelegate cuda_CascadeClassifier_GPU_findLargestObject_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_CascadeClassifier_GPU_findLargestObject_setDelegate(IntPtr obj, int value);
        [NativeDelegate("cuda_CascadeClassifier_GPU_findLargestObject_set")] public static cuda_CascadeClassifier_GPU_findLargestObject_setDelegate cuda_CascadeClassifier_GPU_findLargestObject_set;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_CascadeClassifier_GPU_visualizeInPlace_getDelegate(IntPtr obj);
        [NativeDelegate("cuda_CascadeClassifier_GPU_visualizeInPlace_get")] public static cuda_CascadeClassifier_GPU_visualizeInPlace_getDelegate cuda_CascadeClassifier_GPU_visualizeInPlace_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_CascadeClassifier_GPU_visualizeInPlace_setDelegate(IntPtr obj, int value);
        [NativeDelegate("cuda_CascadeClassifier_GPU_visualizeInPlace_set")] public static cuda_CascadeClassifier_GPU_visualizeInPlace_setDelegate cuda_CascadeClassifier_GPU_visualizeInPlace_set;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size cuda_CascadeClassifier_GPU_getClassifierSizeDelegate(IntPtr obj);
        [NativeDelegate("cuda_CascadeClassifier_GPU_getClassifierSize")] public static cuda_CascadeClassifier_GPU_getClassifierSizeDelegate cuda_CascadeClassifier_GPU_getClassifierSize;
        
        #endregion

        #region HogDescriptor
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int HOGDescriptor_sizeofDelegate();
        [NativeDelegate("HOGDescriptor_sizeof")] public static HOGDescriptor_sizeofDelegate HOGDescriptor_sizeof;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr HOGDescriptor_newDelegate(Size win_size, Size block_size, Size block_stride, Size cell_size,
	        int nbins, double winSigma, double threshold_L2Hys, bool gamma_correction, int nlevels);
        [NativeDelegate("HOGDescriptor_new")] public static HOGDescriptor_newDelegate HOGDescriptor_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void HOGDescriptor_deleteDelegate(IntPtr obj);
        [NativeDelegate("HOGDescriptor_delete")] public static HOGDescriptor_deleteDelegate HOGDescriptor_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong HOGDescriptor_getDescriptorSizeDelegate(IntPtr obj);
        [NativeDelegate("HOGDescriptor_getDescriptorSize")] public static HOGDescriptor_getDescriptorSizeDelegate HOGDescriptor_getDescriptorSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong HOGDescriptor_getBlockHistogramSizeDelegate(IntPtr obj);
        [NativeDelegate("HOGDescriptor_getBlockHistogramSize")] public static HOGDescriptor_getBlockHistogramSizeDelegate HOGDescriptor_getBlockHistogramSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int HOGDescriptor_checkDetectorSizeDelegate(IntPtr obj);
        [NativeDelegate("HOGDescriptor_checkDetectorSize")] public static HOGDescriptor_checkDetectorSizeDelegate HOGDescriptor_checkDetectorSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double HOGDescriptor_getWinSigmaDelegate(IntPtr obj);
        [NativeDelegate("HOGDescriptor_getWinSigma")] public static HOGDescriptor_getWinSigmaDelegate HOGDescriptor_getWinSigma;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void HOGDescriptor_setSVMDetectorDelegate(IntPtr obj, IntPtr svmdetector);
        [NativeDelegate("HOGDescriptor_setSVMDetector")] public static HOGDescriptor_setSVMDetectorDelegate HOGDescriptor_setSVMDetector;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void HOGDescriptor_detectDelegate(IntPtr obj, IntPtr img, IntPtr found_locations, double hit_threshold, Size win_stride, Size padding);
        [NativeDelegate("HOGDescriptor_detect")] public static HOGDescriptor_detectDelegate HOGDescriptor_detect;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void HOGDescriptor_detectMultiScaleDelegate(IntPtr obj, IntPtr img, IntPtr found_locations,
										           double hit_threshold, Size win_stride, Size padding, double scale, int group_threshold);
        [NativeDelegate("HOGDescriptor_detectMultiScale")] public static HOGDescriptor_detectMultiScaleDelegate HOGDescriptor_detectMultiScale;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void HOGDescriptor_getDescriptorsDelegate(IntPtr obj, IntPtr img, Size win_stride, IntPtr descriptors, [MarshalAs(UnmanagedType.I4)] Gpu.DescriptorFormat descr_format);
        [NativeDelegate("HOGDescriptor_getDescriptors")] public static HOGDescriptor_getDescriptorsDelegate HOGDescriptor_getDescriptors;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size HOGDescriptor_win_size_getDelegate(IntPtr obj);
        [NativeDelegate("HOGDescriptor_win_size_get")] public static HOGDescriptor_win_size_getDelegate HOGDescriptor_win_size_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size HOGDescriptor_block_size_getDelegate(IntPtr obj);
        [NativeDelegate("HOGDescriptor_block_size_get")] public static HOGDescriptor_block_size_getDelegate HOGDescriptor_block_size_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size HOGDescriptor_block_stride_getDelegate(IntPtr obj);
        [NativeDelegate("HOGDescriptor_block_stride_get")] public static HOGDescriptor_block_stride_getDelegate HOGDescriptor_block_stride_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Size HOGDescriptor_cell_size_getDelegate(IntPtr obj);
        [NativeDelegate("HOGDescriptor_cell_size_get")] public static HOGDescriptor_cell_size_getDelegate HOGDescriptor_cell_size_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int HOGDescriptor_nbins_getDelegate(IntPtr obj);
        [NativeDelegate("HOGDescriptor_nbins_get")] public static HOGDescriptor_nbins_getDelegate HOGDescriptor_nbins_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double HOGDescriptor_win_sigma_getDelegate(IntPtr obj);
        [NativeDelegate("HOGDescriptor_win_sigma_get")] public static HOGDescriptor_win_sigma_getDelegate HOGDescriptor_win_sigma_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double HOGDescriptor_threshold_L2hys_getDelegate(IntPtr obj);
        [NativeDelegate("HOGDescriptor_threshold_L2hys_get")] public static HOGDescriptor_threshold_L2hys_getDelegate HOGDescriptor_threshold_L2hys_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int HOGDescriptor_nlevels_getDelegate(IntPtr obj);
        [NativeDelegate("HOGDescriptor_nlevels_get")] public static HOGDescriptor_nlevels_getDelegate HOGDescriptor_nlevels_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int HOGDescriptor_gamma_correction_getDelegate(IntPtr obj);
        [NativeDelegate("HOGDescriptor_gamma_correction_get")] public static HOGDescriptor_gamma_correction_getDelegate HOGDescriptor_gamma_correction_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void HOGDescriptor_win_size_setDelegate(IntPtr obj, Size value);
        [NativeDelegate("HOGDescriptor_win_size_set")] public static HOGDescriptor_win_size_setDelegate HOGDescriptor_win_size_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void HOGDescriptor_block_size_setDelegate(IntPtr obj, Size value);
        [NativeDelegate("HOGDescriptor_block_size_set")] public static HOGDescriptor_block_size_setDelegate HOGDescriptor_block_size_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void HOGDescriptor_block_stride_setDelegate(IntPtr obj, Size value);
        [NativeDelegate("HOGDescriptor_block_stride_set")] public static HOGDescriptor_block_stride_setDelegate HOGDescriptor_block_stride_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void HOGDescriptor_cell_size_setDelegate(IntPtr obj, Size value);
        [NativeDelegate("HOGDescriptor_cell_size_set")] public static HOGDescriptor_cell_size_setDelegate HOGDescriptor_cell_size_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void HOGDescriptor_nbins_setDelegate(IntPtr obj, int value);
        [NativeDelegate("HOGDescriptor_nbins_set")] public static HOGDescriptor_nbins_setDelegate HOGDescriptor_nbins_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void HOGDescriptor_win_sigma_setDelegate(IntPtr obj, double value);
        [NativeDelegate("HOGDescriptor_win_sigma_set")] public static HOGDescriptor_win_sigma_setDelegate HOGDescriptor_win_sigma_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void HOGDescriptor_threshold_L2hys_setDelegate(IntPtr obj, double value);
        [NativeDelegate("HOGDescriptor_threshold_L2hys_set")] public static HOGDescriptor_threshold_L2hys_setDelegate HOGDescriptor_threshold_L2hys_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void HOGDescriptor_nlevels_setDelegate(IntPtr obj, int value);
        [NativeDelegate("HOGDescriptor_nlevels_set")] public static HOGDescriptor_nlevels_setDelegate HOGDescriptor_nlevels_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void HOGDescriptor_gamma_correction_setDelegate(IntPtr obj, int value);
        [NativeDelegate("HOGDescriptor_gamma_correction_set")] public static HOGDescriptor_gamma_correction_setDelegate HOGDescriptor_gamma_correction_set;
        #endregion

        #region MOG_GPU
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_MOG_GPU_deleteDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG_GPU_delete")] public static cuda_MOG_GPU_deleteDelegate cuda_MOG_GPU_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_MOG_GPU_newDelegate(int nmixtures);
        [NativeDelegate("cuda_MOG_GPU_new")] public static cuda_MOG_GPU_newDelegate cuda_MOG_GPU_new;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_MOG_GPU_initializeDelegate(
            IntPtr obj, Size frameSize, int frameType);
        [NativeDelegate("cuda_MOG_GPU_initialize")] public static cuda_MOG_GPU_initializeDelegate cuda_MOG_GPU_initialize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_MOG_GPU_operatorDelegate(
            IntPtr obj, IntPtr frame, IntPtr fgmask, float learningRate, IntPtr stream);
        [NativeDelegate("cuda_MOG_GPU_operator")] public static cuda_MOG_GPU_operatorDelegate cuda_MOG_GPU_operator;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_MOG_GPU_getBackgroundImageDelegate(
            IntPtr obj, IntPtr backgroundImage, IntPtr stream);
        [NativeDelegate("cuda_MOG_GPU_getBackgroundImage")] public static cuda_MOG_GPU_getBackgroundImageDelegate cuda_MOG_GPU_getBackgroundImage;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_MOG_GPU_releaseDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG_GPU_release")] public static cuda_MOG_GPU_releaseDelegate cuda_MOG_GPU_release;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int* cuda_MOG_GPU_historyDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG_GPU_history")] public static cuda_MOG_GPU_historyDelegate cuda_MOG_GPU_history;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* cuda_MOG_GPU_varThresholdDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG_GPU_varThreshold")] public static cuda_MOG_GPU_varThresholdDelegate cuda_MOG_GPU_varThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* cuda_MOG_GPU_backgroundRatioDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG_GPU_backgroundRatio")] public static cuda_MOG_GPU_backgroundRatioDelegate cuda_MOG_GPU_backgroundRatio;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* cuda_MOG_GPU_noiseSigmaDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG_GPU_noiseSigma")] public static cuda_MOG_GPU_noiseSigmaDelegate cuda_MOG_GPU_noiseSigma;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_MOG2_GPU_deleteDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG2_GPU_delete")] public static cuda_MOG2_GPU_deleteDelegate cuda_MOG2_GPU_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_MOG2_GPU_newDelegate(int nmixtures);
        [NativeDelegate("cuda_MOG2_GPU_new")] public static cuda_MOG2_GPU_newDelegate cuda_MOG2_GPU_new;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_MOG2_GPU_initializeDelegate(
            IntPtr obj, Size frameSize, int frameType);
        [NativeDelegate("cuda_MOG2_GPU_initialize")] public static cuda_MOG2_GPU_initializeDelegate cuda_MOG2_GPU_initialize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_MOG2_GPU_operatorDelegate(
            IntPtr obj, IntPtr frame, IntPtr fgmask, float learningRate, IntPtr stream);
        [NativeDelegate("cuda_MOG2_GPU_operator")] public static cuda_MOG2_GPU_operatorDelegate cuda_MOG2_GPU_operator;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_MOG2_GPU_getBackgroundImageDelegate(
            IntPtr obj, IntPtr backgroundImage, IntPtr stream);
        [NativeDelegate("cuda_MOG2_GPU_getBackgroundImage")] public static cuda_MOG2_GPU_getBackgroundImageDelegate cuda_MOG2_GPU_getBackgroundImage;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_MOG2_GPU_releaseDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG2_GPU_release")] public static cuda_MOG2_GPU_releaseDelegate cuda_MOG2_GPU_release;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int* cuda_MOG2_GPU_historyDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG2_GPU_history")] public static cuda_MOG2_GPU_historyDelegate cuda_MOG2_GPU_history;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* cuda_MOG2_GPU_varThresholdDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG2_GPU_varThreshold")] public static cuda_MOG2_GPU_varThresholdDelegate cuda_MOG2_GPU_varThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* cuda_MOG2_GPU_backgroundRatioDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG2_GPU_backgroundRatio")] public static cuda_MOG2_GPU_backgroundRatioDelegate cuda_MOG2_GPU_backgroundRatio;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* cuda_MOG2_GPU_varThresholdGenDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG2_GPU_varThresholdGen")] public static cuda_MOG2_GPU_varThresholdGenDelegate cuda_MOG2_GPU_varThresholdGen;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* cuda_MOG2_GPU_fVarInitDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG2_GPU_fVarInit")] public static cuda_MOG2_GPU_fVarInitDelegate cuda_MOG2_GPU_fVarInit;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* cuda_MOG2_GPU_fVarMinDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG2_GPU_fVarMin")] public static cuda_MOG2_GPU_fVarMinDelegate cuda_MOG2_GPU_fVarMin;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* cuda_MOG2_GPU_fVarMaxDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG2_GPU_fVarMax")] public static cuda_MOG2_GPU_fVarMaxDelegate cuda_MOG2_GPU_fVarMax;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* cuda_MOG2_GPU_fCTDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG2_GPU_fCT")] public static cuda_MOG2_GPU_fCTDelegate cuda_MOG2_GPU_fCT;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_MOG2_GPU_bShadowDetection_getDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG2_GPU_bShadowDetection_get")] public static cuda_MOG2_GPU_bShadowDetection_getDelegate cuda_MOG2_GPU_bShadowDetection_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_MOG2_GPU_bShadowDetection_setDelegate(IntPtr obj, int value);
        [NativeDelegate("cuda_MOG2_GPU_bShadowDetection_set")] public static cuda_MOG2_GPU_bShadowDetection_setDelegate cuda_MOG2_GPU_bShadowDetection_set;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate byte* cuda_MOG2_GPU_nShadowDetectionDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG2_GPU_nShadowDetection")] public static cuda_MOG2_GPU_nShadowDetectionDelegate cuda_MOG2_GPU_nShadowDetection;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* cuda_MOG2_GPU_fTauDelegate(IntPtr obj);
        [NativeDelegate("cuda_MOG2_GPU_fTau")] public static cuda_MOG2_GPU_fTauDelegate cuda_MOG2_GPU_fTau;

        #endregion

        #region StereoBM_GPU
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_StereoBM_GPU_new1Delegate();
        [NativeDelegate("cuda_StereoBM_GPU_new1")] public static cuda_StereoBM_GPU_new1Delegate cuda_StereoBM_GPU_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr cuda_StereoBM_GPU_new2Delegate(int preset, int ndisparities, int winSize);
        [NativeDelegate("cuda_StereoBM_GPU_new2")] public static cuda_StereoBM_GPU_new2Delegate cuda_StereoBM_GPU_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_StereoBM_GPU_deleteDelegate(IntPtr obj);
        [NativeDelegate("cuda_StereoBM_GPU_delete")] public static cuda_StereoBM_GPU_deleteDelegate cuda_StereoBM_GPU_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_StereoBM_GPU_run1Delegate(IntPtr obj, IntPtr left, IntPtr right, IntPtr disparity);
        [NativeDelegate("cuda_StereoBM_GPU_run1")] public static cuda_StereoBM_GPU_run1Delegate cuda_StereoBM_GPU_run1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void cuda_StereoBM_GPU_run2Delegate(IntPtr obj, IntPtr left, IntPtr right, IntPtr disparity, IntPtr stream);
        [NativeDelegate("cuda_StereoBM_GPU_run2")] public static cuda_StereoBM_GPU_run2Delegate cuda_StereoBM_GPU_run2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int cuda_StereoBM_GPU_checkIfGpuCallReasonableDelegate();
        [NativeDelegate("cuda_StereoBM_GPU_checkIfGpuCallReasonable")] public static cuda_StereoBM_GPU_checkIfGpuCallReasonableDelegate cuda_StereoBM_GPU_checkIfGpuCallReasonable;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int* cuda_StereoBM_GPU_presetDelegate(IntPtr obj);
        [NativeDelegate("cuda_StereoBM_GPU_preset")] public static cuda_StereoBM_GPU_presetDelegate cuda_StereoBM_GPU_preset;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int* cuda_StereoBM_GPU_ndispDelegate(IntPtr obj);
        [NativeDelegate("cuda_StereoBM_GPU_ndisp")] public static cuda_StereoBM_GPU_ndispDelegate cuda_StereoBM_GPU_ndisp;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int* cuda_StereoBM_GPU_winSizeDelegate(IntPtr obj);
        [NativeDelegate("cuda_StereoBM_GPU_winSize")] public static cuda_StereoBM_GPU_winSizeDelegate cuda_StereoBM_GPU_winSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* cuda_StereoBM_GPU_avergeTexThresholdDelegate(IntPtr obj);
        [NativeDelegate("cuda_StereoBM_GPU_avergeTexThreshold")] public static cuda_StereoBM_GPU_avergeTexThresholdDelegate cuda_StereoBM_GPU_avergeTexThreshold;
        #endregion
    */
    }
}
