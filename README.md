# Market.Trading.Tools
This is a library for Forex, Stock, etc. tools like Fibonacci, PivotPoints levels

# Get Started

```nuget
Install-Package Market.Trading.Tools
```

### Then call static methods:
```C#
FibonacciRetracement.GetFibboLevels(double pointA, double pointB) // return Retracement Levels Object
PivotPoints.GetPivotPointsLevels(double high, double low, double close, PivotPointsType type = PivotPointsType.ClassicOrStandard)// return Pivot Points Levels Object
```
# NuGet
https://www.nuget.org/packages/Market.Trading.Tools/
