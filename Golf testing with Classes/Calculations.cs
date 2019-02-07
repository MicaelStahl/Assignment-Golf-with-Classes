using System;
using System.Collections.Generic;
using System.Text;

namespace Golf_Assignment_with_Classes
{
    class Calculations
    {
        public static double CalculateDistance(double angle, double velocity)
        {
            return Math.Pow(velocity, 2) / 9.8 * Math.Sin(2 * (Math.PI / 180) * angle);
        }
    }
}