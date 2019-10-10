using System.Runtime.InteropServices;

namespace Native
{
    public static unsafe partial class JavaScriptCore
    {
        private const string libraryPath = "C:\Users\kinomata1\Downloads\include\JavaScriptCore\WebCore.dll";

        [DllImport(libraryPath, EntryPoint = "JSContextGroupCreate", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSContextGroupRef")]
        public static extern OpaqueJSContextGroup* JSContextGroupCreate();

        [DllImport(libraryPath, EntryPoint = "JSContextGroupRetain", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSContextGroupRef")]
        public static extern OpaqueJSContextGroup* JSContextGroupRetain([NativeTypeName("JSContextGroupRef")] OpaqueJSContextGroup* group);

        [DllImport(libraryPath, EntryPoint = "JSContextGroupRelease", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JSContextGroupRelease([NativeTypeName("JSContextGroupRef")] OpaqueJSContextGroup* group);

        [DllImport(libraryPath, EntryPoint = "JSGlobalContextCreate", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSGlobalContextRef")]
        public static extern OpaqueJSContext* JSGlobalContextCreate([NativeTypeName("JSClassRef")] OpaqueJSClass* globalObjectClass);

        [DllImport(libraryPath, EntryPoint = "JSGlobalContextCreateInGroup", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSGlobalContextRef")]
        public static extern OpaqueJSContext* JSGlobalContextCreateInGroup([NativeTypeName("JSContextGroupRef")] OpaqueJSContextGroup* group, [NativeTypeName("JSClassRef")] OpaqueJSClass* globalObjectClass);

        [DllImport(libraryPath, EntryPoint = "JSGlobalContextRetain", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSGlobalContextRef")]
        public static extern OpaqueJSContext* JSGlobalContextRetain([NativeTypeName("JSGlobalContextRef")] OpaqueJSContext* ctx);

        [DllImport(libraryPath, EntryPoint = "JSGlobalContextRelease", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JSGlobalContextRelease([NativeTypeName("JSGlobalContextRef")] OpaqueJSContext* ctx);

        [DllImport(libraryPath, EntryPoint = "JSContextGetGlobalObject", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSContextGetGlobalObject([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx);

        [DllImport(libraryPath, EntryPoint = "JSContextGetGroup", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSContextGroupRef")]
        public static extern OpaqueJSContextGroup* JSContextGetGroup([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx);

        [DllImport(libraryPath, EntryPoint = "JSContextGetGlobalContext", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSGlobalContextRef")]
        public static extern OpaqueJSContext* JSContextGetGlobalContext([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx);

        [DllImport(libraryPath, EntryPoint = "JSGlobalContextCopyName", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSStringRef")]
        public static extern OpaqueJSString* JSGlobalContextCopyName([NativeTypeName("JSGlobalContextRef")] OpaqueJSContext* ctx);

        [DllImport(libraryPath, EntryPoint = "JSGlobalContextSetName", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JSGlobalContextSetName([NativeTypeName("JSGlobalContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSStringRef")] OpaqueJSString* name);
    }
}
