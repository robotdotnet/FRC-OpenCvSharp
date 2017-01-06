using System;
using System.Collections.Generic;
using OpenCvSharp.Util;

namespace OpenCvSharp.FRC
{
    /// <summary>
    /// This class contains optimized version of the most common OpenCv operations for FRC
    /// </summary>
    public static class FrcInvoke
    {
        /// <summary>
        /// Converts image from one color space to another
        /// </summary>
        /// <param name="src">The source image, 8-bit unsigned, 16-bit unsigned or single-precision floating-point</param>
        /// <param name="dst">The destination image; will have the same size and the same depth as src</param>
        /// <param name="code">The color space conversion code</param>
        /// <param name="dstCn">The number of channels in the destination image; if the parameter is 0, the number of the channels will be derived automatically from src and the code</param>
        public static void CvtColor(InputArray src, OutputArray dst, ColorConversionCodes code, int dstCn = 0)
        {
            Cv2.CvtColor(src, dst, code, dstCn);
        }

        public static void InRange(InputArray input, IList<double> hue, IList<double> sat,
            IList<double> val, OutputArray output)
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
            output.ThrowIfNotReady();
            NativeMethods.frc_inRange(input.CvPtr,
                new Scalar(hue[0], sat[0], val[0]),
                new Scalar(hue[1], sat[1], val[1]), output.CvPtr);
            GC.KeepAlive(input);
            output.Fix();
        }

         /// <summary>
        /// set mask elements for those array elements which are within the element-specific bounding box (dst = lowerb &lt;= src &amp;&amp; src &lt; upperb)
        /// </summary>
        /// <param name="input">The first source array</param>
        /// <param name="low">The inclusive lower boundary array of the same size and type as src</param>
        /// <param name="high">The exclusive upper boundary array of the same size and type as src</param>
        /// <param name="output">The destination array, will have the same size as src and CV_8U type</param>
        public static void InRange(InputArray input, IList<double> low, IList<double> high, OutputArray output)
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
            output.ThrowIfNotReady();
            NativeMethods.frc_inRange(input.CvPtr,
                new Scalar(low[0], low[1], low[2]),
                new Scalar(high[0], high[1], high[2]), output.CvPtr);
            GC.KeepAlive(input);
            output.Fix();
        }

        public static void FindContours(InputOutputArray input, ListOfPointArray contours, RetrievalModes mode, ContourApproximationModes method,
            Point? offset = null)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            input.ThrowIfDisposed();

            Point offset0 = offset.GetValueOrDefault();
            NativeMethods.frc_findContours_noHierarchy(input.CvPtr, contours.NativeVector.CvPtr, (int)mode, (int)method, offset0);
            input.Fix();
        }

        public static void FindContours(InputOutputArray input, ListOfPointArray contours, List<HierarchyIndex> hierarchy, RetrievalModes mode,
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
            IntPtr hierarchyPtr;
            NativeMethods.frc_findContours_Hierarchy(input.CvPtr, contours.NativeVector.CvPtr, out hierarchyPtr, (int)mode, (int)method, offset0);
            hierarchy.Clear();
            unsafe
            {
                Vec4i* startV4 = (Vec4i*) NativeMethods.vector_Vec4i_getPointer(hierarchyPtr);
                int size = NativeMethods.vector_Vec4i_getSize(hierarchyPtr).ToInt32();
                for (int i = 0; i < size; i++)
                {
                    hierarchy.Add(HierarchyIndex.FromVec4i(startV4[i]));
                }
            }
            input.Fix();
        }

        public static void FindContoursConvexHull(InputOutputArray input, ListOfPointArray contours, ListOfPointArray hulls, RetrievalModes mode,
            ContourApproximationModes method, bool clockwise = false, Point? offset = null)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            input.ThrowIfDisposed();
            Point offset0 = offset.GetValueOrDefault();
            NativeMethods.frc_findContours_convexHull(input.CvPtr, contours.NativeVector.CvPtr, hulls.NativeVector.CvPtr,
                (int) mode, (int) method, offset0, clockwise ? 1 : 0, 1);
            input.Fix();
        }

        public static void DrawContours(
            InputOutputArray image,
            ListOfPointArray contours,
            int contourIdx,
            Scalar color,
            int thickness = 1,
            LineTypes lineType = LineTypes.Link8,
            IEnumerable<HierarchyIndex> hierarchy = null,
            int maxLevel = Int32.MaxValue,
            Point? offset = null)
        {
            if (image == null)
                throw new ArgumentNullException(nameof(image));
            if (contours == null)
                throw new ArgumentNullException(nameof(contours));
            image.ThrowIfNotReady();

            Point offset0 = offset.GetValueOrDefault(new Point());

            if (hierarchy == null)
            {
                NativeMethods.frc_drawContours(image.CvPtr, contours.NativeVectorDraw.CvPtr,
                    contourIdx, color, thickness, (int)lineType, null, 0, maxLevel, offset0);
            }
            else
            {
                Vec4i[] hiearchyVecs = EnumerableEx.SelectToArray(hierarchy, hi => hi.ToVec4i());
                NativeMethods.frc_drawContours(image.CvPtr, contours.NativeVectorDraw.CvPtr,
                    contourIdx, color, thickness, (int)lineType, hiearchyVecs, hiearchyVecs.Length, maxLevel, offset0);
            }
        }

    }
}
