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
namespace TestLocalizedEnum
{
    /// <summary>
    /// Sample enum illustrating used of a localized enum type converter
    /// </summary>
    [TypeConverter(typeof(LocalizedEnumConverter))]
    public enum SampleEnum
    {
        VerySmall,
        Small,
        Medium,
        Large,
        VeryLarge
    }

}
