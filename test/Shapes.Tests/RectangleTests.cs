using Xunit;

namespace Shapes.Tests;

public class RectangleTests
{
    [Fact]
    public void Rectangle_ShouldBeCorrectlyInitialized()
    {
        var location = new Point();
        var size = new Size(1, 1);
        var rectangle = new Rectangle(location, size);

        Assert.Equal(location.X, rectangle.X);
        Assert.Equal(location.Y, rectangle.Y);
        Assert.Equal(size.Width, rectangle.Width);
        Assert.Equal(size.Height, rectangle.Height);
    }


    [Fact]
    public void IntersectsWith_ShouldReturnTrue_WithIntersectingRectangle()
    {
        var rectangle = new Rectangle(new Point(), new Size(2, 2));
        var rectangle1 = new Rectangle(new Point(), new Size(1, 1));

        var result = rectangle.IntersectsWith(rectangle1);

        Assert.True(result);
    }

    [Fact]
    public void IntersectsWith_ShouldReturnFalse_WithNonIntersectingRectangle()
    {
        var rectangle = new Rectangle(new Point(), new Size(2, 2));
        var rectangle1 = new Rectangle(new Point(5, 5), new Size(2, 2));

        var result = rectangle.IntersectsWith(rectangle1);

        Assert.False(result);
    }
}