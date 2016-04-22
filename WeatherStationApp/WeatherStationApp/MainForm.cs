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
    public partial class MainForm : Form
    {
        public WeatherInfo weatherInfo;

        public MainForm()
        {
            InitializeComponent();
            weatherInfo = new WeatherInfo(15);   
        }

        public string GetSelectedDate(string rawDate)
        {
            int dashCount = 0;
            int cutoff = 0;
            for(int i = 0; i < rawDate.Length; i++)
            {
                if(dashCount ==2)
                {
                    cutoff = i + 4;
                    break;
                }
                if (rawDate[i] == '/')
                    dashCount++;
            }
            string date = "";
            for (int i = 0; i < cutoff; i++)
                date += rawDate[i];
            return date;
        }

        private void setWeatherButton_Click(object sender, EventArgs e)
        {
            WeatherHistoryForm whForm = new WeatherHistoryForm(weatherInfo, GetSelectedDate(monthCalendar.SelectionStart.ToString()));
            whForm.passWeatherInfo = new WeatherHistoryForm.PassWeatherInfo(PassData);
            whForm.Show();
        }

        private void PassData(object sender)
        {
            weatherInfo = (WeatherInfo)sender;
        }

        private void timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] data = GetSpecifiedData(GetSelectedDate(monthCalendar.SelectionStart.ToString()));
            string result = "";
            for(int i = 0; i < data.Length - 1; i++)
            {
                result += data[i] + ", ";
            }
            result += data[data.Length - 1];
            tempLabel.Text = result;
        }

        private void ampmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] data = GetSpecifiedData(GetSelectedDate(monthCalendar.SelectionStart.ToString()));
            string result = "";
            for (int i = 0; i < data.Length - 1; i++)
            {
                result += data[i] + ", ";
            }
            result += data[data.Length - 1];
            tempLabel.Text = result;
        }
        
        public int[] GetSpecifiedData(string date)
        {
            int hour = timeComboBox.SelectedIndex;
            if (ampmComboBox.SelectedIndex == 1)
                hour += 12;
            return weatherInfo.GetInfo(date, hour);
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            int[] data = GetSpecifiedData(GetSelectedDate(monthCalendar.SelectionStart.ToString()));
            string result = "";
            for (int i = 0; i < data.Length - 1; i++)
            {
                result += data[i] + ", ";
            }
            result += data[data.Length - 1];
            tempLabel.Text = result;
        }
    }
}
