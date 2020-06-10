using System;
using System.Collections.Generic;
using System.Text;
using WebSysActMon.Models;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;


namespace WebSysActMon.Models
{
    class WindowsStatistics
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "GetWindowText", ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpWindowText, int nMaxCount);

        [DllImport("user32.dll", EntryPoint = "EnumDesktopWindows", ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool EnumDesktopWindows(IntPtr hDesktop, EnumDelegate lpEnumCallbackFunction, IntPtr lParam);

        // Define the callback delegate's type.
        delegate bool EnumDelegate(IntPtr hWnd, int lParam);

        static List<WindowInfo> Windows;

        // Return a list of the desktop windows' handles and titles.
        public static void GetDesktopWindows(out List<WindowInfo> windows)
        {
            Windows = new List<WindowInfo>();

            if (!EnumDesktopWindows(IntPtr.Zero, FilterCallback,
                IntPtr.Zero))
            {
                windows = null;
            }
            else
            {
                windows = Windows;
            }
        }

        // We use this function to filter windows.
        // This version selects visible windows that have titles.
        private static bool FilterCallback(IntPtr hWnd, int lParam)
        {
            StringBuilder sb_title = new StringBuilder(1024);
            _ = GetWindowText(hWnd, sb_title, sb_title.Capacity);
            string title = sb_title.ToString();

            // If the window is visible and has a title, save it.
            if (IsWindowVisible(hWnd) && !string.IsNullOrEmpty(title))
            {
                Windows.Add(new WindowInfo
                {
                    ID = hWnd.ToInt32(),
                    Title = title,
                    Date = DateTime.Today.ToString("yyyy-MM-dd")
                });
            }

            return true;
        }
    }
}

