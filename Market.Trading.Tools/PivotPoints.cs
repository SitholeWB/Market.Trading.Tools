using Market.Trading.Tools.Constants;
using Market.Trading.Tools.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Trading.Tools
{
    public static class PivotPoints
    {
        public static PivotLevels GetPivotPointsLevels(double high, double low, double close, PivotPointsType type = PivotPointsType.ClassicOrStandard)
        {
            //https://www.babypips.com/tools/pivot-point-calculator
            //https://www.babypips.com/learn/forex/other-pivot-point-calculation-methods
            switch (type)
            {
                case PivotPointsType.Camarilla:
                //TODO
                case PivotPointsType.Woodie:
                    return GetWoodiePivotPoints(high, low, close);
                case PivotPointsType.Fibonacci:
                //TODO
                case PivotPointsType.ClassicOrStandard:
                case PivotPointsType.Default:
                    return GetClassicOrStandardPivotPoints(high, low, close);
            }

            throw new InvalidOperationException();
        }

        private static PivotLevels GetClassicOrStandardPivotPoints(double high, double low, double close)
        {
            //https://www.babypips.com/learn/forex/how-to-calculate-pivot-points
            var pivotLevels = new PivotLevels();
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

        private static PivotLevels GetWoodiePivotPoints(double high, double low, double close)
        {
            var pivotLevels = new PivotLevels();
            double PP = (high + low + 2 * close) / 4;
            pivotLevels.PivotPoint = PP;
            pivotLevels.R1 = (2 * PP) - low;
            pivotLevels.S1 = (2 * PP) - high;

            pivotLevels.R2 = PP + (high - low);
            pivotLevels.S2 = PP - (high - low);

            pivotLevels.R3 = high + 2 * (PP - low);//?????? More research needed
            pivotLevels.S3 = low - 2 * (high - PP);//?????? More research needed

            return pivotLevels;
        }

    }
}
