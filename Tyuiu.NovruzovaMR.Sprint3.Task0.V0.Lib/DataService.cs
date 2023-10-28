using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.cources.programing.interfaces.Sprint3;

namespace Tyuiu.NovruzovaMR.Sprint3.Task0.V0.Lib
{
    public class DataService : 
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int 1;
            for ( 1 = startValue; 1 <= stopValue; i++)
            {
                sumSeries = sumSeries + ((1 / Math.Sin(i)) + value);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
