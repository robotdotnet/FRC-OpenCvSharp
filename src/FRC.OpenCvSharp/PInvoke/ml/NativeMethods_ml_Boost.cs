using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_Boost_getBoostTypeDelegate(IntPtr obj);
        [NativeDelegate("ml_Boost_getBoostType")] public static ml_Boost_getBoostTypeDelegate ml_Boost_getBoostType;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_Boost_setBoostTypeDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_Boost_setBoostType")] public static ml_Boost_setBoostTypeDelegate ml_Boost_setBoostType;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_Boost_getWeakCountDelegate(IntPtr obj);
        [NativeDelegate("ml_Boost_getWeakCount")] public static ml_Boost_getWeakCountDelegate ml_Boost_getWeakCount;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_Boost_setWeakCountDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_Boost_setWeakCount")] public static ml_Boost_setWeakCountDelegate ml_Boost_setWeakCount;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double ml_Boost_getWeightTrimRateDelegate(IntPtr obj);
        [NativeDelegate("ml_Boost_getWeightTrimRate")] public static ml_Boost_getWeightTrimRateDelegate ml_Boost_getWeightTrimRate;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_Boost_setWeightTrimRateDelegate(IntPtr obj, double val);
        [NativeDelegate("ml_Boost_setWeightTrimRate")] public static ml_Boost_setWeightTrimRateDelegate ml_Boost_setWeightTrimRate;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_Boost_createDelegate();
        [NativeDelegate("ml_Boost_create")] public static ml_Boost_createDelegate ml_Boost_create;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_Ptr_Boost_deleteDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_Boost_delete")] public static ReleaseFunc ml_Ptr_Boost_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_Ptr_Boost_getDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_Boost_get")] public static ObjFunc ml_Ptr_Boost_get;
    }
}
