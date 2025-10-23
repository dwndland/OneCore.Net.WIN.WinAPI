// -----------------------------------------------------------------------------------------------------------------
// <copyright file="IDwmapi.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

namespace OneCore.Net.WinAPI;

public interface IDwmapi
{
    int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
}