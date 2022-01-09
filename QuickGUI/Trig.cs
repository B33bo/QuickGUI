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
    public partial class Trig : Form
    {
        public Trig()
        {
            InitializeComponent();
        }

        private void ClickFunc(object sender, EventArgs e)
        {
            var SenderAsConrol = sender as Control;
            Calc.instance.AddKeyFromName("key_" + SenderAsConrol.Text + "(");
            Close();
        }
    }
}
