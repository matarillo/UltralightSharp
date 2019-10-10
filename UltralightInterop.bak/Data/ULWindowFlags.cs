using System;
using System.Runtime.InteropServices;

namespace UltralightInterop.Data
{
    [Flags]
    public enum ULWindowFlags
    {
        Borderless = 1 << 0,
        Titled = 1 << 1,
        Resizable = 1 << 2,
        Maximizable = 1 << 3,
    }
}
