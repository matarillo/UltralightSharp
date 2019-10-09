using System;
using System.Runtime.InteropServices;
using UltralightInterop.Data;

namespace UltralightInterop
{
    public static class AppCore
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void ULUpdateCallback(IntPtr user_data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void ULCloseCallback(IntPtr user_data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void ULResizeCallback(IntPtr user_data, uint width, uint height);

        private static class NativeMethods
        {
            private const string libraryPath = "AppCore.dll";

            [DllImport(libraryPath, EntryPoint = "ulCreateSettings", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULSettings ulCreateSettings();

            [DllImport(libraryPath, EntryPoint = "ulDestroySettings", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulDestroySettings(ULSettings settings);

            [DllImport(libraryPath, EntryPoint = "ulSettingsSetFileSystemPath", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulSettingsSetFileSystemPath(ULSettings settings, ULString path);

            [DllImport(libraryPath, EntryPoint = "ulSettingsSetLoadShadersFromFileSystem", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulSettingsSetLoadShadersFromFileSystem(ULSettings settings, bool enabled);

            [DllImport(libraryPath, EntryPoint = "ulCreateApp", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULApp ulCreateApp(ULSettings settings, ULConfig config);

            [DllImport(libraryPath, EntryPoint = "ulDestroyApp", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulDestroyApp(ULApp app);

            [DllImport(libraryPath, EntryPoint = "ulAppSetWindow", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulAppSetWindow(ULApp app, ULWindow window);

            [DllImport(libraryPath, EntryPoint = "ulAppGetWindow", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULWindow ulAppGetWindow(ULApp app);

            [DllImport(libraryPath, EntryPoint = "ulAppSetUpdateCallback", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulAppSetUpdateCallback(ULApp app, ULUpdateCallback callback, IntPtr user_data);

            [DllImport(libraryPath, EntryPoint = "ulAppIsRunning", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool ulAppIsRunning(ULApp app);

            [DllImport(libraryPath, EntryPoint = "ulAppGetMainMonitor", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULMonitor ulAppGetMainMonitor(ULApp app);

            [DllImport(libraryPath, EntryPoint = "ulAppGetRenderer", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULRenderer ulAppGetRenderer(ULApp app);

            [DllImport(libraryPath, EntryPoint = "ulAppRun", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulAppRun(ULApp app);

            [DllImport(libraryPath, EntryPoint = "ulAppQuit", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulAppQuit(ULApp app);

            [DllImport(libraryPath, EntryPoint = "ulMonitorGetScale", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ulMonitorGetScale(ULMonitor monitor);

            [DllImport(libraryPath, EntryPoint = "ulMonitorGetWidth", CallingConvention = CallingConvention.Cdecl)]
            public static extern uint ulMonitorGetWidth(ULMonitor monitor);

            [DllImport(libraryPath, EntryPoint = "ulMonitorGetHeight", CallingConvention = CallingConvention.Cdecl)]
            public static extern uint ulMonitorGetHeight(ULMonitor monitor);

            [DllImport(libraryPath, EntryPoint = "ulCreateWindow", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULWindow ulCreateWindow(ULMonitor monitor, uint width, uint height, bool fullscreen, uint window_flags);

            [DllImport(libraryPath, EntryPoint = "ulDestroyWindow", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulDestroyWindow(ULWindow window);

            [DllImport(libraryPath, EntryPoint = "ulWindowSetCloseCallback", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulWindowSetCloseCallback(ULWindow window, ULCloseCallback callback, IntPtr user_data);

            [DllImport(libraryPath, EntryPoint = "ulWindowSetResizeCallback", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulWindowSetResizeCallback(ULWindow window, ULResizeCallback callback, IntPtr user_data);

            [DllImport(libraryPath, EntryPoint = "ulWindowGetWidth", CallingConvention = CallingConvention.Cdecl)]
            public static extern uint ulWindowGetWidth(ULWindow window);

            [DllImport(libraryPath, EntryPoint = "ulWindowGetHeight", CallingConvention = CallingConvention.Cdecl)]
            public static extern uint ulWindowGetHeight(ULWindow window);

            [DllImport(libraryPath, EntryPoint = "ulWindowIsFullscreen", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool ulWindowIsFullscreen(ULWindow window);

            [DllImport(libraryPath, EntryPoint = "ulWindowGetScale", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ulWindowGetScale(ULWindow window);

            [DllImport(libraryPath, EntryPoint = "ulWindowSetTitle", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public static extern void ulWindowSetTitle(ULWindow window, [MarshalAs(UnmanagedType.LPStr)] string title);

            [DllImport(libraryPath, EntryPoint = "ulWindowSetCursor", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulWindowSetCursor(ULWindow window, ULCursor cursor);

            [DllImport(libraryPath, EntryPoint = "ulWindowClose", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulWindowClose(ULWindow window);

            [DllImport(libraryPath, EntryPoint = "ulWindowDeviceToPixel", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ulWindowDeviceToPixel(ULWindow window, int val);

            [DllImport(libraryPath, EntryPoint = "ulWindowPixelsToDevice", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ulWindowPixelsToDevice(ULWindow window, int val);

            [DllImport(libraryPath, EntryPoint = "ulCreateOverlay", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULOverlay ulCreateOverlay(ULWindow window, uint width, uint height, int x, int y);

            [DllImport(libraryPath, EntryPoint = "ulDestroyOverlay", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulDestroyOverlay(ULOverlay overlay);

            [DllImport(libraryPath, EntryPoint = "ulOverlayGetView", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULView ulOverlayGetView(ULOverlay overlay);

            [DllImport(libraryPath, EntryPoint = "ulOverlayGetWidth", CallingConvention = CallingConvention.Cdecl)]
            public static extern uint ulOverlayGetWidth(ULOverlay overlay);

            [DllImport(libraryPath, EntryPoint = "ulOverlayGetHeight", CallingConvention = CallingConvention.Cdecl)]
            public static extern uint ulOverlayGetHeight(ULOverlay overlay);

            [DllImport(libraryPath, EntryPoint = "ulOverlayGetX", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ulOverlayGetX(ULOverlay overlay);

            [DllImport(libraryPath, EntryPoint = "ulOverlayGetY", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ulOverlayGetY(ULOverlay overlay);

            [DllImport(libraryPath, EntryPoint = "ulOverlayMoveTo", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulOverlayMoveTo(ULOverlay overlay, int x, int y);

            [DllImport(libraryPath, EntryPoint = "ulOverlayResize", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulOverlayResize(ULOverlay overlay, uint width, uint height);

            [DllImport(libraryPath, EntryPoint = "ulOverlayIsHidden", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool ulOverlayIsHidden(ULOverlay overlay);

            [DllImport(libraryPath, EntryPoint = "ulOverlayHide", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulOverlayHide(ULOverlay overlay);

            [DllImport(libraryPath, EntryPoint = "ulOverlayShow", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulOverlayShow(ULOverlay overlay);

            [DllImport(libraryPath, EntryPoint = "ulOverlayHasFocus", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool ulOverlayHasFocus(ULOverlay overlay);

            [DllImport(libraryPath, EntryPoint = "ulOverlayFocus", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulOverlayFocus(ULOverlay overlay);

            [DllImport(libraryPath, EntryPoint = "ulOverlayUnfocus", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulOverlayUnfocus(ULOverlay overlay);
        }
    }
}
