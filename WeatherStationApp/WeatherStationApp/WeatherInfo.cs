using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationApp
{
    public class WeatherInfo
    {
        readonly int DATA_AMMOUNT = 6;
        readonly int HOURS = 24;
        int[,,] data;
        string[] dates;

        public WeatherInfo(int numDates)
        {
            data = new int[numDates, HOURS, DATA_AMMOUNT];
            dates = new string[numDates];
            for (int i = 0; i < numDates; i++)
                dates[i] = "";
            for (int i = 0; i < numDates; i++)
            {
                for (int j = 0; j < HOURS; j++)
                {
                    for (int k = 0; k < DATA_AMMOUNT; k++)
                    {
                        data[i, j, k] = -1;
                    }
                }
            }
        }

        public int[] GetInfo(string date, int hour)
        {
            int[] info = new int[DATA_AMMOUNT];
            int index = -1;
            for (int i = 0; i < dates.Length; i++)
            {
                if (dates[i].Equals(date))
                    index = i;
            }

            for(int i = 0; i < HOURS; i++)
            {
                if(index == i)
                {
                    for(int j = 0; j < DATA_AMMOUNT; j++)
                    {
                        info[j] = data[index, i, j];
                    }
                    return info;
                }
            }
            return new int[] { -1 };
        }

        public void AddInfo(string date, int hour, int[] info)
        {
            //finds index
            int index = -1;
            for(int i = 0; i < dates.Length; i++)
            {
                if (dates[i].Equals(date))
                    index = i;
            }
            if(index == -1)
            {
                for (int i = 0; i < dates.Length; i++)
                {
                    if(dates[i].Equals(""))
                    {
                        index = i;
                        dates[i] = date;
                        break;
                    }
                }
            }

            //enters dataa
            for(int i = 0; i < DATA_AMMOUNT; i++)
            {
                data[index, hour, i] = info[i];
            }
        }
    }
}
