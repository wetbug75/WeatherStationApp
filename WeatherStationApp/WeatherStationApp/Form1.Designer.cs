namespace WeatherStationApp
{
    partial class Form1
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.ampmComboBox = new System.Windows.Forms.ComboBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.lowTempLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.highTempLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.precipLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timeStateLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timeTempLabel = new System.Windows.Forms.Label();
            this.timePrecipLabel = new System.Windows.Forms.Label();
            this.setWeatherButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time:";
            // 
            // timeComboBox
            // 
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00"});
            this.timeComboBox.Location = new System.Drawing.Point(54, 192);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(125, 21);
            this.timeComboBox.TabIndex = 3;
            // 
            // ampmComboBox
            // 
            this.ampmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ampmComboBox.FormattingEnabled = true;
            this.ampmComboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.ampmComboBox.Location = new System.Drawing.Point(185, 192);
            this.ampmComboBox.Name = "ampmComboBox";
            this.ampmComboBox.Size = new System.Drawing.Size(60, 21);
            this.ampmComboBox.TabIndex = 4;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(365, 59);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(39, 13);
            this.stateLabel.TabIndex = 5;
            this.stateLabel.Text = "Cloudy";
            // 
            // lowTempLabel
            // 
            this.lowTempLabel.AutoSize = true;
            this.lowTempLabel.Location = new System.Drawing.Point(401, 87);
            this.lowTempLabel.Name = "lowTempLabel";
            this.lowTempLabel.Size = new System.Drawing.Size(17, 13);
            this.lowTempLabel.TabIndex = 6;
            this.lowTempLabel.Text = "0°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Low:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "High:";
            // 
            // highTempLabel
            // 
            this.highTempLabel.AutoSize = true;
            this.highTempLabel.Location = new System.Drawing.Point(403, 114);
            this.highTempLabel.Name = "highTempLabel";
            this.highTempLabel.Size = new System.Drawing.Size(17, 13);
            this.highTempLabel.TabIndex = 9;
            this.highTempLabel.Text = "0°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precipitation:";
            // 
            // precipLabel
            // 
            this.precipLabel.AutoSize = true;
            this.precipLabel.Location = new System.Drawing.Point(439, 142);
            this.precipLabel.Name = "precipLabel";
            this.precipLabel.Size = new System.Drawing.Size(21, 13);
            this.precipLabel.TabIndex = 11;
            this.precipLabel.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Daily Forecast:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Wind Speed:";
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.Location = new System.Drawing.Point(439, 167);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(36, 13);
            this.windSpeedLabel.TabIndex = 14;
            this.windSpeedLabel.Text = "0 mph";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Time Forecast:";
            // 
            // timeStateLabel
            // 
            this.timeStateLabel.AutoSize = true;
            this.timeStateLabel.Location = new System.Drawing.Point(365, 284);
            this.timeStateLabel.Name = "timeStateLabel";
            this.timeStateLabel.Size = new System.Drawing.Size(39, 13);
            this.timeStateLabel.TabIndex = 16;
            this.timeStateLabel.Text = "Cloudy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Temperature:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Precipitation:";
            // 
            // timeTempLabel
            // 
            this.timeTempLabel.AutoSize = true;
            this.timeTempLabel.Location = new System.Drawing.Point(441, 310);
            this.timeTempLabel.Name = "timeTempLabel";
            this.timeTempLabel.Size = new System.Drawing.Size(17, 13);
            this.timeTempLabel.TabIndex = 19;
            this.timeTempLabel.Text = "0°";
            // 
            // timePrecipLabel
            // 
            this.timePrecipLabel.AutoSize = true;
            this.timePrecipLabel.Location = new System.Drawing.Point(439, 337);
            this.timePrecipLabel.Name = "timePrecipLabel";
            this.timePrecipLabel.Size = new System.Drawing.Size(21, 13);
            this.timePrecipLabel.TabIndex = 20;
            this.timePrecipLabel.Text = "0%";
            // 
            // setWeatherButton
            // 
            this.setWeatherButton.Location = new System.Drawing.Point(18, 327);
            this.setWeatherButton.Name = "setWeatherButton";
            this.setWeatherButton.Size = new System.Drawing.Size(85, 23);
            this.setWeatherButton.TabIndex = 21;
            this.setWeatherButton.Text = "Set Weather";
            this.setWeatherButton.UseVisualStyleBackColor = true;
            this.setWeatherButton.Click += new System.EventHandler(this.setWeatherButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Specify Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 378);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.setWeatherButton);
            this.Controls.Add(this.timePrecipLabel);
            this.Controls.Add(this.timeTempLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timeStateLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.windSpeedLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.precipLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.highTempLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lowTempLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.ampmComboBox);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.ComboBox ampmComboBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label lowTempLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label highTempLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label precipLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label timeStateLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label timeTempLabel;
        private System.Windows.Forms.Label timePrecipLabel;
        private System.Windows.Forms.Button setWeatherButton;
        private System.Windows.Forms.Label label10;
    }
}

