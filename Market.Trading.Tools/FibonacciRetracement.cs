using Market.Trading.Tools.Constants;
using Market.Trading.Tools.Models;
using System;

namespace Market.Trading.Tools
{
    public static class FibonacciRetracement
    {
        /// <summary>
        /// Get Fibonacci Retracements and Extensions for pure fibonacci levels.
        /// </summary>
        /// <param name="pointA"></param>
        /// <param name="pointB"></param>
        /// <returns></returns>
        public static FibboLevels GetFibboLevels(double pointA, double pointB)
        {
            return new FibboLevels
            {
                PointA = pointA,
                PointB = pointB,
                RetracementLevel_23_6 = pointA + Fibonacci.RetracementLevel_23_6 * (pointB - pointA),
                RetracementLevel_38_2 = pointA + Fibonacci.RetracementLevel_38_2 * (pointB - pointA),
                RetracementLevel_61_8 = pointA + Fibonacci.RetracementLevel_61_8 * (pointB - pointA),
                Extension1_Level_161_8 = pointA + Fibonacci.Extension1_Level_161_8 * (pointB - pointA),
                Extension2_Level_261_8 = pointA + Fibonacci.Extension2_Level_261_8 * (pointB - pointA),
                Extension3_Level_423_6 = pointA + Fibonacci.Extension3_Level_423_6 * (pointB - pointA),
                Extension4_Level_685_4 = pointA + Fibonacci.Extension4_Level_685_4 * (pointB - pointA),
                Extension5_Level_1109 = pointA + Fibonacci.Extension5_Level_1109 * (pointB - pointA),
                Extension6_Level_1794_4 = pointA + Fibonacci.Extension6_Level_1794_4 * (pointB - pointA),
                Extension7_Level_2903_4 = pointA + Fibonacci.Extension7_Level_2903_4 * (pointB - pointA),
                Extension8_Level_4697_8 = pointA + Fibonacci.Extension8_Level_4697_8 * (pointB - pointA),
                Extension9_Level_7601_2 = pointA + Fibonacci.Extension9_Level_7601_2 * (pointB - pointA),
                Extension10_Level_12299 = pointA + Fibonacci.Extension10_Level_12299 * (pointB - pointA)
            }; 
        }

        /// <summary>
        /// Get Fibonacci Retracement or Extension for given level.
        /// </summary>
        /// <param name="pointA"></param>
        /// <param name="pointB"></param>
        /// <param name="fibonacciLevel">A decimal value specifying the level (Do not pass it as percentage).</param>
        /// <returns></returns>
        public static double GetFibboLevels(double pointA, double pointB, double fibonacciLevel)
        {
            return pointA + fibonacciLevel * (pointB - pointA);
        }

    }
}
