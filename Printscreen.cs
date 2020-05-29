using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saveSlides
{
    class Printscreen
    {
        static readonly string file = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private Printscreen()
        {
        }

        public static void Save(string imageName)
        {
          
                    Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                       Screen.PrimaryScreen.Bounds.Height);
                    Graphics graphics = Graphics.FromImage(bitmap as Image);
                    graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);

                    if (!File.Exists(file + "\\Sesiune")) 
                    {
                         DirectoryInfo dir = Directory.CreateDirectory(file+"\\Sesiune");
                    }
                     bitmap.Save(file+"\\Sesiune\\" + imageName + ".jpg", ImageFormat.Jpeg);

        }
    }
}
