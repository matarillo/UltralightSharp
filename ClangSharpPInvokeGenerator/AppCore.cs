using System;
using System.Runtime.InteropServices;

namespace Native
{
    public partial struct C_Settings
    {
    }

    public partial struct C_App
    {
    }

    public partial struct C_Window
    {
    }

    public partial struct C_Monitor
    {
    }

    public partial struct C_Overlay
    {
    }

    public enum ULWindowFlags
    {
        kWindowFlags_Borderless = 1 << 0,
        kWindowFlags_Titled = 1 << 1,
        kWindowFlags_Resizable = 1 << 2,
        kWindowFlags_Maximizable = 1 << 3,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ULUpdateCallback([NativeTypeName("void *")] void* user_data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ULCloseCallback([NativeTypeName("void *")] void* user_data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ULResizeCallback([NativeTypeName("void *")] void* user_data, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

    public static unsafe partial class AppCore
    {
        private const string libraryPath = "C:\Users\kinomata1\Downloads\include\AppCore\AppCore.dll";

        [DllImport(libraryPath, EntryPoint = "ulCreateSettings", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULSettings")]
        public static extern C_Settings* ulCreateSettings();

        [DllImport(libraryPath, EntryPoint = "ulDestroySettings", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulDestroySettings([NativeTypeName("ULSettings")] C_Settings* settings);

        [DllImport(libraryPath, EntryPoint = "ulSettingsSetFileSystemPath", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulSettingsSetFileSystemPath([NativeTypeName("ULSettings")] C_Settings* settings, [NativeTypeName("ULString")] C_String* path);

        [DllImport(libraryPath, EntryPoint = "ulSettingsSetLoadShadersFromFileSystem", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulSettingsSetLoadShadersFromFileSystem([NativeTypeName("ULSettings")] C_Settings* settings, bool enabled);

        [DllImport(libraryPath, EntryPoint = "ulCreateApp", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULApp")]
        public static extern C_App* ulCreateApp([NativeTypeName("ULSettings")] C_Settings* settings, [NativeTypeName("ULConfig")] C_Config* config);

        [DllImport(libraryPath, EntryPoint = "ulDestroyApp", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulDestroyApp([NativeTypeName("ULApp")] C_App* app);

        [DllImport(libraryPath, EntryPoint = "ulAppSetWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulAppSetWindow([NativeTypeName("ULApp")] C_App* app, [NativeTypeName("ULWindow")] C_Window* window);

        [DllImport(libraryPath, EntryPoint = "ulAppGetWindow", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULWindow")]
        public static extern C_Window* ulAppGetWindow([NativeTypeName("ULApp")] C_App* app);

        [DllImport(libraryPath, EntryPoint = "ulAppSetUpdateCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulAppSetUpdateCallback([NativeTypeName("ULApp")] C_App* app, [NativeTypeName("ULUpdateCallback")] IntPtr callback, [NativeTypeName("void *")] void* user_data);

        [DllImport(libraryPath, EntryPoint = "ulAppIsRunning", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ulAppIsRunning([NativeTypeName("ULApp")] C_App* app);

        [DllImport(libraryPath, EntryPoint = "ulAppGetMainMonitor", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULMonitor")]
        public static extern C_Monitor* ulAppGetMainMonitor([NativeTypeName("ULApp")] C_App* app);

        [DllImport(libraryPath, EntryPoint = "ulAppGetRenderer", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULRenderer")]
        public static extern C_Renderer* ulAppGetRenderer([NativeTypeName("ULApp")] C_App* app);

        [DllImport(libraryPath, EntryPoint = "ulAppRun", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulAppRun([NativeTypeName("ULApp")] C_App* app);

        [DllImport(libraryPath, EntryPoint = "ulAppQuit", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulAppQuit([NativeTypeName("ULApp")] C_App* app);

        [DllImport(libraryPath, EntryPoint = "ulMonitorGetScale", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ulMonitorGetScale([NativeTypeName("ULMonitor")] C_Monitor* monitor);

        [DllImport(libraryPath, EntryPoint = "ulMonitorGetWidth", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint ulMonitorGetWidth([NativeTypeName("ULMonitor")] C_Monitor* monitor);

        [DllImport(libraryPath, EntryPoint = "ulMonitorGetHeight", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint ulMonitorGetHeight([NativeTypeName("ULMonitor")] C_Monitor* monitor);

        [DllImport(libraryPath, EntryPoint = "ulCreateWindow", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULWindow")]
        public static extern C_Window* ulCreateWindow([NativeTypeName("ULMonitor")] C_Monitor* monitor, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, bool fullscreen, [NativeTypeName("unsigned int")] uint window_flags);

        [DllImport(libraryPath, EntryPoint = "ulDestroyWindow", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulDestroyWindow([NativeTypeName("ULWindow")] C_Window* window);

        [DllImport(libraryPath, EntryPoint = "ulWindowSetCloseCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulWindowSetCloseCallback([NativeTypeName("ULWindow")] C_Window* window, [NativeTypeName("ULCloseCallback")] IntPtr callback, [NativeTypeName("void *")] void* user_data);

        [DllImport(libraryPath, EntryPoint = "ulWindowSetResizeCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulWindowSetResizeCallback([NativeTypeName("ULWindow")] C_Window* window, [NativeTypeName("ULResizeCallback")] IntPtr callback, [NativeTypeName("void *")] void* user_data);

        [DllImport(libraryPath, EntryPoint = "ulWindowGetWidth", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint ulWindowGetWidth([NativeTypeName("ULWindow")] C_Window* window);

        [DllImport(libraryPath, EntryPoint = "ulWindowGetHeight", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint ulWindowGetHeight([NativeTypeName("ULWindow")] C_Window* window);

        [DllImport(libraryPath, EntryPoint = "ulWindowIsFullscreen", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ulWindowIsFullscreen([NativeTypeName("ULWindow")] C_Window* window);

        [DllImport(libraryPath, EntryPoint = "ulWindowGetScale", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ulWindowGetScale([NativeTypeName("ULWindow")] C_Window* window);

        [DllImport(libraryPath, EntryPoint = "ulWindowSetTitle", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulWindowSetTitle([NativeTypeName("ULWindow")] C_Window* window, [NativeTypeName("const char *")] sbyte* title);

        [DllImport(libraryPath, EntryPoint = "ulWindowSetCursor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulWindowSetCursor([NativeTypeName("ULWindow")] C_Window* window, ULCursor cursor);

        [DllImport(libraryPath, EntryPoint = "ulWindowClose", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulWindowClose([NativeTypeName("ULWindow")] C_Window* window);

        [DllImport(libraryPath, EntryPoint = "ulWindowDeviceToPixel", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ulWindowDeviceToPixel([NativeTypeName("ULWindow")] C_Window* window, int val);

        [DllImport(libraryPath, EntryPoint = "ulWindowPixelsToDevice", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ulWindowPixelsToDevice([NativeTypeName("ULWindow")] C_Window* window, int val);

        [DllImport(libraryPath, EntryPoint = "ulCreateOverlay", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULOverlay")]
        public static extern C_Overlay* ulCreateOverlay([NativeTypeName("ULWindow")] C_Window* window, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int x, int y);

        [DllImport(libraryPath, EntryPoint = "ulDestroyOverlay", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulDestroyOverlay([NativeTypeName("ULOverlay")] C_Overlay* overlay);

        [DllImport(libraryPath, EntryPoint = "ulOverlayGetView", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULView")]
        public static extern C_View* ulOverlayGetView([NativeTypeName("ULOverlay")] C_Overlay* overlay);

        [DllImport(libraryPath, EntryPoint = "ulOverlayGetWidth", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint ulOverlayGetWidth([NativeTypeName("ULOverlay")] C_Overlay* overlay);

        [DllImport(libraryPath, EntryPoint = "ulOverlayGetHeight", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint ulOverlayGetHeight([NativeTypeName("ULOverlay")] C_Overlay* overlay);

        [DllImport(libraryPath, EntryPoint = "ulOverlayGetX", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ulOverlayGetX([NativeTypeName("ULOverlay")] C_Overlay* overlay);

        [DllImport(libraryPath, EntryPoint = "ulOverlayGetY", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ulOverlayGetY([NativeTypeName("ULOverlay")] C_Overlay* overlay);

        [DllImport(libraryPath, EntryPoint = "ulOverlayMoveTo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulOverlayMoveTo([NativeTypeName("ULOverlay")] C_Overlay* overlay, int x, int y);

        [DllImport(libraryPath, EntryPoint = "ulOverlayResize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulOverlayResize([NativeTypeName("ULOverlay")] C_Overlay* overlay, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(libraryPath, EntryPoint = "ulOverlayIsHidden", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ulOverlayIsHidden([NativeTypeName("ULOverlay")] C_Overlay* overlay);

        [DllImport(libraryPath, EntryPoint = "ulOverlayHide", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulOverlayHide([NativeTypeName("ULOverlay")] C_Overlay* overlay);

        [DllImport(libraryPath, EntryPoint = "ulOverlayShow", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulOverlayShow([NativeTypeName("ULOverlay")] C_Overlay* overlay);

        [DllImport(libraryPath, EntryPoint = "ulOverlayHasFocus", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ulOverlayHasFocus([NativeTypeName("ULOverlay")] C_Overlay* overlay);

        [DllImport(libraryPath, EntryPoint = "ulOverlayFocus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulOverlayFocus([NativeTypeName("ULOverlay")] C_Overlay* overlay);

        [DllImport(libraryPath, EntryPoint = "ulOverlayUnfocus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulOverlayUnfocus([NativeTypeName("ULOverlay")] C_Overlay* overlay);
    }
}
