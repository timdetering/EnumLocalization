#region File Header
//
// COPYRIGHT:   Copyright 2007 
//              Infralution
//
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace TestLocalizedFlagEnum
{

    /// <summary>
    /// Sample enum illustrating used of a localized enum type converter
    /// </summary>
    [TypeConverter(typeof(LocalizedEnumConverter))]
    [Flags]
    public enum TextStyle : byte
    {
        None = 0x0,
        Bold = 0x1,
        Italic = 0x2,
        Underline = 0x4,
        All = 0xFF
    }

}
