using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickMaffs;

namespace QuickGUI
{
    public partial class Calc : Form
    {
        public string EquationString = "";
        static bool WasAnswered = false;

        public static Calc instance;

        static Dictionary<string, string> specialChars = new()
        {
            { "dp", "." },
            { "plus", "+" },
            { "minus", "-" },
            { "times", "*" },
            { "timesalt", "×" },
            { "divide", "/" },
            { "dividealt", "÷" },
            { "percent", "%" },
            { "root", "√" },
            { "power", "^" },
            { "factorial", "!" },
            { "degrees", "°" },
            { "openbrack", "(" },
            { "closebrack", ")" },
            { "speech", "\"" },
        };

        public Calc()
        {
            InitializeComponent();
            EquationString = equationText.Text;
            instance = this;

            /*try
            {
                PrivateFontCollection font = new();
                font.AddFontFile("PressStart.ttf");

                foreach (Control c in Controls)
                {
                    c.Font = new Font(font.Families[0], c.Font.Size);
                }
            }
            catch (Exception){} //Uses default font*/
        }

        private void CalcKeyPress(object sender, EventArgs e)
        {
            Control senderAsControl = sender as Control;

            AddKeyFromName(senderAsControl.Name);
        }

        public void AddKeyFromName(string name)
        {
            if (!name.StartsWith("key_"))
                return;

            switch (name)
            {
                default:
                    string item = name[4..];

                    if (specialChars.ContainsKey(item))
                        item = specialChars[item];

                    EquationString += item;
                    break;
                case "key_clear":
                    EquationString = "";
                    break;
                case "key_ans":
                    WasAnswered = true;

                    try { equationText.Text += "=" + new Equation(EquationString).Solve(); }
                    catch (Exception) { equationText.Text += "=" + "Error"; }

                    WasAnswered = false;
                    return;
                case "key_backspace":
                    if (EquationString.Length == 0)
                        break;
                    EquationString = EquationString[..^1];
                    break;
            }
            WasAnswered = false;
            equationText.Text = EquationString;
        }

        private void UpdateEquationString(object sender, EventArgs e)
        {
            if (WasAnswered)
                return;

            EquationString = equationText.Text;
        }

        private void OpenWindow(object sender, EventArgs e)
        {
            Control senderAsControl = sender as Control;

            if (senderAsControl.Name == "var")
                new AddVariable().Show();
        }
    }
}
