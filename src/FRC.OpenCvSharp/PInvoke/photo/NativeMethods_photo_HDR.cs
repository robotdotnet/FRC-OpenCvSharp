using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591
// ReSharper disable InconsistentNaming

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr photo_createCalibrateDebevecDelegate(int samples, float lambda, int random);
        [NativeDelegate("photo_createCalibrateDebevec")] public static photo_createCalibrateDebevecDelegate photo_createCalibrateDebevec;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr photo_createCalibrateRobertsonDelegate(int maxIter, float threshold);
        [NativeDelegate("photo_createCalibrateRobertson")] public static photo_createCalibrateRobertsonDelegate photo_createCalibrateRobertson;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_Ptr_CalibrateDebevec_deleteDelegate(IntPtr obj);
        [NativeDelegate("photo_Ptr_CalibrateDebevec_delete")] public static ReleaseFunc photo_Ptr_CalibrateDebevec_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_Ptr_CalibrateRobertson_deleteDelegate(IntPtr obj);
        [NativeDelegate("photo_Ptr_CalibrateRobertson_delete")] public static photo_Ptr_CalibrateRobertson_deleteDelegate photo_Ptr_CalibrateRobertson_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr photo_Ptr_CalibrateDebevec_getDelegate(IntPtr obj);
        [NativeDelegate("photo_Ptr_CalibrateDebevec_get")] public static ObjFunc photo_Ptr_CalibrateDebevec_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr photo_Ptr_CalibrateRobertson_getDelegate(IntPtr obj);
        [NativeDelegate("photo_Ptr_CalibrateRobertson_get")] public static photo_Ptr_CalibrateRobertson_getDelegate photo_Ptr_CalibrateRobertson_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_CalibrateCRF_processDelegate(
            IntPtr obj, IntPtr[] srcImgs, int srcImgsLength, IntPtr dst, [In, MarshalAs(UnmanagedType.LPArray)] float[] times);
        [NativeDelegate("photo_CalibrateCRF_process")] public static photo_CalibrateCRF_processDelegate photo_CalibrateCRF_process;
    }
}
