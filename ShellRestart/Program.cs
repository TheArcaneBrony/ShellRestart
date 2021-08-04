using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ShellRestart
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            foreach (var process in Process.GetProcessesByName("explorer"))
            {
                process.Kill();
            }

            if (!File.Exists(".nopin"))
            {
                PinForm pf = new PinForm();
                Application.Run(pf);
            }
            //Process.Start("explorer");
        }
    }
}