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
            SetDefaultvalues();
            CalculatedBMITextBox.Enabled = false;
            ActiveTextbox = null;
            ImperialRadioButton.Checked = true;
            BMITextResult.Multiline = true;
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
                        DoneButtonFunction();
                        break;
                    case "back":
                        BackButtonFunction();
                        break;
                    case "clear":
                        ActiveTextbox.Text = "0";
                        break;
                }
            }
        }

        /// <summary>
        /// This function ensures neccesary actions performed when done button is clicked.
        /// </summary>
        private void DoneButtonFunction()
        {
            NumericButtonsTableLayoutPanel.Visible = false;
            ActiveTextbox.BackColor = Color.White;
            ActiveTextbox = null;
        }

        private void SetDefaultvalues()
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

            ShowBMITextResult();
        }

        /// <summary>
        /// This is an click event for Reset Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            WeightTextbox.Text = "";
            HeightTextbox.Text = "";
            MetricRadioButton.Checked = false;
            ImperialRadioButton.Checked = true;
            CalculatedBMITextBox.Text = "";
            BMITextResult.Text = "";
            BMITextResult.BackColor = Color.White;
        }

        /// <summary>
        /// This checks if the metric button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetreLabel.Text = "m";
            KilogramLabel.Text = "Kg";
        }

        /// <summary>
        /// This checks if the Imperial Button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetreLabel.Text = "in";
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


            AnimationTimer.Enabled = true;

            NumericButtonsTableLayoutPanel.BringToFront();

            if (ActiveTextbox.Text != "0")
            {
                outputString = ActiveTextbox.Text;
            }

            NumericButtonsTableLayoutPanel.Visible = true;
            //NumericButtonsTableLayoutPanel.Location = new Point(4, ActiveTextbox.Location.Y + 55);
        }

        /// <summary>
        /// This is an event handler for Tick enet of AnimationTimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            var currentLocation = NumericButtonsTableLayoutPanel.Location;
            NumericButtonsTableLayoutPanel.Location = new Point(currentLocation.X, currentLocation.Y - 18);

            if (NumericButtonsTableLayoutPanel.Location.Y <= ActiveTextbox.Location.Y + 55)
            {
                AnimationTimer.Enabled = false;
                if (NumericButtonsTableLayoutPanel.Location.Y < ActiveTextbox.Location.Y + 55)
                {
                    NumericButtonsTableLayoutPanel.Location = new Point(currentLocation.X, ActiveTextbox.Location.Y + 55);
                }
            }

        }

        /// <summary>
        /// This function shows the user's BMI numerical result as a text result according to BMI scale
        /// </summary>
        private void ShowBMITextResult()
        {
            float BMICalculated = float.Parse(CalculatedBMITextBox.Text);
            if (BMICalculated < 18.5)
            {
                BMITextResult.Text = "UnderWeight";
                BMITextResult.BackColor = Color.Yellow;
                BMITextResult.ForeColor = Color.Red;
            }
            else if (BMICalculated >= 18.5 && BMICalculated <= 24.9)
            {
                BMITextResult.Text = "Normal";
                BMITextResult.BackColor = Color.Lime;
                BMITextResult.ForeColor = Color.White;
            }
            else if (BMICalculated > 24.9 && BMICalculated <= 29.9)
            {
                BMITextResult.Text = "Overweight";
                BMITextResult.BackColor = Color.Red;
                BMITextResult.ForeColor = Color.Yellow;
            }
            else if (BMICalculated > 30)
            {
                BMITextResult.Text = "Obese";
                BMITextResult.BackColor = Color.Crimson;
                BMITextResult.ForeColor = Color.White;
            }
            else
            {
                BMITextResult.Text = "Please enter valid Height and Weight";
            }
        }

        /// <summary>
        /// This is a click event for the BMICalculator Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_Click(object sender, EventArgs e)
        {
            NumericButtonsTableLayoutPanel.Visible = false;
            ActiveTextbox = null;
        }

        /// <summary>
        /// This is closing event for closing the application when BMI form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
