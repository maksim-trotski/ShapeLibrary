using ShapeLibrary.Classes;
using ShapeLibrary.Interfaces;

namespace ShapeLibraryTest
{
    public class ShapeFactoryTests
    {
        private readonly IShapeFactory _shapeFactory;
        private readonly IAreaCalculator _areaCalculator;

        public ShapeFactoryTests()
        {
            _shapeFactory = new ShapeFactory();
            _areaCalculator = new AreaCalculator();
        }

        [Fact]
        public void CreateShape_CreatesCircle_WhenRadiusProvided()
        {
            var shape = _shapeFactory.CreateCircle(5);

            Assert.IsType<Circle>(shape);
        }

        [Fact]
        public void CreateShape_CreatesTriangle_WhenThreeSidesProvided()
        {
            var shape = _shapeFactory.CreateTriangle(3, 4, 5);

            Assert.IsType<Triangle>(shape);
        }
    }
}