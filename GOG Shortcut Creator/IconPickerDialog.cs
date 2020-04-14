using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GOG_Shortcut_Creator
{
    // Source: https://stackoverflow.com/a/55997245
    public static class IconPickerDialog
    {
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern int PickIconDlg(IntPtr hwndOwner, System.Text.StringBuilder lpstrFile, int nMaxFile, ref int lpdwIconIndex);

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern uint ExtractIconEx(string szFileName, int nIconIndex, IntPtr[] phiconLarge, IntPtr[] phiconSmall, uint nIcons);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

        private const int MAX_PATH = 0x00000104;

        public static string PickIcon(IntPtr handle)
        {
            // show the Pick Icon Dialog
            int index = 0;
            int retval;
            var iconfile = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\shell32.dll";
            var sb = new StringBuilder(iconfile, MAX_PATH);

            retval = PickIconDlg(handle, sb, sb.MaxCapacity, ref index);

            if (retval != 0)
            {
                return $"{sb.ToString()},{index}";
            }

            return null;
        }
    }
}
