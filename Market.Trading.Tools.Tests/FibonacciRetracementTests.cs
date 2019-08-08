using NUnit.Framework;
using System;

namespace Market.Trading.Tools.Tests
{
    [TestFixture]
    public class FibonacciRetracementTests
    {
        [Test]
        [TestCase(0.3,0.5)]
        [TestCase(0.03, 0.5)]
        [TestCase(0.0013, 0.0115)]
        [TestCase(0.3043, 0.50045)]
        public void GetFibboLevels_GivenBullishTrend_ShouldReturnExtensionLevelGreaterThanPointAandB(double pointA, double pointB)
        {
            //Arrange
            //Act
            var fibboLevels = FibonacciRetracement.GetFibboLevels(pointA, pointB);

            //Assert
            Assert.Greater(fibboLevels.Extension1_Level_161_8, pointB);
            Assert.Greater(fibboLevels.Extension2_Level_261_8, pointB);
            Assert.Greater(fibboLevels.Extension3_Level_423_6, pointB);
            Assert.Greater(fibboLevels.Extension4_Level_685_4, pointB);
            Assert.Greater(fibboLevels.Extension5_Level_1109, pointB);
            Assert.Greater(fibboLevels.Extension6_Level_1794_4, pointB);
            Assert.Greater(fibboLevels.Extension7_Level_2903_4, pointB);
            Assert.Greater(fibboLevels.Extension8_Level_4697_8, pointB);
            Assert.Greater(fibboLevels.Extension9_Level_7601_2, pointB);
            Assert.Greater(fibboLevels.Extension10_Level_12299, pointB);

            Assert.Greater(fibboLevels.Extension1_Level_161_8, pointA);
            Assert.Greater(fibboLevels.Extension2_Level_261_8, pointA);
            Assert.Greater(fibboLevels.Extension3_Level_423_6, pointA);
            Assert.Greater(fibboLevels.Extension4_Level_685_4, pointA);
            Assert.Greater(fibboLevels.Extension5_Level_1109, pointA);
            Assert.Greater(fibboLevels.Extension6_Level_1794_4, pointA);
            Assert.Greater(fibboLevels.Extension7_Level_2903_4, pointA);
            Assert.Greater(fibboLevels.Extension8_Level_4697_8, pointA);
            Assert.Greater(fibboLevels.Extension9_Level_7601_2, pointA);
            Assert.Greater(fibboLevels.Extension10_Level_12299, pointA);
        }

        [Test]
        [TestCase(0.63, 0.5)]
        [TestCase(0.9103, 0.5)]
        [TestCase(0.120013, 0.0115)]
        [TestCase(0.73043, 0.50045)]
        public void GetFibboLevels_GivenBearishTrend_ShouldReturnExtensionLevelLessThanPointAandB(double pointA, double pointB)
        {
            //Arrange
            //Act
            var fibboLevels = FibonacciRetracement.GetFibboLevels(pointA, pointB);

            //Assert
            Assert.Less(fibboLevels.Extension1_Level_161_8, pointB);
            Assert.Less(fibboLevels.Extension2_Level_261_8, pointB);
            Assert.Less(fibboLevels.Extension3_Level_423_6, pointB);
            Assert.Less(fibboLevels.Extension4_Level_685_4, pointB);
            Assert.Less(fibboLevels.Extension5_Level_1109, pointB);
            Assert.Less(fibboLevels.Extension6_Level_1794_4, pointB);
            Assert.Less(fibboLevels.Extension7_Level_2903_4, pointB);
            Assert.Less(fibboLevels.Extension8_Level_4697_8, pointB);
            Assert.Less(fibboLevels.Extension9_Level_7601_2, pointB);
            Assert.Less(fibboLevels.Extension10_Level_12299, pointB);
                   
            Assert.Less(fibboLevels.Extension1_Level_161_8, pointA);
            Assert.Less(fibboLevels.Extension2_Level_261_8, pointA);
            Assert.Less(fibboLevels.Extension3_Level_423_6, pointA);
            Assert.Less(fibboLevels.Extension4_Level_685_4, pointA);
            Assert.Less(fibboLevels.Extension5_Level_1109, pointA);
            Assert.Less(fibboLevels.Extension6_Level_1794_4, pointA);
            Assert.Less(fibboLevels.Extension7_Level_2903_4, pointA);
            Assert.Less(fibboLevels.Extension8_Level_4697_8, pointA);
            Assert.Less(fibboLevels.Extension9_Level_7601_2, pointA);
            Assert.Less(fibboLevels.Extension10_Level_12299, pointA);
        }

        [Test]
        [TestCase(0.63, 0.5)]
        [TestCase(0.9103, 0.5)]
        [TestCase(0.120013, 0.0115)]
        [TestCase(0.73043, 0.50045)]
        public void GetFibboLevels_GivenBearishTrend_ShouldReturnExtensionLevelsInDescendingOrder(double pointA, double pointB)
        {
            //Arrange
            //Act
            var fibboLevels = FibonacciRetracement.GetFibboLevels(pointA, pointB);

            //Assert
            Assert.Less(fibboLevels.Extension10_Level_12299, fibboLevels.Extension9_Level_7601_2);
            Assert.Less(fibboLevels.Extension9_Level_7601_2, fibboLevels.Extension8_Level_4697_8);
            Assert.Less(fibboLevels.Extension8_Level_4697_8, fibboLevels.Extension7_Level_2903_4);
            Assert.Less(fibboLevels.Extension7_Level_2903_4, fibboLevels.Extension6_Level_1794_4);
            Assert.Less(fibboLevels.Extension6_Level_1794_4, fibboLevels.Extension5_Level_1109);
            Assert.Less(fibboLevels.Extension5_Level_1109, fibboLevels.Extension4_Level_685_4);
            Assert.Less(fibboLevels.Extension4_Level_685_4, fibboLevels.Extension3_Level_423_6);
            Assert.Less(fibboLevels.Extension3_Level_423_6, fibboLevels.Extension2_Level_261_8);
            Assert.Less(fibboLevels.Extension2_Level_261_8, fibboLevels.Extension1_Level_161_8);
            Assert.Less(fibboLevels.Extension1_Level_161_8, pointB);

            Assert.AreEqual(fibboLevels.PointB, pointB);

            Assert.Less(fibboLevels.RetracementLevel_61_8, fibboLevels.RetracementLevel_38_2);
            Assert.Less(fibboLevels.RetracementLevel_38_2, fibboLevels.RetracementLevel_23_6);
            Assert.Less(fibboLevels.RetracementLevel_23_6, pointA);
            Assert.AreEqual(fibboLevels.PointA, pointA);

        }

        [Test]
        [TestCase(0.3, 0.5)]
        [TestCase(0.03, 0.5)]
        [TestCase(0.0013, 0.0115)]
        [TestCase(0.3043, 0.50045)]
        public void GetFibboLevels_GivenBearishTrend_ShouldReturnLevelsInAscendingOrder(double pointA, double pointB)
        {
            //Arrange
            //Act
            var fibboLevels = FibonacciRetracement.GetFibboLevels(pointA, pointB);

            //Assert
            Assert.Greater(fibboLevels.Extension10_Level_12299, fibboLevels.Extension9_Level_7601_2);
            Assert.Greater(fibboLevels.Extension9_Level_7601_2, fibboLevels.Extension8_Level_4697_8);
            Assert.Greater(fibboLevels.Extension8_Level_4697_8, fibboLevels.Extension7_Level_2903_4);
            Assert.Greater(fibboLevels.Extension7_Level_2903_4, fibboLevels.Extension6_Level_1794_4);
            Assert.Greater(fibboLevels.Extension6_Level_1794_4, fibboLevels.Extension5_Level_1109);
            Assert.Greater(fibboLevels.Extension5_Level_1109, fibboLevels.Extension4_Level_685_4);
            Assert.Greater(fibboLevels.Extension4_Level_685_4, fibboLevels.Extension3_Level_423_6);
            Assert.Greater(fibboLevels.Extension3_Level_423_6, fibboLevels.Extension2_Level_261_8);
            Assert.Greater(fibboLevels.Extension2_Level_261_8, fibboLevels.Extension1_Level_161_8);
            Assert.Greater(fibboLevels.Extension1_Level_161_8, pointB);

            Assert.AreEqual(fibboLevels.PointB, pointB);

            Assert.Greater(fibboLevels.RetracementLevel_61_8, fibboLevels.RetracementLevel_38_2);
            Assert.Greater(fibboLevels.RetracementLevel_38_2, fibboLevels.RetracementLevel_23_6);
            Assert.Greater(fibboLevels.RetracementLevel_23_6, pointA);
            Assert.AreEqual(fibboLevels.PointA, pointA);
        }

    }
}
