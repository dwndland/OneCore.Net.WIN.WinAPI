// -----------------------------------------------------------------------------------------------------------------
// <copyright file="Shell32Wrapper.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------



// ReSharper disable once CheckNamespace

namespace OneCore.Net.WIN.WinAPI;

public class Shell32Wrapper : IShell32
{
    public IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags)
    {
        return Shell32.SHGetFileInfo(pszPath, dwFileAttributes, ref psfi, cbSizeFileInfo, uFlags);
    }
}