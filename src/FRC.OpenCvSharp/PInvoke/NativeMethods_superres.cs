using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    // TODO

    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void superres_FrameSource_nextFrameDelegate(IntPtr obj, IntPtr frame);
        [NativeDelegate("superres_FrameSource_nextFrame")] public static superres_FrameSource_nextFrameDelegate superres_FrameSource_nextFrame;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void superres_FrameSource_resetDelegate(IntPtr obj);
        [NativeDelegate("superres_FrameSource_reset")] public static superres_FrameSource_resetDelegate superres_FrameSource_reset;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createFrameSource_EmptyDelegate();
        [NativeDelegate("superres_createFrameSource_Empty")] public static superres_createFrameSource_EmptyDelegate superres_createFrameSource_Empty;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createFrameSource_VideoDelegate(
            [MarshalAs(UnmanagedType.LPStr)] string fileName);
        [NativeDelegate("superres_createFrameSource_Video")] public static superres_createFrameSource_VideoDelegate superres_createFrameSource_Video;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createFrameSource_Video_CUDADelegate(
            [MarshalAs(UnmanagedType.LPStr)] string fileName);
        [NativeDelegate("superres_createFrameSource_Video_CUDA")] public static superres_createFrameSource_Video_CUDADelegate superres_createFrameSource_Video_CUDA;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createFrameSource_CameraDelegate(int deviceId);
        [NativeDelegate("superres_createFrameSource_Camera")] public static superres_createFrameSource_CameraDelegate superres_createFrameSource_Camera;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_Ptr_FrameSource_getDelegate(IntPtr ptr);
        [NativeDelegate("superres_Ptr_FrameSource_get")] public static ObjFunc superres_Ptr_FrameSource_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void superres_Ptr_FrameSource_deleteDelegate(IntPtr ptr);
        [NativeDelegate("superres_Ptr_FrameSource_delete")] public static ReleaseFunc superres_Ptr_FrameSource_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void superres_SuperResolution_setInputDelegate(IntPtr obj, IntPtr frameSource);
        [NativeDelegate("superres_SuperResolution_setInput")] public static superres_SuperResolution_setInputDelegate superres_SuperResolution_setInput;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void superres_SuperResolution_nextFrameDelegate(IntPtr obj, IntPtr frame);
        [NativeDelegate("superres_SuperResolution_nextFrame")] public static superres_SuperResolution_nextFrameDelegate superres_SuperResolution_nextFrame;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void superres_SuperResolution_resetDelegate(IntPtr obj);
        [NativeDelegate("superres_SuperResolution_reset")] public static superres_SuperResolution_resetDelegate superres_SuperResolution_reset;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void superres_SuperResolution_collectGarbageDelegate(IntPtr obj);
        [NativeDelegate("superres_SuperResolution_collectGarbage")] public static superres_SuperResolution_collectGarbageDelegate superres_SuperResolution_collectGarbage;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_SuperResolution_infoDelegate(IntPtr obj);
        [NativeDelegate("superres_SuperResolution_info")] public static superres_SuperResolution_infoDelegate superres_SuperResolution_info;
        */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createSuperResolution_BTVL1Delegate();
        [NativeDelegate("superres_createSuperResolution_BTVL1")] public static superres_createSuperResolution_BTVL1Delegate superres_createSuperResolution_BTVL1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createSuperResolution_BTVL1_CUDADelegate();
        [NativeDelegate("superres_createSuperResolution_BTVL1_CUDA")] public static superres_createSuperResolution_BTVL1_CUDADelegate superres_createSuperResolution_BTVL1_CUDA;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createSuperResolution_BTVL1_OCLDelegate();
        [NativeDelegate("superres_createSuperResolution_BTVL1_OCL")] public static superres_createSuperResolution_BTVL1_OCLDelegate superres_createSuperResolution_BTVL1_OCL;
        */

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_Ptr_SuperResolution_getDelegate(IntPtr ptr);
        [NativeDelegate("superres_Ptr_SuperResolution_get")] public static ObjFunc superres_Ptr_SuperResolution_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void superres_Ptr_SuperResolution_deleteDelegate(IntPtr ptr);
        [NativeDelegate("superres_Ptr_SuperResolution_delete")] public static ReleaseFunc superres_Ptr_SuperResolution_delete;
        

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void superres_DenseOpticalFlowExt_calcDelegate(
            IntPtr obj, IntPtr frame0, IntPtr frame1, IntPtr flow1, IntPtr flow2);
        [NativeDelegate("superres_DenseOpticalFlowExt_calc")] public static superres_DenseOpticalFlowExt_calcDelegate superres_DenseOpticalFlowExt_calc;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void superres_DenseOpticalFlowExt_collectGarbageDelegate(IntPtr obj);
        [NativeDelegate("superres_DenseOpticalFlowExt_collectGarbage")] public static superres_DenseOpticalFlowExt_collectGarbageDelegate superres_DenseOpticalFlowExt_collectGarbage;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_DenseOpticalFlowExt_infoDelegate(IntPtr obj);
        [NativeDelegate("superres_DenseOpticalFlowExt_info")] public static superres_DenseOpticalFlowExt_infoDelegate superres_DenseOpticalFlowExt_info;
        */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_Ptr_DenseOpticalFlowExt_getDelegate(IntPtr ptr);
        [NativeDelegate("superres_Ptr_DenseOpticalFlowExt_get")] public static ObjFunc superres_Ptr_DenseOpticalFlowExt_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void superres_Ptr_DenseOpticalFlowExt_deleteDelegate(IntPtr ptr);
        [NativeDelegate("superres_Ptr_DenseOpticalFlowExt_delete")] public static ReleaseFunc superres_Ptr_DenseOpticalFlowExt_delete;


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createOptFlow_FarnebackDelegate();
        [NativeDelegate("superres_createOptFlow_Farneback")] public static superres_createOptFlow_FarnebackDelegate superres_createOptFlow_Farneback;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createOptFlow_Farneback_CUDADelegate();
        [NativeDelegate("superres_createOptFlow_Farneback_CUDA")] public static superres_createOptFlow_Farneback_CUDADelegate superres_createOptFlow_Farneback_CUDA;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createOptFlow_Farneback_OCLDelegate();
        [NativeDelegate("superres_createOptFlow_Farneback_OCL")] public static superres_createOptFlow_Farneback_OCLDelegate superres_createOptFlow_Farneback_OCL;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createOptFlow_SimpleDelegate();
        [NativeDelegate("superres_createOptFlow_Simple")] public static superres_createOptFlow_SimpleDelegate superres_createOptFlow_Simple;
        */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createOptFlow_DualTVL1Delegate();
        [NativeDelegate("superres_createOptFlow_DualTVL1")] public static superres_createOptFlow_DualTVL1Delegate superres_createOptFlow_DualTVL1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createOptFlow_DualTVL1_CUDADelegate();
        [NativeDelegate("superres_createOptFlow_DualTVL1_CUDA")] public static superres_createOptFlow_DualTVL1_CUDADelegate superres_createOptFlow_DualTVL1_CUDA;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createOptFlow_DualTVL1_OCLDelegate();
        [NativeDelegate("superres_createOptFlow_DualTVL1_OCL")] public static superres_createOptFlow_DualTVL1_OCLDelegate superres_createOptFlow_DualTVL1_OCL;
        */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createOptFlow_Brox_CUDADelegate();
        [NativeDelegate("superres_createOptFlow_Brox_CUDA")] public static superres_createOptFlow_Brox_CUDADelegate superres_createOptFlow_Brox_CUDA;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createOptFlow_PyrLK_CUDADelegate();
        [NativeDelegate("superres_createOptFlow_PyrLK_CUDA")] public static superres_createOptFlow_PyrLK_CUDADelegate superres_createOptFlow_PyrLK_CUDA;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr superres_createOptFlow_PyrLK_OCLDelegate();
        [NativeDelegate("superres_createOptFlow_PyrLK_OCL")] public static superres_createOptFlow_PyrLK_OCLDelegate superres_createOptFlow_PyrLK_OCL;
        */

    }
}
