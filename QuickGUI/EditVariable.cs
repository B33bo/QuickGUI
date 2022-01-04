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
    public partial class EditVariable : Form
    {
        public EditVariable()
        {
            InitializeComponent();

            Text = "Add Variable";
            if (!AddVariable.IsAdd)
            {
                Text = "Edit Variable";
                char CurrentVar = AddVariable.CurrentSelected;
                newVar.Text = $"{CurrentVar}={Variables.variables[CurrentVar].ToMathematicalString()}";
            }
        }

        private void Cancel(object sender, EventArgs e) => Close();

        private void ChangeVariable(object sender, EventArgs e)
        {
            if (newVar.Text.Length <= 2 || !newVar.Text.Contains("="))
            {
                MessageBox.Show($"the string \"{newVar.Text}\". Type the variable in the format varName=value",
                    "Invalid format",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (newVar.Text[1] != '=')
            {
                MessageBox.Show($"Variable names can only be 1 character in length. You typed {newVar.Text.Split('=')[0]}",
                    "Invalid format",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Complex newValue = Complex.NaN;
            try
            {
                string ans = new Equation(newVar.Text[2..]).Solve();
                newValue = ParseComplex.Parse(ans);
            }
            catch (Exception)
            {
                MessageBox.Show($"the value \"{newVar.Text[2..]}\" is not a number or an equation",
                    "Invalid variable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (Variables.variables.ContainsKey(newVar.Text[0]))
                Variables.variables[newVar.Text[0]] = newValue;
            else
                Variables.variables.Add(newVar.Text[0], newValue);

            AddVariable.instance.RefreshVars();
            Close();
        }
    }
}
