using System.Runtime.InteropServices;

namespace Native
{
    public enum JSType
    {
        kJSTypeUndefined,
        kJSTypeNull,
        kJSTypeBoolean,
        kJSTypeNumber,
        kJSTypeString,
        kJSTypeObject,
    }

    public enum JSTypedArrayType
    {
        kJSTypedArrayTypeInt8Array,
        kJSTypedArrayTypeInt16Array,
        kJSTypedArrayTypeInt32Array,
        kJSTypedArrayTypeUint8Array,
        kJSTypedArrayTypeUint8ClampedArray,
        kJSTypedArrayTypeUint16Array,
        kJSTypedArrayTypeUint32Array,
        kJSTypedArrayTypeFloat32Array,
        kJSTypedArrayTypeFloat64Array,
        kJSTypedArrayTypeArrayBuffer,
        kJSTypedArrayTypeNone,
    }

    public static unsafe partial class JavaScriptCore
    {
        private const string libraryPath = "C:\Users\kinomata1\Downloads\include\JavaScriptCore\WebCore.dll";

        [DllImport(libraryPath, EntryPoint = "JSValueGetType", CallingConvention = CallingConvention.Cdecl)]
        public static extern JSType JSValueGetType([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value);

        [DllImport(libraryPath, EntryPoint = "JSValueIsUndefined", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSValueIsUndefined([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value);

        [DllImport(libraryPath, EntryPoint = "JSValueIsNull", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSValueIsNull([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value);

        [DllImport(libraryPath, EntryPoint = "JSValueIsBoolean", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSValueIsBoolean([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value);

        [DllImport(libraryPath, EntryPoint = "JSValueIsNumber", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSValueIsNumber([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value);

        [DllImport(libraryPath, EntryPoint = "JSValueIsString", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSValueIsString([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value);

        [DllImport(libraryPath, EntryPoint = "JSValueIsObject", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSValueIsObject([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value);

        [DllImport(libraryPath, EntryPoint = "JSValueIsObjectOfClass", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSValueIsObjectOfClass([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value, [NativeTypeName("JSClassRef")] OpaqueJSClass* jsClass);

        [DllImport(libraryPath, EntryPoint = "JSValueIsArray", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSValueIsArray([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value);

        [DllImport(libraryPath, EntryPoint = "JSValueIsDate", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSValueIsDate([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value);

        [DllImport(libraryPath, EntryPoint = "JSValueGetTypedArrayType", CallingConvention = CallingConvention.Cdecl)]
        public static extern JSTypedArrayType JSValueGetTypedArrayType([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSValueIsEqual", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSValueIsEqual([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* a, [NativeTypeName("JSValueRef")] OpaqueJSValue* b, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSValueIsStrictEqual", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSValueIsStrictEqual([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* a, [NativeTypeName("JSValueRef")] OpaqueJSValue* b);

        [DllImport(libraryPath, EntryPoint = "JSValueIsInstanceOfConstructor", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSValueIsInstanceOfConstructor([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value, [NativeTypeName("JSObjectRef")] OpaqueJSValue* constructor, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSValueMakeUndefined", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSValueRef")]
        public static extern OpaqueJSValue* JSValueMakeUndefined([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx);

        [DllImport(libraryPath, EntryPoint = "JSValueMakeNull", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSValueRef")]
        public static extern OpaqueJSValue* JSValueMakeNull([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx);

        [DllImport(libraryPath, EntryPoint = "JSValueMakeBoolean", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSValueRef")]
        public static extern OpaqueJSValue* JSValueMakeBoolean([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, bool boolean);

        [DllImport(libraryPath, EntryPoint = "JSValueMakeNumber", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSValueRef")]
        public static extern OpaqueJSValue* JSValueMakeNumber([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, double number);

        [DllImport(libraryPath, EntryPoint = "JSValueMakeString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSValueRef")]
        public static extern OpaqueJSValue* JSValueMakeString([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSStringRef")] OpaqueJSString* @string);

        [DllImport(libraryPath, EntryPoint = "JSValueMakeFromJSONString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSValueRef")]
        public static extern OpaqueJSValue* JSValueMakeFromJSONString([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSStringRef")] OpaqueJSString* @string);

        [DllImport(libraryPath, EntryPoint = "JSValueCreateJSONString", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSStringRef")]
        public static extern OpaqueJSString* JSValueCreateJSONString([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value, [NativeTypeName("unsigned int")] uint indent, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSValueToBoolean", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSValueToBoolean([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value);

        [DllImport(libraryPath, EntryPoint = "JSValueToNumber", CallingConvention = CallingConvention.Cdecl)]
        public static extern double JSValueToNumber([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSValueToStringCopy", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSStringRef")]
        public static extern OpaqueJSString* JSValueToStringCopy([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSValueToObject", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSValueToObject([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSValueProtect", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JSValueProtect([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value);

        [DllImport(libraryPath, EntryPoint = "JSValueUnprotect", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JSValueUnprotect([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSValueRef")] OpaqueJSValue* value);
    }
}
