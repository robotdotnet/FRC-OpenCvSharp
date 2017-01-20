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

        /// <summary>
        /// Finds contours in a binary image.
        /// </summary>
        /// <param name="input">Source, an 8-bit single-channel image. Non-zero pixels are treated as 1’s. 
        /// Zero pixels remain 0’s, so the image is treated as binary.
        /// The function modifies the image while extracting the contours.</param> 
        /// <param name="contours">Detected contours. Each contour is stored as a vector of points.</param>
        /// <param name="mode">Contour retrieval mode</param>
        /// <param name="method">Contour approximation method</param>
        /// <param name="offset"> Optional offset by which every contour point is shifted. 
        /// This is useful if the contours are extracted from the image ROI and then they should be analyzed in the whole image context.</param>
        public static void FindContours(InputOutputArray input, ListOfPointArray contours, RetrievalModes mode,
            ContourApproximationModes method,
            Point? offset = null)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            input.ThrowIfDisposed();

            Point offset0 = offset.GetValueOrDefault();
            NativeMethods.frc_findContours_noHierarchy(input.CvPtr, contours.NativeVector.CvPtr, (int) mode,
                (int) method, offset0);
            input.Fix();
        }

        /// <summary>
        /// Finds contours in a binary image.
        /// </summary>
        /// <param name="input">Source, an 8-bit single-channel image. Non-zero pixels are treated as 1’s. 
        /// Zero pixels remain 0’s, so the image is treated as binary.
        /// The function modifies the image while extracting the contours.</param> 
        /// <param name="contours">Detected contours. Each contour is stored as a vector of points.</param>
        /// <param name="hierarchy">Optional output vector, containing information about the image topology. 
        /// It has as many elements as the number of contours. For each i-th contour contours[i], 
        /// the members of the elements hierarchy[i] are set to 0-based indices in contours of the next 
        /// and previous contours at the same hierarchical level, the first child contour and the parent contour, respectively. 
        /// If for the contour i there are no next, previous, parent, or nested contours, the corresponding elements of hierarchy[i] will be negative.</param>
        /// <param name="mode">Contour retrieval mode</param>
        /// <param name="method">Contour approximation method</param>
        /// <param name="offset"> Optional offset by which every contour point is shifted. 
        /// This is useful if the contours are extracted from the image ROI and then they should be analyzed in the whole image context.</param>
        public static void FindContours(InputOutputArray input, ListOfPointArray contours,
            List<HierarchyIndex> hierarchy, RetrievalModes mode,
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
            NativeMethods.frc_findContours_Hierarchy(input.CvPtr, contours.NativeVector.CvPtr, out hierarchyPtr,
                (int) mode, (int) method, offset0);
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

        /// <summary>
        /// Find contours in a binary image, and then runs a Convex Hull on all contours
        /// </summary>
        /// <param name="input">Source, an 8-bit single-channel image. Non-zero pixels are treated as 1’s. 
        /// Zero pixels remain 0’s, so the image is treated as binary.
        /// The function modifies the image while extracting the contours.</param> 
        /// <param name="contours">Detected contours. Each contour is stored as an array of points.</param>
        /// <param name="hulls">The output convex hulls.  Each hull is stored as an array of points.</param>
        /// <param name="mode">Contour retrieval mode</param>
        /// <param name="method">Contour approximation method</param>
        /// <param name="offset"> Optional offset by which every contour point is shifted. 
        /// This is useful if the contours are extracted from the image ROI and then they should be analyzed in the whole image context.</param>
        /// <param name="clockwise">If true, the output convex hull will be oriented clockwise, 
        /// otherwise it will be oriented counter-clockwise. Here, the usual screen coordinate 
        /// system is assumed - the origin is at the top-left corner, x axis is oriented to the right, 
        /// and y axis is oriented downwards.</param>
        public static void FindContoursConvexHull(InputOutputArray input, ListOfPointArray contours,
            ListOfPointArray hulls, RetrievalModes mode,
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

        /// <summary>
        /// draws contours in the image
        /// </summary>
        /// <param name="image">Destination image.</param>
        /// <param name="contours">All the input contours. Each contour is stored as a point vector.</param>
        /// <param name="contourIdx">Parameter indicating a contour to draw. If it is negative, all the contours are drawn.</param>
        /// <param name="color">Color of the contours.</param>
        /// <param name="thickness">Thickness of lines the contours are drawn with. If it is negative (for example, thickness=CV_FILLED ), 
        /// the contour interiors are drawn.</param>
        /// <param name="lineType">Line connectivity. </param>
        /// <param name="hierarchy">Optional information about hierarchy. It is only needed if you want to draw only some of the contours</param>
        /// <param name="maxLevel">Maximal level for drawn contours. If it is 0, only the specified contour is drawn. 
        /// If it is 1, the function draws the contour(s) and all the nested contours. If it is 2, the function draws the contours, 
        /// all the nested contours, all the nested-to-nested contours, and so on. This parameter is only taken into account 
        /// when there is hierarchy available.</param>
        /// <param name="offset">Optional contour shift parameter. Shift all the drawn contours by the specified offset = (dx, dy)</param>
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
                    contourIdx, color, thickness, (int) lineType, null, 0, maxLevel, offset0);
            }
            else
            {
                Vec4i[] hiearchyVecs = EnumerableEx.SelectToArray(hierarchy, hi => hi.ToVec4i());
                NativeMethods.frc_drawContours(image.CvPtr, contours.NativeVectorDraw.CvPtr,
                    contourIdx, color, thickness, (int) lineType, hiearchyVecs, hiearchyVecs.Length, maxLevel, offset0);
            }
        }

        public enum BlurType
        {
            Box,
            Gaussian,
            Median,
            Bilateral
        }

        public static void Blur(InputArray input, OutputArray output, BlurType type, double radius)
        {
            int iradius = (int) (radius + 0.5);
            int kernelSize;
            switch (type)
            {
                case BlurType.Box:
                    kernelSize = 2*iradius + 1;
                    Cv2.Blur(input, output, new Size(kernelSize, kernelSize));
                    break;
                case BlurType.Gaussian:
                    kernelSize = 6*iradius + 1;
                    Cv2.GaussianBlur(input, output, new Size(kernelSize, kernelSize), radius);
                    break;
                case BlurType.Median:
                    kernelSize = 2*iradius + 1;
                    Cv2.MedianBlur(input, output, kernelSize);
                    break;
                case BlurType.Bilateral:
                    Cv2.BilateralFilter(input, output, -1, radius, radius);
                    break;
            }
        }

        public static void Canny(InputArray input, OutputArray output, double threshold1, double threshold2,
            int apertureSize = 3, bool gradient = false)
        {
            Cv2.Canny(input, output, threshold1, threshold2, apertureSize, gradient);
        }

        public static void Laplacian(InputArray input, OutputArray output, MatType ddepth, int ksize = 1,
            double scale = 1, double delta = 0, BorderTypes borderType = BorderTypes.Reflect101)
        {
            Cv2.Laplacian(input, output, ddepth, ksize, scale, delta, borderType);
        }

        public static void RunCascadeClassifier(Mat input, CascadeClassifier classifier,
            ListOfRect detections, double scaleFactor = 1.1,
            int minNeighbors = 3,
            HaarDetectionType flags = 0,
            Size? minSize = null,
            Size? maxSize = null)
        {
            if (classifier == null)
                throw new ArgumentNullException(nameof(classifier));
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            if (detections == null)
                throw new ArgumentNullException(nameof(detections));

            classifier.ThrowIfDisposed();
            input.ThrowIfDisposed();

            Size minSize0 = minSize.GetValueOrDefault(new Size());
            Size maxSize0 = maxSize.GetValueOrDefault(new Size());

            NativeMethods.objdetect_CascadeClassifier_detectMultiScale1(classifier.CvPtr, input.CvPtr, detections.NativeVector.CvPtr,
                scaleFactor, minNeighbors, (int)flags, minSize0, maxSize0);


        }

        public static void Desaturate(Mat input, Mat output)
        {
            switch (input.Channels())
            {
                case 1:
                    input.CopyTo(output);
                    break;
                case 3:
                    CvtColor(input, output, ColorConversionCodes.BGR2GRAY);
                    break;
                case 4:
                    CvtColor(input, output, ColorConversionCodes.BGRA2GRAY);
                    break;
                default:
                    throw new InvalidOperationException("Input to desaturate must have 1, 3 or 4 channels");
            }
        }

        public static void DistanceTransform(InputArray input, Mat output,
                                             DistanceTypes distanceType,
                                             DistanceMaskSize maskSize)
        {
            Cv2.DistanceTransform(input, output, distanceType, maskSize);
            output.ConvertTo(output, -1);
        }

        public static void FindBlobs(Mat input, Mat output, double minArea, IList<double> circularity)
        {
            FeatureDet
        }
    }
}
