using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WeatherHistoryForm test = new WeatherHistoryForm();
            test.Show();
            
        }

        private void setWeatherButton_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine(monthCalendar.SelectionStart.ToString());
        }
    }
}
