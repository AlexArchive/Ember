using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Ember.Extension
{
    public class ExtensionBootstrap
    {
        public IList<string> ExtensionNames { get; set; }
        public IDictionary<string, IImageUploader> ExtensionCache { get; private set; }

        public ExtensionBootstrap()
        {
            ExtensionCache = ResolveExtensions();
            ExtensionNames = ExtensionCache.Select(extension => extension.Key).ToList();
        }

        private IDictionary<string, IImageUploader> ResolveExtensions()
        {
            var assemblies = LoadAssemblies();

            var extensions = assemblies
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => type.GetInterfaces().Contains(typeof(IImageUploader)))
                .Where(type => type.GetCustomAttributes(typeof(ExtensionAttribute)).Any())
                .ToDictionary(
                    type => ((ExtensionAttribute)type.GetCustomAttributes().First()).ExtensionName,
                    type => (IImageUploader)Activator.CreateInstance(type));

            return extensions;
        }

        public IImageUploader ResolveExtension(string extensionName)
        {
            return ExtensionCache.SingleOrDefault(extension => extension.Key == extensionName).Value;
        }
        
        public bool ExtensionExists(string extensionName)
        {
            return ResolveExtension(extensionName) != null;
        }

        private static IEnumerable<Assembly> LoadAssemblies()
        {
            var extensionDirectory = Application.StartupPath;
            foreach (var assembly in Directory.GetFiles(extensionDirectory, "*.dll"))
            {
                yield return Assembly.LoadFile(assembly);
            }
            yield return Assembly.GetExecutingAssembly();
        }
    }
}