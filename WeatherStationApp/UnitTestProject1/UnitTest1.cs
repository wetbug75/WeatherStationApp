using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherStationApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddWeatherInfoTest()
        {
            WeatherInfo wi = new WeatherInfo(1);
            int[] n = new int[6] { 1, 2, 3, 4, 5, 6 };
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
