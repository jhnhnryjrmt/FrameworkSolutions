using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FrameworkSolutions.ClassComponents
{
    public class clsSingleInstance
    {
        private const int SW_RESTORE = 9;

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        public static bool IsSingleInstance(bool ShowWarningMessage)
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length <= 1)
                return true;
            if (ShowWarningMessage)
                Console.WriteLine("Duplicate Instance.");
            return false;
        }
    }
}
