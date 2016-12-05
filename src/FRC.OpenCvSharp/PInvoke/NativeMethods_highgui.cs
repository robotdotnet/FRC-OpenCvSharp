using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void highgui_namedWindowDelegate([MarshalAs(UnmanagedType.LPStr)] string winname, int flags);
        [NativeDelegate("highgui_namedWindow")] public static highgui_namedWindowDelegate highgui_namedWindow;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void highgui_destroyWindowDelegate([MarshalAs(UnmanagedType.LPStr)] string winName);
        [NativeDelegate("highgui_destroyWindow")] public static highgui_destroyWindowDelegate highgui_destroyWindow;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void highgui_destroyAllWindowsDelegate();
        [NativeDelegate("highgui_destroyAllWindows")] public static highgui_destroyAllWindowsDelegate highgui_destroyAllWindows;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void highgui_imshowDelegate([MarshalAs(UnmanagedType.LPStr)] string winname, IntPtr mat);
        [NativeDelegate("highgui_imshow")] public static highgui_imshowDelegate highgui_imshow;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int highgui_startWindowThreadDelegate();
        [NativeDelegate("highgui_startWindowThread")] public static highgui_startWindowThreadDelegate highgui_startWindowThread;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int highgui_waitKeyDelegate(int delay);
        [NativeDelegate("highgui_waitKey")] public static highgui_waitKeyDelegate highgui_waitKey;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void highgui_resizeWindowDelegate([MarshalAs(UnmanagedType.LPStr)] string winName, int width, int height);
        [NativeDelegate("highgui_resizeWindow")] public static highgui_resizeWindowDelegate highgui_resizeWindow;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void highgui_moveWindowDelegate([MarshalAs(UnmanagedType.LPStr)] string winName, int x, int y);
        [NativeDelegate("highgui_moveWindow")] public static highgui_moveWindowDelegate highgui_moveWindow;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void highgui_setWindowPropertyDelegate([MarshalAs(UnmanagedType.LPStr)] string winName, int propId, double propValue);
        [NativeDelegate("highgui_setWindowProperty")] public static highgui_setWindowPropertyDelegate highgui_setWindowProperty;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void highgui_setWindowTitleDelegate([MarshalAs(UnmanagedType.LPStr)] string winname, [MarshalAs(UnmanagedType.LPStr)] string title);
        [NativeDelegate("highgui_setWindowTitle")] public static highgui_setWindowTitleDelegate highgui_setWindowTitle;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double highgui_getWindowPropertyDelegate([MarshalAs(UnmanagedType.LPStr)] string winName, int propId);
        [NativeDelegate("highgui_getWindowProperty")] public static highgui_getWindowPropertyDelegate highgui_getWindowProperty;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void highgui_setMouseCallbackDelegate(string winName, [MarshalAs(UnmanagedType.FunctionPtr)] CvMouseCallback onMouse, IntPtr userData);
        [NativeDelegate("highgui_setMouseCallback")] public static highgui_setMouseCallbackDelegate highgui_setMouseCallback;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int highgui_createTrackbarDelegate([MarshalAs(UnmanagedType.LPStr)] string trackbarName, [MarshalAs(UnmanagedType.LPStr)] string winName,
            ref int value, int count, IntPtr onChange, IntPtr userData);
        [NativeDelegate("highgui_createTrackbar")] public static highgui_createTrackbarDelegate highgui_createTrackbar;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int highgui_getTrackbarPosDelegate([MarshalAs(UnmanagedType.LPStr)] string trackbarName, [MarshalAs(UnmanagedType.LPStr)] string winName);
        [NativeDelegate("highgui_getTrackbarPos")] public static highgui_getTrackbarPosDelegate highgui_getTrackbarPos;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void highgui_setTrackbarPosDelegate(string trackbarName, string winName, int pos);
        [NativeDelegate("highgui_setTrackbarPos")] public static highgui_setTrackbarPosDelegate highgui_setTrackbarPos;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int highgui_createButtonDelegate(string barName, IntPtr onChange, IntPtr userdata, int type, int initialButtonState);
        [NativeDelegate("highgui_createButton")] public static highgui_createButtonDelegate highgui_createButton;
    }
}
