using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IL2CPU.API.Attribs;

namespace CoreKerOS.Resources
{
    public static class Files
    {
        [ManifestResourceStream(ResourceName = "CoreKerOS.Resources.Wallpers.Wal1.bmp")] public static byte[] CoreKerOSBackgroundRaw;
        [ManifestResourceStream(ResourceName = "CoreKerOS.Resources.Cursors.Cursor1")] public static byte[] CoreKerOSCursorRaw;
    }
}
