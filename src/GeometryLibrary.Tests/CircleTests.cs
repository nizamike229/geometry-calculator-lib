namespace GeometryLibrary.Tests;

using Xunit;

public class CircleTests
{
    [Theory]
    [InlineData(1, Math.PI)]
    [InlineData(2, Math.PI * 4)]
    public void CalculateArea_ValidRadius_ReturnsCorrectArea(double radius, double expectedArea)
    {
        var circle = new Circle(radius);
        var area = circle.CalculateArea();
        
        Assert.Equal(expectedArea, area, 6);
    }

    [Fact]
    public void Constructor_NegativeRadius_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
} 