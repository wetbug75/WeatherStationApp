using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherStationApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //tests to see if forecasts are acurate if data already exists for that day
        public void StoredDataForecastTest()
        {
            MainForm form = new MainForm();
            for (int i = 0; i < 24; i++)
            {
                form.weatherInfo.data[0, i, 0] = 50;//temp
                form.weatherInfo.data[0, i, 1] = 50;//pressure
                form.weatherInfo.data[0, i, 2] = 10;//wind speed
                form.weatherInfo.data[0, i, 3] = 15;//precipitation inches
                form.weatherInfo.data[0, i, 4] = 100;//humidity percentage
                form.weatherInfo.data[0, i, 5] = 100;//cloud cover percentage
                form.weatherInfo.data[0, i, 6] = 0;//precipitation type
            }
            form.weatherInfo.data[0, 20, 0] = 70;
            form.weatherInfo.data[0, 21, 0] = 30;

            Assert.IsTrue(form.GetDayState().Equals("Rainy"));
            Assert.IsTrue(form.GetLowTemp() == 30);
            Assert.IsTrue(form.GetHighTemp() == 70);
            Assert.IsTrue(form.GetDayPrecipitation() == 100);
            Assert.IsTrue(form.GetWindSpeed() == 10);
            Assert.IsTrue(form.GetHourState().Equals("Rainy"));
            Assert.IsTrue(form.GetHourTemp() == 50);
            Assert.IsTrue(form.GetHourPrecipitation() == 100);
        }

        [TestMethod]
        public void WeatherInfoIsEmptyTest()
        {
            WeatherInfo wi = new WeatherInfo(1);
            int[] n = new int[7] { 1, 2, 3, 4, 5, 6, 1};
            wi.AddInfo("4/20/2016", 0, n);
            Assert.IsTrue(!wi.IsEmpty("4/20/2016", 0));
            Assert.IsTrue(wi.IsEmpty("4/20/2016", 1));
            Assert.IsTrue(wi.IsEmpty("4/21/2016", 1));
        }

        [TestMethod]
        public void AddWeatherInfoTest()
        {
            WeatherInfo wi = new WeatherInfo(1);
            int[] n = new int[7] { 1, 2, 3, 4, 5, 6, 0};
            wi.AddInfo("4/20/2016", 0, n);
            int[] nCopy = wi.GetInfo("4/20/2016", 0);

            bool equal = true;
            for(int i = 0; i < 6; i++)
            {
                if (n[i] != nCopy[i])
                    equal = false;
            }
            Assert.IsTrue(equal);
        }

        [TestMethod]
        public void GetSelectedDateTest()
        {
            MainForm form = new MainForm();
            Assert.AreEqual("4/22/2016", form.GetSelectedDate("4/22/2016 12:00 AM"));
        }

        [TestMethod]
        public void GetCurrentTimeTest()
        {
            WeatherInfo wi = new WeatherInfo(1);
            WeatherHistoryForm form = new WeatherHistoryForm(wi, "4/22/2016");
            form.totalHours = 15;
            Assert.AreEqual("3:00 PM", form.GetCurrentTime(2));
        }

        [TestMethod]
        public void AddWeatherInfoToHistoryFormTest()
        {
            WeatherInfo wi = new WeatherInfo(1);
            WeatherHistoryForm form = new WeatherHistoryForm(wi, "4/22/2016");
            form.totalHours = 5;
            form.AddWeatherInfo(5);
            bool equal = true;
            if (form.weatherInfo.data[0, 0, 0] != 0)
                equal = false;
            if (form.weatherInfo.data[0, 4, 0] != 0)
                equal = false;
            if (form.weatherInfo.data[0, 0, 3] != 0)
                equal = false;
            if (form.weatherInfo.data[0, 0, 5] != 0)
                equal = false;
            if (form.weatherInfo.data[0, 2, 2] != 0)
                equal = false;
            if (form.weatherInfo.data[0, 2, 2] != 0)
                equal = false;
            Assert.IsTrue(equal);
        }

        [TestMethod]
        public void GetSpecifiedDataTest()
        {
            MainForm form = new MainForm();
            form.weatherInfo.dates[0] = "4/20/2016";
            form.weatherInfo.data[0, 0, 0] = 2;
            form.weatherInfo.data[0, 0, 1] = 20;
            form.weatherInfo.data[0, 0, 2] = 0;
            form.weatherInfo.data[0, 0, 3] = 7;
            form.weatherInfo.data[0, 0, 4] = 100;
            form.weatherInfo.data[0, 0, 5] = -2;
            int hour = 0;//copy-pasted function contents with modified variables
            if (0 == 1)//
                hour += 12;//
            int[] info = form.weatherInfo.GetInfo("4/20/2016", hour);//
            bool equal = true;
            if (info[0] != 2)
                equal = false;
            if (info[1] != 20)
                equal = false;
            if (info[2] != 0)
                equal = false;
            if (info[3] != 7)
                equal = false;
            if (info[4] != 100)
                equal = false;
            if (info[5] != -2)
                equal = false;
            Assert.IsTrue(equal);
        }
    }
}
