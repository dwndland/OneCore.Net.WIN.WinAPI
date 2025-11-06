// -----------------------------------------------------------------------------------------------------------------
// <copyright file="POINT.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace OneCore.Net.WIN.WinAPI;

[StructLayout(LayoutKind.Sequential)]
public struct POINT
{
    public int X;
    public int Y;
}