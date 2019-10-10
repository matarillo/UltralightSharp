using System;
using System.Runtime.InteropServices;

namespace UltralightInterop.JavaScriptCore
{
    [Flags]
    public enum JSClassAttributes
    {
        None = 0,
        NoAutomaticPrototype = 1 << 1,
    }
}
