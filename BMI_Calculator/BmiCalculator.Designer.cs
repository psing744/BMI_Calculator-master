namespace BMI_Calculator
{
    partial class BmiCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightInputBox = new System.Windows.Forms.TextBox();
            this.WeightInputBox = new System.Windows.Forms.TextBox();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.BMI_Label = new System.Windows.Forms.Label();
            this.BmiResultBox = new System.Windows.Forms.TextBox();
            this.BmiScaleBox = new System.Windows.Forms.TextBox();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.ImpericalButton = new System.Windows.Forms.RadioButton();
            this.ResetButton = new System.Windows.Forms.Button();
            this.KeypadLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.KeypadOneButton = new System.Windows.Forms.Button();
            this.KeypadTwoButton = new System.Windows.Forms.Button();
            this.KeypadThreeButton = new System.Windows.Forms.Button();
            this.KeypadFourButton = new System.Windows.Forms.Button();
            this.KeypadFiveButton = new System.Windows.Forms.Button();
            this.KeypadSixButton = new System.Windows.Forms.Button();
            this.KeypadNineButton = new System.Windows.Forms.Button();
            this.KeypadEightButton = new System.Windows.Forms.Button();
            this.KeypadSevenButton = new System.Windows.Forms.Button();
            this.KeypadZeroButton = new System.Windows.Forms.Button();
            this.KeypadDecimalButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.Animation = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.KeypadLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.HeightInputBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.WeightInputBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.HeadingLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CalculateButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BMI_Label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BmiResultBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.MetricButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ImpericalButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ResetButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BmiScaleBox, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 345);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 86);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(144, 43);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 129);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(144, 43);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "My Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightInputBox
            // 
            this.HeightInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightInputBox.BackColor = System.Drawing.Color.White;
            this.HeightInputBox.Location = new System.Drawing.Point(153, 89);
            this.HeightInputBox.Name = "HeightInputBox";
            this.HeightInputBox.ReadOnly = true;
            this.HeightInputBox.Size = new System.Drawing.Size(145, 38);
            this.HeightInputBox.TabIndex = 2;
            this.HeightInputBox.Tag = "height";
            this.HeightInputBox.Text = "m";
            this.HeightInputBox.Click += new System.EventHandler(this.Label_Click);
            // 
            // WeightInputBox
            // 
            this.WeightInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightInputBox.BackColor = System.Drawing.Color.White;
            this.WeightInputBox.Location = new System.Drawing.Point(153, 132);
            this.WeightInputBox.Name = "WeightInputBox";
            this.WeightInputBox.ReadOnly = true;
            this.WeightInputBox.Size = new System.Drawing.Size(145, 38);
            this.WeightInputBox.TabIndex = 2;
            this.WeightInputBox.Tag = "weight";
            this.WeightInputBox.Text = "kg";
            this.WeightInputBox.Click += new System.EventHandler(this.Label_Click);
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeadingLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.HeadingLabel, 2);
            this.HeadingLabel.Location = new System.Drawing.Point(3, 0);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(295, 43);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "BMI Calculator";
            this.HeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateButton.Location = new System.Drawing.Point(3, 175);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(144, 37);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate ";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // BMI_Label
            // 
            this.BMI_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMI_Label.AutoSize = true;
            this.BMI_Label.Location = new System.Drawing.Point(3, 215);
            this.BMI_Label.Name = "BMI_Label";
            this.BMI_Label.Size = new System.Drawing.Size(144, 43);
            this.BMI_Label.TabIndex = 1;
            this.BMI_Label.Text = "BMI :";
            this.BMI_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BmiResultBox
            // 
            this.BmiResultBox.Location = new System.Drawing.Point(153, 218);
            this.BmiResultBox.Name = "BmiResultBox";
            this.BmiResultBox.ReadOnly = true;
            this.BmiResultBox.Size = new System.Drawing.Size(100, 38);
            this.BmiResultBox.TabIndex = 4;
            // 
            // BmiScaleBox
            // 
            this.BmiScaleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.BmiScaleBox, 2);
            this.BmiScaleBox.Location = new System.Drawing.Point(3, 261);
            this.BmiScaleBox.Name = "BmiScaleBox";
            this.BmiScaleBox.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.BmiScaleBox, 2);
            this.BmiScaleBox.Size = new System.Drawing.Size(295, 38);
            this.BmiScaleBox.TabIndex = 5;
            this.BmiScaleBox.Text = "BMI Scale";
            this.BmiScaleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MetricButton
            // 
            this.MetricButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricButton.AutoSize = true;
            this.MetricButton.Checked = true;
            this.MetricButton.Location = new System.Drawing.Point(3, 46);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(144, 37);
            this.MetricButton.TabIndex = 6;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetricButton.UseVisualStyleBackColor = true;
            this.MetricButton.CheckedChanged += new System.EventHandler(this.MetricButton_CheckedChanged);
            // 
            // ImpericalButton
            // 
            this.ImpericalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImpericalButton.AutoSize = true;
            this.ImpericalButton.Location = new System.Drawing.Point(153, 46);
            this.ImpericalButton.Name = "ImpericalButton";
            this.ImpericalButton.Size = new System.Drawing.Size(145, 37);
            this.ImpericalButton.TabIndex = 7;
            this.ImpericalButton.TabStop = true;
            this.ImpericalButton.Text = "Imperial";
            this.ImpericalButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImpericalButton.UseVisualStyleBackColor = true;
            this.ImpericalButton.CheckedChanged += new System.EventHandler(this.ImpericalButton_CheckedChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(153, 175);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(145, 37);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // KeypadLayoutPanel
            // 
            this.KeypadLayoutPanel.ColumnCount = 3;
            this.KeypadLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.KeypadLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.KeypadLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.KeypadLayoutPanel.Controls.Add(this.KeypadOneButton, 0, 0);
            this.KeypadLayoutPanel.Controls.Add(this.KeypadTwoButton, 1, 0);
            this.KeypadLayoutPanel.Controls.Add(this.KeypadThreeButton, 2, 0);
            this.KeypadLayoutPanel.Controls.Add(this.KeypadFourButton, 0, 1);
            this.KeypadLayoutPanel.Controls.Add(this.KeypadFiveButton, 1, 1);
            this.KeypadLayoutPanel.Controls.Add(this.KeypadSixButton, 2, 1);
            this.KeypadLayoutPanel.Controls.Add(this.KeypadNineButton, 2, 2);
            this.KeypadLayoutPanel.Controls.Add(this.KeypadEightButton, 1, 2);
            this.KeypadLayoutPanel.Controls.Add(this.KeypadSevenButton, 0, 2);
            this.KeypadLayoutPanel.Controls.Add(this.KeypadZeroButton, 1, 3);
            this.KeypadLayoutPanel.Controls.Add(this.KeypadDecimalButton, 0, 3);
            this.KeypadLayoutPanel.Controls.Add(this.BackButton, 2, 3);
            this.KeypadLayoutPanel.Controls.Add(this.DoneButton, 0, 4);
            this.KeypadLayoutPanel.Location = new System.Drawing.Point(12, 363);
            this.KeypadLayoutPanel.Name = "KeypadLayoutPanel";
            this.KeypadLayoutPanel.RowCount = 5;
            this.KeypadLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.KeypadLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.KeypadLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.KeypadLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.KeypadLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.KeypadLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.KeypadLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.KeypadLayoutPanel.Size = new System.Drawing.Size(280, 242);
            this.KeypadLayoutPanel.TabIndex = 1;
            this.KeypadLayoutPanel.Tag = "decimal";
            // 
            // KeypadOneButton
            // 
            this.KeypadOneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeypadOneButton.Location = new System.Drawing.Point(3, 3);
            this.KeypadOneButton.Name = "KeypadOneButton";
            this.KeypadOneButton.Size = new System.Drawing.Size(87, 42);
            this.KeypadOneButton.TabIndex = 0;
            this.KeypadOneButton.Tag = "one";
            this.KeypadOneButton.Text = "1";
            this.KeypadOneButton.UseVisualStyleBackColor = true;
            this.KeypadOneButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // KeypadTwoButton
            // 
            this.KeypadTwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeypadTwoButton.Location = new System.Drawing.Point(96, 3);
            this.KeypadTwoButton.Name = "KeypadTwoButton";
            this.KeypadTwoButton.Size = new System.Drawing.Size(87, 42);
            this.KeypadTwoButton.TabIndex = 0;
            this.KeypadTwoButton.Tag = "two";
            this.KeypadTwoButton.Text = "2";
            this.KeypadTwoButton.UseVisualStyleBackColor = true;
            this.KeypadTwoButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // KeypadThreeButton
            // 
            this.KeypadThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeypadThreeButton.Location = new System.Drawing.Point(189, 3);
            this.KeypadThreeButton.Name = "KeypadThreeButton";
            this.KeypadThreeButton.Size = new System.Drawing.Size(88, 42);
            this.KeypadThreeButton.TabIndex = 0;
            this.KeypadThreeButton.Tag = "three";
            this.KeypadThreeButton.Text = "3";
            this.KeypadThreeButton.UseVisualStyleBackColor = true;
            this.KeypadThreeButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // KeypadFourButton
            // 
            this.KeypadFourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeypadFourButton.Location = new System.Drawing.Point(3, 51);
            this.KeypadFourButton.Name = "KeypadFourButton";
            this.KeypadFourButton.Size = new System.Drawing.Size(87, 42);
            this.KeypadFourButton.TabIndex = 0;
            this.KeypadFourButton.Tag = "four";
            this.KeypadFourButton.Text = "4";
            this.KeypadFourButton.UseVisualStyleBackColor = true;
            this.KeypadFourButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // KeypadFiveButton
            // 
            this.KeypadFiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeypadFiveButton.Location = new System.Drawing.Point(96, 51);
            this.KeypadFiveButton.Name = "KeypadFiveButton";
            this.KeypadFiveButton.Size = new System.Drawing.Size(87, 42);
            this.KeypadFiveButton.TabIndex = 0;
            this.KeypadFiveButton.Tag = "five";
            this.KeypadFiveButton.Text = "5";
            this.KeypadFiveButton.UseVisualStyleBackColor = true;
            this.KeypadFiveButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // KeypadSixButton
            // 
            this.KeypadSixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeypadSixButton.Location = new System.Drawing.Point(189, 51);
            this.KeypadSixButton.Name = "KeypadSixButton";
            this.KeypadSixButton.Size = new System.Drawing.Size(88, 42);
            this.KeypadSixButton.TabIndex = 0;
            this.KeypadSixButton.Tag = "six";
            this.KeypadSixButton.Text = "6";
            this.KeypadSixButton.UseVisualStyleBackColor = true;
            this.KeypadSixButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // KeypadNineButton
            // 
            this.KeypadNineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeypadNineButton.Location = new System.Drawing.Point(189, 99);
            this.KeypadNineButton.Name = "KeypadNineButton";
            this.KeypadNineButton.Size = new System.Drawing.Size(88, 42);
            this.KeypadNineButton.TabIndex = 0;
            this.KeypadNineButton.Tag = "nine";
            this.KeypadNineButton.Text = "9";
            this.KeypadNineButton.UseVisualStyleBackColor = true;
            this.KeypadNineButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // KeypadEightButton
            // 
            this.KeypadEightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeypadEightButton.Location = new System.Drawing.Point(96, 99);
            this.KeypadEightButton.Name = "KeypadEightButton";
            this.KeypadEightButton.Size = new System.Drawing.Size(87, 42);
            this.KeypadEightButton.TabIndex = 0;
            this.KeypadEightButton.Tag = "eight";
            this.KeypadEightButton.Text = "8";
            this.KeypadEightButton.UseVisualStyleBackColor = true;
            this.KeypadEightButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // KeypadSevenButton
            // 
            this.KeypadSevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeypadSevenButton.Location = new System.Drawing.Point(3, 99);
            this.KeypadSevenButton.Name = "KeypadSevenButton";
            this.KeypadSevenButton.Size = new System.Drawing.Size(87, 42);
            this.KeypadSevenButton.TabIndex = 0;
            this.KeypadSevenButton.Tag = "seven";
            this.KeypadSevenButton.Text = "7";
            this.KeypadSevenButton.UseVisualStyleBackColor = true;
            this.KeypadSevenButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // KeypadZeroButton
            // 
            this.KeypadZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeypadZeroButton.Location = new System.Drawing.Point(96, 147);
            this.KeypadZeroButton.Name = "KeypadZeroButton";
            this.KeypadZeroButton.Size = new System.Drawing.Size(87, 42);
            this.KeypadZeroButton.TabIndex = 0;
            this.KeypadZeroButton.Tag = "zero";
            this.KeypadZeroButton.Text = "0";
            this.KeypadZeroButton.UseVisualStyleBackColor = true;
            this.KeypadZeroButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // KeypadDecimalButton
            // 
            this.KeypadDecimalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeypadDecimalButton.Location = new System.Drawing.Point(3, 147);
            this.KeypadDecimalButton.Name = "KeypadDecimalButton";
            this.KeypadDecimalButton.Size = new System.Drawing.Size(87, 42);
            this.KeypadDecimalButton.TabIndex = 0;
            this.KeypadDecimalButton.Tag = "decimal";
            this.KeypadDecimalButton.Text = ".";
            this.KeypadDecimalButton.UseVisualStyleBackColor = true;
            this.KeypadDecimalButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Location = new System.Drawing.Point(189, 147);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(88, 42);
            this.BackButton.TabIndex = 1;
            this.BackButton.Tag = "back";
            this.BackButton.Text = "undo";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeypadLayoutPanel.SetColumnSpan(this.DoneButton, 3);
            this.DoneButton.Location = new System.Drawing.Point(3, 195);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(274, 44);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Tag = "back";
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // Animation
            // 
            this.Animation.Interval = 16;
            this.Animation.Tick += new System.EventHandler(this.Animation_Tick);
            // 
            // BmiCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.KeypadLayoutPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BmiCalculator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BmiCalculator_FormClosing);
            this.Load += new System.EventHandler(this.BmiCalculator_Load);
            this.Click += new System.EventHandler(this.BmiCalculator_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.KeypadLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightInputBox;
        private System.Windows.Forms.TextBox WeightInputBox;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label BMI_Label;
        private System.Windows.Forms.TextBox BmiResultBox;
        private System.Windows.Forms.TextBox BmiScaleBox;
        private System.Windows.Forms.TableLayoutPanel KeypadLayoutPanel;
        private System.Windows.Forms.Button KeypadOneButton;
        private System.Windows.Forms.Button KeypadTwoButton;
        private System.Windows.Forms.Button KeypadThreeButton;
        private System.Windows.Forms.Button KeypadFourButton;
        private System.Windows.Forms.Button KeypadFiveButton;
        private System.Windows.Forms.Button KeypadSixButton;
        private System.Windows.Forms.Button KeypadNineButton;
        private System.Windows.Forms.Button KeypadEightButton;
        private System.Windows.Forms.Button KeypadSevenButton;
        private System.Windows.Forms.Button KeypadZeroButton;
        private System.Windows.Forms.Button KeypadDecimalButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.RadioButton ImpericalButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Timer Animation;
    }
}

