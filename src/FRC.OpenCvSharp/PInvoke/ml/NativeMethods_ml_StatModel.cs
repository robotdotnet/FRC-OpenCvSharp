using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_StatModel_clearDelegate(IntPtr obj);
        [NativeDelegate("ml_StatModel_clear")] public static ml_StatModel_clearDelegate ml_StatModel_clear;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_StatModel_getVarCountDelegate(IntPtr obj);
        [NativeDelegate("ml_StatModel_getVarCount")] public static ml_StatModel_getVarCountDelegate ml_StatModel_getVarCount;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_StatModel_emptyDelegate(IntPtr obj);
        [NativeDelegate("ml_StatModel_empty")] public static ml_StatModel_emptyDelegate ml_StatModel_empty;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_StatModel_isTrainedDelegate(IntPtr obj);
        [NativeDelegate("ml_StatModel_isTrained")] public static ml_StatModel_isTrainedDelegate ml_StatModel_isTrained;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_StatModel_isClassifierDelegate(IntPtr obj);
        [NativeDelegate("ml_StatModel_isClassifier")] public static ml_StatModel_isClassifierDelegate ml_StatModel_isClassifier;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_StatModel_train1Delegate(
            IntPtr obj, IntPtr trainData, int flags);
        [NativeDelegate("ml_StatModel_train1")] public static ml_StatModel_train1Delegate ml_StatModel_train1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ml_StatModel_train2Delegate(
            IntPtr obj, IntPtr samples, int layout, IntPtr responses);
        [NativeDelegate("ml_StatModel_train2")] public static ml_StatModel_train2Delegate ml_StatModel_train2;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float ml_StatModel_calcErrorDelegate(
            IntPtr obj, IntPtr data, int test, IntPtr resp);
        [NativeDelegate("ml_StatModel_calcError")] public static ml_StatModel_calcErrorDelegate ml_StatModel_calcError;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float ml_StatModel_predictDelegate(
            IntPtr obj, IntPtr samples, IntPtr results, int flags);
        [NativeDelegate("ml_StatModel_predict")] public static ml_StatModel_predictDelegate ml_StatModel_predict;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ml_StatModel_saveDelegate(IntPtr obj, string filename);
        [NativeDelegate("ml_StatModel_save")] public static ml_StatModel_saveDelegate ml_StatModel_save;
    }
}
