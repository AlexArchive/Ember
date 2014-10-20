using System.Collections.Generic;

namespace Ember.Extension
{
    public class ExtensionBootstrap
    {
        public List<string> ExtensionNames { get; set; }

        public ExtensionBootstrap()
        {
            ExtensionNames = new List<string> { "Imgur", "Dropbox" };
        }
    }
}