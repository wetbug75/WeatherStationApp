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
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precipitationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Step";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(210, 185);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 1;
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
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Barometric Pressure (Pa):";
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
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precipitation (in.):";
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
            this.pressureUpDown.Name = "pressureUpDown";
            this.pressureUpDown.Size = new System.Drawing.Size(120, 20);
            this.pressureUpDown.TabIndex = 16;
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
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(204, 27);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(516, 45);
            this.trackBar1.TabIndex = 20;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(204, 92);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(516, 45);
            this.trackBar2.TabIndex = 21;
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
            this.label12.Location = new System.Drawing.Point(421, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Current Time:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(497, 192);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(53, 13);
            this.timeLabel.TabIndex = 27;
            this.timeLabel.Text = "12:00 AM";
            // 
            // WeatherHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 281);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
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
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WeatherHistoryForm";
            this.Text = "WeatherHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precipitationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
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
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label timeLabel;
    }
}