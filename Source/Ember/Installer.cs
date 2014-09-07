using System;
using System.Reflection;
using Microsoft.Win32;

namespace Ember
{
    public class Installer
    {
        public const string Path = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        public static bool Installed
        {
            get
            {
                using (var key = Registry.CurrentUser.OpenSubKey(Path))
                {
                    return key.GetValue(AppDomain.CurrentDomain.FriendlyName) != null;
                }
            }
        }

        public static void Install()
        {
            if (Installed) return;

            using (var key = Registry.CurrentUser.OpenSubKey(Path, true))
            {
                key.SetValue(AppDomain.CurrentDomain.FriendlyName, Assembly.GetEntryAssembly().Location);
            }
        }

        public static void Uninstall()
        {
            if (!Installed) return;
                
            using (var key = Registry.CurrentUser.OpenSubKey(Path, true))
            {
                key.DeleteValue(AppDomain.CurrentDomain.FriendlyName);
            }
        }
    }
}