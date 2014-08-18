using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Ember
{
    public static class StartupController
    {
        private static Mutex _mutex;

        public static void RunOnce<TForm>() where TForm : Form
        {
            _mutex = new Mutex(false, GenerateMutexName());

            if (MutexHandleIsObtainable())
            {
                Run<TForm>();
                return;
            }

            Environment.Exit(1);
        }

        public static void Run<TForm>() where TForm : Form
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Activator.CreateInstance<TForm>());
        }

        private static bool MutexHandleIsObtainable()
        {
            try
            {
                return _mutex.WaitOne(TimeSpan.Zero, false);
            }
            catch (AbandonedMutexException)
            {
                return true;
            }
        }

        private static string GenerateMutexName()
        {
            return string.Format("Global\\{{{0}}}", ResolveAssemblyGuid());
        }

        private static string ResolveAssemblyGuid()
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var assemblyAttributes = assembly.GetCustomAttributes(typeof(GuidAttribute), false);
                var guidAttribute = (GuidAttribute)assemblyAttributes.GetValue(0);
                return guidAttribute.Value;
            }
            catch
            {
                throw new InvalidOperationException(
                    "Ensure there is a Guid attribute defined for this assembly.");
            }
        }
    }
}