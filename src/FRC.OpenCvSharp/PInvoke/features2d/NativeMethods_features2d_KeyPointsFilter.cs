using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        // ReSharper disable InconsistentNaming

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_KeyPointsFilter_runByImageBorderDelegate(
            IntPtr keypoints, Size imageSize, int borderSize);
        [NativeDelegate("features2d_KeyPointsFilter_runByImageBorder")] public static features2d_KeyPointsFilter_runByImageBorderDelegate features2d_KeyPointsFilter_runByImageBorder;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_KeyPointsFilter_runByKeypointSizeDelegate(
            IntPtr keypoints, float minSize, float maxSize);
        [NativeDelegate("features2d_KeyPointsFilter_runByKeypointSize")] public static features2d_KeyPointsFilter_runByKeypointSizeDelegate features2d_KeyPointsFilter_runByKeypointSize;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_KeyPointsFilter_runByPixelsMaskDelegate(
            IntPtr keypoints, IntPtr mask);
        [NativeDelegate("features2d_KeyPointsFilter_runByPixelsMask")] public static features2d_KeyPointsFilter_runByPixelsMaskDelegate features2d_KeyPointsFilter_runByPixelsMask;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_KeyPointsFilter_removeDuplicatedDelegate(
            IntPtr keypoints);
        [NativeDelegate("features2d_KeyPointsFilter_removeDuplicated")] public static features2d_KeyPointsFilter_removeDuplicatedDelegate features2d_KeyPointsFilter_removeDuplicated;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_KeyPointsFilter_retainBestDelegate(
            IntPtr keypoints, int npoints);
        [NativeDelegate("features2d_KeyPointsFilter_retainBest")] public static features2d_KeyPointsFilter_retainBestDelegate features2d_KeyPointsFilter_retainBest;
    }
}
