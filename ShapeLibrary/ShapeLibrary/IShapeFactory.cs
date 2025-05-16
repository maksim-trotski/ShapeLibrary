namespace GeometryLibrary
{
    public interface IShapeFactory
    {
        Shape CreateCircle(double radius);
        Shape CreateTriangle(double a, double b, double c);
    }
}
