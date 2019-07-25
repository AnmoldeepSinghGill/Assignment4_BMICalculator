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
        private TextBox m_activeTextbox;

        // PUBLIC Properties
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public bool decimalExists { get; set; }
        public float MetricBMI { get; set; }
        public float ImperialBMI { get; set; }

        public TextBox ActiveTextbox
        {
            get
            {
                return m_activeTextbox;
            }

            set
            {
                // check if m_activeLabel is already pointing at a label
                if (m_activeTextbox != null)
                {
                    m_activeTextbox.BackColor = Color.White;
                }

                m_activeTextbox = value;

                // check if m_activeLabel has not been set to null
                if (m_activeTextbox != null)
                {
                    m_activeTextbox.BackColor = Color.LightBlue;
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
            CalculatedBMITextBox.Enabled = false;
            ActiveTextbox = null;
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

                ActiveTextbox.Text = outputString;
            }
            else
            {
                switch (tag)
                {
                    case "decimal":
                        AddDecimal();
                        break;
                    case "done":
                        NumericButtonsTableLayoutPanel.Visible = false;
                        break;
                    case "back":
                        BackButtonFunction();
                        break;
                }
            }
        }

        private void ClearNumericKeyboard()
        {
            HeightTextbox.Text = "";
            WeightTextbox.Text = "";
            outputString = "0";
            decimalExists = false;
            outputValue = 0.0f;
        }

        private void AddDecimal()
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
        private void BackButtonFunction()
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

            ActiveTextbox.Text = outputString;
        }

        /// <summary>
        /// This is an Event handler For Calculate BMI click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            if(!(float.TryParse(WeightTextbox.Text, out float weight)))
            {
                weight = 0f;
            }
            if (!(float.TryParse(HeightTextbox.Text, out float height)))
            {
                height = 0f;
            }
            float BMI;
            if(ImperialRadioButton.Checked == true)
            {
                BMI = (weight * 703) / (height * height);
                CalculatedBMITextBox.Text = BMI.ToString();
                CalculatedBMITextBox.BackColor = Color.White;
            }
            else if(MetricRadioButton.Checked == true)
            {
                BMI = weight / (height * height);
                CalculatedBMITextBox.Text = BMI.ToString();
                CalculatedBMITextBox.BackColor = Color.White;
            }

            ShowBMIResult();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            WeightTextbox.Text = "";
            HeightTextbox.Text = "";
            MetricRadioButton.Checked = false;
            ImperialRadioButton.Checked = true;
            CalculatedBMITextBox.Text = "";
            BMITextResult.Text = "";
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetreLabel.Text = "m";
            KilogramLabel.Text = "Kg";
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetreLabel.Text = "In";
            KilogramLabel.Text = "Lb";
        }
        /// <summary>
        /// This is the event handler for the HeightLabel click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveTextbox_Click(object sender, EventArgs e)
        {

            ActiveTextbox = sender as TextBox;
            ActiveTextbox.BackColor = Color.LightBlue;


            //AnimationTimer.Enabled = true;

            NumericButtonsTableLayoutPanel.BringToFront();

            if (ActiveTextbox.Text != "0")
            {
                outputString = ActiveTextbox.Text;
            }

            NumericButtonsTableLayoutPanel.Visible = true;
            NumericButtonsTableLayoutPanel.Location = new Point(4, ActiveTextbox.Location.Y + 55);
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            var Location = NumericButtonsTableLayoutPanel.Location;
            NumericButtonsTableLayoutPanel.Location = new Point(Location.X, Location.Y - 20);

            if (NumericButtonsTableLayoutPanel.Location.Y <= ActiveTextbox.Location.Y + 55)
            {
                AnimationTimer.Enabled = false;
                if (NumericButtonsTableLayoutPanel.Location.Y <= ActiveTextbox.Location.Y + 55)
                {
                    NumericButtonsTableLayoutPanel.Location = new Point(Location.X, Location.Y + 55);
                }

            }

        }

        private void ShowBMIResult()
        {
            float BMICalculated = float.Parse(CalculatedBMITextBox.Text);
            if (BMICalculated < 18.5)
            {
                BMITextResult.Text = "UnderWeight";
            }
            else if (BMICalculated >= 18.5 && BMICalculated <= 24.9)
            {
                BMITextResult.Text = "Normal";
            }
            else if (BMICalculated >= 25 && BMICalculated <= 29.9)
            {
                BMITextResult.Text = "Overweight";
            }
            else if (BMICalculated > 30)
            {
                BMITextResult.Text = "Obese";
            }
            else
            {
                BMITextResult.Text = "Please enter valid Height and Weight";
            }
        }
    }
}
