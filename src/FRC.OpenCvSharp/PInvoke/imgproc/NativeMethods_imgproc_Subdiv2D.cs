using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_Subdiv2D_new1Delegate();
        [NativeDelegate("imgproc_Subdiv2D_new1")] public static imgproc_Subdiv2D_new1Delegate imgproc_Subdiv2D_new1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr imgproc_Subdiv2D_new2Delegate(Rect rect);
        [NativeDelegate("imgproc_Subdiv2D_new2")] public static imgproc_Subdiv2D_new2Delegate imgproc_Subdiv2D_new2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_Subdiv2D_deleteDelegate(IntPtr obj);
        [NativeDelegate("imgproc_Subdiv2D_delete")] public static imgproc_Subdiv2D_deleteDelegate imgproc_Subdiv2D_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_Subdiv2D_initDelaunayDelegate(IntPtr obj, Rect rect);
        [NativeDelegate("imgproc_Subdiv2D_initDelaunay")] public static imgproc_Subdiv2D_initDelaunayDelegate imgproc_Subdiv2D_initDelaunay;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_Subdiv2D_insert1Delegate(IntPtr obj, Point2f pt);
        [NativeDelegate("imgproc_Subdiv2D_insert1")] public static imgproc_Subdiv2D_insert1Delegate imgproc_Subdiv2D_insert1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_Subdiv2D_insert2Delegate(IntPtr obj, [MarshalAs(UnmanagedType.LPArray)] Point2f[] ptArray, int length);
        [NativeDelegate("imgproc_Subdiv2D_insert2")] public static imgproc_Subdiv2D_insert2Delegate imgproc_Subdiv2D_insert2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_Subdiv2D_locateDelegate(IntPtr obj, Point2f pt, out int edge, out int vertex);
        [NativeDelegate("imgproc_Subdiv2D_locate")] public static imgproc_Subdiv2D_locateDelegate imgproc_Subdiv2D_locate;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_Subdiv2D_findNearestDelegate(IntPtr obj, Point2f pt, out Point2f nearestPt);
        [NativeDelegate("imgproc_Subdiv2D_findNearest")] public static imgproc_Subdiv2D_findNearestDelegate imgproc_Subdiv2D_findNearest;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_Subdiv2D_getEdgeListDelegate(IntPtr obj, out IntPtr edgeList);
        [NativeDelegate("imgproc_Subdiv2D_getEdgeList")] public static imgproc_Subdiv2D_getEdgeListDelegate imgproc_Subdiv2D_getEdgeList;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_Subdiv2D_getTriangleListDelegate(IntPtr obj, out IntPtr triangleList);
        [NativeDelegate("imgproc_Subdiv2D_getTriangleList")] public static imgproc_Subdiv2D_getTriangleListDelegate imgproc_Subdiv2D_getTriangleList;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_Subdiv2D_getVoronoiFacetListDelegate(IntPtr obj, [MarshalAs(UnmanagedType.LPArray)] int[] idx, int idxCount,
            out IntPtr facetList, out IntPtr facetCenters);
        [NativeDelegate("imgproc_Subdiv2D_getVoronoiFacetList")] public static imgproc_Subdiv2D_getVoronoiFacetListDelegate imgproc_Subdiv2D_getVoronoiFacetList;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void imgproc_Subdiv2D_getVoronoiFacetListDelegate2(IntPtr obj, IntPtr idx, int idxCount,
            out IntPtr facetList, out IntPtr facetCenters);
        [NativeDelegate("imgproc_Subdiv2D_getVoronoiFacetList")] public static imgproc_Subdiv2D_getVoronoiFacetListDelegate2 imgproc_Subdiv2D_getVoronoiFacetList2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Point2f imgproc_Subdiv2D_getVertexDelegate(IntPtr obj, int vertex, out int firstEdge);
        [NativeDelegate("imgproc_Subdiv2D_getVertex")] public static imgproc_Subdiv2D_getVertexDelegate imgproc_Subdiv2D_getVertex;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_Subdiv2D_getEdgeDelegate(IntPtr obj, int edge, int nextEdgeType);
        [NativeDelegate("imgproc_Subdiv2D_getEdge")] public static imgproc_Subdiv2D_getEdgeDelegate imgproc_Subdiv2D_getEdge;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_Subdiv2D_nextEdgeDelegate(IntPtr obj, int edge);
        [NativeDelegate("imgproc_Subdiv2D_nextEdge")] public static imgproc_Subdiv2D_nextEdgeDelegate imgproc_Subdiv2D_nextEdge;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_Subdiv2D_rotateEdgeDelegate(IntPtr obj, int edge, int rotate);
        [NativeDelegate("imgproc_Subdiv2D_rotateEdge")] public static imgproc_Subdiv2D_rotateEdgeDelegate imgproc_Subdiv2D_rotateEdge;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_Subdiv2D_symEdgeDelegate(IntPtr obj, int edge);
        [NativeDelegate("imgproc_Subdiv2D_symEdge")] public static imgproc_Subdiv2D_symEdgeDelegate imgproc_Subdiv2D_symEdge;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_Subdiv2D_edgeOrgDelegate(IntPtr obj, int edge, out Point2f orgpt);
        [NativeDelegate("imgproc_Subdiv2D_edgeOrg")] public static imgproc_Subdiv2D_edgeOrgDelegate imgproc_Subdiv2D_edgeOrg;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int imgproc_Subdiv2D_edgeDstDelegate(IntPtr obj, int edge, out Point2f dstpt);
        [NativeDelegate("imgproc_Subdiv2D_edgeDst")] public static imgproc_Subdiv2D_edgeDstDelegate imgproc_Subdiv2D_edgeDst;

    }
}
