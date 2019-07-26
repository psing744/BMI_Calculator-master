using System;
using System.Drawing;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class BmiCalculator : Form
    {
        public TextBox clickedLabel;
        float height, weight, bmi;
        bool imperial = false, metric = false; 
        string outputString = "";
        public BmiCalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for load of form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BmiCalculator_Load(object sender, EventArgs e)
        {
            BmiScaleBox.Multiline = true;
            MetricButton.Checked = true;
            metric = true;
            KeypadLayoutPanel.Visible = false;
            this.Size = new Size(320, 480);
        }

        /// <summary>
        /// event handler when metric radio button is checked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            HeightInputBox.Text = "m";
            WeightInputBox.Text = "kg";
            metric = true;
            imperial = false;
        }

        /// <summary>
        /// event handler when imperical radio button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImpericalButton_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            HeightInputBox.Text = "in";
            WeightInputBox.Text = "lb";
            imperial = true;
            metric = false;
        }
        /// <summary>
        /// event handler for click on height or weight label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_Click(object sender, EventArgs e)
        {
            clickedLabel = sender as TextBox;
            Animation.Enabled = true; //animation of keypad is enabled when textbox is clicked
            KeypadLayoutPanel.Visible = true;
            clickedLabel.Text = "";
            outputString = "";
        }
        /// <summary>
        /// Event handler for click event of keypad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            Button clicked_button = sender as Button;
            int numericValue;
            bool numericResult = int.TryParse(clicked_button.Text,out numericValue);
            if (numericResult)
            {
                if (outputString == "0")
                {
                    outputString = clicked_button.Text;
                }
                else
                {
                    outputString += numericValue;
                }            
            }
            else
            {
                switch (clicked_button.Tag)
                {
                    case "decimal":
                        AddDecimal();
                        break;
                    case "back":
                        if (outputString.Length == 0)
                        {
                            outputString = "";
                        }
                        else
                        {
                            outputString = outputString.Remove(outputString.Length - 1);
                        }
                        break;
                    case "done":
                        KeypadLayoutPanel.Visible = false;
                        break;
                    default:
                        break;
                }
            }
            clickedLabel.Text = outputString;

            //assigns height and weight output to appropriate labels
            if ((string)clickedLabel.Tag == "height")
            {
                bool heightValidation = float.TryParse(clickedLabel.Text, out height);
            }
            else if((string)clickedLabel.Tag == "weight")
            {
                bool weightValidation = float.TryParse(clickedLabel.Text, out weight);
            }

            //formula for bmi calculation. 
            //takes bool value according to imperical and metric radio button
            if (metric)
            {
                bmi = weight / (height * height);
            }
            if (imperial)
            {
                bmi = weight * 703 / (height * height);
            }
        }
        private void AddDecimal()
        {
            if (outputString.IndexOf('.') == -1)
            {
                if (outputString == "")
                {
                    outputString += "0";
                }
                outputString += ".";
            }
        }
        
        /// <summary>
        /// event handler for click on reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            clear();
            outputString = "";
            if (metric)
            {
                HeightInputBox.Text = "m";
                WeightInputBox.Text = "kg";
            }
            else
            {
                HeightInputBox.Text = "in";
                WeightInputBox.Text = "lb";
            }
        }

        private void clear()
        {
            BmiScaleBox.Text = "BMI Scale";
            BmiResultBox.Text = "";
            KeypadLayoutPanel.Visible = false;
        }
        /// <summary>
        /// event handler for form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BmiCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// event handler for click on calculate bmi button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            BmiResultBox.Text = "" + Math.Round(bmi, 2);

            //output for bmi scale box
            if (bmi < 18.5)
            {
                BmiScaleBox.Text = "Underweight";
            }
            else if(bmi>=18.5 && bmi <= 24.9)
            {
                BmiScaleBox.Text = "Normal";
            }
            else if(bmi>=25 && bmi <= 29.9)
            {
                BmiScaleBox.Text = "Overweight";
            }
            else if (bmi >= 30)
            {
                BmiScaleBox.Text = "Obese";
            }
        }

        
        /// <summary>
        /// animation for keypad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Animation_Tick(object sender, EventArgs e)
        {
            var currentLocation = KeypadLayoutPanel.Location;
            KeypadLayoutPanel.Location = new Point(currentLocation.X, currentLocation.Y - 20);
            if (KeypadLayoutPanel.Location.Y <= WeightLabel.Location.Y + 25)
            {
                Animation.Enabled = false;
                if (KeypadLayoutPanel.Location.Y < WeightLabel.Location.Y + 25)
                {
                    KeypadLayoutPanel.Location = new Point(currentLocation.X, currentLocation.Y + 25);
                }
            }
        }
    }
}
