using System;
using System.Runtime.InteropServices;
using UltralightInterop.Data;

namespace UltralightInterop
{
    public static class Ultralight
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void ULChangeTitleCallback(IntPtr user_data, ULView caller, ULString title);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void ULChangeURLCallback(IntPtr user_data, ULView caller, ULString url);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void ULChangeTooltipCallback(IntPtr user_data, ULView caller, ULString tooltip);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void ULChangeCursorCallback(IntPtr user_data, ULView caller, ULCursor cursor);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void ULAddConsoleMessageCallback(IntPtr user_data, ULView caller, ULMessageSource source, ULMessageLevel level, ULString message, uint line_number, uint column_number, ULString source_id);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void ULBeginLoadingCallback(IntPtr user_data, ULView caller);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void ULFinishLoadingCallback(IntPtr user_data, ULView caller);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void ULUpdateHistoryCallback(IntPtr user_data, ULView caller);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void ULDOMReadyCallback(IntPtr user_data, ULView caller);

        private static class NativeMethods
        {
            private const string libraryPath = "Ultralight.dll";

            [DllImport(libraryPath, EntryPoint = "ulCreateConfig", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULConfig ulCreateConfig();

            [DllImport(libraryPath, EntryPoint = "ulDestroyConfig", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulDestroyConfig(ULConfig config);

            [DllImport(libraryPath, EntryPoint = "ulConfigSetEnableImages", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulConfigSetEnableImages(ULConfig config, bool enabled);

            [DllImport(libraryPath, EntryPoint = "ulConfigSetEnableJavaScript", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulConfigSetEnableJavaScript(ULConfig config, bool enabled);

            [DllImport(libraryPath, EntryPoint = "ulConfigSetUseBGRAForOffscreenRendering", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulConfigSetUseBGRAForOffscreenRendering(ULConfig config, bool enabled);

            [DllImport(libraryPath, EntryPoint = "ulConfigSetDeviceScaleHint", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulConfigSetDeviceScaleHint(ULConfig config, double value);

            [DllImport(libraryPath, EntryPoint = "ulConfigSetFontFamilyStandard", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulConfigSetFontFamilyStandard(ULConfig config, ULString font_name);

            [DllImport(libraryPath, EntryPoint = "ulConfigSetFontFamilyFixed", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulConfigSetFontFamilyFixed(ULConfig config, ULString font_name);

            [DllImport(libraryPath, EntryPoint = "ulConfigSetFontFamilySerif", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulConfigSetFontFamilySerif(ULConfig config, ULString font_name);

            [DllImport(libraryPath, EntryPoint = "ulConfigSetFontFamilySansSerif", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulConfigSetFontFamilySansSerif(ULConfig config, ULString font_name);

            [DllImport(libraryPath, EntryPoint = "ulConfigSetUserAgent", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulConfigSetUserAgent(ULConfig config, ULString agent_string);

            [DllImport(libraryPath, EntryPoint = "ulConfigSetUserStylesheet", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulConfigSetUserStylesheet(ULConfig config, ULString css_string);

            [DllImport(libraryPath, EntryPoint = "ulConfigSetForceRepaint", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulConfigSetForceRepaint(ULConfig config, bool enabled);

            [DllImport(libraryPath, EntryPoint = "ulConfigSetAnimationTimerDelay", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulConfigSetAnimationTimerDelay(ULConfig config, double delay);

            [DllImport(libraryPath, EntryPoint = "ulConfigSetMemoryCacheSize", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulConfigSetMemoryCacheSize(ULConfig config, uint size);

            [DllImport(libraryPath, EntryPoint = "ulConfigSetPageCacheSize", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulConfigSetPageCacheSize(ULConfig config, uint size);

            [DllImport(libraryPath, EntryPoint = "ulCreateRenderer", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULRenderer ulCreateRenderer(ULConfig config);

            [DllImport(libraryPath, EntryPoint = "ulDestroyRenderer", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulDestroyRenderer(ULRenderer renderer);

            [DllImport(libraryPath, EntryPoint = "ulUpdate", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulUpdate(ULRenderer renderer);

            [DllImport(libraryPath, EntryPoint = "ulRender", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulRender(ULRenderer renderer);

            [DllImport(libraryPath, EntryPoint = "ulCreateView", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULView ulCreateView(ULRenderer renderer, uint width, uint height, bool transparent);

            [DllImport(libraryPath, EntryPoint = "ulDestroyView", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulDestroyView(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulViewGetURL", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULString ulViewGetURL(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulViewGetTitle", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULString ulViewGetTitle(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulViewIsLoading", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool ulViewIsLoading(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulViewIsBitmapDirty", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool ulViewIsBitmapDirty(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulViewGetBitmap", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULBitmap ulViewGetBitmap(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulViewLoadHTML", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewLoadHTML(ULView view, ULString html_string);

            [DllImport(libraryPath, EntryPoint = "ulViewLoadURL", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewLoadURL(ULView view, ULString url_string);

            [DllImport(libraryPath, EntryPoint = "ulViewResize", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewResize(ULView view, uint width, uint height);

            [DllImport(libraryPath, EntryPoint = "ulViewGetJSContext", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSContextRef ulViewGetJSContext(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulViewEvaluateScript", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSValueRef ulViewEvaluateScript(ULView view, ULString js_string);

            [DllImport(libraryPath, EntryPoint = "ulViewCanGoBack", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool ulViewCanGoBack(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulViewCanGoForward", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool ulViewCanGoForward(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulViewGoBack", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewGoBack(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulViewGoForward", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewGoForward(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulViewGoToHistoryOffset", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewGoToHistoryOffset(ULView view, int offset);

            [DllImport(libraryPath, EntryPoint = "ulViewReload", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewReload(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulViewStop", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewStop(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulViewFireKeyEvent", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewFireKeyEvent(ULView view, ULKeyEvent key_event);

            [DllImport(libraryPath, EntryPoint = "ulViewFireMouseEvent", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewFireMouseEvent(ULView view, ULMouseEvent mouse_event);

            [DllImport(libraryPath, EntryPoint = "ulViewFireScrollEvent", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewFireScrollEvent(ULView view, ULScrollEvent scroll_event);

            [DllImport(libraryPath, EntryPoint = "ulViewSetChangeTitleCallback", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewSetChangeTitleCallback(ULView view, ULChangeTitleCallback callback, IntPtr user_data);

            [DllImport(libraryPath, EntryPoint = "ulViewSetChangeURLCallback", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewSetChangeURLCallback(ULView view, ULChangeURLCallback callback, IntPtr user_data);

            [DllImport(libraryPath, EntryPoint = "ulViewSetChangeTooltipCallback", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewSetChangeTooltipCallback(ULView view, ULChangeTooltipCallback callback, IntPtr user_data);

            [DllImport(libraryPath, EntryPoint = "ulViewSetChangeCursorCallback", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewSetChangeCursorCallback(ULView view, ULChangeCursorCallback callback, IntPtr user_data);

            [DllImport(libraryPath, EntryPoint = "ulViewSetAddConsoleMessageCallback", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewSetAddConsoleMessageCallback(ULView view, ULAddConsoleMessageCallback callback, IntPtr user_data);

            [DllImport(libraryPath, EntryPoint = "ulViewSetBeginLoadingCallback", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewSetBeginLoadingCallback(ULView view, ULBeginLoadingCallback callback, IntPtr user_data);

            [DllImport(libraryPath, EntryPoint = "ulViewSetFinishLoadingCallback", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewSetFinishLoadingCallback(ULView view, ULFinishLoadingCallback callback, IntPtr user_data);

            [DllImport(libraryPath, EntryPoint = "ulViewSetUpdateHistoryCallback", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewSetUpdateHistoryCallback(ULView view, ULUpdateHistoryCallback callback, IntPtr user_data);

            [DllImport(libraryPath, EntryPoint = "ulViewSetDOMReadyCallback", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewSetDOMReadyCallback(ULView view, ULDOMReadyCallback callback, IntPtr user_data);

            [DllImport(libraryPath, EntryPoint = "ulViewSetNeedsPaint", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulViewSetNeedsPaint(ULView view, bool needs_paint);

            [DllImport(libraryPath, EntryPoint = "ulViewGetNeedsPaint", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool ulViewGetNeedsPaint(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulViewCreateInspectorView", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULView ulViewCreateInspectorView(ULView view);

            [DllImport(libraryPath, EntryPoint = "ulCreateString", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public static extern ULString ulCreateString([MarshalAs(UnmanagedType.LPStr)] string str);

            [DllImport(libraryPath, EntryPoint = "ulCreateStringUTF8", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULString ulCreateStringUTF8(byte[] str, UIntPtr len);

            [DllImport(libraryPath, EntryPoint = "ulCreateStringUTF16", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULString ulCreateStringUTF16(char[] str, UIntPtr len);

            [DllImport(libraryPath, EntryPoint = "ulDestroyString", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulDestroyString(ULString str);

            [DllImport(libraryPath, EntryPoint = "ulStringGetData", CallingConvention = CallingConvention.Cdecl)]
            public static extern /* (ULChar16 *) */IntPtr ulStringGetData(ULString str);

            [DllImport(libraryPath, EntryPoint = "ulStringGetLength", CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr ulStringGetLength(ULString str);

            [DllImport(libraryPath, EntryPoint = "ulStringIsEmpty", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool ulStringIsEmpty(ULString str);

            [DllImport(libraryPath, EntryPoint = "ulCreateEmptyBitmap", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULBitmap ulCreateEmptyBitmap();

            [DllImport(libraryPath, EntryPoint = "ulCreateBitmap", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULBitmap ulCreateBitmap(uint width, uint height, ULBitmapFormat format);

            [DllImport(libraryPath, EntryPoint = "ulCreateBitmapFromPixels", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULBitmap ulCreateBitmapFromPixels(uint width, uint height, ULBitmapFormat format, uint row_bytes, /* (const void *) */IntPtr pixels, UIntPtr size, bool should_copy);

            [DllImport(libraryPath, EntryPoint = "ulCreateBitmapFromCopy", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULBitmap ulCreateBitmapFromCopy(ULBitmap existing_bitmap);

            [DllImport(libraryPath, EntryPoint = "ulDestroyBitmap", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulDestroyBitmap(ULBitmap bitmap);

            [DllImport(libraryPath, EntryPoint = "ulBitmapGetWidth", CallingConvention = CallingConvention.Cdecl)]
            public static extern uint ulBitmapGetWidth(ULBitmap bitmap);

            [DllImport(libraryPath, EntryPoint = "ulBitmapGetHeight", CallingConvention = CallingConvention.Cdecl)]
            public static extern uint ulBitmapGetHeight(ULBitmap bitmap);

            [DllImport(libraryPath, EntryPoint = "ulBitmapGetFormat", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULBitmapFormat ulBitmapGetFormat(ULBitmap bitmap);

            [DllImport(libraryPath, EntryPoint = "ulBitmapGetBpp", CallingConvention = CallingConvention.Cdecl)]
            public static extern uint ulBitmapGetBpp(ULBitmap bitmap);

            [DllImport(libraryPath, EntryPoint = "ulBitmapGetRowBytes", CallingConvention = CallingConvention.Cdecl)]
            public static extern uint ulBitmapGetRowBytes(ULBitmap bitmap);

            [DllImport(libraryPath, EntryPoint = "ulBitmapGetSize", CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr ulBitmapGetSize(ULBitmap bitmap);

            [DllImport(libraryPath, EntryPoint = "ulBitmapOwnsPixels", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool ulBitmapOwnsPixels(ULBitmap bitmap);

            [DllImport(libraryPath, EntryPoint = "ulBitmapLockPixels", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ulBitmapLockPixels(ULBitmap bitmap);

            [DllImport(libraryPath, EntryPoint = "ulBitmapUnlockPixels", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulBitmapUnlockPixels(ULBitmap bitmap);

            [DllImport(libraryPath, EntryPoint = "ulBitmapRawPixels", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ulBitmapRawPixels(ULBitmap bitmap);

            [DllImport(libraryPath, EntryPoint = "ulBitmapIsEmpty", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool ulBitmapIsEmpty(ULBitmap bitmap);

            [DllImport(libraryPath, EntryPoint = "ulBitmapErase", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulBitmapErase(ULBitmap bitmap);

            [DllImport(libraryPath, EntryPoint = "ulBitmapWritePNG", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public static extern bool ulBitmapWritePNG(ULBitmap bitmap, [MarshalAs(UnmanagedType.LPStr)] string path);

            [DllImport(libraryPath, EntryPoint = "ulCreateKeyEvent", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULKeyEvent ulCreateKeyEvent(ULKeyEventType type, uint modifiers, int virtual_key_code, int native_key_code, ULString text, ULString unmodified_text, bool is_keypad, bool is_auto_repeat, bool is_system_key);

            [DllImport(libraryPath, EntryPoint = "ulCreateKeyEventWindows", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULKeyEvent ulCreateKeyEventWindows(ULKeyEventType type, UIntPtr wparam, IntPtr lparam, bool is_system_key);

            [DllImport(libraryPath, EntryPoint = "ulDestroyKeyEvent", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulDestroyKeyEvent(ULKeyEvent evt);

            [DllImport(libraryPath, EntryPoint = "ulCreateMouseEvent", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULMouseEvent ulCreateMouseEvent(ULMouseEventType type, int x, int y, ULMouseButton button);

            [DllImport(libraryPath, EntryPoint = "ulDestroyMouseEvent", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulDestroyMouseEvent(ULMouseEvent evt);

            [DllImport(libraryPath, EntryPoint = "ulCreateScrollEvent", CallingConvention = CallingConvention.Cdecl)]
            public static extern ULScrollEvent ulCreateScrollEvent(ULScrollEventType type, int delta_x, int delta_y);

            [DllImport(libraryPath, EntryPoint = "ulDestroyScrollEvent", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ulDestroyScrollEvent(ULScrollEvent evt);
        }
    }
}
