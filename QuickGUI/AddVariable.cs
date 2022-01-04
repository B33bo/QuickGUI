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
        public static bool IsAdd;

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
                VariableContainer.Items.Add($"{variables[i]} = {Variables.variables[variables[i]].ToMathematicalString()}");
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
            if (VariableContainer.SelectedIndex < 0)
                return;

            IsAdd = false;
            new EditVariable().Show();
        }

        private void RemoveVar(object sender, EventArgs e)
        {
            if (VariableContainer.SelectedIndex < 0)
                return;
            Variables.variables.Remove(variables[VariableContainer.SelectedIndex]);
            RefreshVars();
        }

        private void AddVar(object sender, EventArgs e)
        {
            IsAdd = true;
            new EditVariable().Show();
        }
    }
}
