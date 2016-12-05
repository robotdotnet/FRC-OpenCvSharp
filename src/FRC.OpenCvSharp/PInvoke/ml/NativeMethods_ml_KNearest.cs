using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_KNearest_getDefaultKDelegate(IntPtr obj);
        [NativeDelegate("ml_KNearest_getDefaultK")] public static ml_KNearest_getDefaultKDelegate ml_KNearest_getDefaultK;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_KNearest_setDefaultKDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_KNearest_setDefaultK")] public static ml_KNearest_setDefaultKDelegate ml_KNearest_setDefaultK;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_KNearest_getIsClassifierDelegate(IntPtr obj);
        [NativeDelegate("ml_KNearest_getIsClassifier")] public static ml_KNearest_getIsClassifierDelegate ml_KNearest_getIsClassifier;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_KNearest_setIsClassifierDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_KNearest_setIsClassifier")] public static ml_KNearest_setIsClassifierDelegate ml_KNearest_setIsClassifier;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_KNearest_getEmaxDelegate(IntPtr obj);
        [NativeDelegate("ml_KNearest_getEmax")] public static ml_KNearest_getEmaxDelegate ml_KNearest_getEmax;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_KNearest_setEmaxDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_KNearest_setEmax")] public static ml_KNearest_setEmaxDelegate ml_KNearest_setEmax;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_KNearest_getAlgorithmTypeDelegate(IntPtr obj);
        [NativeDelegate("ml_KNearest_getAlgorithmType")] public static ml_KNearest_getAlgorithmTypeDelegate ml_KNearest_getAlgorithmType;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_KNearest_setAlgorithmTypeDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_KNearest_setAlgorithmType")] public static ml_KNearest_setAlgorithmTypeDelegate ml_KNearest_setAlgorithmType;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float ml_KNearest_findNearestDelegate(IntPtr samples, int k,
            IntPtr results, IntPtr neighborResponses, IntPtr dist);
        [NativeDelegate("ml_KNearest_findNearest")] public static ml_KNearest_findNearestDelegate ml_KNearest_findNearest;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_KNearest_createDelegate();
        [NativeDelegate("ml_KNearest_create")] public static ml_KNearest_createDelegate ml_KNearest_create;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_Ptr_KNearest_deleteDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_KNearest_delete")] public static ReleaseFunc ml_Ptr_KNearest_delete;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_Ptr_KNearest_getDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_KNearest_get")] public static ObjFunc ml_Ptr_KNearest_get;
    }
}
