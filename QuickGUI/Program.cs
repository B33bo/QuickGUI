using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickGUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calc());
        }

        public static string ToReadable(this string[] s)
        {
            string value = "";
            for (int i = 0; i < s.Length; i++)
            {
                value += s[i];
            }
            return value;
        }

        public static string ToReadable(this string[] s, string seperator)
        {
            string value = "";
            for (int i = 0; i < s.Length; i++)
            {
                value += seperator + s[i];
            }
            return value.Length == 0 ? "" : value[seperator.Length..];
        }
    }
}
