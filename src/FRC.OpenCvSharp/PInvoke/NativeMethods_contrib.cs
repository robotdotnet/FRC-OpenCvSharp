using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp.CPlusPlus
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int contrib_initModule_contribDelegate();
        [NativeDelegate("contrib_initModule_contrib")] public static contrib_initModule_contribDelegate contrib_initModule_contrib;

        #region CvAdaptiveSkinDetector
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr contrib_CvAdaptiveSkinDetector_newDelegate(int samplingDivider, int morphingMethod);
        [NativeDelegate("contrib_CvAdaptiveSkinDetector_new")] public static contrib_CvAdaptiveSkinDetector_newDelegate contrib_CvAdaptiveSkinDetector_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void contrib_CvAdaptiveSkinDetector_deleteDelegate(IntPtr self);
        [NativeDelegate("contrib_CvAdaptiveSkinDetector_delete")] public static contrib_CvAdaptiveSkinDetector_deleteDelegate contrib_CvAdaptiveSkinDetector_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void contrib_CvAdaptiveSkinDetector_processDelegate(IntPtr self, IntPtr inputBgrImage, IntPtr outputHueMask);
        [NativeDelegate("contrib_CvAdaptiveSkinDetector_process")] public static contrib_CvAdaptiveSkinDetector_processDelegate contrib_CvAdaptiveSkinDetector_process;
        #endregion

        #region FaceRecognizer

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void contrib_FaceRecognizer_deleteDelegate(IntPtr obj);
        [NativeDelegate("contrib_FaceRecognizer_delete")] public static contrib_FaceRecognizer_deleteDelegate contrib_FaceRecognizer_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void contrib_FaceRecognizer_trainDelegate(
            IntPtr obj, IntPtr[] src, int srcLength, int[] labels, int labelsLength);
        [NativeDelegate("contrib_FaceRecognizer_train")] public static contrib_FaceRecognizer_trainDelegate contrib_FaceRecognizer_train;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void contrib_FaceRecognizer_updateDelegate(
            IntPtr obj, IntPtr[] src, int srcLength, int[] labels, int labelsLength);
        [NativeDelegate("contrib_FaceRecognizer_update")] public static contrib_FaceRecognizer_updateDelegate contrib_FaceRecognizer_update;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int contrib_FaceRecognizer_predict1Delegate(IntPtr obj, IntPtr src);
        [NativeDelegate("contrib_FaceRecognizer_predict1")] public static contrib_FaceRecognizer_predict1Delegate contrib_FaceRecognizer_predict1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void contrib_FaceRecognizer_predict2Delegate(
            IntPtr obj, IntPtr src, out int label, out double confidence);
        [NativeDelegate("contrib_FaceRecognizer_predict2")] public static contrib_FaceRecognizer_predict2Delegate contrib_FaceRecognizer_predict2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void contrib_FaceRecognizer_save1Delegate(IntPtr obj, string filename);
        [NativeDelegate("contrib_FaceRecognizer_save1")] public static contrib_FaceRecognizer_save1Delegate contrib_FaceRecognizer_save1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void contrib_FaceRecognizer_load1Delegate(IntPtr obj, string filename);
        [NativeDelegate("contrib_FaceRecognizer_load1")] public static contrib_FaceRecognizer_load1Delegate contrib_FaceRecognizer_load1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void contrib_FaceRecognizer_save2Delegate(IntPtr obj, IntPtr fs);
        [NativeDelegate("contrib_FaceRecognizer_save2")] public static contrib_FaceRecognizer_save2Delegate contrib_FaceRecognizer_save2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void contrib_FaceRecognizer_load2Delegate(IntPtr obj, IntPtr fs);
        [NativeDelegate("contrib_FaceRecognizer_load2")] public static contrib_FaceRecognizer_load2Delegate contrib_FaceRecognizer_load2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr contrib_FaceRecognizer_infoDelegate(IntPtr obj);
        [NativeDelegate("contrib_FaceRecognizer_info")] public static contrib_FaceRecognizer_infoDelegate contrib_FaceRecognizer_info;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr contrib_createEigenFaceRecognizerDelegate(
            int numComponents, double threshold);
        [NativeDelegate("contrib_createEigenFaceRecognizer")] public static contrib_createEigenFaceRecognizerDelegate contrib_createEigenFaceRecognizer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr contrib_createFisherFaceRecognizerDelegate(
            int numComponents, double threshold);
        [NativeDelegate("contrib_createFisherFaceRecognizer")] public static contrib_createFisherFaceRecognizerDelegate contrib_createFisherFaceRecognizer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr contrib_createLBPHFaceRecognizerDelegate(
            int radius, int neighbors, int gridX, int gridY, double threshold);
        [NativeDelegate("contrib_createLBPHFaceRecognizer")] public static contrib_createLBPHFaceRecognizerDelegate contrib_createLBPHFaceRecognizer;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr contrib_Ptr_FaceRecognizer_objDelegate(IntPtr obj);
        [NativeDelegate("contrib_Ptr_FaceRecognizer_obj")] public static contrib_Ptr_FaceRecognizer_objDelegate contrib_Ptr_FaceRecognizer_obj;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void contrib_Ptr_FaceRecognizer_deleteDelegate(IntPtr obj);
        [NativeDelegate("contrib_Ptr_FaceRecognizer_delete")] public static contrib_Ptr_FaceRecognizer_deleteDelegate contrib_Ptr_FaceRecognizer_delete;

        #endregion

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void contrib_applyColorMapDelegate(IntPtr src, IntPtr dst, int colormap);
        [NativeDelegate("contrib_applyColorMap")] public static contrib_applyColorMapDelegate contrib_applyColorMap;

    }
}
