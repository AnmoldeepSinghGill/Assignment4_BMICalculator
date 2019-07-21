using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_BMICalculator
{
    public partial class BMICalculator : Form
    {
        //PRIVATE DATA MEMBERS
        private Label m_activeLabel;

        // PUBLIC Properties
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public bool decimalExists { get; set; }
        public float MetricBMI { get; set; }
        public float ImperialBMI { get; set; }

        public Label ActiveLabel
        {
            get
            {
                return m_activeLabel;
            }

            set
            {
                // check if m_activeLabel is already pointing at a label
                if (m_activeLabel != null)
                {
                    m_activeLabel.BackColor = Color.White;
                }

                m_activeLabel = value;

                // check if m_activeLabel has not been set to null
                if (m_activeLabel != null)
                {
                    m_activeLabel.BackColor = Color.LightBlue;
                }

            }
        }
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            this.Size = new Size(320, 480);
            ClearNumericKeyboard();
            WeightLabel.Text = "0";
        }

        /// <summary>
        /// This is the shared Event Handler For all of the calculator buttons' Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButtons_Click(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numericValue = 0;

            bool numericResult = int.TryParse(tag, out numericValue);

            if (numericResult)
            {
                int maxSize = (decimalExists) ? 5 : 3;

                if (outputString == "0")
                {
                    outputString = tag;
                }
                else
                {
                    if (outputString.Length < maxSize)
                    {
                        outputString += tag;
                    }
                }

                HeightLabel.Text = outputString;
            }
            else
            {
                switch (tag)
                {
                    case "decimal":
                        addDecimalToResultLabel();
                        break;
                    case "done":
                        NumberButtonTableLayoutPanel.Visible = false;
                        break;
                    case "back":
                        BackFunction();
                        break;
                }
            }
        }

        private void ClearNumericKeyboard()
        {
            HeightLabel.Text = "0";
            outputString = "0";
            decimalExists = false;
            outputValue = 0.0f;
        }

        private void addDecimalToResultLabel()
        {
            if (!decimalExists)
            {
                outputString += ".";
                decimalExists = true;
            }
        }

        /// <summary>
        /// Clears the last character in the label
        /// </summary>
        private void BackFunction()
        {
            var lastChar = outputString.Substring(outputString.Length - 1);
            if (lastChar == ".")
            {
                decimalExists = false;
            }
            outputString = outputString.Remove(outputString.Length - 1);

            if (outputString.Length == 0)
            {
                outputString = "0";
            }

            HeightLabel.Text = outputString;
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            float weight = float.Parse(WeightLabel.Text);
            float height = float.Parse(HeightLabel.Text);
            float BMI;
            if(ImperialRadioButton.Checked == true)
            {
                BMI = (weight * 703) / (height * height);
                CalculatedBMILabel.Text = BMI.ToString();
            }
            else if(MetricRadioButton.Checked == true)
            {
                BMI = (weight * 10000) / (height * height);
                CalculatedBMILabel.Text = BMI.ToString();
            }     
        }

        /// <summary>
        /// This is the event handler for the HeightLabel click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void ActiveLabel_Click(object sender, EventArgs e)
        //{

        //    if (ActiveLabel != null)
        //    {
        //        ClearNumericKeyboard();
        //    }

        //    ActiveLabel = sender as Label;
        //    ActiveLabel.BackColor = Color.LightBlue;

        //    //AnimationTimer.Enabled = true;

        //    //NumberButtonTableLayoutPanel.Location = new Point(12, ActiveLabel.Location.Y + 55);
        //    NumberButtonTableLayoutPanel.BringToFront();

        //    if (ActiveLabel.Text != "0")
        //    {
        //        outputString = ActiveLabel.Text;
        //        HeightLabel.Text = ActiveLabel.Text;
        //    }

        //    NumberButtonTableLayoutPanel.Visible = true;
        //}
    }
}
