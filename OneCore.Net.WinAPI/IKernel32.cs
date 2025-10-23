// -----------------------------------------------------------------------------------------------------------------
// <copyright file="IKernel32.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

namespace OneCore.Net.WinAPI;

public interface IKernel32
{
    IntPtr LoadLibrary(string lpFileName);

    IntPtr GetModuleHandle(string moduleName);
}