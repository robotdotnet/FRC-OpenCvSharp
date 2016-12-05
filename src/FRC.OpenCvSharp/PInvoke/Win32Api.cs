using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    /// <summary>
    /// Win32API Wrapper
    /// </summary>
    public static class Win32Api
    {
        #region Constants
        public const int DIB_RGB_COLORS = 0; /* color table in RGBs */
        public const int DIB_PAL_COLORS = 1; /* color table in palette indices */

        public const int BI_RGB = 0;
        public const int BI_RLE8 = 1;
        public const int BI_RLE4 = 2;
        public const int BI_BITFIELDS = 3;
        public const int BI_JPEG = 4;
        public const int BI_PNG = 5;

        public const int BLACKONWHITE = 1;
        public const int WHITEONBLACK = 2;
        public const int COLORONCOLOR = 3;
        public const int HALFTONE = 4;
        public const int MAXSTRETCHBLTMODE = 4;

        /* Ternary raster operations */
        public const uint SRCCOPY = (uint)0x00CC0020; /* dest = source                   */
        public const uint SRCPAINT = (uint)0x00EE0086; /* dest = source OR dest           */
        public const uint SRCAND = (uint)0x008800C6; /* dest = source AND dest          */
        public const uint SRCINVERT = (uint)0x00660046; /* dest = source XOR dest          */
        public const uint SRCERASE = (uint)0x00440328; /* dest = source AND (NOT dest )   */
        public const uint NOTSRCCOPY = (uint)0x00330008; /* dest = (NOT source)             */
        public const uint NOTSRCERASE = (uint)0x001100A6; /* dest = (NOT src) AND (NOT dest) */
        public const uint MERGECOPY = (uint)0x00C000CA; /* dest = (source AND pattern)     */
        public const uint MERGEPAINT = (uint)0x00BB0226; /* dest = (NOT source) OR dest     */
        public const uint PATCOPY = (uint)0x00F00021; /* dest = pattern                  */
        public const uint PATPAINT = (uint)0x00FB0A09; /* dest = DPSnoo                   */
        public const uint PATINVERT = (uint)0x005A0049; /* dest = pattern XOR dest         */
        public const uint DSTINVERT = (uint)0x00550009; /* dest = (NOT dest)               */
        public const uint BLACKNESS = (uint)0x00000042; /* dest = BLACK                    */
        public const uint WHITENESS = (uint)0x00FF0062; /* dest = WHITE                    */
        public const uint NOMIRRORBITMAP = (uint)0x80000000; /* Do not Mirror the bitmap in this call */
        public const uint CAPTUREBLT = (uint)0x40000000; /* Include layered windows */
        #endregion

        #region Structures
        public enum ColorTableType : int
        {
            Rgb = 0,
            Palette = 1,
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct ICONINFO
        {
            public bool IsIcon;
            public int HotSpotX;
            public int HotSoptY;
            public IntPtr MaskHbitmap;
            public IntPtr ColorHbitmap;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct BITMAPINFOHEADER
        {
            public UInt32 Size;
            public Int32 Width;
            public Int32 Height;
            public UInt16 Planes;
            public UInt16 BitCount;
            public UInt32 Compression;
            public UInt32 SizeImage;
            public Int32 XPelsPerMeter;
            public Int32 YPelsPerMeter;
            public UInt32 ClrUsed;
            public UInt32 ClrImportant;
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct RGBQUAD
        {
            public Byte Blue;
            public Byte Green;
            public Byte Red;
            public Byte Reserved;
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct BITMAPINFO
        {
            public BITMAPINFOHEADER Header;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public RGBQUAD[] Colors;
        };
        #endregion
        #region gdi32
#if LANG_JP
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hdc">デバイスコンテキストのハンドル</param>
        /// <param name="XDest">転送先長方形の左上隅の x 座標</param>
        /// <param name="YDest">転送先長方形の左上隅の y 座標</param>
        /// <param name="dwWidth">転送元長方形の幅</param>
        /// <param name="dwHeight">転送元長方形の高さ</param>
        /// <param name="XSrc">転送元長方形の左下隅の x 座標</param>
        /// <param name="YSrc">転送元長方形の左下隅の y 座標</param>
        /// <param name="uStartScan">配列内の最初の走査行</param>
        /// <param name="cScanLines">走査行の数</param>
        /// <param name="lpvBits">DIB ビットからなる配列</param>
        /// <param name="lpbmi">ビットマップ情報</param>
        /// <param name="fuColorUse">RGB 値またはパレットインデックス</param>
        /// <returns></returns>
#else
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hdc"></param>
        /// <param name="XDest"></param>
        /// <param name="YDest"></param>
        /// <param name="dwWidth"></param>
        /// <param name="dwHeight"></param>
        /// <param name="XSrc"></param>
        /// <param name="YSrc"></param>
        /// <param name="uStartScan"></param>
        /// <param name="cScanLines"></param>
        /// <param name="lpvBits"></param>
        /// <param name="lpbmi"></param>
        /// <param name="fuColorUse"></param>
        /// <returns></returns>
#endif
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int SetDIBitsToDeviceDelegate(IntPtr hdc, Int32 XDest, Int32 YDest, UInt32 dwWidth, UInt32 dwHeight, Int32 XSrc, Int32 YSrc, UInt32 uStartScan, UInt32 cScanLines, IntPtr lpvBits, ref BITMAPINFO lpbmi, UInt32 fuColorUse);
        [NativeDelegate("SetDIBitsToDevice")] public static SetDIBitsToDeviceDelegate SetDIBitsToDevice;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int SetDIBitsToDeviceDelegate2(IntPtr hdc, Int32 XDest, Int32 YDest, UInt32 dwWidth, UInt32 dwHeight, Int32 XSrc, Int32 YSrc, UInt32 uStartScan, UInt32 cScanLines, IntPtr lpvBits, IntPtr lpbmi, UInt32 fuColorUse);
        [NativeDelegate("SetDIBitsToDevice")] public static SetDIBitsToDeviceDelegate2 SetDIBitsToDevice2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int GetDIBColorTableDelegate(IntPtr dc, int index, int entries, [In, Out] RGBQUAD[] colors);
        [NativeDelegate("GetDIBColorTable")] public static GetDIBColorTableDelegate GetDIBColorTable;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int GetDIBitsDelegate(IntPtr dc, IntPtr bmp, int startScan, int scanLineCount, [In, Out] byte[] data, IntPtr info, ColorTableType usage);
        [NativeDelegate("GetDIBits")] public static GetDIBitsDelegate GetDIBits;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr CreateCompatibleDCDelegate(IntPtr hdc);
        [NativeDelegate("CreateCompatibleDC")] public static CreateCompatibleDCDelegate CreateCompatibleDC;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool GetIconInfoDelegate(IntPtr icon, out ICONINFO info);
        [NativeDelegate("GetIconInfo")] public static GetIconInfoDelegate GetIconInfo;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr GetDCDelegate(IntPtr window);
        [NativeDelegate("GetDC")] public static GetDCDelegate GetDC;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool ReleaseDCDelegate(IntPtr window, IntPtr dc);
        [NativeDelegate("ReleaseDC")] public static ReleaseDCDelegate ReleaseDC;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr SelectObjectDelegate(IntPtr hdc, IntPtr obj);
        [NativeDelegate("SelectObject")] public static SelectObjectDelegate SelectObject;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool DeleteObjectDelegate(IntPtr handle);
        [NativeDelegate("DeleteObject")] public static DeleteObjectDelegate DeleteObject;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool DeleteDCDelegate(IntPtr hdc);
        [NativeDelegate("DeleteDC")] public static DeleteDCDelegate DeleteDC;
#if LANG_JP
        /// <summary>
        /// 指定されたデバイスコンテキストのビットマップ伸縮モードを設定します
        /// </summary>
        /// <param name="hdc">デバイスコンテキストのハンドル</param>
        /// <param name="iStretchMode">ビットマップの伸縮モード</param>
        /// <returns></returns>
#else
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hdc"></param>
        /// <param name="iStretchMode"></param>
        /// <returns></returns>
#endif
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int SetStretchBltModeDelegate(IntPtr hdc, int iStretchMode);
        [NativeDelegate("SetStretchBltMode")] public static SetStretchBltModeDelegate SetStretchBltMode;
#if LANG_JP
        /// <summary>
        /// 指定されたデバイス独立ビットマップ（DIB）内の長方形ピクセルの色データを、指定された長方形へコピーします。
        /// コピー先長方形がコピー元長方形より大きい場合、この関数はコピー先長方形に合わせて、色データの行と列を拡大します。
        /// コピー先長方形がコピー元長方形より小さい場合、この関数は指定されたラスタオペレーションを使って、行と列を縮小します。
        /// </summary>
        /// <param name="hdc">デバイスコンテキストのハンドル</param>
        /// <param name="XDest">コピー先長方形の左上隅の x 座標</param>
        /// <param name="YDest">コピー先長方形の左上隅の y 座標</param>
        /// <param name="nDestWidth">コピー先長方形の幅</param>
        /// <param name="nDestHeight">コピー先長方形の高さ</param>
        /// <param name="XSrc">コピー元長方形の左上隅の x 座標</param>
        /// <param name="YSrc">コピー元長方形の左上隅の x 座標</param>
        /// <param name="nSrcWidth">コピー元長方形の幅</param>
        /// <param name="nSrcHeight">コピー元長方形の高さ</param>
        /// <param name="lpBits">ビットマップのビット</param>
        /// <param name="lpBitsInfo">ビットマップのデータ</param>
        /// <param name="iUsage">データの種類</param>
        /// <param name="dwRop">ラスタオペレーションコード</param>
        /// <returns></returns>
#else
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hdc"></param>
        /// <param name="XDest"></param>
        /// <param name="YDest"></param>
        /// <param name="nDestWidth"></param>
        /// <param name="nDestHeight"></param>
        /// <param name="XSrc"></param>
        /// <param name="YSrc"></param>
        /// <param name="nSrcWidth"></param>
        /// <param name="nSrcHeight"></param>
        /// <param name="lpBits"></param>
        /// <param name="lpBitsInfo"></param>
        /// <param name="iUsage"></param>
        /// <param name="dwRop"></param>
        /// <returns></returns>
#endif
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int StretchDIBitsDelegate(IntPtr hdc, Int32 XDest, Int32 YDest, Int32 nDestWidth, Int32 nDestHeight, Int32 XSrc, Int32 YSrc, Int32 nSrcWidth, Int32 nSrcHeight, IntPtr lpBits, ref BITMAPINFO lpBitsInfo, UInt32 iUsage, UInt32 dwRop);
        [NativeDelegate("StretchDIBits")] public static StretchDIBitsDelegate StretchDIBits;
        #endregion
    }

}
