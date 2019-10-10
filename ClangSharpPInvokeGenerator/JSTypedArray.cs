using System;
using System.Runtime.InteropServices;

namespace Native
{
    public static unsafe partial class JavaScriptCore
    {
        private const string libraryPath = "C:\Users\kinomata1\Downloads\include\JavaScriptCore\WebCore.dll";

        [DllImport(libraryPath, EntryPoint = "JSObjectMakeTypedArray", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectMakeTypedArray([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, JSTypedArrayType arrayType, [NativeTypeName("size_t")] UIntPtr length, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectMakeTypedArrayWithBytesNoCopy", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectMakeTypedArrayWithBytesNoCopy([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, JSTypedArrayType arrayType, [NativeTypeName("void *")] void* bytes, [NativeTypeName("size_t")] UIntPtr byteLength, [NativeTypeName("JSTypedArrayBytesDeallocator")] IntPtr bytesDeallocator, [NativeTypeName("void *")] void* deallocatorContext, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectMakeTypedArrayWithArrayBuffer", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectMakeTypedArrayWithArrayBuffer([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, JSTypedArrayType arrayType, [NativeTypeName("JSObjectRef")] OpaqueJSValue* buffer, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectMakeTypedArrayWithArrayBufferAndOffset", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectMakeTypedArrayWithArrayBufferAndOffset([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, JSTypedArrayType arrayType, [NativeTypeName("JSObjectRef")] OpaqueJSValue* buffer, [NativeTypeName("size_t")] UIntPtr byteOffset, [NativeTypeName("size_t")] UIntPtr length, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectGetTypedArrayBytesPtr", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("void *")]
        public static extern void* JSObjectGetTypedArrayBytesPtr([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectGetTypedArrayLength", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr JSObjectGetTypedArrayLength([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectGetTypedArrayByteLength", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr JSObjectGetTypedArrayByteLength([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectGetTypedArrayByteOffset", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr JSObjectGetTypedArrayByteOffset([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectGetTypedArrayBuffer", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectGetTypedArrayBuffer([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectMakeArrayBufferWithBytesNoCopy", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectMakeArrayBufferWithBytesNoCopy([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("void *")] void* bytes, [NativeTypeName("size_t")] UIntPtr byteLength, [NativeTypeName("JSTypedArrayBytesDeallocator")] IntPtr bytesDeallocator, [NativeTypeName("void *")] void* deallocatorContext, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectGetArrayBufferBytesPtr", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("void *")]
        public static extern void* JSObjectGetArrayBufferBytesPtr([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectGetArrayBufferByteLength", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr JSObjectGetArrayBufferByteLength([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);
    }
}
