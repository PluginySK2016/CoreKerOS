using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreKerOS.Graphics;
using Cosmos.System.Graphics;

namespace CoreKerOS.System
{
    public static class Boot
    {
        public static void onBoot()
        {
            GUI.Wallpaper = new Bitmap(Resources.Files.CoreKerOSBackgroundRaw);
            GUI.Cursor = new Bitmap(Resources.Files.CoreKerOSCursorRaw);
            GUI.StartGUI();
        }
    }
}
