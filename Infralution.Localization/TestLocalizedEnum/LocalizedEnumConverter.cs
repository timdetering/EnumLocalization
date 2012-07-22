#region File Header
//
// COPYRIGHT:   Copyright 2007 
//              Infralution
//
#endregion
using System;
using System.Collections.Generic;
using System.Text;
namespace TestLocalizedEnum
{
    /// <summary>
    /// Defines a type converter for enum types defined in this project
    /// </summary>
    class LocalizedEnumConverter : Infralution.Localization.ResourceEnumConverter
    {
        /// <summary>
        /// Create a new instance of the converter using translations from the given resource manager
        /// </summary>
        /// <param name="type"></param>
        public LocalizedEnumConverter(Type type)
            : base(type, Properties.Resources.ResourceManager)
        {
        }
    }
}
