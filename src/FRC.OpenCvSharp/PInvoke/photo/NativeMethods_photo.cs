using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591
// ReSharper disable InconsistentNaming

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_inpaintDelegate(IntPtr src, IntPtr inpaintMask,
            IntPtr dst, double inpaintRadius, int flags);
        [NativeDelegate("photo_inpaint")] public static photo_inpaintDelegate photo_inpaint;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_fastNlMeansDenoisingDelegate(IntPtr src, IntPtr dst, float h,
            int templateWindowSize, int searchWindowSize);
        [NativeDelegate("photo_fastNlMeansDenoising")] public static photo_fastNlMeansDenoisingDelegate photo_fastNlMeansDenoising;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_fastNlMeansDenoisingColoredDelegate(IntPtr src, IntPtr dst,
            float h, float hColor, int templateWindowSize, int searchWindowSize);
        [NativeDelegate("photo_fastNlMeansDenoisingColored")] public static photo_fastNlMeansDenoisingColoredDelegate photo_fastNlMeansDenoisingColored;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_fastNlMeansDenoisingMultiDelegate(IntPtr[] srcImgs, int srcImgsLength,
            IntPtr dst, int imgToDenoiseIndex, int temporalWindowSize,
            float h, int templateWindowSize, int searchWindowSize);
        [NativeDelegate("photo_fastNlMeansDenoisingMulti")] public static photo_fastNlMeansDenoisingMultiDelegate photo_fastNlMeansDenoisingMulti;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_fastNlMeansDenoisingColoredMultiDelegate(IntPtr[] srcImgs, int srcImgsLength,
            IntPtr dst, int imgToDenoiseIndex, int temporalWindowSize,
            float h, float hColor, int templateWindowSize, int searchWindowSize);
        [NativeDelegate("photo_fastNlMeansDenoisingColoredMulti")] public static photo_fastNlMeansDenoisingColoredMultiDelegate photo_fastNlMeansDenoisingColoredMulti;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_denoise_TVL1Delegate(
            IntPtr[] observations, int observationsSize, IntPtr result, double lambda, int niters);
        [NativeDelegate("photo_denoise_TVL1")] public static photo_denoise_TVL1Delegate photo_denoise_TVL1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_decolorDelegate(
            IntPtr src, IntPtr grayscale, IntPtr color_boost);
        [NativeDelegate("photo_decolor")] public static photo_decolorDelegate photo_decolor;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_seamlessCloneDelegate(
            IntPtr src, IntPtr dst, IntPtr mask, Point p, IntPtr blend, int flags);
        [NativeDelegate("photo_seamlessClone")] public static photo_seamlessCloneDelegate photo_seamlessClone;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_colorChangeDelegate(
            IntPtr src, IntPtr mask, IntPtr dst, float red_mul, float green_mul, float blue_mul);
        [NativeDelegate("photo_colorChange")] public static photo_colorChangeDelegate photo_colorChange;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_illuminationChangeDelegate(
            IntPtr src, IntPtr mask, IntPtr dst, float alpha, float beta);
        [NativeDelegate("photo_illuminationChange")] public static photo_illuminationChangeDelegate photo_illuminationChange;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_textureFlatteningDelegate(
            IntPtr src, IntPtr mask, IntPtr dst,
            float low_threshold, float high_threshold, int kernel_size);
        [NativeDelegate("photo_textureFlattening")] public static photo_textureFlatteningDelegate photo_textureFlattening;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_edgePreservingFilterDelegate(
            IntPtr src, IntPtr dst, int flags, float sigma_s, float sigma_r);
        [NativeDelegate("photo_edgePreservingFilter")] public static photo_edgePreservingFilterDelegate photo_edgePreservingFilter;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_detailEnhanceDelegate(
            IntPtr src, IntPtr dst, float sigma_s, float sigma_r);
        [NativeDelegate("photo_detailEnhance")] public static photo_detailEnhanceDelegate photo_detailEnhance;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_pencilSketchDelegate(
            IntPtr src, IntPtr dst1, IntPtr dst2,
            float sigma_s, float sigma_r, float shade_factor);
        [NativeDelegate("photo_pencilSketch")] public static photo_pencilSketchDelegate photo_pencilSketch;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void photo_stylizationDelegate(
            IntPtr src, IntPtr dst, float sigma_s, float sigma_r);
        [NativeDelegate("photo_stylization")] public static photo_stylizationDelegate photo_stylization;

    }
}
