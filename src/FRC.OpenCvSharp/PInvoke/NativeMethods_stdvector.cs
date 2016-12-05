using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;
using OpenCvSharp.ML;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        #region uchar
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_uchar_new1Delegate();
        [NativeDelegate("vector_uchar_new1")] public static vector_uchar_new1Delegate vector_uchar_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_uchar_new2Delegate(IntPtr size);
        [NativeDelegate("vector_uchar_new2")] public static vector_uchar_new2Delegate vector_uchar_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_uchar_new3Delegate([In] byte[] data, IntPtr dataLength);
        [NativeDelegate("vector_uchar_new3")] public static vector_uchar_new3Delegate vector_uchar_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_uchar_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_uchar_getSize")] public static vector_uchar_getSizeDelegate vector_uchar_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_uchar_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_uchar_getPointer")] public static vector_uchar_getPointerDelegate vector_uchar_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_uchar_copyDelegate(IntPtr vector, IntPtr dst);
        [NativeDelegate("vector_vector_uchar_copy")] public static vector_vector_uchar_copyDelegate vector_vector_uchar_copy;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_uchar_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_uchar_delete")] public static vector_uchar_deleteDelegate vector_uchar_delete;
        #endregion
        #region int
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_int32_new1Delegate();
        [NativeDelegate("vector_int32_new1")] public static vector_int32_new1Delegate vector_int32_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_int32_new2Delegate(IntPtr size);
        [NativeDelegate("vector_int32_new2")] public static vector_int32_new2Delegate vector_int32_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_int32_new3Delegate([In] int[] data, IntPtr dataLength);
        [NativeDelegate("vector_int32_new3")] public static vector_int32_new3Delegate vector_int32_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_int32_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_int32_getSize")] public static vector_int32_getSizeDelegate vector_int32_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_int32_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_int32_getPointer")] public static vector_int32_getPointerDelegate vector_int32_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_int32_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_int32_delete")] public static vector_int32_deleteDelegate vector_int32_delete;
        #endregion
        #region float
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_float_new1Delegate();
        [NativeDelegate("vector_float_new1")] public static vector_float_new1Delegate vector_float_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_float_new2Delegate(IntPtr size);
        [NativeDelegate("vector_float_new2")] public static vector_float_new2Delegate vector_float_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_float_new3Delegate([In] float[] data, IntPtr dataLength);
        [NativeDelegate("vector_float_new3")] public static vector_float_new3Delegate vector_float_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_float_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_float_getSize")] public static vector_float_getSizeDelegate vector_float_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_float_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_float_getPointer")] public static vector_float_getPointerDelegate vector_float_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_float_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_float_delete")] public static vector_float_deleteDelegate vector_float_delete;
        #endregion
        #region double
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_double_new1Delegate();
        [NativeDelegate("vector_double_new1")] public static vector_double_new1Delegate vector_double_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_double_new2Delegate(IntPtr size);
        [NativeDelegate("vector_double_new2")] public static vector_double_new2Delegate vector_double_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_double_new3Delegate([In] double[] data, IntPtr dataLength);
        [NativeDelegate("vector_double_new3")] public static vector_double_new3Delegate vector_double_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_double_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_double_getSize")] public static vector_double_getSizeDelegate vector_double_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_double_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_double_getPointer")] public static vector_double_getPointerDelegate vector_double_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_double_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_double_delete")] public static vector_double_deleteDelegate vector_double_delete;
        #endregion
        #region cv::Vec2f
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec2f_new1Delegate();
        [NativeDelegate("vector_Vec2f_new1")] public static vector_Vec2f_new1Delegate vector_Vec2f_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec2f_new2Delegate(IntPtr size);
        [NativeDelegate("vector_Vec2f_new2")] public static vector_Vec2f_new2Delegate vector_Vec2f_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec2f_new3Delegate([In] Vec2f[] data, IntPtr dataLength);
        [NativeDelegate("vector_Vec2f_new3")] public static vector_Vec2f_new3Delegate vector_Vec2f_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec2f_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec2f_getSize")] public static vector_Vec2f_getSizeDelegate vector_Vec2f_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec2f_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec2f_getPointer")] public static vector_Vec2f_getPointerDelegate vector_Vec2f_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_Vec2f_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec2f_delete")] public static vector_Vec2f_deleteDelegate vector_Vec2f_delete;
        #endregion
        #region cv::Vec3f
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec3f_new1Delegate();
        [NativeDelegate("vector_Vec3f_new1")] public static vector_Vec3f_new1Delegate vector_Vec3f_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec3f_new2Delegate(IntPtr size);
        [NativeDelegate("vector_Vec3f_new2")] public static vector_Vec3f_new2Delegate vector_Vec3f_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec3f_new3Delegate([In] Vec3f[] data, IntPtr dataLength);
        [NativeDelegate("vector_Vec3f_new3")] public static vector_Vec3f_new3Delegate vector_Vec3f_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec3f_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec3f_getSize")] public static vector_Vec3f_getSizeDelegate vector_Vec3f_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec3f_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec3f_getPointer")] public static vector_Vec3f_getPointerDelegate vector_Vec3f_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_Vec3f_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec3f_delete")] public static vector_Vec3f_deleteDelegate vector_Vec3f_delete;
        #endregion
        #region cv::Vec4f
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec4f_new1Delegate();
        [NativeDelegate("vector_Vec4f_new1")] public static vector_Vec4f_new1Delegate vector_Vec4f_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec4f_new2Delegate(IntPtr size);
        [NativeDelegate("vector_Vec4f_new2")] public static vector_Vec4f_new2Delegate vector_Vec4f_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec4f_new3Delegate([In] Vec4f[] data, IntPtr dataLength);
        [NativeDelegate("vector_Vec4f_new3")] public static vector_Vec4f_new3Delegate vector_Vec4f_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec4f_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec4f_getSize")] public static vector_Vec4f_getSizeDelegate vector_Vec4f_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec4f_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec4f_getPointer")] public static vector_Vec4f_getPointerDelegate vector_Vec4f_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_Vec4f_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec4f_delete")] public static vector_Vec4f_deleteDelegate vector_Vec4f_delete;
        #endregion
        #region cv::Vec4i
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec4i_new1Delegate();
        [NativeDelegate("vector_Vec4i_new1")] public static vector_Vec4i_new1Delegate vector_Vec4i_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec4i_new2Delegate(IntPtr size);
        [NativeDelegate("vector_Vec4i_new2")] public static vector_Vec4i_new2Delegate vector_Vec4i_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec4i_new3Delegate([In] Vec4i[] data, IntPtr dataLength);
        [NativeDelegate("vector_Vec4i_new3")] public static vector_Vec4i_new3Delegate vector_Vec4i_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec4i_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec4i_getSize")] public static vector_Vec4i_getSizeDelegate vector_Vec4i_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec4i_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec4i_getPointer")] public static vector_Vec4i_getPointerDelegate vector_Vec4i_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_Vec4i_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec4i_delete")] public static vector_Vec4i_deleteDelegate vector_Vec4i_delete;
        #endregion
        #region cv::Vec6f
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec6f_new1Delegate();
        [NativeDelegate("vector_Vec6f_new1")] public static vector_Vec6f_new1Delegate vector_Vec6f_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec6f_new2Delegate(IntPtr size);
        [NativeDelegate("vector_Vec6f_new2")] public static vector_Vec6f_new2Delegate vector_Vec6f_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec6f_new3Delegate([In] Vec6f[] data, IntPtr dataLength);
        [NativeDelegate("vector_Vec6f_new3")] public static vector_Vec6f_new3Delegate vector_Vec6f_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec6f_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec6f_getSize")] public static vector_Vec6f_getSizeDelegate vector_Vec6f_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec6f_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec6f_getPointer")] public static vector_Vec6f_getPointerDelegate vector_Vec6f_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_Vec6f_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec6f_delete")] public static vector_Vec6f_deleteDelegate vector_Vec6f_delete;
        #endregion
        #region cv::Vec6d
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec6d_new1Delegate();
        [NativeDelegate("vector_Vec6d_new1")] public static vector_Vec6d_new1Delegate vector_Vec6d_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec6d_new2Delegate(IntPtr size);
        [NativeDelegate("vector_Vec6d_new2")] public static vector_Vec6d_new2Delegate vector_Vec6d_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec6d_new3Delegate([In] Vec6d[] data, IntPtr dataLength);
        [NativeDelegate("vector_Vec6d_new3")] public static vector_Vec6d_new3Delegate vector_Vec6d_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec6d_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec6d_getSize")] public static vector_Vec6d_getSizeDelegate vector_Vec6d_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Vec6d_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec6d_getPointer")] public static vector_Vec6d_getPointerDelegate vector_Vec6d_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_Vec6d_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_Vec6d_delete")] public static vector_Vec6d_deleteDelegate vector_Vec6d_delete;
        #endregion
        #region cv::Point2i
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point2i_new1Delegate();
        [NativeDelegate("vector_Point2i_new1")] public static vector_Point2i_new1Delegate vector_Point2i_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point2i_new2Delegate(IntPtr size);
        [NativeDelegate("vector_Point2i_new2")] public static vector_Point2i_new2Delegate vector_Point2i_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point2i_new3Delegate([In] Point[] data, IntPtr dataLength);
        [NativeDelegate("vector_Point2i_new3")] public static vector_Point2i_new3Delegate vector_Point2i_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point2i_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_Point2i_getSize")] public static vector_Point2i_getSizeDelegate vector_Point2i_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point2i_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_Point2i_getPointer")] public static vector_Point2i_getPointerDelegate vector_Point2i_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_Point2i_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_Point2i_delete")] public static vector_Point2i_deleteDelegate vector_Point2i_delete;
        #endregion
        #region cv::Point2f
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point2f_new1Delegate();
        [NativeDelegate("vector_Point2f_new1")] public static vector_Point2f_new1Delegate vector_Point2f_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point2f_new2Delegate(IntPtr size);
        [NativeDelegate("vector_Point2f_new2")] public static vector_Point2f_new2Delegate vector_Point2f_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point2f_new3Delegate([In] Point2f[] data, IntPtr dataLength);
        [NativeDelegate("vector_Point2f_new3")] public static vector_Point2f_new3Delegate vector_Point2f_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point2f_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_Point2f_getSize")] public static vector_Point2f_getSizeDelegate vector_Point2f_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point2f_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_Point2f_getPointer")] public static vector_Point2f_getPointerDelegate vector_Point2f_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_Point2f_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_Point2f_delete")] public static vector_Point2f_deleteDelegate vector_Point2f_delete;
        #endregion
        #region cv::Point3f
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point3f_new1Delegate();
        [NativeDelegate("vector_Point3f_new1")] public static vector_Point3f_new1Delegate vector_Point3f_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point3f_new2Delegate(IntPtr size);
        [NativeDelegate("vector_Point3f_new2")] public static vector_Point3f_new2Delegate vector_Point3f_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point3f_new3Delegate([In] Point3f[] data, IntPtr dataLength);
        [NativeDelegate("vector_Point3f_new3")] public static vector_Point3f_new3Delegate vector_Point3f_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point3f_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_Point3f_getSize")] public static vector_Point3f_getSizeDelegate vector_Point3f_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Point3f_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_Point3f_getPointer")] public static vector_Point3f_getPointerDelegate vector_Point3f_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_Point3f_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_Point3f_delete")] public static vector_Point3f_deleteDelegate vector_Point3f_delete;
        #endregion
        #region cv::Rect
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Rect_new1Delegate();
        [NativeDelegate("vector_Rect_new1")] public static vector_Rect_new1Delegate vector_Rect_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Rect_new2Delegate(IntPtr size);
        [NativeDelegate("vector_Rect_new2")] public static vector_Rect_new2Delegate vector_Rect_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Rect_new3Delegate([In] Rect[] data, IntPtr dataLength);
        [NativeDelegate("vector_Rect_new3")] public static vector_Rect_new3Delegate vector_Rect_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Rect_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_Rect_getSize")] public static vector_Rect_getSizeDelegate vector_Rect_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Rect_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_Rect_getPointer")] public static vector_Rect_getPointerDelegate vector_Rect_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_Rect_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_Rect_delete")] public static vector_Rect_deleteDelegate vector_Rect_delete;
        #endregion
        #region cv::KeyPoint
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_KeyPoint_new1Delegate();
        [NativeDelegate("vector_KeyPoint_new1")] public static vector_KeyPoint_new1Delegate vector_KeyPoint_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_KeyPoint_new2Delegate(IntPtr size);
        [NativeDelegate("vector_KeyPoint_new2")] public static vector_KeyPoint_new2Delegate vector_KeyPoint_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_KeyPoint_new3Delegate([In]KeyPoint[] data, IntPtr dataLength);
        [NativeDelegate("vector_KeyPoint_new3")] public static vector_KeyPoint_new3Delegate vector_KeyPoint_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_KeyPoint_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_KeyPoint_getSize")] public static vector_KeyPoint_getSizeDelegate vector_KeyPoint_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_KeyPoint_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_KeyPoint_getPointer")] public static vector_KeyPoint_getPointerDelegate vector_KeyPoint_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_KeyPoint_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_KeyPoint_delete")] public static vector_KeyPoint_deleteDelegate vector_KeyPoint_delete;
        #endregion
        #region cv::KeyPoint
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DMatch_new1Delegate();
        [NativeDelegate("vector_DMatch_new1")] public static vector_DMatch_new1Delegate vector_DMatch_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DMatch_new2Delegate(IntPtr size);
        [NativeDelegate("vector_DMatch_new2")] public static vector_DMatch_new2Delegate vector_DMatch_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DMatch_new3Delegate([In] DMatch[] data, IntPtr dataLength);
        [NativeDelegate("vector_DMatch_new3")] public static vector_DMatch_new3Delegate vector_DMatch_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DMatch_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_DMatch_getSize")] public static vector_DMatch_getSizeDelegate vector_DMatch_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DMatch_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_DMatch_getPointer")] public static vector_DMatch_getPointerDelegate vector_DMatch_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_DMatch_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_DMatch_delete")] public static vector_DMatch_deleteDelegate vector_DMatch_delete;
        #endregion
        #region vector<int>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_int_new1Delegate();
        [NativeDelegate("vector_vector_int_new1")] public static vector_vector_int_new1Delegate vector_vector_int_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_int_new2Delegate(IntPtr size);
        [NativeDelegate("vector_vector_int_new2")] public static vector_vector_int_new2Delegate vector_vector_int_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_int_getSize1Delegate(IntPtr vector);
        [NativeDelegate("vector_vector_int_getSize1")] public static vector_vector_int_getSize1Delegate vector_vector_int_getSize1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_int_getSize2Delegate(IntPtr vector, [In, Out] IntPtr[] size);
        [NativeDelegate("vector_vector_int_getSize2")] public static vector_vector_int_getSize2Delegate vector_vector_int_getSize2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_int_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_vector_int_getPointer")] public static vector_vector_int_getPointerDelegate vector_vector_int_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_int_copyDelegate(IntPtr vec, IntPtr[] dst);
        [NativeDelegate("vector_vector_int_copy")] public static vector_vector_int_copyDelegate vector_vector_int_copy;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_int_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_vector_int_delete")] public static vector_vector_int_deleteDelegate vector_vector_int_delete;
        #endregion
        #region vector<float>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_float_new1Delegate();
        [NativeDelegate("vector_vector_float_new1")] public static vector_vector_float_new1Delegate vector_vector_float_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_float_new2Delegate(IntPtr size);
        [NativeDelegate("vector_vector_float_new2")] public static vector_vector_float_new2Delegate vector_vector_float_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_float_getSize1Delegate(IntPtr vector);
        [NativeDelegate("vector_vector_float_getSize1")] public static vector_vector_float_getSize1Delegate vector_vector_float_getSize1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_float_getSize2Delegate(IntPtr vector, [In, Out] IntPtr[] size);
        [NativeDelegate("vector_vector_float_getSize2")] public static vector_vector_float_getSize2Delegate vector_vector_float_getSize2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_float_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_vector_float_getPointer")] public static vector_vector_float_getPointerDelegate vector_vector_float_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_float_copyDelegate(IntPtr vec, IntPtr[] dst);
        [NativeDelegate("vector_vector_float_copy")] public static vector_vector_float_copyDelegate vector_vector_float_copy;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_float_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_vector_float_delete")] public static vector_vector_float_deleteDelegate vector_vector_float_delete;
        #endregion
        #region vector<double>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_double_new1Delegate();
        [NativeDelegate("vector_vector_double_new1")] public static vector_vector_double_new1Delegate vector_vector_double_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_double_new2Delegate(IntPtr size);
        [NativeDelegate("vector_vector_double_new2")] public static vector_vector_double_new2Delegate vector_vector_double_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_double_getSize1Delegate(IntPtr vector);
        [NativeDelegate("vector_vector_double_getSize1")] public static vector_vector_double_getSize1Delegate vector_vector_double_getSize1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_double_getSize2Delegate(IntPtr vector, [In, Out] IntPtr[] size);
        [NativeDelegate("vector_vector_double_getSize2")] public static vector_vector_double_getSize2Delegate vector_vector_double_getSize2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_double_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_vector_double_getPointer")] public static vector_vector_double_getPointerDelegate vector_vector_double_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_double_copyDelegate(IntPtr vec, IntPtr[] dst);
        [NativeDelegate("vector_vector_double_copy")] public static vector_vector_double_copyDelegate vector_vector_double_copy;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_double_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_vector_double_delete")] public static vector_vector_double_deleteDelegate vector_vector_double_delete;
        #endregion
        #region vector<cv::KeyPoint>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_KeyPoint_new1Delegate();
        [NativeDelegate("vector_vector_KeyPoint_new1")] public static vector_vector_KeyPoint_new1Delegate vector_vector_KeyPoint_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_KeyPoint_new2Delegate(IntPtr size);
        [NativeDelegate("vector_vector_KeyPoint_new2")] public static vector_vector_KeyPoint_new2Delegate vector_vector_KeyPoint_new2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_KeyPoint_new3Delegate(
            IntPtr[] values, int size1, int[] size2);
        [NativeDelegate("vector_vector_KeyPoint_new3")] public static vector_vector_KeyPoint_new3Delegate vector_vector_KeyPoint_new3;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_KeyPoint_getSize1Delegate(IntPtr vector);
        [NativeDelegate("vector_vector_KeyPoint_getSize1")] public static vector_vector_KeyPoint_getSize1Delegate vector_vector_KeyPoint_getSize1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_KeyPoint_getSize2Delegate(IntPtr vector, [In, Out] IntPtr[] size);
        [NativeDelegate("vector_vector_KeyPoint_getSize2")] public static vector_vector_KeyPoint_getSize2Delegate vector_vector_KeyPoint_getSize2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_KeyPoint_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_vector_KeyPoint_getPointer")] public static vector_vector_KeyPoint_getPointerDelegate vector_vector_KeyPoint_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_KeyPoint_copyDelegate(IntPtr vec, IntPtr[] dst);
        [NativeDelegate("vector_vector_KeyPoint_copy")] public static vector_vector_KeyPoint_copyDelegate vector_vector_KeyPoint_copy;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_KeyPoint_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_vector_KeyPoint_delete")] public static vector_vector_KeyPoint_deleteDelegate vector_vector_KeyPoint_delete;
        #endregion
        #region vector<cv::DMatch>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_DMatch_new1Delegate();
        [NativeDelegate("vector_vector_DMatch_new1")] public static vector_vector_DMatch_new1Delegate vector_vector_DMatch_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_DMatch_new2Delegate(IntPtr size);
        [NativeDelegate("vector_vector_DMatch_new2")] public static vector_vector_DMatch_new2Delegate vector_vector_DMatch_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_DMatch_getSize1Delegate(IntPtr vector);
        [NativeDelegate("vector_vector_DMatch_getSize1")] public static vector_vector_DMatch_getSize1Delegate vector_vector_DMatch_getSize1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_DMatch_getSize2Delegate(IntPtr vector, [In, Out] IntPtr[] size);
        [NativeDelegate("vector_vector_DMatch_getSize2")] public static vector_vector_DMatch_getSize2Delegate vector_vector_DMatch_getSize2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_DMatch_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_vector_DMatch_getPointer")] public static vector_vector_DMatch_getPointerDelegate vector_vector_DMatch_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_DMatch_copyDelegate(IntPtr vec, IntPtr[] dst);
        [NativeDelegate("vector_vector_DMatch_copy")] public static vector_vector_DMatch_copyDelegate vector_vector_DMatch_copy;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_DMatch_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_vector_DMatch_delete")] public static vector_vector_DMatch_deleteDelegate vector_vector_DMatch_delete;
        #endregion
        #region vector<cv::Point>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_Point_new1Delegate();
        [NativeDelegate("vector_vector_Point_new1")] public static vector_vector_Point_new1Delegate vector_vector_Point_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_Point_new2Delegate(IntPtr size);
        [NativeDelegate("vector_vector_Point_new2")] public static vector_vector_Point_new2Delegate vector_vector_Point_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_Point_getSize1Delegate(IntPtr vector);
        [NativeDelegate("vector_vector_Point_getSize1")] public static vector_vector_Point_getSize1Delegate vector_vector_Point_getSize1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_Point_getSize2Delegate(IntPtr vector, [In, Out] IntPtr[] size);
        [NativeDelegate("vector_vector_Point_getSize2")] public static vector_vector_Point_getSize2Delegate vector_vector_Point_getSize2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_Point_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_vector_Point_getPointer")] public static vector_vector_Point_getPointerDelegate vector_vector_Point_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_Point_copyDelegate(IntPtr vec, IntPtr[] dst);
        [NativeDelegate("vector_vector_Point_copy")] public static vector_vector_Point_copyDelegate vector_vector_Point_copy;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_Point_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_vector_Point_delete")] public static vector_vector_Point_deleteDelegate vector_vector_Point_delete;
        #endregion
        #region vector<cv::Point2f>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_Point2f_new1Delegate();
        [NativeDelegate("vector_vector_Point2f_new1")] public static vector_vector_Point2f_new1Delegate vector_vector_Point2f_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_Point2f_new2Delegate(IntPtr size);
        [NativeDelegate("vector_vector_Point2f_new2")] public static vector_vector_Point2f_new2Delegate vector_vector_Point2f_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_Point2f_getSize1Delegate(IntPtr vector);
        [NativeDelegate("vector_vector_Point2f_getSize1")] public static vector_vector_Point2f_getSize1Delegate vector_vector_Point2f_getSize1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_Point2f_getSize2Delegate(IntPtr vector, [In, Out] IntPtr[] size);
        [NativeDelegate("vector_vector_Point2f_getSize2")] public static vector_vector_Point2f_getSize2Delegate vector_vector_Point2f_getSize2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_vector_Point2f_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_vector_Point2f_getPointer")] public static vector_vector_Point2f_getPointerDelegate vector_vector_Point2f_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_Point2f_copyDelegate(IntPtr vec, IntPtr[] dst);
        [NativeDelegate("vector_vector_Point2f_copy")] public static vector_vector_Point2f_copyDelegate vector_vector_Point2f_copy;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_vector_Point2f_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_vector_Point2f_delete")] public static vector_vector_Point2f_deleteDelegate vector_vector_Point2f_delete;
        #endregion
        #region vector<std::string>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_string_new1Delegate();
        [NativeDelegate("vector_string_new1")] public static vector_string_new1Delegate vector_string_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_string_new2Delegate(IntPtr size);
        [NativeDelegate("vector_string_new2")] public static vector_string_new2Delegate vector_string_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_string_getSizeDelegate(IntPtr vec);
        [NativeDelegate("vector_string_getSize")] public static vector_string_getSizeDelegate vector_string_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_string_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_string_getPointer")] public static vector_string_getPointerDelegate vector_string_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate sbyte* vector_string_elemAtDelegate(IntPtr vector, int i);
        [NativeDelegate("vector_string_elemAt")] public static vector_string_elemAtDelegate vector_string_elemAt;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_string_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_string_delete")] public static vector_string_deleteDelegate vector_string_delete;
        #endregion
        #region cv::Mat
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Mat_new1Delegate();
        [NativeDelegate("vector_Mat_new1")] public static vector_Mat_new1Delegate vector_Mat_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Mat_new2Delegate(IntPtr size);
        [NativeDelegate("vector_Mat_new2")] public static vector_Mat_new2Delegate vector_Mat_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Mat_new3Delegate(IntPtr data, IntPtr dataLength);
        [NativeDelegate("vector_Mat_new3")] public static vector_Mat_new3Delegate vector_Mat_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Mat_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_Mat_getSize")] public static vector_Mat_getSizeDelegate vector_Mat_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_Mat_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_Mat_getPointer")] public static vector_Mat_getPointerDelegate vector_Mat_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_Mat_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_Mat_delete")] public static vector_Mat_deleteDelegate vector_Mat_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_Mat_assignToArrayDelegate(IntPtr vector, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] arr);
        [NativeDelegate("vector_Mat_assignToArray")] public static vector_Mat_assignToArrayDelegate vector_Mat_assignToArray;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_Mat_addrefDelegate(IntPtr vector);
        [NativeDelegate("vector_Mat_addref")] public static vector_Mat_addrefDelegate vector_Mat_addref;

        #endregion

        #region cv::ml::DTrees::Node

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DTrees_Node_new1Delegate();
        [NativeDelegate("vector_DTrees_Node_new1")] public static vector_DTrees_Node_new1Delegate vector_DTrees_Node_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DTrees_Node_new2Delegate(IntPtr size);
        [NativeDelegate("vector_DTrees_Node_new2")] public static vector_DTrees_Node_new2Delegate vector_DTrees_Node_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DTrees_Node_new3Delegate([In]DTrees.Node[] data, IntPtr dataLength);
        [NativeDelegate("vector_DTrees_Node_new3")] public static vector_DTrees_Node_new3Delegate vector_DTrees_Node_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DTrees_Node_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_DTrees_Node_getSize")] public static vector_DTrees_Node_getSizeDelegate vector_DTrees_Node_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DTrees_Node_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_DTrees_Node_getPointer")] public static vector_DTrees_Node_getPointerDelegate vector_DTrees_Node_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_DTrees_Node_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_DTrees_Node_delete")] public static vector_DTrees_Node_deleteDelegate vector_DTrees_Node_delete;

        #endregion

        #region cv::ml::DTrees::Split

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DTrees_Split_new1Delegate();
        [NativeDelegate("vector_DTrees_Split_new1")] public static vector_DTrees_Split_new1Delegate vector_DTrees_Split_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DTrees_Split_new2Delegate(IntPtr size);
        [NativeDelegate("vector_DTrees_Split_new2")] public static vector_DTrees_Split_new2Delegate vector_DTrees_Split_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DTrees_Split_new3Delegate([In]DTrees.Split[] data, IntPtr dataLength);
        [NativeDelegate("vector_DTrees_Split_new3")] public static vector_DTrees_Split_new3Delegate vector_DTrees_Split_new3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DTrees_Split_getSizeDelegate(IntPtr vector);
        [NativeDelegate("vector_DTrees_Split_getSize")] public static vector_DTrees_Split_getSizeDelegate vector_DTrees_Split_getSize;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr vector_DTrees_Split_getPointerDelegate(IntPtr vector);
        [NativeDelegate("vector_DTrees_Split_getPointer")] public static vector_DTrees_Split_getPointerDelegate vector_DTrees_Split_getPointer;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vector_DTrees_Split_deleteDelegate(IntPtr vector);
        [NativeDelegate("vector_DTrees_Split_delete")] public static vector_DTrees_Split_deleteDelegate vector_DTrees_Split_delete;

        #endregion

    }
}
