using System;
using System.Runtime.InteropServices;

namespace UltralightInterop.JavaScriptCore
{
    [StructLayout(LayoutKind.Sequential)]
    public struct JSClassDefinition
    {
        // [NativeTypeName("const JSClassDefinition")]
        // public static extern JSClassDefinition kJSClassDefinitionEmpty;
        public static readonly JSClassDefinition Empty = default(JSClassDefinition);

        public int version;

        public JSClassAttributes attributes;

        /* (const char *) */
        public IntPtr className;

        /* (JSClassRef) */
        public IntPtr parentClass;

        /* (const JSStaticValue *) */
        public IntPtr staticValues;

        /* (const JSStaticFunction *) */
        public IntPtr staticFunctions;

        /* (JSObjectInitializeCallback) */
        public IntPtr initialize;

        /* (JSObjectFinalizeCallback) */
        public IntPtr finalize;

        /* (JSObjectHasPropertyCallback) */
        public IntPtr hasProperty;

        /* (JSObjectGetPropertyCallback) */
        public IntPtr getProperty;

        /* (JSObjectSetPropertyCallback) */
        public IntPtr setProperty;

        /* (JSObjectDeletePropertyCallback) */
        public IntPtr deleteProperty;

        /* (JSObjectGetPropertyNamesCallback) */
        public IntPtr getPropertyNames;

        /* (JSObjectCallAsFunctionCallback) */
        public IntPtr callAsFunction;

        /* (JSObjectCallAsConstructorCallback) */
        public IntPtr callAsConstructor;

        /* (JSObjectHasInstanceCallback) */
        public IntPtr hasInstance;

        /* (JSObjectConvertToTypeCallback) */
        public IntPtr convertToType;
    }
}
