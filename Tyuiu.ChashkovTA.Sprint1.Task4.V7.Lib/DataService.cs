﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChashkovTA.Sprint1.Task4.V7.Lib
{
    public class DataService : ISprint1Task4V7
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((1.0 + Math.Sqrt(x * y)) / (Math.Pow(x - 3 * y, 2)), 3) - 0.001;
        }
    }
}
