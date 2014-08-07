using System;
using Screenshot.Forms;

namespace Screenshot
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
