using GeometryLibrary;

namespace ShapeLibraryTest
{
    public class CircleTests
    {
        [Fact]
        public void CircleArea_WithValidRadius_ReturnsCorrectArea()
        {
            var circle = new Circle(5);
            double expected = Math.PI * 25;

            double actual = circle.CalculateArea();

            Assert.Equal(expected, actual, 6);
        }

        [Fact]
        public void CircleCreation_WithNegativeRadius_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}