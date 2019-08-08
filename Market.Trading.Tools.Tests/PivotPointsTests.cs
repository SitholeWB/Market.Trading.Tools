using Market.Trading.Tools.Constants;
using Market.Trading.Tools.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Trading.Tools.Tests
{
    [TestFixture]
    public class PivotPointsTests
    {

        [Test]
        [TestCase(1.4787, 1.4737, 1.4787)]
        [TestCase(50, 15, 50)]
        [TestCase(1.4787, 1.4737, 1.4787, PivotPointsType.ClassicOrStandard)]
        [TestCase(50, 15, 50, PivotPointsType.Woodie)]
        public void GetPivotPointsLevels_GivenBullishTrend_ShouldReturnExtensionLevelGreaterThanPointAandB(double high, double low, double close, PivotPointsType type = PivotPointsType.Default)
        {
            //Arrange
            //Act
            PivotLevels pivotPoints = (type == PivotPointsType.Default) ? PivotPoints.GetPivotPointsLevels(high, low, close) : PivotPoints.GetPivotPointsLevels(high, low, close, type);

            //Assert
            Assert.Greater(pivotPoints.R3, pivotPoints.R2);
            Assert.Greater(pivotPoints.R2, pivotPoints.R1);
            Assert.Greater(pivotPoints.R1, pivotPoints.PivotPoint);

            Assert.Less(pivotPoints.S3, pivotPoints.S2);
            Assert.Less(pivotPoints.S2, pivotPoints.S1);
            Assert.Less(pivotPoints.S1, pivotPoints.PivotPoint);
        }
    }
}
