using System;
using System.Runtime.InteropServices;

namespace UltralightInterop.JavaScriptCore
{
    [StructLayout(LayoutKind.Sequential)]
    public struct JSStaticFunction
    {
        /* (const char *) */
        public IntPtr name;

        /* (JSObjectCallAsFunctionCallback) */
        public IntPtr callAsFunction;

        public JSPropertyAttributes attributes;
    }
}
