namespace Assignment4_BMICalculator
{
    partial class SplashScreen
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.Dot1Label = new System.Windows.Forms.Label();
            this.Dot2Label = new System.Windows.Forms.Label();
            this.Dot1Timer = new System.Windows.Forms.Timer(this.components);
            this.Dot2Timer = new System.Windows.Forms.Timer(this.components);
            this.WelcomeToLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(43, 66);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(208, 31);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "BMI Calculator!!";
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LoadingLabel.Location = new System.Drawing.Point(12, 392);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(135, 26);
            this.LoadingLabel.TabIndex = 1;
            this.LoadingLabel.Text = "LoadingFiles";
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Interval = 500;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // Dot1Label
            // 
            this.Dot1Label.AutoSize = true;
            this.Dot1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Dot1Label.Location = new System.Drawing.Point(140, 392);
            this.Dot1Label.Name = "Dot1Label";
            this.Dot1Label.Size = new System.Drawing.Size(18, 26);
            this.Dot1Label.TabIndex = 1;
            this.Dot1Label.Text = ".";
            // 
            // Dot2Label
            // 
            this.Dot2Label.AutoSize = true;
            this.Dot2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Dot2Label.Location = new System.Drawing.Point(153, 392);
            this.Dot2Label.Name = "Dot2Label";
            this.Dot2Label.Size = new System.Drawing.Size(18, 26);
            this.Dot2Label.TabIndex = 1;
            this.Dot2Label.Text = ".";
            // 
            // Dot1Timer
            // 
            this.Dot1Timer.Interval = 1500;
            this.Dot1Timer.Tick += new System.EventHandler(this.Dot1Timer_Tick);
            // 
            // Dot2Timer
            // 
            this.Dot2Timer.Interval = 2500;
            this.Dot2Timer.Tick += new System.EventHandler(this.Dot2Timer_Tick);
            // 
            // WelcomeToLabel
            // 
            this.WelcomeToLabel.AutoSize = true;
            this.WelcomeToLabel.Location = new System.Drawing.Point(62, 26);
            this.WelcomeToLabel.Name = "WelcomeToLabel";
            this.WelcomeToLabel.Size = new System.Drawing.Size(165, 31);
            this.WelcomeToLabel.TabIndex = 0;
            this.WelcomeToLabel.Text = "Welcome To";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.Dot2Label);
            this.Controls.Add(this.Dot1Label);
            this.Controls.Add(this.LoadingLabel);
            this.Controls.Add(this.WelcomeToLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SplashScreen";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.Timer LoadingTimer;
        private System.Windows.Forms.Label Dot1Label;
        private System.Windows.Forms.Label Dot2Label;
        private System.Windows.Forms.Timer Dot1Timer;
        private System.Windows.Forms.Timer Dot2Timer;
        private System.Windows.Forms.Label WelcomeToLabel;
    }
}