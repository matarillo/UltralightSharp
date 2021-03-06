using System;
using System.Runtime.InteropServices;

namespace UltralightInterop.Data
{
    [StructLayout(LayoutKind.Sequential)]
    public struct JSStaticValue
    {
        /* (const char *) */
        public IntPtr name;

        /* (JSObjectGetPropertyCallback) */
        public IntPtr getProperty;

        /* (JSObjectSetPropertyCallback) */
        public IntPtr setProperty;

        public JSPropertyAttributes attributes;
    }
}
