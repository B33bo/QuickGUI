using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickGUI
{
    public partial class BooleanOpers : Form
    {
        public static Dictionary<string, string> nameToString = new()
        {
            { "less", "<" },
            { "greater", ">" },
            { "equal", "=" },
            { "notequal", "≠" },
            { "lessequal", "≤" },
            { "greaterequal", "≥" },
            { "approx", "≈" },
            { "notapprox", "≉" },
            { "isinfkey", "isInf("},
            { "isnankey", "isNaN("},
            { "truekey", "1"},
            { "falsekey", "-1"},
        };
        public BooleanOpers()
        {
            InitializeComponent();
        }

        private void AddBooleanType(object sender, EventArgs e)
        {
            Control senderAsControl = sender as Control;
            Calc.instance.AddKeyFromName("key_" + nameToString[senderAsControl.Name]);
            Close();
        }

        private void AddBooleanFunc(object sender, EventArgs e)
        {
            Control senderAsControl = sender as Control;
            Calc.instance.AddKeyFromName("key_" + senderAsControl.Text + "(");
            Close();
        }
    }
}
