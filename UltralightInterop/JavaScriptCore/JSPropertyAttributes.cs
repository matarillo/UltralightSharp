using System;
using System.Runtime.InteropServices;

namespace UltralightInterop.JavaScriptCore
{
    [Flags]
    public enum JSPropertyAttributes
    {
        None = 0,
        ReadOnly = 1 << 1,
        DontEnum = 1 << 2,
        DontDelete = 1 << 3,
    }
}
