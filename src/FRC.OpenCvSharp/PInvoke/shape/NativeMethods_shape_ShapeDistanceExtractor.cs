using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        // ShapeDistanceExtractor

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float shape_ShapeDistanceExtractor_computeDistanceDelegate(
            IntPtr obj, IntPtr contour1, IntPtr contour2);
        [NativeDelegate("shape_ShapeDistanceExtractor_computeDistance")] public static shape_ShapeDistanceExtractor_computeDistanceDelegate shape_ShapeDistanceExtractor_computeDistance;

        // ShapeContextDistanceExtractor

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_Ptr_ShapeContextDistanceExtractor_deleteDelegate(IntPtr obj);
        [NativeDelegate("shape_Ptr_ShapeContextDistanceExtractor_delete")] public static ReleaseFunc shape_Ptr_ShapeContextDistanceExtractor_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr shape_Ptr_ShapeContextDistanceExtractor_getDelegate(IntPtr obj);
        [NativeDelegate("shape_Ptr_ShapeContextDistanceExtractor_get")] public static ObjFunc shape_Ptr_ShapeContextDistanceExtractor_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_ShapeContextDistanceExtractor_setAngularBinsDelegate(IntPtr obj, int val);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_setAngularBins")] public static shape_ShapeContextDistanceExtractor_setAngularBinsDelegate shape_ShapeContextDistanceExtractor_setAngularBins;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int shape_ShapeContextDistanceExtractor_getAngularBinsDelegate(IntPtr obj);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_getAngularBins")] public static shape_ShapeContextDistanceExtractor_getAngularBinsDelegate shape_ShapeContextDistanceExtractor_getAngularBins;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_ShapeContextDistanceExtractor_setRadialBinsDelegate(IntPtr obj, int val);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_setRadialBins")] public static shape_ShapeContextDistanceExtractor_setRadialBinsDelegate shape_ShapeContextDistanceExtractor_setRadialBins;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int shape_ShapeContextDistanceExtractor_getRadialBinsDelegate(IntPtr obj);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_getRadialBins")] public static shape_ShapeContextDistanceExtractor_getRadialBinsDelegate shape_ShapeContextDistanceExtractor_getRadialBins;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_ShapeContextDistanceExtractor_setInnerRadiusDelegate(IntPtr obj, float val);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_setInnerRadius")] public static shape_ShapeContextDistanceExtractor_setInnerRadiusDelegate shape_ShapeContextDistanceExtractor_setInnerRadius;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float shape_ShapeContextDistanceExtractor_getInnerRadiusDelegate(IntPtr obj);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_getInnerRadius")] public static shape_ShapeContextDistanceExtractor_getInnerRadiusDelegate shape_ShapeContextDistanceExtractor_getInnerRadius;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_ShapeContextDistanceExtractor_setOuterRadiusDelegate(IntPtr obj, float val);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_setOuterRadius")] public static shape_ShapeContextDistanceExtractor_setOuterRadiusDelegate shape_ShapeContextDistanceExtractor_setOuterRadius;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float shape_ShapeContextDistanceExtractor_getOuterRadiusDelegate(IntPtr obj);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_getOuterRadius")] public static shape_ShapeContextDistanceExtractor_getOuterRadiusDelegate shape_ShapeContextDistanceExtractor_getOuterRadius;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_ShapeContextDistanceExtractor_setRotationInvariantDelegate(IntPtr obj, int val);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_setRotationInvariant")] public static shape_ShapeContextDistanceExtractor_setRotationInvariantDelegate shape_ShapeContextDistanceExtractor_setRotationInvariant;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int shape_ShapeContextDistanceExtractor_getRotationInvariantDelegate(IntPtr obj);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_getRotationInvariant")] public static shape_ShapeContextDistanceExtractor_getRotationInvariantDelegate shape_ShapeContextDistanceExtractor_getRotationInvariant;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_ShapeContextDistanceExtractor_setShapeContextWeightDelegate(IntPtr obj, float val);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_setShapeContextWeight")] public static shape_ShapeContextDistanceExtractor_setShapeContextWeightDelegate shape_ShapeContextDistanceExtractor_setShapeContextWeight;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float shape_ShapeContextDistanceExtractor_getShapeContextWeightDelegate(IntPtr obj);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_getShapeContextWeight")] public static shape_ShapeContextDistanceExtractor_getShapeContextWeightDelegate shape_ShapeContextDistanceExtractor_getShapeContextWeight;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_ShapeContextDistanceExtractor_setImageAppearanceWeightDelegate(IntPtr obj, float val);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_setImageAppearanceWeight")] public static shape_ShapeContextDistanceExtractor_setImageAppearanceWeightDelegate shape_ShapeContextDistanceExtractor_setImageAppearanceWeight;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float shape_ShapeContextDistanceExtractor_getImageAppearanceWeightDelegate(IntPtr obj);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_getImageAppearanceWeight")] public static shape_ShapeContextDistanceExtractor_getImageAppearanceWeightDelegate shape_ShapeContextDistanceExtractor_getImageAppearanceWeight;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_ShapeContextDistanceExtractor_setBendingEnergyWeightDelegate(IntPtr obj, float val);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_setBendingEnergyWeight")] public static shape_ShapeContextDistanceExtractor_setBendingEnergyWeightDelegate shape_ShapeContextDistanceExtractor_setBendingEnergyWeight;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float shape_ShapeContextDistanceExtractor_getBendingEnergyWeightDelegate(IntPtr obj);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_getBendingEnergyWeight")] public static shape_ShapeContextDistanceExtractor_getBendingEnergyWeightDelegate shape_ShapeContextDistanceExtractor_getBendingEnergyWeight;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_ShapeContextDistanceExtractor_setImagesDelegate(IntPtr obj, IntPtr image1, IntPtr image2);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_setImages")] public static shape_ShapeContextDistanceExtractor_setImagesDelegate shape_ShapeContextDistanceExtractor_setImages;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_ShapeContextDistanceExtractor_getImagesDelegate(IntPtr obj, IntPtr image1, IntPtr image2);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_getImages")] public static shape_ShapeContextDistanceExtractor_getImagesDelegate shape_ShapeContextDistanceExtractor_getImages;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_ShapeContextDistanceExtractor_setIterationsDelegate(IntPtr obj, int val);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_setIterations")] public static shape_ShapeContextDistanceExtractor_setIterationsDelegate shape_ShapeContextDistanceExtractor_setIterations;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int shape_ShapeContextDistanceExtractor_getIterationsDelegate(IntPtr obj);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_getIterations")] public static shape_ShapeContextDistanceExtractor_getIterationsDelegate shape_ShapeContextDistanceExtractor_getIterations;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_ShapeContextDistanceExtractor_setStdDevDelegate(IntPtr obj, float val);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_setStdDev")] public static shape_ShapeContextDistanceExtractor_setStdDevDelegate shape_ShapeContextDistanceExtractor_setStdDev;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float shape_ShapeContextDistanceExtractor_getStdDevDelegate(IntPtr obj);
        [NativeDelegate("shape_ShapeContextDistanceExtractor_getStdDev")] public static shape_ShapeContextDistanceExtractor_getStdDevDelegate shape_ShapeContextDistanceExtractor_getStdDev;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr shape_createShapeContextDistanceExtractorDelegate(
            int nAngularBins, int nRadialBins,
            float innerRadius, float outerRadius, int iterations /*,
	        const Ptr<HistogramCostExtractor> &comparer = createChiHistogramCostExtractor(),
	        const Ptr<ShapeTransformer> &transformer = createThinPlateSplineShapeTransformer()*/);
        [NativeDelegate("shape_createShapeContextDistanceExtractor")] public static shape_createShapeContextDistanceExtractorDelegate shape_createShapeContextDistanceExtractor;


        // HausdorffDistanceExtractor
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_Ptr_HausdorffDistanceExtractor_deleteDelegate(IntPtr obj);
        [NativeDelegate("shape_Ptr_HausdorffDistanceExtractor_delete")] public static ReleaseFunc shape_Ptr_HausdorffDistanceExtractor_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr shape_Ptr_HausdorffDistanceExtractor_getDelegate(IntPtr obj);
        [NativeDelegate("shape_Ptr_HausdorffDistanceExtractor_get")] public static ObjFunc shape_Ptr_HausdorffDistanceExtractor_get;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_HausdorffDistanceExtractor_setDistanceFlagDelegate(IntPtr obj, int val);
        [NativeDelegate("shape_HausdorffDistanceExtractor_setDistanceFlag")] public static shape_HausdorffDistanceExtractor_setDistanceFlagDelegate shape_HausdorffDistanceExtractor_setDistanceFlag;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int shape_HausdorffDistanceExtractor_getDistanceFlagDelegate(IntPtr obj);
        [NativeDelegate("shape_HausdorffDistanceExtractor_getDistanceFlag")] public static shape_HausdorffDistanceExtractor_getDistanceFlagDelegate shape_HausdorffDistanceExtractor_getDistanceFlag;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void shape_HausdorffDistanceExtractor_setRankProportionDelegate(IntPtr obj, float val);
        [NativeDelegate("shape_HausdorffDistanceExtractor_setRankProportion")] public static shape_HausdorffDistanceExtractor_setRankProportionDelegate shape_HausdorffDistanceExtractor_setRankProportion;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float shape_HausdorffDistanceExtractor_getRankProportionDelegate(IntPtr obj);
        [NativeDelegate("shape_HausdorffDistanceExtractor_getRankProportion")] public static shape_HausdorffDistanceExtractor_getRankProportionDelegate shape_HausdorffDistanceExtractor_getRankProportion;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr shape_createHausdorffDistanceExtractorDelegate(int distanceFlag, float rankProp);
        [NativeDelegate("shape_createHausdorffDistanceExtractor")] public static shape_createHausdorffDistanceExtractorDelegate shape_createHausdorffDistanceExtractor;
    }
}
