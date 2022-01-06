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
    public partial class AddVariable : Form
    {
        public static List<char> variables = new();
        public static AddVariable instance;

        public static char CurrentSelected
        {
            get => variables[instance.VariableContainer.SelectedIndex];
        }
        public AddVariable()
        {
            Name = "Choose a variable";
            instance = this;
            InitializeComponent();

            RefreshVars();
        }

        public void RefreshVars()
        {
            variables = Variables.variables.Keys.OfType<char>().ToList();
            VariableContainer.Items.Clear();

            for (int i = 0; i < variables.Count; i++)
            {
                VariableContainer.Items.Add($"{variables[i]} = {Variables.variables[variables[i]]}");
            }
        }

        private void UseVariable(object sender, EventArgs e)
        {
            if (VariableContainer.SelectedIndex < 0)
            {
                Close();
                return;
            }

            char lastVariable = variables[VariableContainer.SelectedIndex];
            Calc.instance.AddKeyFromName($"key_{lastVariable}");
            Close();
        }

        private void EditVar(object sender, EventArgs e)
        {
            string editString = "x=y";

            if (VariableContainer.SelectedIndex > 0)
                editString = $"{CurrentSelected}={Variables.variables[CurrentSelected]}";

            string newString = PromptManager.Show("Edit a variable", editString);

            if (newString == "")
                return;

            string newValue = "";
            try
            {
                newValue = new Equation(newString[2..]).Solve();
            }
            catch (Exception)
            {
                MessageBox.Show($"'{newString[2..]}' is not an equation!", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Variables.variables.ContainsKey(newString[0]))
                Variables.variables[newString[0]] = newValue;
            else
                Variables.variables.Add(newString[0], newValue);

            RefreshVars();
        }

        private void RemoveVar(object sender, EventArgs e)
        {
            if (VariableContainer.SelectedIndex < 0)
                return;
            Variables.variables.Remove(variables[VariableContainer.SelectedIndex]);
            RefreshVars();
        }
    }
}
