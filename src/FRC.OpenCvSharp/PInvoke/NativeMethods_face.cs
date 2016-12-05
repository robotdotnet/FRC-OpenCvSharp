using OpenCvSharp.PInvoke.NativeLibraryUtilties;

using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    // ReSharper disable InconsistentNaming

    partial class NativeMethods
    {
        /*
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void face_FaceRecognizer_deleteDelegate(IntPtr obj);
        [NativeDelegate("face_FaceRecognizer_delete")] public static face_FaceRecognizer_deleteDelegate face_FaceRecognizer_delete;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void face_FaceRecognizer_trainDelegate(
        IntPtr obj, IntPtr[] src, int srcLength, int[] labels, int labelsLength);
        [NativeDelegate("face_FaceRecognizer_train")] public static face_FaceRecognizer_trainDelegate face_FaceRecognizer_train;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void face_FaceRecognizer_updateDelegate(
        IntPtr obj, IntPtr[] src, int srcLength, int[] labels, int labelsLength);
        [NativeDelegate("face_FaceRecognizer_update")] public static face_FaceRecognizer_updateDelegate face_FaceRecognizer_update;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int face_FaceRecognizer_predict1Delegate(IntPtr obj, IntPtr src);
        [NativeDelegate("face_FaceRecognizer_predict1")] public static face_FaceRecognizer_predict1Delegate face_FaceRecognizer_predict1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void face_FaceRecognizer_predict2Delegate(
        IntPtr obj, IntPtr src, out int label, out double confidence);
        [NativeDelegate("face_FaceRecognizer_predict2")] public static face_FaceRecognizer_predict2Delegate face_FaceRecognizer_predict2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void face_FaceRecognizer_save1Delegate(IntPtr obj, string filename);
        [NativeDelegate("face_FaceRecognizer_save1")] public static face_FaceRecognizer_save1Delegate face_FaceRecognizer_save1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void face_FaceRecognizer_load1Delegate(IntPtr obj, string filename);
        [NativeDelegate("face_FaceRecognizer_load1")] public static face_FaceRecognizer_load1Delegate face_FaceRecognizer_load1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void face_FaceRecognizer_save2Delegate(IntPtr obj, IntPtr fs);
        [NativeDelegate("face_FaceRecognizer_save2")] public static face_FaceRecognizer_save2Delegate face_FaceRecognizer_save2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void face_FaceRecognizer_load2Delegate(IntPtr obj, IntPtr fs);
        [NativeDelegate("face_FaceRecognizer_load2")] public static face_FaceRecognizer_load2Delegate face_FaceRecognizer_load2;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr face_FaceRecognizer_infoDelegate(IntPtr obj);
        [NativeDelegate("face_FaceRecognizer_info")] public static face_FaceRecognizer_infoDelegate face_FaceRecognizer_info;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr face_createEigenFaceRecognizerDelegate(
        int numComponents, double threshold);
        [NativeDelegate("face_createEigenFaceRecognizer")] public static face_createEigenFaceRecognizerDelegate face_createEigenFaceRecognizer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr face_createFisherFaceRecognizerDelegate(
        int numComponents, double threshold);
        [NativeDelegate("face_createFisherFaceRecognizer")] public static face_createFisherFaceRecognizerDelegate face_createFisherFaceRecognizer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr face_createLBPHFaceRecognizerDelegate(
        int radius, int neighbors, int gridX, int gridY, double threshold);
        [NativeDelegate("face_createLBPHFaceRecognizer")] public static face_createLBPHFaceRecognizerDelegate face_createLBPHFaceRecognizer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr face_Ptr_FaceRecognizer_getDelegate(IntPtr obj);
        [NativeDelegate("face_Ptr_FaceRecognizer_get")] public static ObjFunc face_Ptr_FaceRecognizer_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void face_Ptr_FaceRecognizer_deleteDelegate(IntPtr obj);
        [NativeDelegate("face_Ptr_FaceRecognizer_delete")] public static ReleaseFunc face_Ptr_FaceRecognizer_delete;
        */
    }
}
