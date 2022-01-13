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
        static List<string> equations = new();
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
                    if (file[i][0] == '*')
                        continue;

                    string[] items = file[i].Split(')');
                    Functions.Add((items[0] + ")", items[1..].ToReadable(")")));
                    continue;
                }

                if (file[i] == "Functions::")
                    isInFile = true;
            }

            for (int i = 0; i < equations.Count; i++)
            {
                string funcName = equations[i].Split('=')[0];
                string funcData = equations[i].Split('=')[1..].ToReadable("=");
                Functions.Add((funcName, funcData));
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
            string userInput = PromptManager.Show("Enter an equation. 1st arg = 'a', 2nd = 'b' etc", "Custom method");
            string[] userInputSplitEquals = userInput.Split("=");

            //Format: f(x,y,z?302)=x+y+z

            string functionData = userInputSplitEquals[0];
            string equation = userInputSplitEquals[1..].ToReadable("=");
            string functionName = functionData.Split('(')[0];

            if (Function.functions.ContainsKey(functionName))
            {
                MessageBox.Show($"'{functionName}' is already a equation!", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            equations.Add(userInput);

            Function.functions.Add(functionData.Split('(')[0], new Function((args) => PerformFunction(userInput, args)));
            LoadEquations();
        }

        private static string PerformFunction(string functionData, string[] args)
        {
            //functionData looks like this: functionName(a, b, c)=a+b+c
            Equation eq;

            {
                string[] functionSplitEquals = functionData.Split('=');

                string functionCode = functionSplitEquals[1..].ToReadable("=");

                eq = new(functionCode);
                functionData = functionSplitEquals[0];
            }
            
            string[] functionVarNames = functionData.Split(',');

            string functionName = functionVarNames[0][..^3]; //"functionName(a" without the comma

            functionVarNames[0] = functionVarNames[0][^1].ToString(); //Turn it into a variable 

            //to store the variables before being altered by the program
            Dictionary<char, string> previousVariables = new();
            for (int i = 0; i < functionVarNames.Length; i++)
            {
                if (Variables.variables.ContainsKey(functionVarNames[i][0]))
                {
                    previousVariables.Add(functionVarNames[i][0], Variables.variables[functionVarNames[i][0]]);
                    Variables.variables[functionVarNames[i][0]] = args[i];
                }
                else
                {
                    Variables.variables.Add(functionVarNames[i][0], args[i]);
                }
            }

            string value = eq.Solve();

            //Undo everything above
            for (int i = 0; i < args.Length; i++)
            {
                if (previousVariables.ContainsKey(functionVarNames[i][0]))
                {
                    Variables.variables[args[i][0]] = previousVariables[functionVarNames[i][0]];
                }
                else
                    Variables.variables.Remove(args[i][0]);
            }

            return value;
        }
    }
}
