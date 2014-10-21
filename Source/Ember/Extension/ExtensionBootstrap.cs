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
        private readonly IDictionary<string, IImageUploader> extensionCache;

        public ExtensionBootstrap()
        {
            extensionCache = ResolveExtensions();
            ExtensionNames = extensionCache.Select(extension => extension.Key).ToList();
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
            return extensionCache.Single(extension => extension.Key == extensionName).Value;
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