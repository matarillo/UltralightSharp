using System;
using System.Runtime.InteropServices;

namespace Native
{
    public partial struct C_Config
    {
    }

    public partial struct C_Renderer
    {
    }

    public partial struct C_View
    {
    }

    public partial struct C_Bitmap
    {
    }

    public partial struct C_String
    {
    }

    public partial struct C_Buffer
    {
    }

    public partial struct C_RenderTarget
    {
    }

    public partial struct C_KeyEvent
    {
    }

    public partial struct C_MouseEvent
    {
    }

    public partial struct C_ScrollEvent
    {
    }

    public enum ULMessageSource
    {
        kMessageSource_XML = 0,
        kMessageSource_JS,
        kMessageSource_Network,
        kMessageSource_ConsoleAPI,
        kMessageSource_Storage,
        kMessageSource_AppCache,
        kMessageSource_Rendering,
        kMessageSource_CSS,
        kMessageSource_Security,
        kMessageSource_ContentBlocker,
        kMessageSource_Other,
    }

    public enum ULMessageLevel
    {
        kMessageLevel_Log = 1,
        kMessageLevel_Warning = 2,
        kMessageLevel_Error = 3,
        kMessageLevel_Debug = 4,
        kMessageLevel_Info = 5,
    }

    public enum ULCursor
    {
        kCursor_Pointer = 0,
        kCursor_Cross,
        kCursor_Hand,
        kCursor_IBeam,
        kCursor_Wait,
        kCursor_Help,
        kCursor_EastResize,
        kCursor_NorthResize,
        kCursor_NorthEastResize,
        kCursor_NorthWestResize,
        kCursor_SouthResize,
        kCursor_SouthEastResize,
        kCursor_SouthWestResize,
        kCursor_WestResize,
        kCursor_NorthSouthResize,
        kCursor_EastWestResize,
        kCursor_NorthEastSouthWestResize,
        kCursor_NorthWestSouthEastResize,
        kCursor_ColumnResize,
        kCursor_RowResize,
        kCursor_MiddlePanning,
        kCursor_EastPanning,
        kCursor_NorthPanning,
        kCursor_NorthEastPanning,
        kCursor_NorthWestPanning,
        kCursor_SouthPanning,
        kCursor_SouthEastPanning,
        kCursor_SouthWestPanning,
        kCursor_WestPanning,
        kCursor_Move,
        kCursor_VerticalText,
        kCursor_Cell,
        kCursor_ContextMenu,
        kCursor_Alias,
        kCursor_Progress,
        kCursor_NoDrop,
        kCursor_Copy,
        kCursor_None,
        kCursor_NotAllowed,
        kCursor_ZoomIn,
        kCursor_ZoomOut,
        kCursor_Grab,
        kCursor_Grabbing,
        kCursor_Custom,
    }

    public enum ULBitmapFormat
    {
        kBitmapFormat_A8,
        kBitmapFormat_RGBA8,
    }

    public enum ULKeyEventType
    {
        kKeyEventType_KeyDown,
        kKeyEventType_KeyUp,
        kKeyEventType_RawKeyDown,
        kKeyEventType_Char,
    }

    public enum ULMouseEventType
    {
        kMouseEventType_MouseMoved,
        kMouseEventType_MouseDown,
        kMouseEventType_MouseUp,
    }

    public enum ULMouseButton
    {
        kMouseButton_None = 0,
        kMouseButton_Left,
        kMouseButton_Middle,
        kMouseButton_Right,
    }

    public enum ULScrollEventType
    {
        kScrollEventType_ScrollByPixel,
        kScrollEventType_ScrollByPage,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ULChangeTitleCallback([NativeTypeName("void *")] void* user_data, [NativeTypeName("ULView")] C_View* caller, [NativeTypeName("ULString")] C_String* title);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ULChangeURLCallback([NativeTypeName("void *")] void* user_data, [NativeTypeName("ULView")] C_View* caller, [NativeTypeName("ULString")] C_String* url);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ULChangeTooltipCallback([NativeTypeName("void *")] void* user_data, [NativeTypeName("ULView")] C_View* caller, [NativeTypeName("ULString")] C_String* tooltip);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ULChangeCursorCallback([NativeTypeName("void *")] void* user_data, [NativeTypeName("ULView")] C_View* caller, ULCursor cursor);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ULAddConsoleMessageCallback([NativeTypeName("void *")] void* user_data, [NativeTypeName("ULView")] C_View* caller, ULMessageSource source, ULMessageLevel level, [NativeTypeName("ULString")] C_String* message, [NativeTypeName("unsigned int")] uint line_number, [NativeTypeName("unsigned int")] uint column_number, [NativeTypeName("ULString")] C_String* source_id);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ULBeginLoadingCallback([NativeTypeName("void *")] void* user_data, [NativeTypeName("ULView")] C_View* caller);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ULFinishLoadingCallback([NativeTypeName("void *")] void* user_data, [NativeTypeName("ULView")] C_View* caller);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ULUpdateHistoryCallback([NativeTypeName("void *")] void* user_data, [NativeTypeName("ULView")] C_View* caller);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ULDOMReadyCallback([NativeTypeName("void *")] void* user_data, [NativeTypeName("ULView")] C_View* caller);

    public static unsafe partial class Ultralight
    {
        private const string libraryPath = "C:\Users\kinomata1\Downloads\include\Ultralight\Ultralight.dll";

        [DllImport(libraryPath, EntryPoint = "ulCreateConfig", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULConfig")]
        public static extern C_Config* ulCreateConfig();

        [DllImport(libraryPath, EntryPoint = "ulDestroyConfig", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulDestroyConfig([NativeTypeName("ULConfig")] C_Config* config);

        [DllImport(libraryPath, EntryPoint = "ulConfigSetEnableImages", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulConfigSetEnableImages([NativeTypeName("ULConfig")] C_Config* config, bool enabled);

        [DllImport(libraryPath, EntryPoint = "ulConfigSetEnableJavaScript", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulConfigSetEnableJavaScript([NativeTypeName("ULConfig")] C_Config* config, bool enabled);

        [DllImport(libraryPath, EntryPoint = "ulConfigSetUseBGRAForOffscreenRendering", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulConfigSetUseBGRAForOffscreenRendering([NativeTypeName("ULConfig")] C_Config* config, bool enabled);

        [DllImport(libraryPath, EntryPoint = "ulConfigSetDeviceScaleHint", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulConfigSetDeviceScaleHint([NativeTypeName("ULConfig")] C_Config* config, double value);

        [DllImport(libraryPath, EntryPoint = "ulConfigSetFontFamilyStandard", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulConfigSetFontFamilyStandard([NativeTypeName("ULConfig")] C_Config* config, [NativeTypeName("ULString")] C_String* font_name);

        [DllImport(libraryPath, EntryPoint = "ulConfigSetFontFamilyFixed", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulConfigSetFontFamilyFixed([NativeTypeName("ULConfig")] C_Config* config, [NativeTypeName("ULString")] C_String* font_name);

        [DllImport(libraryPath, EntryPoint = "ulConfigSetFontFamilySerif", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulConfigSetFontFamilySerif([NativeTypeName("ULConfig")] C_Config* config, [NativeTypeName("ULString")] C_String* font_name);

        [DllImport(libraryPath, EntryPoint = "ulConfigSetFontFamilySansSerif", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulConfigSetFontFamilySansSerif([NativeTypeName("ULConfig")] C_Config* config, [NativeTypeName("ULString")] C_String* font_name);

        [DllImport(libraryPath, EntryPoint = "ulConfigSetUserAgent", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulConfigSetUserAgent([NativeTypeName("ULConfig")] C_Config* config, [NativeTypeName("ULString")] C_String* agent_string);

        [DllImport(libraryPath, EntryPoint = "ulConfigSetUserStylesheet", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulConfigSetUserStylesheet([NativeTypeName("ULConfig")] C_Config* config, [NativeTypeName("ULString")] C_String* css_string);

        [DllImport(libraryPath, EntryPoint = "ulConfigSetForceRepaint", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulConfigSetForceRepaint([NativeTypeName("ULConfig")] C_Config* config, bool enabled);

        [DllImport(libraryPath, EntryPoint = "ulConfigSetAnimationTimerDelay", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulConfigSetAnimationTimerDelay([NativeTypeName("ULConfig")] C_Config* config, double delay);

        [DllImport(libraryPath, EntryPoint = "ulConfigSetMemoryCacheSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulConfigSetMemoryCacheSize([NativeTypeName("ULConfig")] C_Config* config, [NativeTypeName("unsigned int")] uint size);

        [DllImport(libraryPath, EntryPoint = "ulConfigSetPageCacheSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulConfigSetPageCacheSize([NativeTypeName("ULConfig")] C_Config* config, [NativeTypeName("unsigned int")] uint size);

        [DllImport(libraryPath, EntryPoint = "ulCreateRenderer", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULRenderer")]
        public static extern C_Renderer* ulCreateRenderer([NativeTypeName("ULConfig")] C_Config* config);

        [DllImport(libraryPath, EntryPoint = "ulDestroyRenderer", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulDestroyRenderer([NativeTypeName("ULRenderer")] C_Renderer* renderer);

        [DllImport(libraryPath, EntryPoint = "ulUpdate", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulUpdate([NativeTypeName("ULRenderer")] C_Renderer* renderer);

        [DllImport(libraryPath, EntryPoint = "ulRender", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulRender([NativeTypeName("ULRenderer")] C_Renderer* renderer);

        [DllImport(libraryPath, EntryPoint = "ulCreateView", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULView")]
        public static extern C_View* ulCreateView([NativeTypeName("ULRenderer")] C_Renderer* renderer, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, bool transparent);

        [DllImport(libraryPath, EntryPoint = "ulDestroyView", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulDestroyView([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulViewGetURL", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULString")]
        public static extern C_String* ulViewGetURL([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulViewGetTitle", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULString")]
        public static extern C_String* ulViewGetTitle([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulViewIsLoading", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ulViewIsLoading([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulViewIsBitmapDirty", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ulViewIsBitmapDirty([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulViewGetBitmap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULBitmap")]
        public static extern C_Bitmap* ulViewGetBitmap([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulViewLoadHTML", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewLoadHTML([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULString")] C_String* html_string);

        [DllImport(libraryPath, EntryPoint = "ulViewLoadURL", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewLoadURL([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULString")] C_String* url_string);

        [DllImport(libraryPath, EntryPoint = "ulViewResize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewResize([NativeTypeName("ULView")] C_View* view, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height);

        [DllImport(libraryPath, EntryPoint = "ulViewGetJSContext", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSContextRef")]
        public static extern OpaqueJSContext* ulViewGetJSContext([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulViewEvaluateScript", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSValueRef")]
        public static extern OpaqueJSValue* ulViewEvaluateScript([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULString")] C_String* js_string);

        [DllImport(libraryPath, EntryPoint = "ulViewCanGoBack", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ulViewCanGoBack([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulViewCanGoForward", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ulViewCanGoForward([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulViewGoBack", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewGoBack([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulViewGoForward", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewGoForward([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulViewGoToHistoryOffset", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewGoToHistoryOffset([NativeTypeName("ULView")] C_View* view, int offset);

        [DllImport(libraryPath, EntryPoint = "ulViewReload", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewReload([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulViewStop", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewStop([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulViewFireKeyEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewFireKeyEvent([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULKeyEvent")] C_KeyEvent* key_event);

        [DllImport(libraryPath, EntryPoint = "ulViewFireMouseEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewFireMouseEvent([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULMouseEvent")] C_MouseEvent* mouse_event);

        [DllImport(libraryPath, EntryPoint = "ulViewFireScrollEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewFireScrollEvent([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULScrollEvent")] C_ScrollEvent* scroll_event);

        [DllImport(libraryPath, EntryPoint = "ulViewSetChangeTitleCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewSetChangeTitleCallback([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULChangeTitleCallback")] IntPtr callback, [NativeTypeName("void *")] void* user_data);

        [DllImport(libraryPath, EntryPoint = "ulViewSetChangeURLCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewSetChangeURLCallback([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULChangeURLCallback")] IntPtr callback, [NativeTypeName("void *")] void* user_data);

        [DllImport(libraryPath, EntryPoint = "ulViewSetChangeTooltipCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewSetChangeTooltipCallback([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULChangeTooltipCallback")] IntPtr callback, [NativeTypeName("void *")] void* user_data);

        [DllImport(libraryPath, EntryPoint = "ulViewSetChangeCursorCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewSetChangeCursorCallback([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULChangeCursorCallback")] IntPtr callback, [NativeTypeName("void *")] void* user_data);

        [DllImport(libraryPath, EntryPoint = "ulViewSetAddConsoleMessageCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewSetAddConsoleMessageCallback([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULAddConsoleMessageCallback")] IntPtr callback, [NativeTypeName("void *")] void* user_data);

        [DllImport(libraryPath, EntryPoint = "ulViewSetBeginLoadingCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewSetBeginLoadingCallback([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULBeginLoadingCallback")] IntPtr callback, [NativeTypeName("void *")] void* user_data);

        [DllImport(libraryPath, EntryPoint = "ulViewSetFinishLoadingCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewSetFinishLoadingCallback([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULFinishLoadingCallback")] IntPtr callback, [NativeTypeName("void *")] void* user_data);

        [DllImport(libraryPath, EntryPoint = "ulViewSetUpdateHistoryCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewSetUpdateHistoryCallback([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULUpdateHistoryCallback")] IntPtr callback, [NativeTypeName("void *")] void* user_data);

        [DllImport(libraryPath, EntryPoint = "ulViewSetDOMReadyCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewSetDOMReadyCallback([NativeTypeName("ULView")] C_View* view, [NativeTypeName("ULDOMReadyCallback")] IntPtr callback, [NativeTypeName("void *")] void* user_data);

        [DllImport(libraryPath, EntryPoint = "ulViewSetNeedsPaint", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulViewSetNeedsPaint([NativeTypeName("ULView")] C_View* view, bool needs_paint);

        [DllImport(libraryPath, EntryPoint = "ulViewGetNeedsPaint", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ulViewGetNeedsPaint([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulViewCreateInspectorView", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULView")]
        public static extern C_View* ulViewCreateInspectorView([NativeTypeName("ULView")] C_View* view);

        [DllImport(libraryPath, EntryPoint = "ulCreateString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULString")]
        public static extern C_String* ulCreateString([NativeTypeName("const char *")] sbyte* str);

        [DllImport(libraryPath, EntryPoint = "ulCreateStringUTF8", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULString")]
        public static extern C_String* ulCreateStringUTF8([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] UIntPtr len);

        [DllImport(libraryPath, EntryPoint = "ulCreateStringUTF16", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULString")]
        public static extern C_String* ulCreateStringUTF16([NativeTypeName("ULChar16 *")] char* str, [NativeTypeName("size_t")] UIntPtr len);

        [DllImport(libraryPath, EntryPoint = "ulDestroyString", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulDestroyString([NativeTypeName("ULString")] C_String* str);

        [DllImport(libraryPath, EntryPoint = "ulStringGetData", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULChar16 *")]
        public static extern char* ulStringGetData([NativeTypeName("ULString")] C_String* str);

        [DllImport(libraryPath, EntryPoint = "ulStringGetLength", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr ulStringGetLength([NativeTypeName("ULString")] C_String* str);

        [DllImport(libraryPath, EntryPoint = "ulStringIsEmpty", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ulStringIsEmpty([NativeTypeName("ULString")] C_String* str);

        [DllImport(libraryPath, EntryPoint = "ulCreateEmptyBitmap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULBitmap")]
        public static extern C_Bitmap* ulCreateEmptyBitmap();

        [DllImport(libraryPath, EntryPoint = "ulCreateBitmap", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULBitmap")]
        public static extern C_Bitmap* ulCreateBitmap([NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, ULBitmapFormat format);

        [DllImport(libraryPath, EntryPoint = "ulCreateBitmapFromPixels", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULBitmap")]
        public static extern C_Bitmap* ulCreateBitmapFromPixels([NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, ULBitmapFormat format, [NativeTypeName("unsigned int")] uint row_bytes, [NativeTypeName("const void *")] void* pixels, [NativeTypeName("size_t")] UIntPtr size, bool should_copy);

        [DllImport(libraryPath, EntryPoint = "ulCreateBitmapFromCopy", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULBitmap")]
        public static extern C_Bitmap* ulCreateBitmapFromCopy([NativeTypeName("ULBitmap")] C_Bitmap* existing_bitmap);

        [DllImport(libraryPath, EntryPoint = "ulDestroyBitmap", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulDestroyBitmap([NativeTypeName("ULBitmap")] C_Bitmap* bitmap);

        [DllImport(libraryPath, EntryPoint = "ulBitmapGetWidth", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint ulBitmapGetWidth([NativeTypeName("ULBitmap")] C_Bitmap* bitmap);

        [DllImport(libraryPath, EntryPoint = "ulBitmapGetHeight", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint ulBitmapGetHeight([NativeTypeName("ULBitmap")] C_Bitmap* bitmap);

        [DllImport(libraryPath, EntryPoint = "ulBitmapGetFormat", CallingConvention = CallingConvention.Cdecl)]
        public static extern ULBitmapFormat ulBitmapGetFormat([NativeTypeName("ULBitmap")] C_Bitmap* bitmap);

        [DllImport(libraryPath, EntryPoint = "ulBitmapGetBpp", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint ulBitmapGetBpp([NativeTypeName("ULBitmap")] C_Bitmap* bitmap);

        [DllImport(libraryPath, EntryPoint = "ulBitmapGetRowBytes", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint ulBitmapGetRowBytes([NativeTypeName("ULBitmap")] C_Bitmap* bitmap);

        [DllImport(libraryPath, EntryPoint = "ulBitmapGetSize", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr ulBitmapGetSize([NativeTypeName("ULBitmap")] C_Bitmap* bitmap);

        [DllImport(libraryPath, EntryPoint = "ulBitmapOwnsPixels", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ulBitmapOwnsPixels([NativeTypeName("ULBitmap")] C_Bitmap* bitmap);

        [DllImport(libraryPath, EntryPoint = "ulBitmapLockPixels", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("void *")]
        public static extern void* ulBitmapLockPixels([NativeTypeName("ULBitmap")] C_Bitmap* bitmap);

        [DllImport(libraryPath, EntryPoint = "ulBitmapUnlockPixels", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulBitmapUnlockPixels([NativeTypeName("ULBitmap")] C_Bitmap* bitmap);

        [DllImport(libraryPath, EntryPoint = "ulBitmapRawPixels", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("void *")]
        public static extern void* ulBitmapRawPixels([NativeTypeName("ULBitmap")] C_Bitmap* bitmap);

        [DllImport(libraryPath, EntryPoint = "ulBitmapIsEmpty", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ulBitmapIsEmpty([NativeTypeName("ULBitmap")] C_Bitmap* bitmap);

        [DllImport(libraryPath, EntryPoint = "ulBitmapErase", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulBitmapErase([NativeTypeName("ULBitmap")] C_Bitmap* bitmap);

        [DllImport(libraryPath, EntryPoint = "ulBitmapWritePNG", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ulBitmapWritePNG([NativeTypeName("ULBitmap")] C_Bitmap* bitmap, [NativeTypeName("const char *")] sbyte* path);

        [DllImport(libraryPath, EntryPoint = "ulCreateKeyEvent", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULKeyEvent")]
        public static extern C_KeyEvent* ulCreateKeyEvent(ULKeyEventType type, [NativeTypeName("unsigned int")] uint modifiers, int virtual_key_code, int native_key_code, [NativeTypeName("ULString")] C_String* text, [NativeTypeName("ULString")] C_String* unmodified_text, bool is_keypad, bool is_auto_repeat, bool is_system_key);

        [DllImport(libraryPath, EntryPoint = "ulCreateKeyEventWindows", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULKeyEvent")]
        public static extern C_KeyEvent* ulCreateKeyEventWindows(ULKeyEventType type, [NativeTypeName("uintptr_t")] UIntPtr wparam, [NativeTypeName("intptr_t")] IntPtr lparam, bool is_system_key);

        [DllImport(libraryPath, EntryPoint = "ulDestroyKeyEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulDestroyKeyEvent([NativeTypeName("ULKeyEvent")] C_KeyEvent* evt);

        [DllImport(libraryPath, EntryPoint = "ulCreateMouseEvent", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULMouseEvent")]
        public static extern C_MouseEvent* ulCreateMouseEvent(ULMouseEventType type, int x, int y, ULMouseButton button);

        [DllImport(libraryPath, EntryPoint = "ulDestroyMouseEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulDestroyMouseEvent([NativeTypeName("ULMouseEvent")] C_MouseEvent* evt);

        [DllImport(libraryPath, EntryPoint = "ulCreateScrollEvent", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("ULScrollEvent")]
        public static extern C_ScrollEvent* ulCreateScrollEvent(ULScrollEventType type, int delta_x, int delta_y);

        [DllImport(libraryPath, EntryPoint = "ulDestroyScrollEvent", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ulDestroyScrollEvent([NativeTypeName("ULScrollEvent")] C_ScrollEvent* evt);
    }
}
