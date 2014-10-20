using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Ember.Extension
{
    public class ExtensionBootstrap
    {
        public IList<string> ExtensionNames { get; set; }
        private readonly IDictionary<string, IImageUploader> extensionCache;
 
        public ExtensionBootstrap()
        {
            extensionCache = ResolveExtensions();
            ExtensionNames = extensionCache.Select(extension => extension.Key).ToList();
        }

        private IDictionary<string, IImageUploader> ResolveExtensions()
        {
            var assembly = Assembly.GetExecutingAssembly();

            var extensions = assembly
                .GetTypes()
                .Where(type => type.GetInterfaces().Contains(typeof (IImageUploader)))
                .Where(type => type.GetCustomAttributes(typeof (ExtensionAttribute)).Any())
                .ToDictionary(
                    type => ((ExtensionAttribute) type.GetCustomAttributes().First()).HostName,
                    type => (IImageUploader) Activator.CreateInstance(type));

            return extensions;
        }

        public IImageUploader ResolveExtension(string hostName)
        {
            return extensionCache.Single(extension => extension.Key == hostName).Value;
        }
    }
}