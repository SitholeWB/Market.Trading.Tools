using Market.Trading.Tools.Constants;
using Market.Trading.Tools.Models;
using System;

namespace Market.Trading.Tools
{
    public static class FibonacciRetracement
    {
        public static FibboLevels GetFibboLevels(double pointA, double pointB)
        {
            return new FibboLevels
            {
                PointA = pointA,
                PointB = pointB,
                RetracementLevel_23_6 = pointA + Fibonacci.RetracementLevel_23_6 * (pointB - pointA),
                RetracementLevel_38_2 = pointA + Fibonacci.RetracementLevel_38_2 * (pointB - pointA),
                RetracementLevel_61_8 = pointA + Fibonacci.RetracementLevel_61_8 * (pointB - pointA),
                ExtensionLevel_161_8 = pointA + Fibonacci.ExtensionLevel_161_8 * (pointB - pointA),
                ExtensionLevel_261_8 = pointA + Fibonacci.ExtensionLevel_261_8 * (pointB - pointA),
                ExtensionLevel_423_6 = pointA + Fibonacci.ExtensionLevel_423_6 * (pointB - pointA),
                ExtensionLevel_685_4 = pointA + Fibonacci.ExtensionLevel_685_4 * (pointB - pointA),
                ExtensionLevel_1109 = pointA + Fibonacci.ExtensionLevel_1109 * (pointB - pointA)
            }; 
        }
    }
}
