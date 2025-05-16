using ShapeLibrary.Classes;
using ShapeLibrary.Interfaces;

namespace ShapeLibraryTest
{
    public class AreaCalculatorTest
    {
        private readonly IShapeFactory _shapeFactory;
        private readonly IAreaCalculator _areaCalculator;

        public AreaCalculatorTest()
        {
            _shapeFactory = new ShapeFactory();
            _areaCalculator = new AreaCalculator();
        }

        [Fact]
        public void CalculateArea_ReturnsCircleArea_ForCircle()
        {
            var circle = _shapeFactory.CreateCircle(5);
            double expected = Math.PI * 25;

            double actual = _areaCalculator.CalculateArea(circle);

            Assert.Equal(expected, actual, 6);
        }
    }
}