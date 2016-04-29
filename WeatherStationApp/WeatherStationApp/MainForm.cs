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
            timeComboBox.SelectedIndex = 0;
            ampmComboBox.SelectedIndex = 0;
        }

        public string GetSelectedDate(string rawDate)
        {
            int dashCount = 0;
            int cutoff = 0;
            for (int i = 0; i < rawDate.Length; i++)
            {
                if (dashCount == 2)
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
            for (int i = 0; i < data.Length - 1; i++)
            {
                result += data[i] + ", ";
            }
            result += data[data.Length - 1];
            tempLabel.Text = result;
        }

        public int[] GetSpecifiedData(string date)
        {
            try
            {
                int hour = timeComboBox.SelectedIndex;
                if (ampmComboBox.SelectedIndex == 1)
                    hour += 12;
                return weatherInfo.GetInfo(date, hour);
            }
            catch
            {
                return new int[] { 0, 0, 0, 0, 0, 0, 0 };
            }
        }

        private void ampmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hour = timeComboBox.SelectedIndex;
            if (ampmComboBox.SelectedIndex == 1)
                hour += 12;
            string date = GetSelectedDate(monthCalendar.SelectionStart.ToString());
            int[] data = GetSpecifiedData(date);
            string result = "";
            for (int i = 0; i < data.Length - 1; i++)
            {
                result += data[i] + ", ";
            }
            result += data[data.Length - 1];
            tempLabel.Text = result;

            stateLabel.Text = GetDayState(date);
            lowTempLabel.Text = GetLowTemp(date) + "°";
            highTempLabel.Text = GetHighTemp(date) + "°";
            precipLabel.Text = GetDayPrecipitation(date) + "%";
            windSpeedLabel.Text = GetWindSpeed(date) + " mph";
            timeStateLabel.Text = GetHourState(date, hour);
            timeTempLabel.Text = GetHourTemp(date, hour) + "°";
            timePrecipLabel.Text = GetHourPrecipitation(date, hour) + "%";
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            int hour = timeComboBox.SelectedIndex;
            if (ampmComboBox.SelectedIndex == 1)
                hour += 12;
            string date = GetSelectedDate(monthCalendar.SelectionStart.ToString());
            int[] data = GetSpecifiedData(date);
            string result = "";
            for (int i = 0; i < data.Length - 1; i++)
            {
                result += data[i] + ", ";
            }
            result += data[data.Length - 1];
            tempLabel.Text = result;

            stateLabel.Text = GetDayState(date);
            lowTempLabel.Text = GetLowTemp(date) + "°";
            highTempLabel.Text = GetHighTemp(date) + "°";
            precipLabel.Text = GetDayPrecipitation(date) + "%";
            windSpeedLabel.Text = GetWindSpeed(date) + " mph";
            timeStateLabel.Text = GetHourState(date, hour);
            timeTempLabel.Text = GetHourTemp(date, hour) + "°";
            timePrecipLabel.Text = GetHourPrecipitation(date, hour) + "%";
        }

        public int[,] CreateDayData(string date)
        {
            int[,] data = new int[24, weatherInfo.DATA_AMMOUNT];
            for (int i = 0; i < 24; i++)
            {
                int[] temp = weatherInfo.GetInfo(date, i);
                for (int j = 0; j < weatherInfo.DATA_AMMOUNT; j++)
                {
                    data[i, j] = temp[j];
                }
            }
            return data;
        }

        public int[,] CreateDayDataPrediction(string date)
        {
            int[,] data = new int[24, weatherInfo.DATA_AMMOUNT];

            //unfinished

            return data;
        }

        //ignores leap years
        //assumes date string is structured correctly
        //assumes no multi-month jumps (i.e., daysAgo should never exceed at least 28)
        public string GetPriorDate(string currentDate, int daysAgo)
        {
            string monthStr;
            string dayStr = "";
            string yearStr;
            int c = 0;
            while (currentDate[c] != '/')
            {
                c++;
            }
            c++;
            dayStr += currentDate[c];
            c++;
            if(currentDate[c] != '/')
            {
                dayStr += currentDate[c];
                c++;
            }
            c++;
            yearStr = "" + currentDate[c++] + currentDate[c++] + currentDate[c++] + currentDate[c];
            if (currentDate[1] != '/')
                monthStr = "" + currentDate[0] + currentDate[1];
            else
                monthStr = "" + currentDate[0];

            int month = Int32.Parse(monthStr);
            int day = Int32.Parse(dayStr);
            int year = Int32.Parse(yearStr);

            if(day - daysAgo <= 0)
            {
                if (month == 3)//going to Feb
                    day = day + 28 - daysAgo;
                else if (month == 2 || month == 4 || month == 6 || month == 8 || month == 9 || month == 11 || month == 1)//going to 31 day month
                    day = day + 31 - daysAgo;
                else//going to 30 day month
                    day = day + 30 - daysAgo;
                month--;
                if (month == 0)
                {
                    month = 12;
                    year--;
                }
            }
            else
            {
                day = day - daysAgo;
            }

            return month + "/" + day + "/" + year;
        }

        public string GetDayState(string date)
        {
            WeatherForecast weatherForecast;
            if (!weatherInfo.IsEmpty(date))
            {
                int[,] data = CreateDayData(date);
                weatherForecast = new WeatherForecast(data);
            }
            else
            {
                int[,] data = CreateDayDataPrediction(date);
                weatherForecast = new WeatherForecast(data);
            }
            return weatherForecast.GetDayState();
        }

        public int GetLowTemp(string date)
        {
            WeatherForecast weatherForecast;
            if (!weatherInfo.IsEmpty(date))
            {
                int[,] data = CreateDayData(date);
                weatherForecast = new WeatherForecast(data);
            }
            else
            {
                int[,] data = CreateDayDataPrediction(date);
                weatherForecast = new WeatherForecast(data);
            }
            return weatherForecast.GetLowTemp();
        }

        public int GetHighTemp(string date)
        {
            WeatherForecast weatherForecast;
            if (!weatherInfo.IsEmpty(date))
            {
                int[,] data = CreateDayData(date);
                weatherForecast = new WeatherForecast(data);
            }
            else
            {
                int[,] data = CreateDayDataPrediction(date);
                weatherForecast = new WeatherForecast(data);
            }
            return weatherForecast.GetHighTemp();
        }

        public int GetDayPrecipitation(string date)
        {
            WeatherForecast weatherForecast;
            if (!weatherInfo.IsEmpty(date))
            {
                int[,] data = CreateDayData(date);
                weatherForecast = new WeatherForecast(data);
            }
            else
            {
                int[,] data = CreateDayDataPrediction(date);
                weatherForecast = new WeatherForecast(data);
            }
            return weatherForecast.GetDayPrecipitationPercentage();
        }

        public int GetWindSpeed(string date)
        {
            WeatherForecast weatherForecast;
            if (!weatherInfo.IsEmpty(date))
            {
                int[,] data = CreateDayData(date);
                weatherForecast = new WeatherForecast(data);
            }
            else
            {
                int[,] data = CreateDayDataPrediction(date);
                weatherForecast = new WeatherForecast(data);
            }
            return weatherForecast.GetWindSpeed();
        }

        public string GetHourState(string date, int hour)
        {
            WeatherForecast weatherForecast;
            if (!weatherInfo.IsEmpty(date))
            {
                int[,] data = CreateDayData(date);
                weatherForecast = new WeatherForecast(data);
            }
            else
            {
                int[,] data = CreateDayDataPrediction(date);
                weatherForecast = new WeatherForecast(data);
            }
            return weatherForecast.GetHourState(hour);
        }

        public int GetHourTemp(string date, int hour)
        {
            WeatherForecast weatherForecast;
            if (!weatherInfo.IsEmpty(date))
            {
                int[,] data = CreateDayData(date);
                weatherForecast = new WeatherForecast(data);
            }
            else
            {
                int[,] data = CreateDayDataPrediction(date);
                weatherForecast = new WeatherForecast(data);
            }
            return weatherForecast.GetHourTemp(hour);
        }

        public int GetHourPrecipitation(string date, int hour)
        {
            WeatherForecast weatherForecast;
            if (!weatherInfo.IsEmpty(date))
            {
                int[,] data = CreateDayData(date);
                weatherForecast = new WeatherForecast(data);
            }
            else
            {
                int[,] data = CreateDayDataPrediction(date);
                weatherForecast = new WeatherForecast(data);
            }
            return weatherForecast.GetHourPrecipitationPercentage(hour);
        }
    }
}
