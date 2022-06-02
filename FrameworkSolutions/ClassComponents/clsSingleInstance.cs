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
    }
}
