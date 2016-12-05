using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        // ReSharper disable InconsistentNaming
        /*
        // BriefDescriptorExtractor
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_BriefDescriptorExtractor_createDelegate(int bytes);
        [NativeDelegate("xfeatures2d_BriefDescriptorExtractor_create")] public static xfeatures2d_BriefDescriptorExtractor_createDelegate xfeatures2d_BriefDescriptorExtractor_create;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void xfeatures2d_Ptr_BriefDescriptorExtractor_deleteDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_Ptr_BriefDescriptorExtractor_delete")] public static ReleaseFunc xfeatures2d_Ptr_BriefDescriptorExtractor_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void xfeatures2d_BriefDescriptorExtractor_readDelegate(IntPtr obj, IntPtr fn);
        [NativeDelegate("xfeatures2d_BriefDescriptorExtractor_read")] public static xfeatures2d_BriefDescriptorExtractor_readDelegate xfeatures2d_BriefDescriptorExtractor_read;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void xfeatures2d_BriefDescriptorExtractor_writeDelegate(IntPtr obj, IntPtr fs);
        [NativeDelegate("xfeatures2d_BriefDescriptorExtractor_write")] public static xfeatures2d_BriefDescriptorExtractor_writeDelegate xfeatures2d_BriefDescriptorExtractor_write;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int xfeatures2d_BriefDescriptorExtractor_descriptorSizeDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_BriefDescriptorExtractor_descriptorSize")] public static xfeatures2d_BriefDescriptorExtractor_descriptorSizeDelegate xfeatures2d_BriefDescriptorExtractor_descriptorSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int xfeatures2d_BriefDescriptorExtractor_descriptorTypeDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_BriefDescriptorExtractor_descriptorType")] public static xfeatures2d_BriefDescriptorExtractor_descriptorTypeDelegate xfeatures2d_BriefDescriptorExtractor_descriptorType;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_BriefDescriptorExtractor_infoDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_BriefDescriptorExtractor_info")] public static xfeatures2d_BriefDescriptorExtractor_infoDelegate xfeatures2d_BriefDescriptorExtractor_info;
        

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_Ptr_BriefDescriptorExtractor_getDelegate(IntPtr ptr);
        [NativeDelegate("xfeatures2d_Ptr_BriefDescriptorExtractor_get")] public static ObjFunc xfeatures2d_Ptr_BriefDescriptorExtractor_get;

        // FREAK
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_FREAK_createDelegate(int orientationNormalized,
            int scaleNormalized, float patternScale, int nOctaves,
            int[] selectedPairs, int selectedPairsLength);
        [NativeDelegate("xfeatures2d_FREAK_create")] public static xfeatures2d_FREAK_createDelegate xfeatures2d_FREAK_create;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void xfeatures2d_Ptr_FREAK_deleteDelegate(IntPtr ptr);
        [NativeDelegate("xfeatures2d_Ptr_FREAK_delete")] public static ReleaseFunc xfeatures2d_Ptr_FREAK_delete;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_FREAK_infoDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_FREAK_info")] public static xfeatures2d_FREAK_infoDelegate xfeatures2d_FREAK_info;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_Ptr_FREAK_getDelegate(IntPtr ptr);
        [NativeDelegate("xfeatures2d_Ptr_FREAK_get")] public static ObjFunc xfeatures2d_Ptr_FREAK_get;

        // StarDetector
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_StarDetector_createDelegate(
            int maxSize, int responseThreshold,
            int lineThresholdProjected, int lineThresholdBinarized, int suppressNonmaxSize);
        [NativeDelegate("xfeatures2d_StarDetector_create")] public static xfeatures2d_StarDetector_createDelegate xfeatures2d_StarDetector_create;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void xfeatures2d_Ptr_StarDetector_deleteDelegate(IntPtr ptr);
        [NativeDelegate("xfeatures2d_Ptr_StarDetector_delete")] public static ReleaseFunc xfeatures2d_Ptr_StarDetector_delete;

        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_StarDetector_infoDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_StarDetector_info")] public static xfeatures2d_StarDetector_infoDelegate xfeatures2d_StarDetector_info;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_Ptr_StarDetector_getDelegate(IntPtr ptr);
        [NativeDelegate("xfeatures2d_Ptr_StarDetector_get")] public static ObjFunc xfeatures2d_Ptr_StarDetector_get;

        // DenseFeatureDetector
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_DenseFeatureDetector_newDelegate(
            float initFeatureScale, int featureScaleLevels, float featureScaleMul,
            int initXyStep, int initImgBound, int varyXyStepWithScale, int varyImgBoundWithScale);
        [NativeDelegate("xfeatures2d_DenseFeatureDetector_new")] public static xfeatures2d_DenseFeatureDetector_newDelegate xfeatures2d_DenseFeatureDetector_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void xfeatures2d_DenseFeatureDetector_deleteDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_DenseFeatureDetector_delete")] public static xfeatures2d_DenseFeatureDetector_deleteDelegate xfeatures2d_DenseFeatureDetector_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_DenseFeatureDetector_infoDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_DenseFeatureDetector_info")] public static xfeatures2d_DenseFeatureDetector_infoDelegate xfeatures2d_DenseFeatureDetector_info;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_Ptr_DenseFeatureDetector_getDelegate(IntPtr ptr);
        [NativeDelegate("xfeatures2d_Ptr_DenseFeatureDetector_get")] public static xfeatures2d_Ptr_DenseFeatureDetector_getDelegate xfeatures2d_Ptr_DenseFeatureDetector_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void xfeatures2d_Ptr_DenseFeatureDetector_deleteDelegate(IntPtr ptr);
        [NativeDelegate("xfeatures2d_Ptr_DenseFeatureDetector_delete")] public static xfeatures2d_Ptr_DenseFeatureDetector_deleteDelegate xfeatures2d_Ptr_DenseFeatureDetector_delete;
        */
        /*
        // SURF
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_SURF_createDelegate(
            double hessianThreshold, int nOctaves,
            int nOctaveLayers, int extended, int upright);
        [NativeDelegate("xfeatures2d_SURF_create")] public static xfeatures2d_SURF_createDelegate xfeatures2d_SURF_create;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void xfeatures2d_Ptr_SURF_deleteDelegate(IntPtr ptr);
        [NativeDelegate("xfeatures2d_Ptr_SURF_delete")] public static ReleaseFunc xfeatures2d_Ptr_SURF_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_Ptr_SURF_getDelegate(IntPtr ptr);
        [NativeDelegate("xfeatures2d_Ptr_SURF_get")] public static ObjFunc xfeatures2d_Ptr_SURF_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_SURF_infoDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_SURF_info")] public static xfeatures2d_SURF_infoDelegate xfeatures2d_SURF_info;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double xfeatures2d_SURF_getHessianThresholdDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_SURF_getHessianThreshold")] public static xfeatures2d_SURF_getHessianThresholdDelegate xfeatures2d_SURF_getHessianThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int xfeatures2d_SURF_getNOctavesDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_SURF_getNOctaves")] public static xfeatures2d_SURF_getNOctavesDelegate xfeatures2d_SURF_getNOctaves;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int xfeatures2d_SURF_getNOctaveLayersDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_SURF_getNOctaveLayers")] public static xfeatures2d_SURF_getNOctaveLayersDelegate xfeatures2d_SURF_getNOctaveLayers;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int xfeatures2d_SURF_getExtendedDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_SURF_getExtended")] public static xfeatures2d_SURF_getExtendedDelegate xfeatures2d_SURF_getExtended;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int xfeatures2d_SURF_getUprightDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_SURF_getUpright")] public static xfeatures2d_SURF_getUprightDelegate xfeatures2d_SURF_getUpright;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void xfeatures2d_SURF_setHessianThresholdDelegate(IntPtr obj, double value);
        [NativeDelegate("xfeatures2d_SURF_setHessianThreshold")] public static xfeatures2d_SURF_setHessianThresholdDelegate xfeatures2d_SURF_setHessianThreshold;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void xfeatures2d_SURF_setNOctavesDelegate(IntPtr obj, int value);
        [NativeDelegate("xfeatures2d_SURF_setNOctaves")] public static xfeatures2d_SURF_setNOctavesDelegate xfeatures2d_SURF_setNOctaves;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void xfeatures2d_SURF_setNOctaveLayersDelegate(IntPtr obj, int value);
        [NativeDelegate("xfeatures2d_SURF_setNOctaveLayers")] public static xfeatures2d_SURF_setNOctaveLayersDelegate xfeatures2d_SURF_setNOctaveLayers;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void xfeatures2d_SURF_setExtendedDelegate(IntPtr obj, int value);
        [NativeDelegate("xfeatures2d_SURF_setExtended")] public static xfeatures2d_SURF_setExtendedDelegate xfeatures2d_SURF_setExtended;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void xfeatures2d_SURF_setUprightDelegate(IntPtr obj, int value);
        [NativeDelegate("xfeatures2d_SURF_setUpright")] public static xfeatures2d_SURF_setUprightDelegate xfeatures2d_SURF_setUpright;

        // SIFT
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_SIFT_createDelegate(int nfeatures, int nOctaveLayers,
            double contrastThreshold, double edgeThreshold, double sigma);
        [NativeDelegate("xfeatures2d_SIFT_create")] public static xfeatures2d_SIFT_createDelegate xfeatures2d_SIFT_create;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void xfeatures2d_Ptr_SIFT_deleteDelegate(IntPtr ptr);
        [NativeDelegate("xfeatures2d_Ptr_SIFT_delete")] public static ReleaseFunc xfeatures2d_Ptr_SIFT_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_Ptr_SIFT_getDelegate(IntPtr ptr);
        [NativeDelegate("xfeatures2d_Ptr_SIFT_get")] public static ObjFunc xfeatures2d_Ptr_SIFT_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr xfeatures2d_SIFT_infoDelegate(IntPtr obj);
        [NativeDelegate("xfeatures2d_SIFT_info")] public static xfeatures2d_SIFT_infoDelegate xfeatures2d_SIFT_info;
        */
    }
}
