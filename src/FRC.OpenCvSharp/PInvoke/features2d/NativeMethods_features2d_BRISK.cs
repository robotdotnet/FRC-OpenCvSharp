using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        // ReSharper disable InconsistentNaming

        // BRISK
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_BRISK_create1Delegate(int thresh, int octaves, float patternScale);
        [NativeDelegate("features2d_BRISK_create1")] public static features2d_BRISK_create1Delegate features2d_BRISK_create1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_BRISK_create2Delegate(
            float[] radiusList, int radiusListLength, int[] numberList, int numberListLength,
            float dMax, float dMin,
            int[] indexChange, int indexChangeLength);
        [NativeDelegate("features2d_BRISK_create2")] public static features2d_BRISK_create2Delegate features2d_BRISK_create2;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void features2d_Ptr_BRISK_deleteDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_BRISK_delete")] public static ReleaseFunc features2d_Ptr_BRISK_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_Ptr_BRISK_getDelegate(IntPtr ptr);
        [NativeDelegate("features2d_Ptr_BRISK_get")] public static ObjFunc features2d_Ptr_BRISK_get;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr features2d_BRISK_infoDelegate(IntPtr obj);
        [NativeDelegate("features2d_BRISK_info")] public static features2d_BRISK_infoDelegate features2d_BRISK_info;
        */
    }
}
