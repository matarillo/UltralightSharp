using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace UltralightInterop.JavaScriptCore
{
    public sealed class JSContextGroupRef : SafeHandleZeroOrMinusOneIsInvalid
    {
        JSContextGroupRef() : base(true)
        {
        }

        protected override bool ReleaseHandle()
        {
            return true;
        }

        static class NativeMethods
        {
        }
    }
}
