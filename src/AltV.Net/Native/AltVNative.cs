using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: InternalsVisibleTo("AltV.Net.Mock")]
[assembly: InternalsVisibleTo("AltV.Net.Async")]

namespace AltV.Net.Native
{
    internal static partial class AltVNative
    {
        private const string _dllName = "csharp-module";
        private const CallingConvention _callingConvention = CallingConvention.Cdecl;

        //TODO: maybe these two aren't needed, remove on release when there stay unused
        [DllImport(_dllName, CallingConvention = _callingConvention)]
        internal static extern int FreeObject(IntPtr pointer);

        [DllImport(_dllName, CallingConvention = _callingConvention)]
        internal static extern int FreeArray(IntPtr array);
    }
}