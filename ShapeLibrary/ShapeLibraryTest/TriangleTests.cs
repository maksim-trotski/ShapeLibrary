using ShapeLibrary.Classes;

namespace ShapeLibraryTest
{
    public class TriangleTests
    {
        [Fact]
        public void TriangleArea_WithValidSides_ReturnsCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            double expected = 6;

            double actual = triangle.CalculateArea();

            Assert.Equal(expected, actual, 6);
        }

        [Fact]
        public void TriangleCreation_WithInvalidSides_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(5, 12, 13, true)]
        [InlineData(6, 8, 10, true)]
        [InlineData(5, 5, 5, false)]
        [InlineData(5, 5, 7, false)]
        public void IsRightAngled_ReturnsCorrectResult(double a, double b, double c, bool expected)
        {
            var triangle = new Triangle(a, b, c);

            bool actual = triangle.IsRightAngled();

            Assert.Equal(expected, actual);
        }
    }
}