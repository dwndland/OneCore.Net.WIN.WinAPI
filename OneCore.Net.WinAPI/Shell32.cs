// -----------------------------------------------------------------------------------------------------------------
// <copyright file="Shell32.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace OneCore.Net.WinAPI;

public static class Shell32
{
    [DllImport("shell32.dll")]
    public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
}