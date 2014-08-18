using System;
using Ember.Forms;

namespace Ember
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            StartupController.RunOnce<MainForm>();
        }
    }
}
