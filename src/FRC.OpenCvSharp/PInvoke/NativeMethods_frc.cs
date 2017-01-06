using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NativeLibraryUtilities;

namespace OpenCvSharp
{
    public partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void frc_cvtColorDelegate(IntPtr src, IntPtr dst, int code, int dstCn);
        [NativeDelegate("frc_cvtColor")]
        public static frc_cvtColorDelegate frc_cvtColor;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void frc_inRangeDelegate(IntPtr src, Scalar lowerb, Scalar upperb, IntPtr dst);
        [NativeDelegate("frc_inRange")]
        public static frc_inRangeDelegate frc_inRange;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void frc_findContours_noHierarchyDelegate(
            IntPtr src, IntPtr contours, int mode, int method, Point offset);
        [NativeDelegate]
        public static frc_findContours_noHierarchyDelegate frc_findContours_noHierarchy;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void frc_findContours_HierarchyDelegate(
            IntPtr src, IntPtr contours, out IntPtr hierarchy, int mode, int method, Point offset);
        [NativeDelegate]
        public static frc_findContours_HierarchyDelegate frc_findContours_Hierarchy;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void frc_convexHull_vectorDelegate(
            IntPtr contours, IntPtr hulls, int clockwise, int returnPoints);
        [NativeDelegate] public static frc_convexHull_vectorDelegate frc_convexHull_vector;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void frc_convexHull_all_vectorDelegate(
            IntPtr contours, IntPtr hulls, int clockwise, int returnPoints);
        [NativeDelegate]
        public static frc_convexHull_all_vectorDelegate frc_convexHull_all_vector;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void frc_findContours_convexHullDelegate(
            IntPtr src, IntPtr contours, IntPtr hulls, int mode, int method, Point offset, int clockwise, int returnPoints);
        [NativeDelegate]
        public static frc_findContours_convexHullDelegate frc_findContours_convexHull;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void frc_drawContoursDelegate(IntPtr image,
            IntPtr contours, 
            int contourIdx, Scalar color, int thickness, int lineType,
            Vec4i[] hierarchy, int hiearchyLength, int maxLevel, Point offset);

        [NativeDelegate] public static frc_drawContoursDelegate frc_drawContours;
    }
}
