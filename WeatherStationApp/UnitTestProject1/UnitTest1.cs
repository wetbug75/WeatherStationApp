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
    }
}
