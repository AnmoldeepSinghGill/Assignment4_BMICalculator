namespace Assignment4_BMICalculator
{
    partial class BMICalculator
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
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightTextbox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextbox = new System.Windows.Forms.TextBox();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.KilogramLabel = new System.Windows.Forms.Label();
            this.MetreLabel = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CalculatedBMI = new System.Windows.Forms.Label();
            this.CalculatedBMITextBox = new System.Windows.Forms.TextBox();
            this.NumericButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.BMITextResult = new System.Windows.Forms.TextBox();
            this.MainTableLayoutPanel.SuspendLayout();
            this.NumericButtonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ImperialRadioButton.Location = new System.Drawing.Point(2, 2);
            this.ImperialRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(147, 57);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTableLayoutPanel.SetColumnSpan(this.MetricRadioButton, 2);
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MetricRadioButton.Location = new System.Drawing.Point(154, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(146, 55);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.HeightLabel.Location = new System.Drawing.Point(3, 61);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(145, 61);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "My Height:";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightTextbox
            // 
            this.HeightTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.HeightTextbox.Location = new System.Drawing.Point(154, 72);
            this.HeightTextbox.Name = "HeightTextbox";
            this.HeightTextbox.ReadOnly = true;
            this.HeightTextbox.Size = new System.Drawing.Size(84, 38);
            this.HeightTextbox.TabIndex = 3;
            this.HeightTextbox.Text = "0";
            this.HeightTextbox.Click += new System.EventHandler(this.ActiveTextbox_Click);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.WeightLabel.Location = new System.Drawing.Point(3, 122);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(145, 61);
            this.WeightLabel.TabIndex = 4;
            this.WeightLabel.Text = "MyWeight:";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightTextbox
            // 
            this.WeightTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.WeightTextbox.Location = new System.Drawing.Point(154, 133);
            this.WeightTextbox.Name = "WeightTextbox";
            this.WeightTextbox.Size = new System.Drawing.Size(84, 38);
            this.WeightTextbox.TabIndex = 5;
            this.WeightTextbox.Text = "0";
            this.WeightTextbox.Click += new System.EventHandler(this.ActiveTextbox_Click);
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 3;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayoutPanel.Controls.Add(this.BMITextResult, 0, 5);
            this.MainTableLayoutPanel.Controls.Add(this.KilogramLabel, 2, 2);
            this.MainTableLayoutPanel.Controls.Add(this.MetreLabel, 2, 1);
            this.MainTableLayoutPanel.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.WeightTextbox, 1, 2);
            this.MainTableLayoutPanel.Controls.Add(this.MetricRadioButton, 1, 0);
            this.MainTableLayoutPanel.Controls.Add(this.HeightTextbox, 1, 1);
            this.MainTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 2);
            this.MainTableLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 3);
            this.MainTableLayoutPanel.Controls.Add(this.ResetButton, 1, 3);
            this.MainTableLayoutPanel.Controls.Add(this.CalculatedBMI, 0, 4);
            this.MainTableLayoutPanel.Controls.Add(this.CalculatedBMITextBox, 1, 4);
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(1, 12);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 6;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(303, 369);
            this.MainTableLayoutPanel.TabIndex = 6;
            // 
            // KilogramLabel
            // 
            this.KilogramLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KilogramLabel.AutoSize = true;
            this.KilogramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.KilogramLabel.Location = new System.Drawing.Point(244, 122);
            this.KilogramLabel.Name = "KilogramLabel";
            this.KilogramLabel.Size = new System.Drawing.Size(56, 61);
            this.KilogramLabel.TabIndex = 10;
            this.KilogramLabel.Text = "Kg";
            this.KilogramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MetreLabel
            // 
            this.MetreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetreLabel.AutoSize = true;
            this.MetreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MetreLabel.Location = new System.Drawing.Point(244, 61);
            this.MetreLabel.Name = "MetreLabel";
            this.MetreLabel.Size = new System.Drawing.Size(56, 61);
            this.MetreLabel.TabIndex = 8;
            this.MetreLabel.Text = "m";
            this.MetreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 186);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(145, 55);
            this.CalculateBMIButton.TabIndex = 6;
            this.CalculateBMIButton.Text = "Calculate";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTableLayoutPanel.SetColumnSpan(this.ResetButton, 2);
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ResetButton.Location = new System.Drawing.Point(154, 186);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(146, 55);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CalculatedBMI
            // 
            this.CalculatedBMI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculatedBMI.AutoSize = true;
            this.CalculatedBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CalculatedBMI.Location = new System.Drawing.Point(3, 244);
            this.CalculatedBMI.Name = "CalculatedBMI";
            this.CalculatedBMI.Size = new System.Drawing.Size(145, 61);
            this.CalculatedBMI.TabIndex = 8;
            this.CalculatedBMI.Text = "Calculated BMI";
            this.CalculatedBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculatedBMITextBox
            // 
            this.CalculatedBMITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTableLayoutPanel.SetColumnSpan(this.CalculatedBMITextBox, 2);
            this.CalculatedBMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CalculatedBMITextBox.Location = new System.Drawing.Point(154, 247);
            this.CalculatedBMITextBox.Name = "CalculatedBMITextBox";
            this.CalculatedBMITextBox.Size = new System.Drawing.Size(146, 38);
            this.CalculatedBMITextBox.TabIndex = 9;
            // 
            // NumericButtonsTableLayoutPanel
            // 
            this.NumericButtonsTableLayoutPanel.ColumnCount = 4;
            this.NumericButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericButtonsTableLayoutPanel.Controls.Add(this.SevenButton, 0, 0);
            this.NumericButtonsTableLayoutPanel.Controls.Add(this.EightButton, 1, 0);
            this.NumericButtonsTableLayoutPanel.Controls.Add(this.FourButton, 0, 1);
            this.NumericButtonsTableLayoutPanel.Controls.Add(this.FiveButton, 1, 1);
            this.NumericButtonsTableLayoutPanel.Controls.Add(this.OneButton, 0, 2);
            this.NumericButtonsTableLayoutPanel.Controls.Add(this.TwoButton, 1, 2);
            this.NumericButtonsTableLayoutPanel.Controls.Add(this.ZeroButton, 1, 3);
            this.NumericButtonsTableLayoutPanel.Controls.Add(this.DecimalButton, 2, 3);
            this.NumericButtonsTableLayoutPanel.Controls.Add(this.ThreeButton, 2, 2);
            this.NumericButtonsTableLayoutPanel.Controls.Add(this.SixButton, 2, 1);
            this.NumericButtonsTableLayoutPanel.Controls.Add(this.NineButton, 2, 0);
            this.NumericButtonsTableLayoutPanel.Controls.Add(this.BackButton, 3, 0);
            this.NumericButtonsTableLayoutPanel.Controls.Add(this.DoneButton, 3, 2);
            this.NumericButtonsTableLayoutPanel.Location = new System.Drawing.Point(4, 489);
            this.NumericButtonsTableLayoutPanel.Name = "NumericButtonsTableLayoutPanel";
            this.NumericButtonsTableLayoutPanel.RowCount = 4;
            this.NumericButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericButtonsTableLayoutPanel.Size = new System.Drawing.Size(288, 200);
            this.NumericButtonsTableLayoutPanel.TabIndex = 7;
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SevenButton.ForeColor = System.Drawing.Color.White;
            this.SevenButton.Location = new System.Drawing.Point(3, 3);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(66, 44);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.CalculatorButtons_Click);
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.EightButton.ForeColor = System.Drawing.Color.White;
            this.EightButton.Location = new System.Drawing.Point(75, 3);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(66, 44);
            this.EightButton.TabIndex = 0;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.CalculatorButtons_Click);
            // 
            // FourButton
            // 
            this.FourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FourButton.ForeColor = System.Drawing.Color.White;
            this.FourButton.Location = new System.Drawing.Point(3, 53);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(66, 44);
            this.FourButton.TabIndex = 0;
            this.FourButton.Tag = "4";
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.CalculatorButtons_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FiveButton.ForeColor = System.Drawing.Color.White;
            this.FiveButton.Location = new System.Drawing.Point(75, 53);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(66, 44);
            this.FiveButton.TabIndex = 0;
            this.FiveButton.Tag = "5";
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.CalculatorButtons_Click);
            // 
            // OneButton
            // 
            this.OneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OneButton.ForeColor = System.Drawing.Color.White;
            this.OneButton.Location = new System.Drawing.Point(3, 103);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(66, 44);
            this.OneButton.TabIndex = 0;
            this.OneButton.Tag = "1";
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.CalculatorButtons_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TwoButton.ForeColor = System.Drawing.Color.White;
            this.TwoButton.Location = new System.Drawing.Point(75, 103);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(66, 44);
            this.TwoButton.TabIndex = 0;
            this.TwoButton.Tag = "2";
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.CalculatorButtons_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ZeroButton.ForeColor = System.Drawing.Color.White;
            this.ZeroButton.Location = new System.Drawing.Point(75, 153);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(66, 44);
            this.ZeroButton.TabIndex = 0;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.CalculatorButtons_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DecimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DecimalButton.ForeColor = System.Drawing.Color.White;
            this.DecimalButton.Location = new System.Drawing.Point(147, 153);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(66, 44);
            this.DecimalButton.TabIndex = 0;
            this.DecimalButton.Tag = "decimal";
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.CalculatorButtons_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ThreeButton.ForeColor = System.Drawing.Color.White;
            this.ThreeButton.Location = new System.Drawing.Point(147, 103);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(66, 44);
            this.ThreeButton.TabIndex = 0;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.CalculatorButtons_Click);
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SixButton.ForeColor = System.Drawing.Color.White;
            this.SixButton.Location = new System.Drawing.Point(147, 53);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(66, 44);
            this.SixButton.TabIndex = 0;
            this.SixButton.Tag = "6";
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.CalculatorButtons_Click);
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NineButton.ForeColor = System.Drawing.Color.White;
            this.NineButton.Location = new System.Drawing.Point(147, 3);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(66, 44);
            this.NineButton.TabIndex = 0;
            this.NineButton.Tag = "9";
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.CalculatorButtons_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(219, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(66, 44);
            this.BackButton.TabIndex = 0;
            this.BackButton.Tag = "back";
            this.BackButton.Text = "<--";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.CalculatorButtons_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(219, 103);
            this.DoneButton.Name = "DoneButton";
            this.NumericButtonsTableLayoutPanel.SetRowSpan(this.DoneButton, 2);
            this.DoneButton.Size = new System.Drawing.Size(66, 94);
            this.DoneButton.TabIndex = 0;
            this.DoneButton.Tag = "done";
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.CalculatorButtons_Click);
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Interval = 1000;
            // 
            // BMITextResult
            // 
            this.BMITextResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTableLayoutPanel.SetColumnSpan(this.BMITextResult, 3);
            this.BMITextResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BMITextResult.Location = new System.Drawing.Point(3, 308);
            this.BMITextResult.Name = "BMITextResult";
            this.BMITextResult.Size = new System.Drawing.Size(297, 38);
            this.BMITextResult.TabIndex = 8;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.NumericButtonsTableLayoutPanel);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            this.NumericButtonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextbox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightTextbox;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label CalculatedBMI;
        private System.Windows.Forms.TextBox CalculatedBMITextBox;
        private System.Windows.Forms.TableLayoutPanel NumericButtonsTableLayoutPanel;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label MetreLabel;
        private System.Windows.Forms.Label KilogramLabel;
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.TextBox BMITextResult;
    }
}

