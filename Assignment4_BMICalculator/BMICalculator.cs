using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*-------------------------------------------------------------------------------------------------
 * Author: Anmoldeep Singh Gill
 * 
 * Student Number: 301044883
 * 
 * Create Date: 14 Jul, 2019
 * 
 * Description: This project initialise a BMI Calculator Form which calculates
 * the User's Body Mass Ratio (BMI) using their Height and weight in both metric
 * and imperial units.
 * 
 * Revision History: Final Version (With all functionality)
 * -------------------------------------------------------------------------------------------------
 */
namespace Assignment4_BMICalculator
{
    public partial class BMICalculator : Form
    {
        //PRIVATE DATA MEMBERS
        private TextBox _activeTextbox;

        // PUBLIC Properties
        public float MetricBMI { get; set; }
        public float ImperialBMI { get; set; }
        public string stringOutput { get; set; }

        public TextBox ActiveTextbox
        {
            get
            {
                return _activeTextbox;
            }

            set
            {
                // check if _activeTextbox is already pointing at a label
                if (_activeTextbox != null)
                {
                    _activeTextbox.BackColor = Color.White;
                }

                _activeTextbox = value;

                // check if _activeTextbox has not been set to null
                if (_activeTextbox != null)
                {
                    _activeTextbox.BackColor = Color.LightBlue;
                }

            }
        }
        public BMICalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Load Event for BMI Calculator Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// This is an Event handler For Calculate BMI click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            if (!(float.TryParse(WeightTextbox.Text, out float weight)))
            {
                weight = 0f;
            }
            if (!(float.TryParse(HeightTextbox.Text, out float height)))
            {
                height = 0f;
            }
            float BMI;
            if (ImperialRadioButton.Checked == true)
            {
                BMI = (weight * 703) / (height * height);
                double BMIdoub = Convert.ToDouble(BMI);
                double result = Math.Round(BMIdoub, 2);
                CalculatedBMITextBox.Text = result.ToString();
                CalculatedBMITextBox.BackColor = Color.White;
            }
            else if (MetricRadioButton.Checked == true)
            {
                BMI = weight / (height * height);
                double BMIdoub = Convert.ToDouble(BMI);
                double result = Math.Round(BMIdoub, 2);
                CalculatedBMITextBox.Text = result.ToString();
                CalculatedBMITextBox.BackColor = Color.White;
            }

            ShowBMITextResult();
        }

        /// <summary>
        /// This function shows the user's BMI numerical result as a text result according to BMI scale
        /// </summary>
        private void ShowBMITextResult()
        {
            float BMICalculated = float.Parse(CalculatedBMITextBox.Text);
            int BMICalculatedProgressBar = Convert.ToInt32(BMICalculated);

            //Checks if the BMIProgressBar valu is not over than 100
            if (BMICalculatedProgressBar >= 100)
            {
                BMICalculatedProgressBar = 100;
            }

            if (BMICalculated < 18.5)
            {
                BMITextResult.Text = "You are UnderWeight";
                BMITextResult.BackColor = Color.Yellow;
                BMITextResult.ForeColor = Color.Red;
                BMIResultProgressBar.Value = BMICalculatedProgressBar;
            }
            else if (BMICalculated >= 18.5 && BMICalculated <= 24.9)
            {
                BMITextResult.Text = "You are Normal";
                BMITextResult.BackColor = Color.Lime;
                BMITextResult.ForeColor = Color.White;
                BMIResultProgressBar.Value = BMICalculatedProgressBar;
            }
            else if (BMICalculated > 24.9 && BMICalculated <= 29.9)
            {
                BMITextResult.Text = "You are Overweight";
                BMITextResult.BackColor = Color.Red;
                BMITextResult.ForeColor = Color.Yellow;
                BMIResultProgressBar.Value = BMICalculatedProgressBar;
            }
            else if (BMICalculated > 30)
            {
                BMITextResult.Text = "You are Obese";
                BMITextResult.BackColor = Color.Crimson;
                BMITextResult.ForeColor = Color.White;
                BMIResultProgressBar.Value = BMICalculatedProgressBar;
            }
            else
            {
                BMITextResult.Text = "Please enter valid Height and Weight";
            }
        }

        /// <summary>
        /// This checks if the metric button is checked and changes the UnitLabels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "m";
            WeightUnitLabel.Text = "Kg";
        }

        /// <summary>
        /// This checks if the Imperial Button is checked and changes the UnitLabels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "in";
            WeightUnitLabel.Text = "Lb";
        }

        /// <summary>
        /// This is the shared Event Handler For all of the calculator buttons's Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButtons_Click(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numericValue = 0;
            int size = ((stringOutput.IndexOf('.') == -1) ? 3 : 5);

            bool numericResult = int.TryParse(tag, out numericValue);

            if (numericResult)
            {
                if (stringOutput == "0")
                {
                    stringOutput = tag;
                }
                else
                {
                    if (stringOutput.Length < size)
                    {
                        stringOutput += tag;
                    }
                }
                ActiveTextbox.Text = stringOutput;
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
                    case "allClear":
                        stringOutput = "0";
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

        /// <summary>
        /// This Function Sets the Default values for all the Controls
        /// </summary>
        private void SetDefaultvalues()
        {
            HeightTextbox.Text = "";
            WeightTextbox.Text = "";
            stringOutput = "0";
        }

        /// <summary>
        /// This method adds decimal value to the ActiveTextbox
        /// </summary>
        private void AddDecimal()
        {
            if (stringOutput.IndexOf('.') == -1)
            {
                if (stringOutput == "")
                {
                    stringOutput += "0";
                }
                stringOutput += ".";
            }
        }

        /// <summary>
        /// Clears the last character in the label
        /// </summary>
        private void BackButtonFunction()
        {
            var lastChar = stringOutput.Substring(stringOutput.Length - 1);

            //to remove Last item of the Output String
            stringOutput = stringOutput.Remove(stringOutput.Length - 1);

            //Checks if the Output String is already 0
            if (stringOutput.Length == 0)
            {
                stringOutput = "0";
            }

            ActiveTextbox.Text = stringOutput;
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
            BMIResultProgressBar.Value = 0;
        }

        /// <summary>
        /// This is the event handler for the HeightLabel click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveTextbox_Click(object sender, EventArgs e)
        {
            if (ActiveTextbox != null)
            {
                stringOutput = "0";
            }

            ActiveTextbox = sender as TextBox;
            ActiveTextbox.BackColor = Color.LightBlue;


            AnimationTimer.Enabled = true;

            NumericButtonsTableLayoutPanel.BringToFront();

            if (ActiveTextbox.Text != "0")
            {
                stringOutput = ActiveTextbox.Text;
            }
            if(ActiveTextbox.Text == "0")
            {
                stringOutput = ActiveTextbox.Text;
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
            NumericButtonsTableLayoutPanel.Location = new Point(currentLocation.X, currentLocation.Y - 20);

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
