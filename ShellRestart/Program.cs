using System.Diagnostics;

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
            //Process.Start("explorer");
        }
    }
}