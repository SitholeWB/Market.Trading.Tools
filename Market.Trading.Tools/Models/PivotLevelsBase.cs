using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Trading.Tools.Models
{
    public abstract class PivotLevelsBase
    {
        public double PivotPoint { get; set; }
        public double S1 { get; set; }
        public double R1 { get; set; }
        public double S2 { get; set; }
        public double R2 { get; set; }
    }
}
