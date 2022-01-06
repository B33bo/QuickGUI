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
    public partial class ThingsWindow : Form
    {
        public ThingsWindow()
        {
            InitializeComponent();
        }

        private void OpenTab(object sender, EventArgs e)
        {
            Control senderAsControl = sender as Control;
            Close();
            
        }
    }
}
