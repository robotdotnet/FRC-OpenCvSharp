using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace OpenCvSharp
{
    /// <summary>
    /// This class contains optimized version of the most common OpenCv operations for FRC
    /// </summary>
    public static class FRC
    {
        public static void ConvertToHSV(Mat input, Mat output)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            if (output == null)
                throw new ArgumentNullException(nameof(output));
            input.ThrowIfDisposed();
            output.ThrowIfDisposed();

            NativeMethods.imgproc_cvtColor(input.CvPtr, input.CvPtr, (int)ColorConversionCodes.BGR2HSV, 0);
        }

        public static void ConvertToHLS(Mat input, Mat output)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            if (output == null)
                throw new ArgumentNullException(nameof(output));
            input.ThrowIfDisposed();
            output.ThrowIfDisposed();

            NativeMethods.imgproc_cvtColor(input.CvPtr, input.CvPtr, (int)ColorConversionCodes.BGR2HLS, 0);
        }

        public static void InRange(Mat input, IList<double> hue, IList<double> sat,
            IList<double> val, Mat output)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            if (output == null)
                throw new ArgumentNullException(nameof(output));
            if (hue == null)
                throw new ArgumentNullException(nameof(hue));
            if (sat == null)
                throw new ArgumentNullException(nameof(sat));
            if (val == null)
                throw new ArgumentNullException(nameof(val));
            if (hue.Count < 2)
                throw new ArgumentOutOfRangeException(nameof(hue), "List must have at least a count of 2");
            if (sat.Count < 2)
                throw new ArgumentOutOfRangeException(nameof(sat), "List must have at least a count of 2");
            if (val.Count < 2)
                throw new ArgumentOutOfRangeException(nameof(val), "List must have at least a count of 2");
            input.ThrowIfDisposed();
            output.ThrowIfDisposed();
            NativeMethods.core_inRange_Scalar(input.CvPtr,
                new Scalar(hue[0], sat[0], val[0]),
                new Scalar(hue[1], sat[1], val[1]), output.CvPtr);
        }

        public static void InRange(Mat input, IList<double> low, IList<double> high, Mat output)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            if (output == null)
                throw new ArgumentNullException(nameof(output));
            if (low == null)
                throw new ArgumentNullException(nameof(low));
            if (high == null)
                throw new ArgumentNullException(nameof(high));
            if (low.Count < 3)
                throw new ArgumentOutOfRangeException(nameof(low), "List must have at least a count of 3");
            if (high.Count < 3)
                throw new ArgumentOutOfRangeException(nameof(high), "List must have at least a count of 3");
            input.ThrowIfDisposed();
            output.ThrowIfDisposed();
            NativeMethods.core_inRange_Scalar(input.CvPtr,
                new Scalar(low[0], low[1], low[2]),
                new Scalar(high[0], high[1], high[2]), output.CvPtr);
        }

        public static void FindContours(InputOutputArray input, List<Point[]> contours, RetrievalModes mode, ContourApproximationModes method,
            Point? offset = null)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            input.ThrowIfDisposed();

            Point offset0 = offset.GetValueOrDefault();
            IntPtr contoursPtr;
            NativeMethods.imgproc_findContours2_vector(input.CvPtr, out contoursPtr, (int)mode, (int)method, offset0);

            unsafe
            {
                int size = NativeMethods.vector_vector_Point_getSize1(contoursPtr).ToInt32();
                contours.Clear();
                contours.Capacity = size;
                IntPtr* capacities = (IntPtr*)Marshal.AllocHGlobal(size * IntPtr.Size);
                GCHandle* capacities2 = (GCHandle*)Marshal.AllocHGlobal(size * IntPtr.Size);
                NativeMethods.vector_vector_Point_getSize2Ptr(contoursPtr, capacities);
                for (int i = 0; i < size; i++)
                {
                    Point[] arr = new Point[(int)capacities[i]];
                    contours.Add(arr);
                    capacities2[i] = GCHandle.Alloc(arr, GCHandleType.Pinned);
                    //capacities[i] = capacities2[i].AddrOfPinnedObject();
                }
                //NativeMethods.vector_vector_Point_copy2(contoursPtr, capacities);
                for (int i = 0; i < size; i++)
                {
                    capacities2[i].Free();
                }
                Marshal.FreeHGlobal((IntPtr)capacities);
                Marshal.FreeHGlobal((IntPtr)capacities2);
            }
            NativeMethods.vector_vector_Point_delete(contoursPtr);
            input.Fix();
        }

        public static void FindContours(InputOutputArray input, List<Point[]> contours, List<HierarchyIndex> hierarchy, RetrievalModes mode,
            ContourApproximationModes method, Point? offset = null)
        {
            if (hierarchy == null)
            {
                FindContours(input, contours, mode, method, offset);
                return;
            }
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            input.ThrowIfDisposed();

            Point offset0 = offset.GetValueOrDefault();
            IntPtr contoursPtr, hierarchyPtr;
            NativeMethods.imgproc_findContours1_vector(input.CvPtr, out contoursPtr, out hierarchyPtr, (int)mode, (int)method, offset0);

            hierarchy.Clear();
            unsafe
            {
                Vec4i* startV4 = (Vec4i*)NativeMethods.vector_Vec4i_getPointer(hierarchyPtr);
                int size = NativeMethods.vector_Vec4i_getSize(hierarchyPtr).ToInt32();
                for (int i = 0; i < size; i++)
                {
                    hierarchy.Add(HierarchyIndex.FromVec4i(startV4[i]));
                }

                size = NativeMethods.vector_vector_Point_getSize1(contoursPtr).ToInt32();
                contours.Clear();
                contours.Capacity = size;
                IntPtr* capacities = stackalloc IntPtr[size];
                NativeMethods.vector_vector_Point_getSize2Ptr(contoursPtr, capacities);
                for (int i = 0; i < size; i++)
                {
                    Point[] arr = new Point[(int)capacities[i]];
                    contours.Add(arr);
                    capacities[i] = GCHandle.ToIntPtr(GCHandle.Alloc(arr));
                }
                NativeMethods.vector_vector_Point_copy2(contoursPtr, capacities);
                for (int i = 0; i < size; i++)
                {
                    GCHandle.FromIntPtr(capacities[i]).Free();
                }
            }

            NativeMethods.vector_Vec4i_delete(hierarchyPtr);
            NativeMethods.vector_vector_Point_delete(contoursPtr);
            input.Fix();
        }
    }
}
