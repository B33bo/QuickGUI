using System;
using System.Numerics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickMaffs;

namespace QuickGUI
{
    public partial class Prompt : Form
    {
        public Prompt()
        {
            InitializeComponent();

            if (PromptManager.DefaultValue != null)
                newVar.Text = PromptManager.DefaultValue;
        }

        private void Close(object sender, EventArgs e) => Close();
    }
}
