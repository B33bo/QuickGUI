using System;
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
    public partial class AddFunction : Form
    {
        List<(string, string)> Functions = new();
        public AddFunction()
        {
            InitializeComponent();
            LoadEquations();
        }

        private void LoadEquations()
        {
            Functions = new();
            string[] file = Properties.Resources.HelpPage.Split('\n');
            bool isInFile = false;

            for (int i = 0; i < file.Length; i++)
            {
                file[i] = file[i].Trim().Replace("	", "");

                if (file[i] == "")
                    continue;

                if (isInFile)
                {
                    if (file[i] == "Conversions::")
                        break;
                    else if (file[i].StartsWith("rand(a,b)"))
                        Functions.Add(("", "non-trigonometry functions"));
                    else if (file[i][0] == '*')
                        continue;

                    string[] items = file[i].Split(')');
                    Functions.Add((items[0] + ")", items[1..].ToReadable(")")));
                    continue;
                }

                if (file[i] == "Functions::")
                    isInFile = true;
            }

            FunctionList.Items.Clear();

            for (int i = 0; i < Functions.Count; i++)
            {
                FunctionList.Items.Add(Functions[i].Item1);
            }
        }

        private void FunctionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExplanationLabel.Text = Functions[FunctionList.SelectedIndex].Item1 + ": " + Functions[FunctionList.SelectedIndex].Item2;
        }

        private void UseFunction(object sender, EventArgs e)
        {
            if (FunctionList.SelectedIndex < 0)
            {
                Close();
                return;
            }

            string targetFunction = Functions[FunctionList.SelectedIndex].Item1.Split("(")[0];
            Calc.instance.AddKeyFromName($"key_{targetFunction}(");
            Close();
        }

        private void AddFunc(object sender, EventArgs e)
        {
            string Equation = PromptManager.Show("Enter an equation. 1st arg = 'a', 2nd = 'b' etc", "Custom method");
        }
    }
}
