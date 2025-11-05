// -----------------------------------------------------------------------------------------------------------------
// <copyright file="Kernel32Wrapper.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------



// ReSharper disable once CheckNamespace

namespace OneCore.Net.WIN.WinAPI;

public class Kernel32Wrapper : IKernel32
{
    public IntPtr LoadLibrary(string lpFileName)
    {
        return Kernel32.LoadLibrary(lpFileName);
    }

    public IntPtr GetModuleHandle(string moduleName)
    {
        return Kernel32.GetModuleHandle(moduleName);
    }
}