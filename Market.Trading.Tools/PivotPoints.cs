using Market.Trading.Tools.Constants;
using Market.Trading.Tools.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Trading.Tools
{
    public static class PivotPoints
    {
        /// <summary>
        /// Get commonly known PivotPoints types.
        /// </summary>
        /// <param name="high"></param>
        /// <param name="low"></param>
        /// <param name="close"></param>
        /// <param name="type">Type of PivotPoints to get, default is ClassicOrStandard.</param>
        /// <returns></returns>
        public static PivotLevelsBase GetPivotPointsLevels(double high, double low, double close, PivotPointsType type = PivotPointsType.ClassicOrStandard)
        {
            //https://www.babypips.com/tools/pivot-point-calculator
            //https://www.babypips.com/learn/forex/other-pivot-point-calculation-methods
            switch (type)
            {
                case PivotPointsType.Camarilla:
                    return GetCamarillaPivotPoints(high, low, close);
                case PivotPointsType.Woodie:
                    return GetWoodiePivotPoints(high, low, close);
                case PivotPointsType.Fibonacci:
                    return GetFibonacciPivotPoints(high, low, close);
                case PivotPointsType.ClassicOrStandard:
                case PivotPointsType.Default:
                    return GetClassicOrStandardPivotPoints(high, low, close);
            }

            throw new InvalidOperationException();
        }

        private static FibonacciPivotLevels GetFibonacciPivotPoints(double high, double low, double close)
        {
            var pivotLevels = new FibonacciPivotLevels();
            double PP = (high + low + close) / 3;
            pivotLevels.PivotPoint = PP;
            pivotLevels.R1 = PP + ((high - low) * .382);
            pivotLevels.S1 = PP - ((high - low) * .382);

            pivotLevels.R2 = PP + ((high - low) * .618);
            pivotLevels.S2 = PP - ((high - low) * .618);

            pivotLevels.R3 = PP + ((high - low) * 1.000);
            pivotLevels.S3 = PP - ((high - low) * 1.000);

            return pivotLevels;
        }

        private static ClassicOrStandardPivotLevels GetClassicOrStandardPivotPoints(double high, double low, double close)
        {
            var pivotLevels = new ClassicOrStandardPivotLevels();
            double PP = (high + low + close) / 3;
            pivotLevels.PivotPoint = PP;
            pivotLevels.R1 = (2 * PP) - low;
            pivotLevels.S1 = (2 * PP) - high;

            pivotLevels.R2 = PP + (high - low);
            pivotLevels.S2 = PP - (high - low);

            pivotLevels.R3 = high + 2 * (PP - low);
            pivotLevels.S3 = low - 2 * (high - PP);

            return pivotLevels;
        }

        private static WoodiePivotLevels GetWoodiePivotPoints(double high, double low, double close)
        {
            var pivotLevels = new WoodiePivotLevels();
            double PP = (high + low + 2 * close) / 4;
            pivotLevels.PivotPoint = PP;
            pivotLevels.R1 = (2 * PP) - low;
            pivotLevels.S1 = (2 * PP) - high;

            pivotLevels.R2 = PP + (high - low);
            pivotLevels.S2 = PP - (high - low);
            return pivotLevels;
        }

        private static CamarillaPivotLevels GetCamarillaPivotPoints(double high, double low, double close)
        {
            var pivotLevels = new CamarillaPivotLevels();
            double PP = (high + low + close) / 3;
            pivotLevels.PivotPoint = PP;
            pivotLevels.R1 = close + ((high - low) * 1.0833);
            pivotLevels.S1 = close - ((high - low) * 1.0833);

            pivotLevels.R2 = close + ((high - low) * 1.1666);
            pivotLevels.S2 = close - ((high - low) * 1.1666);

            pivotLevels.R3 = close + ((high - low) * 1.2500);
            pivotLevels.S3 = close - ((high - low) * 1.2500);

            pivotLevels.R4 = close + ((high - low) * 1.5000);
            pivotLevels.S4 = close - ((high - low) * 1.5000);

            return pivotLevels;
        }

    }
}
