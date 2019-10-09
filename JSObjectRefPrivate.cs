using System.Runtime.InteropServices;

namespace Native
{
    public static unsafe partial class JavaScriptCore
    {
        private const string libraryPath = "C:\Users\kinomata1\Downloads\include\JavaScriptCore\WebCore.dll";

        [DllImport(libraryPath, EntryPoint = "JSObjectSetPrivateProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSObjectSetPrivateProperty([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSStringRef")] OpaqueJSString* propertyName, [NativeTypeName("JSValueRef")] OpaqueJSValue* value);

        [DllImport(libraryPath, EntryPoint = "JSObjectGetPrivateProperty", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSValueRef")]
        public static extern OpaqueJSValue* JSObjectGetPrivateProperty([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSStringRef")] OpaqueJSString* propertyName);

        [DllImport(libraryPath, EntryPoint = "JSObjectDeletePrivateProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSObjectDeletePrivateProperty([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSStringRef")] OpaqueJSString* propertyName);
    }
}
