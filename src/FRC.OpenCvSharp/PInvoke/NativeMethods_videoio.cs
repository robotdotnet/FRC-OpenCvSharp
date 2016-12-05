using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        // VideoCapture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr videoio_VideoCapture_new1Delegate();
        [NativeDelegate("videoio_VideoCapture_new1")] public static videoio_VideoCapture_new1Delegate videoio_VideoCapture_new1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr videoio_VideoCapture_new2Delegate([MarshalAs(UnmanagedType.LPStr)] string filename);
        [NativeDelegate("videoio_VideoCapture_new2")] public static videoio_VideoCapture_new2Delegate videoio_VideoCapture_new2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr videoio_VideoCapture_new3Delegate(int device);
        [NativeDelegate("videoio_VideoCapture_new3")] public static videoio_VideoCapture_new3Delegate videoio_VideoCapture_new3;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void videoio_VideoCapture_deleteDelegate(IntPtr obj);
        [NativeDelegate("videoio_VideoCapture_delete")] public static videoio_VideoCapture_deleteDelegate videoio_VideoCapture_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int videoio_VideoCapture_open1Delegate(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string filename);
        [NativeDelegate("videoio_VideoCapture_open1")] public static videoio_VideoCapture_open1Delegate videoio_VideoCapture_open1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int videoio_VideoCapture_open2Delegate(IntPtr obj, int device);
        [NativeDelegate("videoio_VideoCapture_open2")] public static videoio_VideoCapture_open2Delegate videoio_VideoCapture_open2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int videoio_VideoCapture_isOpenedDelegate(IntPtr obj);
        [NativeDelegate("videoio_VideoCapture_isOpened")] public static videoio_VideoCapture_isOpenedDelegate videoio_VideoCapture_isOpened;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void videoio_VideoCapture_releaseDelegate(IntPtr obj);
        [NativeDelegate("videoio_VideoCapture_release")] public static videoio_VideoCapture_releaseDelegate videoio_VideoCapture_release;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int videoio_VideoCapture_grabDelegate(IntPtr obj);
        [NativeDelegate("videoio_VideoCapture_grab")] public static videoio_VideoCapture_grabDelegate videoio_VideoCapture_grab;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int videoio_VideoCapture_retrieveDelegate(IntPtr obj, IntPtr image, int flag);
        [NativeDelegate("videoio_VideoCapture_retrieve")] public static videoio_VideoCapture_retrieveDelegate videoio_VideoCapture_retrieve;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void videoio_VideoCapture_operatorRightShift_MatDelegate(IntPtr obj, IntPtr image);
        [NativeDelegate("videoio_VideoCapture_operatorRightShift_Mat")] public static videoio_VideoCapture_operatorRightShift_MatDelegate videoio_VideoCapture_operatorRightShift_Mat;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void videoio_VideoCapture_operatorRightShift_UMatDelegate(IntPtr obj, IntPtr image);
        [NativeDelegate("videoio_VideoCapture_operatorRightShift_UMat")] public static videoio_VideoCapture_operatorRightShift_UMatDelegate videoio_VideoCapture_operatorRightShift_UMat;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int videoio_VideoCapture_readDelegate(IntPtr obj, IntPtr image);
        [NativeDelegate("videoio_VideoCapture_read")] public static videoio_VideoCapture_readDelegate videoio_VideoCapture_read;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int videoio_VideoCapture_setDelegate(IntPtr obj, int propId, double value);
        [NativeDelegate("videoio_VideoCapture_set")] public static videoio_VideoCapture_setDelegate videoio_VideoCapture_set;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double videoio_VideoCapture_getDelegate(IntPtr obj, int propId);
        [NativeDelegate("videoio_VideoCapture_get")] public static videoio_VideoCapture_getDelegate videoio_VideoCapture_get;


        // VideoWriter

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr videoio_VideoWriter_new1Delegate();
        [NativeDelegate("videoio_VideoWriter_new1")] public static videoio_VideoWriter_new1Delegate videoio_VideoWriter_new1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr videoio_VideoWriter_new2Delegate(
            [MarshalAs(UnmanagedType.LPStr)] string filename, int fourcc, double fps,
            Size frameSize, int isColor);
        [NativeDelegate("videoio_VideoWriter_new2")] public static videoio_VideoWriter_new2Delegate videoio_VideoWriter_new2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void videoio_VideoWriter_deleteDelegate(IntPtr obj);
        [NativeDelegate("videoio_VideoWriter_delete")] public static videoio_VideoWriter_deleteDelegate videoio_VideoWriter_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int videoio_VideoWriter_openDelegate(
            IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string filename,
            int fourcc, double fps, Size frameSize, int isColor);
        [NativeDelegate("videoio_VideoWriter_open")] public static videoio_VideoWriter_openDelegate videoio_VideoWriter_open;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int videoio_VideoWriter_isOpenedDelegate(IntPtr obj);
        [NativeDelegate("videoio_VideoWriter_isOpened")] public static videoio_VideoWriter_isOpenedDelegate videoio_VideoWriter_isOpened;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void videoio_VideoWriter_releaseDelegate(IntPtr obj);
        [NativeDelegate("videoio_VideoWriter_release")] public static videoio_VideoWriter_releaseDelegate videoio_VideoWriter_release;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void videoio_VideoWriter_OperatorLeftShiftDelegate(IntPtr obj, IntPtr image);
        [NativeDelegate("videoio_VideoWriter_OperatorLeftShift")] public static videoio_VideoWriter_OperatorLeftShiftDelegate videoio_VideoWriter_OperatorLeftShift;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void videoio_VideoWriter_writeDelegate(IntPtr obj, IntPtr image);
        [NativeDelegate("videoio_VideoWriter_write")] public static videoio_VideoWriter_writeDelegate videoio_VideoWriter_write;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int videoio_VideoWriter_setDelegate(IntPtr obj, int propId, double value);
        [NativeDelegate("videoio_VideoWriter_set")] public static videoio_VideoWriter_setDelegate videoio_VideoWriter_set;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double videoio_VideoWriter_getDelegate(IntPtr obj, int propId);
        [NativeDelegate("videoio_VideoWriter_get")] public static videoio_VideoWriter_getDelegate videoio_VideoWriter_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int videoio_VideoWriter_fourccDelegate(byte c1, byte c2, byte c3, byte c4);
        [NativeDelegate("videoio_VideoWriter_fourcc")] public static videoio_VideoWriter_fourccDelegate videoio_VideoWriter_fourcc;
    }
}
