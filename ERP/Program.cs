using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace MES
{
    static class Program
    {
        public static PrivateFontCollection regularFontCollection;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitFonts();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font(regularFontCollection.Families[0], 10f);
            Application.Run(new MainForm());
        }

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        static void InitFonts()
        {
            regularFontCollection = new PrivateFontCollection();

            byte[][] fontDataArray = new byte[2][];
            fontDataArray[0] = Properties.Resources.NanumBarunGothic;
            fontDataArray[1] = Properties.Resources.NanumBarunGothicBold;

            foreach (var fontData in fontDataArray)
            {
                int fontLength = fontData.Length;

                System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
                Marshal.Copy(fontData, 0, data, fontLength);

                // We HAVE to do this to register the font to the system (Weird .NET bug !)
                uint cFonts = 0;
                AddFontMemResourceEx(data, (uint)fontData.Length, IntPtr.Zero, ref cFonts);

                regularFontCollection.AddMemoryFont(data, fontLength);
            }
        }
    }
}
