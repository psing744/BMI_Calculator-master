﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class BmiCalculator : Form
    {
        public TextBox clickedLabel;
        public TextBox outputLabel;
        string outputString = "";
        public BmiCalculator()
        {
            InitializeComponent();
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
                    default:
                        break;
                }
            }
            clickedLabel.Text = outputString;
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
        /// event handler for load of form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BmiCalculator_Load(object sender, EventArgs e)
        {
            KeypadLayoutPanel.Visible = false;
            MetricButton.Checked = true;
        }
        /// <summary>
        /// event handler for click on height or weight label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_Click(object sender, EventArgs e)
        {
            clickedLabel = sender as TextBox;
            KeypadLayoutPanel.Visible = true;
            clickedLabel.Text = "";
            outputString = "";
        }
        /// <summary>
        /// event handler when metric radio button is checked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightInputBox.Text = "m";
            WeightInputBox.Text = "kg";
        }
        /// <summary>
        /// event handler when imperical radio button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImpericalButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightInputBox.Text = "in";
            WeightInputBox.Text = "lb";
        }
    }
}
