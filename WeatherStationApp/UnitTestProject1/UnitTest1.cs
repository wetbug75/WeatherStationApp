using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherStationApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WeatherForecastResultsTest()
        {
            int[,] arr = new int[24, 7];
            for (int i = 0; i < 24; i++)
            {
                arr[i, 0] = 10;//temp
                arr[i, 1] = 26;//pressure
                arr[i, 2] = 10;//wind speed
                arr[i, 3] = 30;//precipitation 1/100 inches
                arr[i, 4] = 90;//humidity percentage
                arr[i, 5] = 85;//cloud cover percentage
                arr[i, 6] = 1;//precipitation type
            }
            arr[15, 0] = 15;
            arr[20, 0] = 2;
            WeatherForecast wf = new WeatherForecast(arr);
            System.Console.WriteLine("day state: " + wf.GetDayState());
            Assert.IsTrue(wf.GetDayState().Equals("Heavy snow"));
            Assert.IsTrue(wf.GetLowTemp() == 2);
            Assert.IsTrue(wf.GetHighTemp() == 15);
            Assert.IsTrue(wf.GetDayPrecipitationPercentage() == 70);
            Assert.IsTrue(wf.GetWindSpeed() == 10);
            Assert.IsTrue(wf.GetHourState(6).Equals("Heavy snow"));
            Assert.IsTrue(wf.GetHourTemp(15) == 15);
            Assert.IsTrue(wf.GetHourPrecipitationPercentage(1) == 70);
        }

        [TestMethod]
        //tests to see if forecasts are acurate if data already exists for that day
        public void StoredDataForecastTest()
        {
            MainForm form = new MainForm();
            form.weatherInfo.dates[0] = "the date";
            for (int i = 0; i < 24; i++)
            {
                form.weatherInfo.data[0, i, 0] = 50;//temp
                form.weatherInfo.data[0, i, 1] = 24;//pressure
                form.weatherInfo.data[0, i, 2] = 10;//wind speed
                form.weatherInfo.data[0, i, 3] = 35;//precipitation 1/100 inches
                form.weatherInfo.data[0, i, 4] = 100;//humidity percentage
                form.weatherInfo.data[0, i, 5] = 100;//cloud cover percentage
                form.weatherInfo.data[0, i, 6] = 0;//precipitation type
            }
            form.weatherInfo.data[0, 20, 0] = 70;
            form.weatherInfo.data[0, 21, 0] = 30;

            Assert.IsTrue(form.GetDayState("the date").Equals("Heavy rain"));
            Assert.IsTrue(form.GetLowTemp("the date") == 30);
            Assert.IsTrue(form.GetHighTemp("the date") == 70);
            Assert.IsTrue(form.GetDayPrecipitation("the date") == 100);
            Assert.IsTrue(form.GetWindSpeed("the date") == 10);
            Assert.IsTrue(form.GetHourState("the date", 2).Equals("Heavy rain"));
            Assert.IsTrue(form.GetHourTemp("the date", 0) == 50);
            Assert.IsTrue(form.GetHourPrecipitation("the date", 10) == 100);
        }

        [TestMethod]
        public void WeatherInfoIsEmptyTest()
        {
            WeatherInfo wi = new WeatherInfo(1);
            int[] n = new int[7] { 1, 2, 3, 4, 5, 6, 1};
            for(int i = 0; i < 24; i++)
                wi.AddInfo("4/20/2016", i, n);
            Assert.IsTrue(!wi.IsEmpty("4/20/2016"));
            Assert.IsTrue(wi.IsEmpty("4/21/2016"));
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
            if (form.weatherInfo.data[0, 2, 1] != 24)
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

        [TestMethod]
        public void CreateDayDataTest()
        {
            MainForm form = new MainForm();
            form.weatherInfo.dates[0] = "the date";
            for (int i = 0; i < 24; i++)
            {
                form.weatherInfo.data[0, i, 0] = 50;//temp
                form.weatherInfo.data[0, i, 1] = 24;//pressure
                form.weatherInfo.data[0, i, 2] = 10;//wind speed
                form.weatherInfo.data[0, i, 3] = 35;//precipitation 1/100 inches
                form.weatherInfo.data[0, i, 4] = 100;//humidity percentage
                form.weatherInfo.data[0, i, 5] = 100;//cloud cover percentage
                form.weatherInfo.data[0, i, 6] = 0;//precipitation type
            }
            form.weatherInfo.data[0, 3, 2] = 30;

            int[,] day = form.CreateDayData("the date");
            Assert.IsTrue(day[3, 2] == 30);
            Assert.IsTrue(day[0, 2] == 10);
            Assert.IsTrue(day[20, 0] == 50);
            Assert.IsTrue(day[8, 6] == 0);
        }

        [TestMethod]
        public void CreateDayDataPredictionTest()
        {
            MainForm form = new MainForm();
            form.weatherInfo.dates[0] = "4/28/2016";
            for (int i = 0; i < 24; i++)
            {
                form.weatherInfo.data[0, i, 0] = 50;//temp
                form.weatherInfo.data[0, i, 1] = 24;//pressure
                form.weatherInfo.data[0, i, 2] = 10;//wind speed
                form.weatherInfo.data[0, i, 3] = 35;//precipitation 1/100 inches
                form.weatherInfo.data[0, i, 4] = 100;//humidity percentage
                form.weatherInfo.data[0, i, 5] = 100;//cloud cover percentage
                form.weatherInfo.data[0, i, 6] = 0;//precipitation type
            }

            int[,] predictions = form.CreateDayDataPrediction("4/29/2016");
            Assert.IsTrue(predictions[0, 0] < 100 && predictions[0, 0] > 0);
            Assert.IsTrue(predictions[0, 1] <= 32 && predictions[0, 1] >= 24);
            Assert.IsTrue(predictions[0, 2] < 50 && predictions[0, 2] >= 0);
            Assert.IsTrue(predictions[5, 3] < 60 && predictions[5, 3] >= 0);
            Assert.IsTrue(predictions[0, 4] <= 100 && predictions[0, 4] > 0);
            Assert.IsTrue(predictions[0, 5] <= 100 && predictions[0, 5] >= 0);
            Assert.IsTrue(predictions[0, 6] == 0 || predictions[0, 6] == 1 || predictions[0, 6] == 2);
        }

        [TestMethod]
        public void GetPriorDateTest()
        {
            MainForm form = new MainForm();
            form.weatherInfo.dates[0] = "4/28/2016";
            form.weatherInfo.dates[1] = "4/29/2016";
            form.weatherInfo.dates[2] = "4/27/2016";

            Assert.IsTrue(form.GetPriorDate("4/30/2016", 1).Equals("4/29/2016"));
            Assert.IsTrue(form.GetPriorDate("4/30/2016", 3).Equals("4/27/2016"));
            Assert.IsTrue(form.GetPriorDate("4/29/2016", 1).Equals("4/28/2016"));
            Assert.IsTrue(form.GetPriorDate("5/2/2016", 4).Equals("4/28/2016"));
        }
    }
}
