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
using QuickMaffs.Convert;

namespace QuickGUI
{
    public partial class Conversions : Form
    {
        ConversionType type;
        Dictionary<string, string> units;

        public Conversions()
        {
            InitializeComponent();
            type = (ConversionType)ConversionTypeBox.SelectedIndex;
        }

        private Dictionary<string, string> GetUnits()
        {
            return type switch
            {
                ConversionType.Angle => Angle.Units,
                ConversionType.Distance => Distance.Units,
                ConversionType.Energy => Energy.Units,
                ConversionType.MetricUnits => MetricUnits(Metric.Units),
                ConversionType.Number => new(),
                ConversionType.DataStorage => MetricUnits(Metric.Units),
                ConversionType.Temperature => Temperature.Units,
                ConversionType.Time => Time.Units,
                _ => null,
            };
        }

        private static Dictionary<string, string> MetricUnits(List<string> list)
        {
            Dictionary<string, string> dict = new();
            for (int i = 0; i < list.Count; i++)
            {
                string trueMetric = list[i].Split(' ')[0];
                if (trueMetric == "")
                    trueMetric = "none";
                dict.Add(list[i], trueMetric);
            }
            return dict;
        }

        enum ConversionType
        {
            Angle,
            Distance,
            Energy,
            MetricUnits,
            Number,
            DataStorage,
            Temperature,
            Time
        }

        private void ReloadType(object sender, EventArgs e)
        {
            type = (ConversionType)ConversionTypeBox.SelectedIndex;
            units = GetUnits();
            originBox.Items.Clear();
            destinationBox.Items.Clear();

            string[] unitText = units.Keys.ToArray();

            originBox.Items.AddRange(unitText);
            destinationBox.Items.AddRange(unitText);
        }

        private string Answer()
        {
            if (originBox.SelectedIndex == -1)
                originBox.SelectedIndex = 0;

            if (destinationBox.SelectedIndex == -1)
                destinationBox.SelectedIndex = 0;

            string input = inputBox.Text;
            Complex inputComplex = 0;

            if (input.StartsWith("eq:"))
            {
                try
                {
                    input = new Equation(input[3..]).Solve();
                    inputComplex = ComplexHelper.Parse(input);
                }
                catch{}
            }
            else
            {
                if (input != "")
                {
                    if (!ComplexHelper.TryParse(input, out inputComplex))
                        inputComplex = 0;
                }
            }
            string fromUnits = units[(string)originBox.Items[originBox.SelectedIndex]];
            string toUnits = units[(string)destinationBox.Items[destinationBox.SelectedIndex]];

            return type switch
            {
                ConversionType.Angle => Angle.Convert(inputComplex, fromUnits, toUnits),
                ConversionType.Distance => Distance.Convert(inputComplex, fromUnits, toUnits),
                ConversionType.Energy => Energy.Convert(inputComplex, fromUnits, toUnits),
                ConversionType.MetricUnits => Metric.Convert(inputComplex, fromUnits, toUnits),
                ConversionType.Number => NumberBaseConversions.Convert(input, fromUnits, toUnits),
                ConversionType.DataStorage => Storage.Convert(inputComplex, fromUnits, toUnits),
                ConversionType.Temperature => Temperature.Convert(inputComplex, fromUnits, toUnits),
                ConversionType.Time => Time.Convert(inputComplex, fromUnits, toUnits),
                _ => "0",
            };
        }

        private void Recalc(object sender, EventArgs e)
        {
            answerText.Text = Answer();
        }
    }
}
