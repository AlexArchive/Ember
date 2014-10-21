using System;

namespace Ember.Extension
{
    /// <summary>
    /// Attribute indicating that the type is an extension entry-point.
    /// </summary>
    public class ExtensionAttribute : Attribute
    {   
        /// <summary>
        /// The name of the extension that will be conveyed to the user.
        /// </summary>
        public string ExtensionName { get; set; }
    }
}