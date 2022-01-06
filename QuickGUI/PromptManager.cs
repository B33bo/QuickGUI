using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickGUI
{
    public static class PromptManager
    {
#nullable enable
        public static string? DefaultValue;
#nullable disable
        public static string Show(string caption)
        {
            Prompt p = new();
            p.Name = caption;
            DefaultValue = null;
            return p.ShowDialog() == DialogResult.OK ? p.newVar.Text : "";
        }

        public static string Show(string caption, string defaultValue)
        {
            DefaultValue = defaultValue;
            Prompt p = new();
            p.Text = caption;
            return p.ShowDialog() == DialogResult.OK ? p.newVar.Text : "";
        }
    }
}
