﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovruzovaMR.Sprint3.Task1.V15.Lib
{
    public class DataService : ISprint3Task1V15
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1;

            while (startValue <= stopValue)
            {
                result *= ((Math.Pow(value, 2) * startValue) + 1);
                startValue++;
            }
            return Math.Round(result, 3);
        }
    }
}