using System;
using System.Runtime.InteropServices;
using UltralightInterop.Data;

namespace UltralightInterop
{
    public static class JavaScriptCore
    {
        #region JSBase

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void JSTypedArrayBytesDeallocator(IntPtr bytes, IntPtr deallocatorContext);

        #endregion

        #region JSObjectRef

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void JSObjectInitializeCallback(JSContextRef ctx, JSObjectRef @object);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void JSObjectFinalizeCallback(JSObjectRef @object);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool JSObjectHasPropertyCallback(JSContextRef ctx, JSObjectRef @object, JSStringRef propertyName);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate JSValueRef JSObjectGetPropertyCallback(JSContextRef ctx, JSObjectRef @object, JSStringRef propertyName, /* (JSValueRef *) */IntPtr exception);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool JSObjectSetPropertyCallback(JSContextRef ctx, JSObjectRef @object, JSStringRef propertyName, JSValueRef value, /* (JSValueRef *) */IntPtr exception);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool JSObjectDeletePropertyCallback(JSContextRef ctx, JSObjectRef @object, JSStringRef propertyName, /* (JSValueRef *) */IntPtr exception);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void JSObjectGetPropertyNamesCallback(JSContextRef ctx, JSObjectRef @object, JSPropertyNameAccumulatorRef propertyNames);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate JSValueRef JSObjectCallAsFunctionCallback(JSContextRef ctx, JSObjectRef function, JSObjectRef thisObject, UIntPtr argumentCount, JSValueRef[] arguments, /* (JSValueRef *) */IntPtr exception);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate JSObjectRef JSObjectCallAsConstructorCallback(JSContextRef ctx, JSObjectRef constructor, UIntPtr argumentCount, JSValueRef[] arguments, /* (JSValueRef *) */IntPtr exception);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool JSObjectHasInstanceCallback(JSContextRef ctx, JSObjectRef constructor, JSValueRef possibleInstance, /* (JSValueRef *) */IntPtr exception);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate JSValueRef JSObjectConvertToTypeCallback(JSContextRef ctx, JSObjectRef @object, JSType type, /* (JSValueRef *) */IntPtr exception);

        #endregion

        private static class NativeMethods
        {
            private const string libraryPath = "WebCore.dll";

            #region JSBase

            [DllImport(libraryPath, EntryPoint = "JSEvaluateScript", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSValueRef JSEvaluateScript(JSContextRef ctx, JSStringRef script, JSObjectRef thisObject, JSStringRef sourceURL, int startingLineNumber, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSCheckScriptSyntax", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSCheckScriptSyntax(JSContextRef ctx, JSStringRef script, JSStringRef sourceURL, int startingLineNumber, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSGarbageCollect", CallingConvention = CallingConvention.Cdecl)]
            public static extern void JSGarbageCollect(JSContextRef ctx);

            #endregion

            #region JSContextRef

            [DllImport(libraryPath, EntryPoint = "JSContextGroupCreate", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSContextGroupRef JSContextGroupCreate();

            [DllImport(libraryPath, EntryPoint = "JSContextGroupRetain", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSContextGroupRef JSContextGroupRetain(JSContextGroupRef group);

            [DllImport(libraryPath, EntryPoint = "JSContextGroupRelease", CallingConvention = CallingConvention.Cdecl)]
            public static extern void JSContextGroupRelease(JSContextGroupRef group);

            [DllImport(libraryPath, EntryPoint = "JSGlobalContextCreate", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSGlobalContextRef JSGlobalContextCreate(JSClassRef globalObjectClass);

            [DllImport(libraryPath, EntryPoint = "JSGlobalContextCreateInGroup", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSGlobalContextRef JSGlobalContextCreateInGroup(JSContextGroupRef group, JSClassRef globalObjectClass);

            [DllImport(libraryPath, EntryPoint = "JSGlobalContextRetain", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSGlobalContextRef JSGlobalContextRetain(JSGlobalContextRef ctx);

            [DllImport(libraryPath, EntryPoint = "JSGlobalContextRelease", CallingConvention = CallingConvention.Cdecl)]
            public static extern void JSGlobalContextRelease(JSGlobalContextRef ctx);

            [DllImport(libraryPath, EntryPoint = "JSContextGetGlobalObject", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSContextGetGlobalObject(JSContextRef ctx);

            [DllImport(libraryPath, EntryPoint = "JSContextGetGroup", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSContextGroupRef JSContextGetGroup(JSContextRef ctx);

            [DllImport(libraryPath, EntryPoint = "JSContextGetGlobalContext", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSGlobalContextRef JSContextGetGlobalContext(JSContextRef ctx);

            [DllImport(libraryPath, EntryPoint = "JSGlobalContextCopyName", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSStringRef JSGlobalContextCopyName(JSGlobalContextRef ctx);

            [DllImport(libraryPath, EntryPoint = "JSGlobalContextSetName", CallingConvention = CallingConvention.Cdecl)]
            public static extern void JSGlobalContextSetName(JSGlobalContextRef ctx, JSStringRef name);

            #endregion

            #region JSStringRef

            [DllImport(libraryPath, EntryPoint = "JSStringCreateWithCharacters", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSStringRef JSStringCreateWithCharacters([MarshalAs(UnmanagedType.LPWStr)] string chars, UIntPtr numChars);

            [DllImport(libraryPath, EntryPoint = "JSStringCreateWithUTF8CString", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSStringRef JSStringCreateWithUTF8CString(byte[] @string);

            [DllImport(libraryPath, EntryPoint = "JSStringRetain", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSStringRef JSStringRetain(JSStringRef @string);

            [DllImport(libraryPath, EntryPoint = "JSStringRelease", CallingConvention = CallingConvention.Cdecl)]
            public static extern void JSStringRelease(JSStringRef @string);

            [DllImport(libraryPath, EntryPoint = "JSStringGetLength", CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr JSStringGetLength(JSStringRef @string);

            [DllImport(libraryPath, EntryPoint = "JSStringGetCharactersPtr", CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.LPWStr)]
            public static extern string JSStringGetCharactersPtr(JSStringRef @string);

            [DllImport(libraryPath, EntryPoint = "JSStringGetMaximumUTF8CStringSize", CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr JSStringGetMaximumUTF8CStringSize(JSStringRef @string);

            [DllImport(libraryPath, EntryPoint = "JSStringGetUTF8CString", CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr JSStringGetUTF8CString(JSStringRef @string, byte[] buffer, UIntPtr bufferSize);

            [DllImport(libraryPath, EntryPoint = "JSStringIsEqual", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSStringIsEqual(JSStringRef a, JSStringRef b);

            [DllImport(libraryPath, EntryPoint = "JSStringIsEqualToUTF8CString", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSStringIsEqualToUTF8CString(JSStringRef a, byte[] b);

            #endregion

            #region JSObjectRef

            [DllImport(libraryPath, EntryPoint = "JSClassCreate", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSClassRef JSClassCreate([In] ref JSClassDefinition definition);

            [DllImport(libraryPath, EntryPoint = "JSClassRetain", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSClassRef JSClassRetain(JSClassRef jsClass);

            [DllImport(libraryPath, EntryPoint = "JSClassRelease", CallingConvention = CallingConvention.Cdecl)]
            public static extern void JSClassRelease(JSClassRef jsClass);

            [DllImport(libraryPath, EntryPoint = "JSObjectMake", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectMake(JSContextRef ctx, JSClassRef jsClass, IntPtr data);

            [DllImport(libraryPath, EntryPoint = "JSObjectMakeFunctionWithCallback", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectMakeFunctionWithCallback(JSContextRef ctx, JSStringRef name, JSObjectCallAsFunctionCallback callAsFunction);

            [DllImport(libraryPath, EntryPoint = "JSObjectMakeConstructor", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectMakeConstructor(JSContextRef ctx, JSClassRef jsClass, JSObjectCallAsConstructorCallback callAsConstructor);

            [DllImport(libraryPath, EntryPoint = "JSObjectMakeArray", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectMakeArray(JSContextRef ctx, UIntPtr argumentCount, JSValueRef[] arguments, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectMakeDate", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectMakeDate(JSContextRef ctx, UIntPtr argumentCount, JSValueRef[] arguments, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectMakeError", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectMakeError(JSContextRef ctx, UIntPtr argumentCount, JSValueRef[] arguments, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectMakeRegExp", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectMakeRegExp(JSContextRef ctx, UIntPtr argumentCount, JSValueRef[] arguments, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectMakeFunction", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectMakeFunction(JSContextRef ctx, JSStringRef name, uint parameterCount, JSStringRef[] parameterNames, JSStringRef body, JSStringRef sourceURL, int startingLineNumber, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectGetPrototype", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSValueRef JSObjectGetPrototype(JSContextRef ctx, JSObjectRef @object);

            [DllImport(libraryPath, EntryPoint = "JSObjectSetPrototype", CallingConvention = CallingConvention.Cdecl)]
            public static extern void JSObjectSetPrototype(JSContextRef ctx, JSObjectRef @object, JSValueRef value);

            [DllImport(libraryPath, EntryPoint = "JSObjectHasProperty", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSObjectHasProperty(JSContextRef ctx, JSObjectRef @object, JSStringRef propertyName);

            [DllImport(libraryPath, EntryPoint = "JSObjectGetProperty", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSValueRef JSObjectGetProperty(JSContextRef ctx, JSObjectRef @object, JSStringRef propertyName, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectSetProperty", CallingConvention = CallingConvention.Cdecl)]
            public static extern void JSObjectSetProperty(JSContextRef ctx, JSObjectRef @object, JSStringRef propertyName, JSValueRef value, JSPropertyAttributes attributes, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectDeleteProperty", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSObjectDeleteProperty(JSContextRef ctx, JSObjectRef @object, JSStringRef propertyName, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectGetPropertyAtIndex", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSValueRef JSObjectGetPropertyAtIndex(JSContextRef ctx, JSObjectRef @object, uint propertyIndex, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectSetPropertyAtIndex", CallingConvention = CallingConvention.Cdecl)]
            public static extern void JSObjectSetPropertyAtIndex(JSContextRef ctx, JSObjectRef @object, uint propertyIndex, JSValueRef value, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectGetPrivate", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr JSObjectGetPrivate(JSObjectRef @object);

            [DllImport(libraryPath, EntryPoint = "JSObjectSetPrivate", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSObjectSetPrivate(JSObjectRef @object, IntPtr data);

            [DllImport(libraryPath, EntryPoint = "JSObjectIsFunction", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSObjectIsFunction(JSContextRef ctx, JSObjectRef @object);

            [DllImport(libraryPath, EntryPoint = "JSObjectCallAsFunction", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSValueRef JSObjectCallAsFunction(JSContextRef ctx, JSObjectRef @object, JSObjectRef thisObject, UIntPtr argumentCount, JSValueRef[] arguments, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectIsConstructor", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSObjectIsConstructor(JSContextRef ctx, JSObjectRef @object);

            [DllImport(libraryPath, EntryPoint = "JSObjectCallAsConstructor", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectCallAsConstructor(JSContextRef ctx, JSObjectRef @object, UIntPtr argumentCount, JSValueRef[] arguments, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectCopyPropertyNames", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSPropertyNameArrayRef JSObjectCopyPropertyNames(JSContextRef ctx, JSObjectRef @object);

            [DllImport(libraryPath, EntryPoint = "JSPropertyNameArrayRetain", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSPropertyNameArrayRef JSPropertyNameArrayRetain(JSPropertyNameArrayRef array);

            [DllImport(libraryPath, EntryPoint = "JSPropertyNameArrayRelease", CallingConvention = CallingConvention.Cdecl)]
            public static extern void JSPropertyNameArrayRelease(JSPropertyNameArrayRef array);

            [DllImport(libraryPath, EntryPoint = "JSPropertyNameArrayGetCount", CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr JSPropertyNameArrayGetCount(JSPropertyNameArrayRef array);

            [DllImport(libraryPath, EntryPoint = "JSPropertyNameArrayGetNameAtIndex", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSStringRef JSPropertyNameArrayGetNameAtIndex(JSPropertyNameArrayRef array, UIntPtr index);

            [DllImport(libraryPath, EntryPoint = "JSPropertyNameAccumulatorAddName", CallingConvention = CallingConvention.Cdecl)]
            public static extern void JSPropertyNameAccumulatorAddName(JSPropertyNameAccumulatorRef accumulator, JSStringRef propertyName);

            #endregion

            #region JSObjectRefPrivate

            [DllImport(libraryPath, EntryPoint = "JSObjectSetPrivateProperty", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSObjectSetPrivateProperty(JSContextRef ctx, JSObjectRef @object, JSStringRef propertyName, JSValueRef value);

            [DllImport(libraryPath, EntryPoint = "JSObjectGetPrivateProperty", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSValueRef JSObjectGetPrivateProperty(JSContextRef ctx, JSObjectRef @object, JSStringRef propertyName);

            [DllImport(libraryPath, EntryPoint = "JSObjectDeletePrivateProperty", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSObjectDeletePrivateProperty(JSContextRef ctx, JSObjectRef @object, JSStringRef propertyName);

            #endregion

            #region JSTypedArray

            [DllImport(libraryPath, EntryPoint = "JSObjectMakeTypedArray", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectMakeTypedArray(JSContextRef ctx, JSTypedArrayType arrayType, UIntPtr length, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectMakeTypedArrayWithBytesNoCopy", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectMakeTypedArrayWithBytesNoCopy(JSContextRef ctx, JSTypedArrayType arrayType, IntPtr bytes, UIntPtr byteLength, JSTypedArrayBytesDeallocator bytesDeallocator, IntPtr deallocatorContext, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectMakeTypedArrayWithArrayBuffer", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectMakeTypedArrayWithArrayBuffer(JSContextRef ctx, JSTypedArrayType arrayType, JSObjectRef buffer, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectMakeTypedArrayWithArrayBufferAndOffset", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectMakeTypedArrayWithArrayBufferAndOffset(JSContextRef ctx, JSTypedArrayType arrayType, JSObjectRef buffer, UIntPtr byteOffset, UIntPtr length, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectGetTypedArrayBytesPtr", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr JSObjectGetTypedArrayBytesPtr(JSContextRef ctx, JSObjectRef @object, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectGetTypedArrayLength", CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr JSObjectGetTypedArrayLength(JSContextRef ctx, JSObjectRef @object, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectGetTypedArrayByteLength", CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr JSObjectGetTypedArrayByteLength(JSContextRef ctx, JSObjectRef @object, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectGetTypedArrayByteOffset", CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr JSObjectGetTypedArrayByteOffset(JSContextRef ctx, JSObjectRef @object, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectGetTypedArrayBuffer", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectGetTypedArrayBuffer(JSContextRef ctx, JSObjectRef @object, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectMakeArrayBufferWithBytesNoCopy", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSObjectMakeArrayBufferWithBytesNoCopy(JSContextRef ctx, IntPtr bytes, UIntPtr byteLength, JSTypedArrayBytesDeallocator bytesDeallocator, IntPtr deallocatorContext, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectGetArrayBufferBytesPtr", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr JSObjectGetArrayBufferBytesPtr(JSContextRef ctx, JSObjectRef @object, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSObjectGetArrayBufferByteLength", CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr JSObjectGetArrayBufferByteLength(JSContextRef ctx, JSObjectRef @object, /* (JSValueRef *) */IntPtr exception);

            #endregion

            #region JSValueRef

            [DllImport(libraryPath, EntryPoint = "JSValueGetType", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSType JSValueGetType(JSContextRef ctx, JSValueRef value);

            [DllImport(libraryPath, EntryPoint = "JSValueIsUndefined", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSValueIsUndefined(JSContextRef ctx, JSValueRef value);

            [DllImport(libraryPath, EntryPoint = "JSValueIsNull", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSValueIsNull(JSContextRef ctx, JSValueRef value);

            [DllImport(libraryPath, EntryPoint = "JSValueIsBoolean", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSValueIsBoolean(JSContextRef ctx, JSValueRef value);

            [DllImport(libraryPath, EntryPoint = "JSValueIsNumber", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSValueIsNumber(JSContextRef ctx, JSValueRef value);

            [DllImport(libraryPath, EntryPoint = "JSValueIsString", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSValueIsString(JSContextRef ctx, JSValueRef value);

            [DllImport(libraryPath, EntryPoint = "JSValueIsObject", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSValueIsObject(JSContextRef ctx, JSValueRef value);

            [DllImport(libraryPath, EntryPoint = "JSValueIsObjectOfClass", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSValueIsObjectOfClass(JSContextRef ctx, JSValueRef value, JSClassRef jsClass);

            [DllImport(libraryPath, EntryPoint = "JSValueIsArray", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSValueIsArray(JSContextRef ctx, JSValueRef value);

            [DllImport(libraryPath, EntryPoint = "JSValueIsDate", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSValueIsDate(JSContextRef ctx, JSValueRef value);

            [DllImport(libraryPath, EntryPoint = "JSValueGetTypedArrayType", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSTypedArrayType JSValueGetTypedArrayType(JSContextRef ctx, JSValueRef value, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSValueIsEqual", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSValueIsEqual(JSContextRef ctx, JSValueRef a, JSValueRef b, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSValueIsStrictEqual", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSValueIsStrictEqual(JSContextRef ctx, JSValueRef a, JSValueRef b);

            [DllImport(libraryPath, EntryPoint = "JSValueIsInstanceOfConstructor", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSValueIsInstanceOfConstructor(JSContextRef ctx, JSValueRef value, JSObjectRef constructor, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSValueMakeUndefined", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSValueRef JSValueMakeUndefined(JSContextRef ctx);

            [DllImport(libraryPath, EntryPoint = "JSValueMakeNull", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSValueRef JSValueMakeNull(JSContextRef ctx);

            [DllImport(libraryPath, EntryPoint = "JSValueMakeBoolean", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSValueRef JSValueMakeBoolean(JSContextRef ctx, bool boolean);

            [DllImport(libraryPath, EntryPoint = "JSValueMakeNumber", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSValueRef JSValueMakeNumber(JSContextRef ctx, double number);

            [DllImport(libraryPath, EntryPoint = "JSValueMakeString", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSValueRef JSValueMakeString(JSContextRef ctx, JSStringRef @string);

            [DllImport(libraryPath, EntryPoint = "JSValueMakeFromJSONString", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSValueRef JSValueMakeFromJSONString(JSContextRef ctx, JSStringRef @string);

            [DllImport(libraryPath, EntryPoint = "JSValueCreateJSONString", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSStringRef JSValueCreateJSONString(JSContextRef ctx, JSValueRef value, uint indent, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSValueToBoolean", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool JSValueToBoolean(JSContextRef ctx, JSValueRef value);

            [DllImport(libraryPath, EntryPoint = "JSValueToNumber", CallingConvention = CallingConvention.Cdecl)]
            public static extern double JSValueToNumber(JSContextRef ctx, JSValueRef value, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSValueToStringCopy", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSStringRef JSValueToStringCopy(JSContextRef ctx, JSValueRef value, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSValueToObject", CallingConvention = CallingConvention.Cdecl)]
            public static extern JSObjectRef JSValueToObject(JSContextRef ctx, JSValueRef value, /* (JSValueRef *) */IntPtr exception);

            [DllImport(libraryPath, EntryPoint = "JSValueProtect", CallingConvention = CallingConvention.Cdecl)]
            public static extern void JSValueProtect(JSContextRef ctx, JSValueRef value);

            [DllImport(libraryPath, EntryPoint = "JSValueUnprotect", CallingConvention = CallingConvention.Cdecl)]
            public static extern void JSValueUnprotect(JSContextRef ctx, JSValueRef value);

            #endregion
        }
    }
}
