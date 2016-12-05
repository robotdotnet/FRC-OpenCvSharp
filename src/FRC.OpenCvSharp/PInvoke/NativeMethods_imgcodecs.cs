using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgcodecs_imreadDelegate(string filename, int flags);
        [NativeDelegate("imgcodecs_imread")] public static imgcodecs_imreadDelegate imgcodecs_imread;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgcodecs_imreadmultiDelegate([MarshalAs(UnmanagedType.LPStr)] string filename, IntPtr mats, int flags);
        [NativeDelegate("imgcodecs_imreadmulti")] public static imgcodecs_imreadmultiDelegate imgcodecs_imreadmulti;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgcodecs_imwriteDelegate([MarshalAs(UnmanagedType.LPStr)] string filename, IntPtr img, [In] int[] @params, int paramsLength);
        [NativeDelegate("imgcodecs_imwrite")] public static imgcodecs_imwriteDelegate imgcodecs_imwrite;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgcodecs_imdecode_MatDelegate(IntPtr buf, int flags);
        [NativeDelegate("imgcodecs_imdecode_Mat")] public static imgcodecs_imdecode_MatDelegate imgcodecs_imdecode_Mat;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgcodecs_imdecode_vectorDelegate(byte[] buf, IntPtr bufLength, int flags);
        [NativeDelegate("imgcodecs_imdecode_vector")] public static imgcodecs_imdecode_vectorDelegate imgcodecs_imdecode_vector;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgcodecs_imdecode_InputArrayDelegate(IntPtr buf, int flags);
        [NativeDelegate("imgcodecs_imdecode_InputArray")] public static imgcodecs_imdecode_InputArrayDelegate imgcodecs_imdecode_InputArray;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgcodecs_imencode_vectorDelegate([MarshalAs(UnmanagedType.LPStr)] string ext, IntPtr img, IntPtr buf, [In] int[] @params, int paramsLength);
        [NativeDelegate("imgcodecs_imencode_vector")] public static imgcodecs_imencode_vectorDelegate imgcodecs_imencode_vector;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgcodecs_cvConvertImage_CvArrDelegate(IntPtr src, IntPtr dst, int flags);
        [NativeDelegate("imgcodecs_cvConvertImage_CvArr")] public static imgcodecs_cvConvertImage_CvArrDelegate imgcodecs_cvConvertImage_CvArr;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgcodecs_cvConvertImage_MatDelegate(IntPtr src, IntPtr dst, int flags);
        [NativeDelegate("imgcodecs_cvConvertImage_Mat")] public static imgcodecs_cvConvertImage_MatDelegate imgcodecs_cvConvertImage_Mat;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgcodecs_cvHaveImageReaderDelegate([MarshalAs(UnmanagedType.LPStr)] string fileName);
        [NativeDelegate("imgcodecs_cvHaveImageReader")] public static imgcodecs_cvHaveImageReaderDelegate imgcodecs_cvHaveImageReader;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgcodecs_cvHaveImageWriterDelegate([MarshalAs(UnmanagedType.LPStr)] string fileName);
        [NativeDelegate("imgcodecs_cvHaveImageWriter")] public static imgcodecs_cvHaveImageWriterDelegate imgcodecs_cvHaveImageWriter;

    }
}
