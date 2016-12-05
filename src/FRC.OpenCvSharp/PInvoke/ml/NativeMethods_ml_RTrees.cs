using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_RTrees_getCalculateVarImportanceDelegate(IntPtr obj);
        [NativeDelegate("ml_RTrees_getCalculateVarImportance")] public static ml_RTrees_getCalculateVarImportanceDelegate ml_RTrees_getCalculateVarImportance;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_RTrees_setCalculateVarImportanceDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_RTrees_setCalculateVarImportance")] public static ml_RTrees_setCalculateVarImportanceDelegate ml_RTrees_setCalculateVarImportance;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_RTrees_getActiveVarCountDelegate(IntPtr obj);
        [NativeDelegate("ml_RTrees_getActiveVarCount")] public static ml_RTrees_getActiveVarCountDelegate ml_RTrees_getActiveVarCount;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_RTrees_setActiveVarCountDelegate(IntPtr obj, int val);
        [NativeDelegate("ml_RTrees_setActiveVarCount")] public static ml_RTrees_setActiveVarCountDelegate ml_RTrees_setActiveVarCount;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate TermCriteria ml_RTrees_getTermCriteriaDelegate(IntPtr obj);
        [NativeDelegate("ml_RTrees_getTermCriteria")] public static ml_RTrees_getTermCriteriaDelegate ml_RTrees_getTermCriteria;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_RTrees_setTermCriteriaDelegate(IntPtr obj, TermCriteria val);
        [NativeDelegate("ml_RTrees_setTermCriteria")] public static ml_RTrees_setTermCriteriaDelegate ml_RTrees_setTermCriteria;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_RTrees_getVarImportanceDelegate(IntPtr obj);
        [NativeDelegate("ml_RTrees_getVarImportance")] public static ml_RTrees_getVarImportanceDelegate ml_RTrees_getVarImportance;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_RTrees_createDelegate();
        [NativeDelegate("ml_RTrees_create")] public static ml_RTrees_createDelegate ml_RTrees_create;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_Ptr_RTrees_deleteDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_RTrees_delete")] public static ReleaseFunc ml_Ptr_RTrees_delete;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr ml_Ptr_RTrees_getDelegate(IntPtr obj);
        [NativeDelegate("ml_Ptr_RTrees_get")] public static ObjFunc ml_Ptr_RTrees_get;
    }
}
