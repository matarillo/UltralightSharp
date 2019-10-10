using System;
using System.Runtime.InteropServices;

namespace Native
{
    public static unsafe partial class JavaScriptCore
    {
        private const string libraryPath = "C:\Users\kinomata1\Downloads\include\JavaScriptCore\WebCore.dll";

        [DllImport(libraryPath, EntryPoint = "JSStringCreateWithCharacters", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSStringRef")]
        public static extern OpaqueJSString* JSStringCreateWithCharacters([NativeTypeName("const JSChar *")] char* chars, [NativeTypeName("size_t")] UIntPtr numChars);

        [DllImport(libraryPath, EntryPoint = "JSStringCreateWithUTF8CString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSStringRef")]
        public static extern OpaqueJSString* JSStringCreateWithUTF8CString([NativeTypeName("const char *")] sbyte* @string);

        [DllImport(libraryPath, EntryPoint = "JSStringRetain", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSStringRef")]
        public static extern OpaqueJSString* JSStringRetain([NativeTypeName("JSStringRef")] OpaqueJSString* @string);

        [DllImport(libraryPath, EntryPoint = "JSStringRelease", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JSStringRelease([NativeTypeName("JSStringRef")] OpaqueJSString* @string);

        [DllImport(libraryPath, EntryPoint = "JSStringGetLength", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr JSStringGetLength([NativeTypeName("JSStringRef")] OpaqueJSString* @string);

        [DllImport(libraryPath, EntryPoint = "JSStringGetCharactersPtr", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("const JSChar *")]
        public static extern char* JSStringGetCharactersPtr([NativeTypeName("JSStringRef")] OpaqueJSString* @string);

        [DllImport(libraryPath, EntryPoint = "JSStringGetMaximumUTF8CStringSize", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr JSStringGetMaximumUTF8CStringSize([NativeTypeName("JSStringRef")] OpaqueJSString* @string);

        [DllImport(libraryPath, EntryPoint = "JSStringGetUTF8CString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr JSStringGetUTF8CString([NativeTypeName("JSStringRef")] OpaqueJSString* @string, [NativeTypeName("char *")] sbyte* buffer, [NativeTypeName("size_t")] UIntPtr bufferSize);

        [DllImport(libraryPath, EntryPoint = "JSStringIsEqual", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSStringIsEqual([NativeTypeName("JSStringRef")] OpaqueJSString* a, [NativeTypeName("JSStringRef")] OpaqueJSString* b);

        [DllImport(libraryPath, EntryPoint = "JSStringIsEqualToUTF8CString", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSStringIsEqualToUTF8CString([NativeTypeName("JSStringRef")] OpaqueJSString* a, [NativeTypeName("const char *")] sbyte* b);
    }
}
