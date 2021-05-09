using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataTypesHierarchy_VP_CourseWork
{
    public partial class ConverterLength : UserControl
    {

        public ConverterLength()
        {
            InitializeComponent();

            List<LengthValue> States2 = new List<LengthValue>();
            List<LengthValue> States1 = new List<LengthValue>();
            States1.Add(new LengthValue("нанометров", 0.000000001));
            States1.Add(new LengthValue("микронов", 0.000001));
            States1.Add(new LengthValue("миллиметров", 0.001));
            States1.Add(new LengthValue("сантиметров", 0.01));
            States1.Add(new LengthValue("метров", 1));
            States1.Add(new LengthValue("километров", 1000));
            States1.Add(new LengthValue("дюймов", 0.0254));
            States1.Add(new LengthValue("футов", 0.3048));
            States1.Add(new LengthValue("ярдов", 0.9144));
            States1.Add(new LengthValue("миль", 1609.344));
            States1.Add(new LengthValue("морских миль", 1852));
            States2.AddRange(States1.ToArray());

            comboBox_In.DataSource = States1;
            comboBox_In.DisplayMember = "Name";
            comboBox_In.ValueMember = "Length";
            comboBox_Out.DataSource = States2;
            comboBox_Out.DisplayMember = "Name";
            comboBox_Out.ValueMember = "Length";
            comboBox_In.SelectedIndexChanged += NumberIn_TextChanged;
            comboBox_Out.SelectedIndexChanged += NumberIn_TextChanged;
        }

        private class LengthValue
        {
            private string name;
            private double length;
            public LengthValue(string Name, double Length)
            {
                name = Name;
                length = Length;
            }
            public string Name
            {
                get
                {
                    return name;
                }
            }
            public double Length
            {
                get
                {
                    return length;
                }
            }
        }

        private void CalculateLen(TextBox textboxIn, TextBox textboxOut, ComboBox comboBoxIn, ComboBox comboBoxOut)
        {
            if (!double.TryParse(textboxIn.Text, out double number))
                return;

            double stepIn = (double)comboBoxIn.SelectedValue;
            double stepOut = (double)comboBoxOut.SelectedValue;
            number *= stepIn; // переводим в метры.
            number = 1 / stepOut * number;
            textboxOut.Text = number.ToString();
        }

        private void NumberIn_TextChanged(object sender, EventArgs e)
        {
            CalculateLen(NumberIn, NumberOut, comboBox_In, comboBox_Out);
        }
    }
}
