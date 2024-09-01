using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAP.HelperMethods
{
    public static class CalculatorHelper
    {
        public static bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0));
        }
    }
}

//All the following rules must be satisfied:

//Is NOT leap year if NOT divisible by 4
//Is leap year is divisible by 4
//Is leap year if divisible by 400
//Is NOT leap year if divisible by 100 but NOT by 400
//Examples:

//1997 is NOT leap year(not divisible by 4)
//1996 is leap year (divisible by 4)
//1600 is leap year (divisible by 400)
//1800 is NOT leap year(divisible by 4, divisible by 100, NOT divisible by 400)
