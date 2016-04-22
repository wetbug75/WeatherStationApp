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
    public partial class WeatherHistoryForm : Form
    {
        public delegate void PassWeatherInfo(object sender);
        public PassWeatherInfo passWeatherInfo;

        public WeatherInfo weatherInfo;
        public string date;
        public int totalHours;

        public WeatherHistoryForm(WeatherInfo weatherInfo, string date)
        {
            InitializeComponent();

            totalHours = 0;
            this.weatherInfo = weatherInfo;
            this.date = date;
        }

        public string GetCurrentTime(int hours)
        {
            string time = "";
            if (totalHours < 12)
            {
                time = totalHours + ":00 AM";
            }
            else
            {
                time = (totalHours - 12) + ":00 PM";
                if(totalHours == 12)
                    time = totalHours + ":00 PM";
            }
            return time;
        }

        public void AddWeatherInfo(int hours)
        {
            int[] info = new int[weatherInfo.DATA_AMMOUNT];
            info[0] = (int)tempUpDown.Value;
            info[1] = (int)pressureUpDown.Value;
            info[2] = (int)windUpDown.Value;
            info[3] = (int)precipitationUpDown.Value;
            info[4] = humidityTrackBar.Value;
            info[5] = cloudTrackBar.Value;

            for(int i = 0; i < hours; i++)
            {
                weatherInfo.AddInfo(date, totalHours - i - 1, info);
            }
        }

        private void stepButton_Click(object sender, EventArgs e)
        {

            int hours = (int)hourUpDown.Value;
            totalHours += hours;
            //if (totalHours >= weatherInfo.HOURS)
            //    totalHours = weatherInfo.HOURS - 1;
            timeLabel.Text = GetCurrentTime(hours);

            AddWeatherInfo(hours);

            if (totalHours >= 24)
            {
                if (passWeatherInfo != null)
                    passWeatherInfo(weatherInfo);
                this.Close();
            }
        }
    }
}
