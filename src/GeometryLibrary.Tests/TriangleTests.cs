namespace GeometryLibrary.Tests;

using Xunit;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 5, 5, 10.825317547305483)]
    public void CalculateArea_ValidSides_ReturnsCorrectArea(double a, double b, double c, double expectedArea)
    {
        var triangle = new Triangle(a, b, c);
        var area = triangle.CalculateArea();
        
        Assert.Equal(expectedArea, area, 6);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(5, 5, 5, false)]
    public void IsRightTriangle_ReturnsCorrectResult(double a, double b, double c, bool expected)
    {
        var triangle = new Triangle(a, b, c);
        var isRight = triangle.IsRightTriangle();
        
        Assert.Equal(expected, isRight);
    }

    [Theory]
    [InlineData(-1, 2, 2)]
    [InlineData(1, -2, 2)]
    [InlineData(1, 2, -2)]
    public void Constructor_NegativeSide_ThrowsArgumentException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Theory]
    [InlineData(1, 1, 3)]
    [InlineData(3, 1, 1)]
    [InlineData(1, 3, 1)]
    public void Constructor_InvalidTriangleInequality_ThrowsArgumentException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
} 