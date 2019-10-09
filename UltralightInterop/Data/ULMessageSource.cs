using System;
using System.Runtime.InteropServices;

namespace UltralightInterop.Data
{
    public enum ULMessageSource
    {
        XML = 0,
        JS,
        Network,
        ConsoleAPI,
        Storage,
        AppCache,
        Rendering,
        CSS,
        Security,
        ContentBlocker,
        Other,
    }
}
