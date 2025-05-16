using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Classes
{
    public class AreaCalculator : IAreaCalculator
    {
        public double CalculateArea(Shape shape)
        {
            if (shape == null)
                throw new ArgumentNullException(nameof(shape));
            return shape.CalculateArea();
        }
    }
}
