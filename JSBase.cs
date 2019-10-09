using System.Runtime.InteropServices;

namespace Native
{
    public partial struct OpaqueJSContextGroup
    {
    }

    public partial struct OpaqueJSContext
    {
    }

    public partial struct OpaqueJSString
    {
    }

    public partial struct OpaqueJSClass
    {
    }

    public partial struct OpaqueJSPropertyNameArray
    {
    }

    public partial struct OpaqueJSPropertyNameAccumulator
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void JSTypedArrayBytesDeallocator([NativeTypeName("void *")] void* bytes, [NativeTypeName("void *")] void* deallocatorContext);

    public partial struct OpaqueJSValue
    {
    }

    public static unsafe partial class JavaScriptCore
    {
        private const string libraryPath = "C:\Users\kinomata1\Downloads\include\JavaScriptCore\WebCore.dll";

        [DllImport(libraryPath, EntryPoint = "JSEvaluateScript", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSValueRef")]
        public static extern OpaqueJSValue* JSEvaluateScript([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSStringRef")] OpaqueJSString* script, [NativeTypeName("JSObjectRef")] OpaqueJSValue* thisObject, [NativeTypeName("JSStringRef")] OpaqueJSString* sourceURL, int startingLineNumber, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSCheckScriptSyntax", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSCheckScriptSyntax([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSStringRef")] OpaqueJSString* script, [NativeTypeName("JSStringRef")] OpaqueJSString* sourceURL, int startingLineNumber, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSGarbageCollect", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JSGarbageCollect([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx);
    }
}
