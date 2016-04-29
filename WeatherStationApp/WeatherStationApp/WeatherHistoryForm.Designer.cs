namespace WeatherStationApp
{
    partial class WeatherHistoryForm
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
            this.stepButton = new System.Windows.Forms.Button();
            this.hourUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tempUpDown = new System.Windows.Forms.NumericUpDown();
            this.pressureUpDown = new System.Windows.Forms.NumericUpDown();
            this.windUpDown = new System.Windows.Forms.NumericUpDown();
            this.precipitationUpDown = new System.Windows.Forms.NumericUpDown();
            this.humidityTrackBar = new System.Windows.Forms.TrackBar();
            this.cloudTrackBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rainRadioButton = new System.Windows.Forms.RadioButton();
            this.snowRadioButton = new System.Windows.Forms.RadioButton();
            this.hailRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precipitationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(210, 208);
            this.stepButton.Margin = new System.Windows.Forms.Padding(2);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(90, 35);
            this.stepButton.TabIndex = 0;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // hourUpDown
            // 
            this.hourUpDown.Location = new System.Drawing.Point(210, 185);
            this.hourUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.hourUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hourUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hourUpDown.Name = "hourUpDown";
            this.hourUpDown.Size = new System.Drawing.Size(90, 20);
            this.hourUpDown.TabIndex = 1;
            this.hourUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hours:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temperature (F):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Barometric Pressure (in. of mercury):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wind Speed (mph):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Humidity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precipitation (1/100 in.):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cloud Cover";
            // 
            // tempUpDown
            // 
            this.tempUpDown.Location = new System.Drawing.Point(15, 28);
            this.tempUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.tempUpDown.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.tempUpDown.Name = "tempUpDown";
            this.tempUpDown.Size = new System.Drawing.Size(120, 20);
            this.tempUpDown.TabIndex = 15;
            // 
            // pressureUpDown
            // 
            this.pressureUpDown.Location = new System.Drawing.Point(13, 92);
            this.pressureUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.pressureUpDown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.pressureUpDown.Name = "pressureUpDown";
            this.pressureUpDown.Size = new System.Drawing.Size(120, 20);
            this.pressureUpDown.TabIndex = 16;
            this.pressureUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // windUpDown
            // 
            this.windUpDown.Location = new System.Drawing.Point(15, 159);
            this.windUpDown.Name = "windUpDown";
            this.windUpDown.Size = new System.Drawing.Size(120, 20);
            this.windUpDown.TabIndex = 17;
            // 
            // precipitationUpDown
            // 
            this.precipitationUpDown.Location = new System.Drawing.Point(15, 223);
            this.precipitationUpDown.Name = "precipitationUpDown";
            this.precipitationUpDown.Size = new System.Drawing.Size(120, 20);
            this.precipitationUpDown.TabIndex = 19;
            // 
            // humidityTrackBar
            // 
            this.humidityTrackBar.Location = new System.Drawing.Point(204, 27);
            this.humidityTrackBar.Maximum = 100;
            this.humidityTrackBar.Name = "humidityTrackBar";
            this.humidityTrackBar.Size = new System.Drawing.Size(516, 45);
            this.humidityTrackBar.TabIndex = 20;
            // 
            // cloudTrackBar
            // 
            this.cloudTrackBar.Location = new System.Drawing.Point(204, 92);
            this.cloudTrackBar.Maximum = 100;
            this.cloudTrackBar.Name = "cloudTrackBar";
            this.cloudTrackBar.Size = new System.Drawing.Size(516, 45);
            this.cloudTrackBar.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label8.Location = new System.Drawing.Point(696, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 9);
            this.label8.TabIndex = 22;
            this.label8.Text = "100%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label9.Location = new System.Drawing.Point(696, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 9);
            this.label9.TabIndex = 23;
            this.label9.Text = "100%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label10.Location = new System.Drawing.Point(211, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 9);
            this.label10.TabIndex = 24;
            this.label10.Text = "0%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label11.Location = new System.Drawing.Point(211, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 9);
            this.label11.TabIndex = 25;
            this.label11.Text = "0%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(315, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Current Time:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(391, 193);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(53, 13);
            this.timeLabel.TabIndex = 27;
            this.timeLabel.Text = "12:00 AM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hailRadioButton);
            this.groupBox1.Controls.Add(this.snowRadioButton);
            this.groupBox1.Controls.Add(this.rainRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(510, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precipitation Type";
            // 
            // rainRadioButton
            // 
            this.rainRadioButton.AutoSize = true;
            this.rainRadioButton.Checked = true;
            this.rainRadioButton.Location = new System.Drawing.Point(7, 20);
            this.rainRadioButton.Name = "rainRadioButton";
            this.rainRadioButton.Size = new System.Drawing.Size(47, 17);
            this.rainRadioButton.TabIndex = 0;
            this.rainRadioButton.TabStop = true;
            this.rainRadioButton.Text = "Rain";
            this.rainRadioButton.UseVisualStyleBackColor = true;
            // 
            // snowRadioButton
            // 
            this.snowRadioButton.AutoSize = true;
            this.snowRadioButton.Location = new System.Drawing.Point(7, 43);
            this.snowRadioButton.Name = "snowRadioButton";
            this.snowRadioButton.Size = new System.Drawing.Size(52, 17);
            this.snowRadioButton.TabIndex = 1;
            this.snowRadioButton.TabStop = true;
            this.snowRadioButton.Text = "Snow";
            this.snowRadioButton.UseVisualStyleBackColor = true;
            // 
            // hailRadioButton
            // 
            this.hailRadioButton.AutoSize = true;
            this.hailRadioButton.Location = new System.Drawing.Point(7, 66);
            this.hailRadioButton.Name = "hailRadioButton";
            this.hailRadioButton.Size = new System.Drawing.Size(43, 17);
            this.hailRadioButton.TabIndex = 2;
            this.hailRadioButton.TabStop = true;
            this.hailRadioButton.Text = "Hail";
            this.hailRadioButton.UseVisualStyleBackColor = true;
            // 
            // WeatherHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cloudTrackBar);
            this.Controls.Add(this.humidityTrackBar);
            this.Controls.Add(this.precipitationUpDown);
            this.Controls.Add(this.windUpDown);
            this.Controls.Add(this.pressureUpDown);
            this.Controls.Add(this.tempUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourUpDown);
            this.Controls.Add(this.stepButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WeatherHistoryForm";
            this.Text = "WeatherHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precipitationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.NumericUpDown hourUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown tempUpDown;
        private System.Windows.Forms.NumericUpDown pressureUpDown;
        private System.Windows.Forms.NumericUpDown windUpDown;
        private System.Windows.Forms.NumericUpDown precipitationUpDown;
        private System.Windows.Forms.TrackBar humidityTrackBar;
        private System.Windows.Forms.TrackBar cloudTrackBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton hailRadioButton;
        private System.Windows.Forms.RadioButton snowRadioButton;
        private System.Windows.Forms.RadioButton rainRadioButton;
    }
}