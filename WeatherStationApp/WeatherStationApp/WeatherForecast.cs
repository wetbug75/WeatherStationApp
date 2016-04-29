using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationApp
{
    //takes data of a single WeatherInfo day and converts it to the values MainForm expects
    public class WeatherForecast
    {
        int[,] data;// [hour, specific data]
        //0 - temp
        //1 - pressure
        //2 - wind speed
        //3 - precipitation
        //4 - humidity
        //5 - cloud cover
        //6 - precip. type

        public WeatherForecast(int[,] weatherInfo)
        {
            data = new int[weatherInfo.GetLength(0), weatherInfo.GetLength(1)];
            for(int i = 0; i < weatherInfo.GetLength(0); i++)
            {
                for(int j = 0; j < weatherInfo.GetLength(1); j++)
                {
                    data[i, j] = weatherInfo[i, j];
                }
            }
        }

        private int GetAverage(int specifiedData)
        {
            int num = 0;
            for(int i = 0; i < data.GetLength(0); i++)
            {
                num += data[i, specifiedData];
            }
            return num / data.GetLength(0);
        }

        private int GetMax(int specifiedData)
        {
            int num = -200;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if(num < data[i, specifiedData])
                    num = data[i, specifiedData];
            }
            return num;
        }

        private int GetMin(int specifiedData)
        {
            int num = 10000;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (num > data[i, specifiedData])
                    num = data[i, specifiedData];
            }
            return num;
        }

        private int GetMostCommonPrecipitationType()
        {
            int zeroCount = 0;
            int oneCount = 0;
            int twoCount = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 6] == 0)
                    zeroCount++;
                else if (data[i, 6] == 1)
                    oneCount++;
                else
                    twoCount++;
            }
            if (zeroCount >= oneCount && zeroCount >= twoCount)
                return 0;
            if (oneCount >= zeroCount && oneCount >= twoCount)
                return 1;
            return 2;
        }

        public string GetDayState()
        {
            if (GetAverage(3) >= 30)// lots of precip.
            {
                return "Heavy " + GetPrecipitationType(GetMostCommonPrecipitationType());
            }
            else if (GetAverage(3) >= 10)// medium precip.
            {
                return "Moderate " + GetPrecipitationType(GetMostCommonPrecipitationType());
            }
            else if (GetAverage(3) > 0)// low precip
            {
                return "Light " + GetPrecipitationType(GetMostCommonPrecipitationType());
            }
            else// no precip
            {
                if (GetAverage(5) >= 60)//lots of clouds
                    return "Cloudy";
                else if (GetAverage(5) >= 20)
                    return "Some Clouds";
            }
            return "Clear Skies";
        }

        public int GetLowTemp()
        {
            return GetMin(0);
        }

        public int GetHighTemp()
        {
            return GetMax(0);
        }

        public int GetDayPrecipitationPercentage()
        {
            if (GetAverage(5) == 0)
                return 0;
            if (GetAverage(3) == 0)
                return 0;
            return (int)((Math.Pow(24, 3) / Math.Pow(GetAverage(1), 3)) * GetAverage(4));
        }

        public int GetWindSpeed()
        {
            return GetAverage(2);
        }

        private string GetPrecipitationType(int precip)
        {
            if (precip == 0)
                return "rain";
            if (precip == 1)
                return "snow";
            return "hail";
        }

        public string GetHourState(int hour)
        {
            if(data[hour,3] >= 30)// lots of precip.
            {
                return "Heavy " + GetPrecipitationType(data[hour, 6]);
            }
            else if(data[hour,3] >= 10)// medium precip.
            {
                return "Moderate " + GetPrecipitationType(data[hour, 6]);
            }
            else if(data[hour,3] > 0)// low precip
            {
                return "Light " + GetPrecipitationType(data[hour, 6]);
            }
            else// no precip
            {
                if (data[hour, 5] >= 60)//lots of clouds
                    return "Cloudy";
                else if (data[hour, 5] >= 20)
                    return "Some Clouds";
            }
            return "Clear Skies";
        }

        public int GetHourTemp(int hour)
        {
            return data[hour, 0];
        }

        public int GetHourPrecipitationPercentage(int hour)
        {
            if (data[hour, 3] == 0)
                return 0;
            if (data[hour, 5] == 0)
                return 0;
            return (int)((Math.Pow(24, 3) / Math.Pow(data[hour, 1], 3)) * data[hour, 4]);
        }
    }
}
