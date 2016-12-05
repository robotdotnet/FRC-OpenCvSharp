using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;
using System.Text;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Algorithm_writeDelegate(IntPtr obj, IntPtr fs);
        [NativeDelegate("core_Algorithm_write")] public static core_Algorithm_writeDelegate core_Algorithm_write;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Algorithm_readDelegate(IntPtr obj, IntPtr fn);
        [NativeDelegate("core_Algorithm_read")] public static core_Algorithm_readDelegate core_Algorithm_read;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int core_Algorithm_emptyDelegate(IntPtr obj);
        [NativeDelegate("core_Algorithm_empty")] public static core_Algorithm_emptyDelegate core_Algorithm_empty;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Algorithm_saveDelegate(IntPtr obj, string filename);
        [NativeDelegate("core_Algorithm_save")] public static core_Algorithm_saveDelegate core_Algorithm_save;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void core_Algorithm_getDefaultNameDelegate(
            IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] StringBuilder buf, int bufLength);
        [NativeDelegate("core_Algorithm_getDefaultName")] public static core_Algorithm_getDefaultNameDelegate core_Algorithm_getDefaultName;
    }
}
