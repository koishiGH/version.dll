using System.Runtime.InteropServices;

namespace VersionDll;

public static class Program
{
    [UnmanagedCallersOnly(EntryPoint = "DllMain")]
    public static bool DllMain(nint hModule, uint dwReason, nint lpReserved)
    {
        return true;
    }
} 