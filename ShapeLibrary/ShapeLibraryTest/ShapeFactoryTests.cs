using GeometryLibrary;

namespace ShapeLibraryTest
{
    public class ShapeFactoryTests
    {
        [Fact]
        public void CreateShape_CreatesCircle_WhenRadiusProvided()
        {
            var shape = ShapeFactory.CreateCircle(5);

            Assert.IsType<Circle>(shape);
        }

        [Fact]
        public void CreateShape_CreatesTriangle_WhenThreeSidesProvided()
        {
            var shape = ShapeFactory.CreateTriangle(3, 4, 5);

            Assert.IsType<Triangle>(shape);
        }

        [Fact]
        public void CalculateArea_ReturnsCircleArea_ForCircle()
        {
            var circle = ShapeFactory.CreateCircle(5);
            double expected = Math.PI * 25;

            double actual = ShapeFactory.CalculateArea(circle);

            Assert.Equal(expected, actual, 6);
        }

        [Fact]
        public void CalculateArea_ReturnsTriangleArea_ForTriangle()
        {
            var triangle = ShapeFactory.CreateTriangle(3, 4, 5);
            double expected = 6;

            double actual = ShapeFactory.CalculateArea(triangle);

            Assert.Equal(expected, actual, 6);
        }
    }
}