using System;
using System.Runtime.InteropServices;

namespace Native
{
    public enum __AnonymousEnum_JSObjectRef_2161
    {
        kJSPropertyAttributeNone = 0,
        kJSPropertyAttributeReadOnly = 1 << 1,
        kJSPropertyAttributeDontEnum = 1 << 2,
        kJSPropertyAttributeDontDelete = 1 << 3,
    }

    public enum __AnonymousEnum_JSObjectRef_2912
    {
        kJSClassAttributeNone = 0,
        kJSClassAttributeNoAutomaticPrototype = 1 << 1,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void JSObjectInitializeCallback([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void JSObjectFinalizeCallback([NativeTypeName("JSObjectRef")] OpaqueJSValue* @object);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool JSObjectHasPropertyCallback([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSStringRef")] OpaqueJSString* propertyName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("JSValueRef")]
    public unsafe delegate OpaqueJSValue* JSObjectGetPropertyCallback([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSStringRef")] OpaqueJSString* propertyName, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool JSObjectSetPropertyCallback([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSStringRef")] OpaqueJSString* propertyName, [NativeTypeName("JSValueRef")] OpaqueJSValue* value, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool JSObjectDeletePropertyCallback([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSStringRef")] OpaqueJSString* propertyName, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void JSObjectGetPropertyNamesCallback([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSPropertyNameAccumulatorRef")] OpaqueJSPropertyNameAccumulator* propertyNames);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("JSValueRef")]
    public unsafe delegate OpaqueJSValue* JSObjectCallAsFunctionCallback([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* function, [NativeTypeName("JSObjectRef")] OpaqueJSValue* thisObject, [NativeTypeName("size_t")] UIntPtr argumentCount, [NativeTypeName("const JSValueRef []")] OpaqueJSValue* arguments, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("JSObjectRef")]
    public unsafe delegate OpaqueJSValue* JSObjectCallAsConstructorCallback([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* constructor, [NativeTypeName("size_t")] UIntPtr argumentCount, [NativeTypeName("const JSValueRef []")] OpaqueJSValue* arguments, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool JSObjectHasInstanceCallback([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* constructor, [NativeTypeName("JSValueRef")] OpaqueJSValue* possibleInstance, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("JSValueRef")]
    public unsafe delegate OpaqueJSValue* JSObjectConvertToTypeCallback([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, JSType type, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

    public unsafe partial struct JSStaticValue
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("JSObjectGetPropertyCallback")]
        public IntPtr getProperty;

        [NativeTypeName("JSObjectSetPropertyCallback")]
        public IntPtr setProperty;

        [NativeTypeName("JSPropertyAttributes")]
        public uint attributes;
    }

    public unsafe partial struct JSStaticFunction
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("JSObjectCallAsFunctionCallback")]
        public IntPtr callAsFunction;

        [NativeTypeName("JSPropertyAttributes")]
        public uint attributes;
    }

    public unsafe partial struct JSClassDefinition
    {
        public int version;

        [NativeTypeName("JSClassAttributes")]
        public uint attributes;

        [NativeTypeName("const char *")]
        public sbyte* className;

        [NativeTypeName("JSClassRef")]
        public OpaqueJSClass* parentClass;

        [NativeTypeName("const JSStaticValue *")]
        public JSStaticValue* staticValues;

        [NativeTypeName("const JSStaticFunction *")]
        public JSStaticFunction* staticFunctions;

        [NativeTypeName("JSObjectInitializeCallback")]
        public IntPtr initialize;

        [NativeTypeName("JSObjectFinalizeCallback")]
        public IntPtr finalize;

        [NativeTypeName("JSObjectHasPropertyCallback")]
        public IntPtr hasProperty;

        [NativeTypeName("JSObjectGetPropertyCallback")]
        public IntPtr getProperty;

        [NativeTypeName("JSObjectSetPropertyCallback")]
        public IntPtr setProperty;

        [NativeTypeName("JSObjectDeletePropertyCallback")]
        public IntPtr deleteProperty;

        [NativeTypeName("JSObjectGetPropertyNamesCallback")]
        public IntPtr getPropertyNames;

        [NativeTypeName("JSObjectCallAsFunctionCallback")]
        public IntPtr callAsFunction;

        [NativeTypeName("JSObjectCallAsConstructorCallback")]
        public IntPtr callAsConstructor;

        [NativeTypeName("JSObjectHasInstanceCallback")]
        public IntPtr hasInstance;

        [NativeTypeName("JSObjectConvertToTypeCallback")]
        public IntPtr convertToType;
    }

    public static unsafe partial class JavaScriptCore
    {
        private const string libraryPath = "C:\Users\kinomata1\Downloads\include\JavaScriptCore\WebCore.dll";

        // [NativeTypeName("const JSClassDefinition")]
        // public static extern JSClassDefinition kJSClassDefinitionEmpty;

        [DllImport(libraryPath, EntryPoint = "JSClassCreate", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSClassRef")]
        public static extern OpaqueJSClass* JSClassCreate([NativeTypeName("const JSClassDefinition *")] JSClassDefinition* definition);

        [DllImport(libraryPath, EntryPoint = "JSClassRetain", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSClassRef")]
        public static extern OpaqueJSClass* JSClassRetain([NativeTypeName("JSClassRef")] OpaqueJSClass* jsClass);

        [DllImport(libraryPath, EntryPoint = "JSClassRelease", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JSClassRelease([NativeTypeName("JSClassRef")] OpaqueJSClass* jsClass);

        [DllImport(libraryPath, EntryPoint = "JSObjectMake", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectMake([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSClassRef")] OpaqueJSClass* jsClass, [NativeTypeName("void *")] void* data);

        [DllImport(libraryPath, EntryPoint = "JSObjectMakeFunctionWithCallback", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectMakeFunctionWithCallback([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSStringRef")] OpaqueJSString* name, [NativeTypeName("JSObjectCallAsFunctionCallback")] IntPtr callAsFunction);

        [DllImport(libraryPath, EntryPoint = "JSObjectMakeConstructor", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectMakeConstructor([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSClassRef")] OpaqueJSClass* jsClass, [NativeTypeName("JSObjectCallAsConstructorCallback")] IntPtr callAsConstructor);

        [DllImport(libraryPath, EntryPoint = "JSObjectMakeArray", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectMakeArray([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("size_t")] UIntPtr argumentCount, [NativeTypeName("const JSValueRef []")] OpaqueJSValue* arguments, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectMakeDate", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectMakeDate([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("size_t")] UIntPtr argumentCount, [NativeTypeName("const JSValueRef []")] OpaqueJSValue* arguments, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectMakeError", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectMakeError([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("size_t")] UIntPtr argumentCount, [NativeTypeName("const JSValueRef []")] OpaqueJSValue* arguments, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectMakeRegExp", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectMakeRegExp([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("size_t")] UIntPtr argumentCount, [NativeTypeName("const JSValueRef []")] OpaqueJSValue* arguments, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectMakeFunction", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectMakeFunction([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSStringRef")] OpaqueJSString* name, [NativeTypeName("unsigned int")] uint parameterCount, [NativeTypeName("const JSStringRef []")] OpaqueJSString* parameterNames, [NativeTypeName("JSStringRef")] OpaqueJSString* body, [NativeTypeName("JSStringRef")] OpaqueJSString* sourceURL, int startingLineNumber, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectGetPrototype", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSValueRef")]
        public static extern OpaqueJSValue* JSObjectGetPrototype([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object);

        [DllImport(libraryPath, EntryPoint = "JSObjectSetPrototype", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JSObjectSetPrototype([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSValueRef")] OpaqueJSValue* value);

        [DllImport(libraryPath, EntryPoint = "JSObjectHasProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSObjectHasProperty([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSStringRef")] OpaqueJSString* propertyName);

        [DllImport(libraryPath, EntryPoint = "JSObjectGetProperty", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSValueRef")]
        public static extern OpaqueJSValue* JSObjectGetProperty([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSStringRef")] OpaqueJSString* propertyName, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectSetProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JSObjectSetProperty([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSStringRef")] OpaqueJSString* propertyName, [NativeTypeName("JSValueRef")] OpaqueJSValue* value, [NativeTypeName("JSPropertyAttributes")] uint attributes, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectDeleteProperty", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSObjectDeleteProperty([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSStringRef")] OpaqueJSString* propertyName, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectGetPropertyAtIndex", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSValueRef")]
        public static extern OpaqueJSValue* JSObjectGetPropertyAtIndex([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("unsigned int")] uint propertyIndex, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectSetPropertyAtIndex", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JSObjectSetPropertyAtIndex([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("unsigned int")] uint propertyIndex, [NativeTypeName("JSValueRef")] OpaqueJSValue* value, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectGetPrivate", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("void *")]
        public static extern void* JSObjectGetPrivate([NativeTypeName("JSObjectRef")] OpaqueJSValue* @object);

        [DllImport(libraryPath, EntryPoint = "JSObjectSetPrivate", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSObjectSetPrivate([NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("void *")] void* data);

        [DllImport(libraryPath, EntryPoint = "JSObjectIsFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSObjectIsFunction([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object);

        [DllImport(libraryPath, EntryPoint = "JSObjectCallAsFunction", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSValueRef")]
        public static extern OpaqueJSValue* JSObjectCallAsFunction([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("JSObjectRef")] OpaqueJSValue* thisObject, [NativeTypeName("size_t")] UIntPtr argumentCount, [NativeTypeName("const JSValueRef []")] OpaqueJSValue* arguments, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectIsConstructor", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool JSObjectIsConstructor([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object);

        [DllImport(libraryPath, EntryPoint = "JSObjectCallAsConstructor", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSObjectRef")]
        public static extern OpaqueJSValue* JSObjectCallAsConstructor([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object, [NativeTypeName("size_t")] UIntPtr argumentCount, [NativeTypeName("const JSValueRef []")] OpaqueJSValue* arguments, [NativeTypeName("JSValueRef *")] OpaqueJSValue** exception);

        [DllImport(libraryPath, EntryPoint = "JSObjectCopyPropertyNames", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSPropertyNameArrayRef")]
        public static extern OpaqueJSPropertyNameArray* JSObjectCopyPropertyNames([NativeTypeName("JSContextRef")] OpaqueJSContext* ctx, [NativeTypeName("JSObjectRef")] OpaqueJSValue* @object);

        [DllImport(libraryPath, EntryPoint = "JSPropertyNameArrayRetain", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSPropertyNameArrayRef")]
        public static extern OpaqueJSPropertyNameArray* JSPropertyNameArrayRetain([NativeTypeName("JSPropertyNameArrayRef")] OpaqueJSPropertyNameArray* array);

        [DllImport(libraryPath, EntryPoint = "JSPropertyNameArrayRelease", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JSPropertyNameArrayRelease([NativeTypeName("JSPropertyNameArrayRef")] OpaqueJSPropertyNameArray* array);

        [DllImport(libraryPath, EntryPoint = "JSPropertyNameArrayGetCount", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr JSPropertyNameArrayGetCount([NativeTypeName("JSPropertyNameArrayRef")] OpaqueJSPropertyNameArray* array);

        [DllImport(libraryPath, EntryPoint = "JSPropertyNameArrayGetNameAtIndex", CallingConvention = CallingConvention.Cdecl)]
        [return: NativeTypeName("JSStringRef")]
        public static extern OpaqueJSString* JSPropertyNameArrayGetNameAtIndex([NativeTypeName("JSPropertyNameArrayRef")] OpaqueJSPropertyNameArray* array, [NativeTypeName("size_t")] UIntPtr index);

        [DllImport(libraryPath, EntryPoint = "JSPropertyNameAccumulatorAddName", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JSPropertyNameAccumulatorAddName([NativeTypeName("JSPropertyNameAccumulatorRef")] OpaqueJSPropertyNameAccumulator* accumulator, [NativeTypeName("JSStringRef")] OpaqueJSString* propertyName);
    }
}
