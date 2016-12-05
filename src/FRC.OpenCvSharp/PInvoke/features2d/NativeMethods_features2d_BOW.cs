using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        // ReSharper disable InconsistentNaming

        // BOWTrainer

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_BOWTrainer_addDelegate(IntPtr obj, IntPtr descriptors);
        [NativeDelegate("features2d_BOWTrainer_add")] public static features2d_BOWTrainer_addDelegate features2d_BOWTrainer_add;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_BOWTrainer_getDescriptorsDelegate(IntPtr obj, IntPtr descriptors);
        [NativeDelegate("features2d_BOWTrainer_getDescriptors")] public static features2d_BOWTrainer_getDescriptorsDelegate features2d_BOWTrainer_getDescriptors;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_BOWTrainer_descriptorsCountDelegate(IntPtr obj);
        [NativeDelegate("features2d_BOWTrainer_descriptorsCount")] public static features2d_BOWTrainer_descriptorsCountDelegate features2d_BOWTrainer_descriptorsCount;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_BOWTrainer_clearDelegate(IntPtr obj);
        [NativeDelegate("features2d_BOWTrainer_clear")] public static features2d_BOWTrainer_clearDelegate features2d_BOWTrainer_clear;


        // BOWKMeansTrainer

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_BOWKMeansTrainer_newDelegate(
            int clusterCount, TermCriteria termcrit, int attempts, int flags);
        [NativeDelegate("features2d_BOWKMeansTrainer_new")] public static features2d_BOWKMeansTrainer_newDelegate features2d_BOWKMeansTrainer_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_BOWKMeansTrainer_deleteDelegate(IntPtr obj);
        [NativeDelegate("features2d_BOWKMeansTrainer_delete")] public static features2d_BOWKMeansTrainer_deleteDelegate features2d_BOWKMeansTrainer_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_BOWKMeansTrainer_cluster1Delegate(IntPtr obj);
        [NativeDelegate("features2d_BOWKMeansTrainer_cluster1")] public static features2d_BOWKMeansTrainer_cluster1Delegate features2d_BOWKMeansTrainer_cluster1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_BOWKMeansTrainer_cluster2Delegate(IntPtr obj, IntPtr descriptors);
        [NativeDelegate("features2d_BOWKMeansTrainer_cluster2")] public static features2d_BOWKMeansTrainer_cluster2Delegate features2d_BOWKMeansTrainer_cluster2;


        // BOWImgDescriptorExtractor

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_BOWImgDescriptorExtractor_new1Delegate(IntPtr dextractor, IntPtr dmatcher);
        [NativeDelegate("features2d_BOWImgDescriptorExtractor_new1")] public static features2d_BOWImgDescriptorExtractor_new1Delegate features2d_BOWImgDescriptorExtractor_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_BOWImgDescriptorExtractor_new2Delegate(IntPtr dmatcher);
        [NativeDelegate("features2d_BOWImgDescriptorExtractor_new2")] public static features2d_BOWImgDescriptorExtractor_new2Delegate features2d_BOWImgDescriptorExtractor_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_BOWImgDescriptorExtractor_deleteDelegate(IntPtr obj);
        [NativeDelegate("features2d_BOWImgDescriptorExtractor_delete")] public static features2d_BOWImgDescriptorExtractor_deleteDelegate features2d_BOWImgDescriptorExtractor_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_BOWImgDescriptorExtractor_setVocabularyDelegate(IntPtr obj, IntPtr vocabulary);
        [NativeDelegate("features2d_BOWImgDescriptorExtractor_setVocabulary")] public static features2d_BOWImgDescriptorExtractor_setVocabularyDelegate features2d_BOWImgDescriptorExtractor_setVocabulary;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_BOWImgDescriptorExtractor_getVocabularyDelegate(IntPtr obj);
        [NativeDelegate("features2d_BOWImgDescriptorExtractor_getVocabulary")] public static features2d_BOWImgDescriptorExtractor_getVocabularyDelegate features2d_BOWImgDescriptorExtractor_getVocabulary;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_BOWImgDescriptorExtractor_compute11Delegate(
            IntPtr obj, IntPtr image, IntPtr keypoints, IntPtr imgDescriptor,
            IntPtr pointIdxsOfClusters, IntPtr descriptors);
        [NativeDelegate("features2d_BOWImgDescriptorExtractor_compute11")] public static features2d_BOWImgDescriptorExtractor_compute11Delegate features2d_BOWImgDescriptorExtractor_compute11;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_BOWImgDescriptorExtractor_compute12Delegate(
            IntPtr obj, IntPtr keypointDescriptors,
            IntPtr imgDescriptor, IntPtr pointIdxsOfClusters);
        [NativeDelegate("features2d_BOWImgDescriptorExtractor_compute12")] public static features2d_BOWImgDescriptorExtractor_compute12Delegate features2d_BOWImgDescriptorExtractor_compute12;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_BOWImgDescriptorExtractor_compute2Delegate(
            IntPtr obj, IntPtr image, IntPtr keypoints, IntPtr imgDescriptor);
        [NativeDelegate("features2d_BOWImgDescriptorExtractor_compute2")] public static features2d_BOWImgDescriptorExtractor_compute2Delegate features2d_BOWImgDescriptorExtractor_compute2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_BOWImgDescriptorExtractor_descriptorSizeDelegate(IntPtr obj);
        [NativeDelegate("features2d_BOWImgDescriptorExtractor_descriptorSize")] public static features2d_BOWImgDescriptorExtractor_descriptorSizeDelegate features2d_BOWImgDescriptorExtractor_descriptorSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int features2d_BOWImgDescriptorExtractor_descriptorTypeDelegate(IntPtr obj);
        [NativeDelegate("features2d_BOWImgDescriptorExtractor_descriptorType")] public static features2d_BOWImgDescriptorExtractor_descriptorTypeDelegate features2d_BOWImgDescriptorExtractor_descriptorType;
    }
}
