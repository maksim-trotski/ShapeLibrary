namespace GeometryLibrary
{
    public static class ShapeFactory
    {
        public static Shape CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public static Shape CreateTriangle(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }

        public static double CalculateArea(Shape shape)
        {
            if (shape == null)
                throw new ArgumentNullException(nameof(shape));

            return shape.CalculateArea();
        }

        //public static Shape CreateShape(Dictionary<string, double> parameters)
        //{
        //    if (parameters == null)
        //        throw new ArgumentNullException(nameof(parameters));

        //    if (parameters.Count == 1 && parameters.ContainsKey("Radius"))
        //    {
        //        return new Circle(parameters["Radius"]);
        //    }
        //    else if (parameters.Count == 3 &&
        //             parameters.ContainsKey("SideA") &&
        //             parameters.ContainsKey("SideB") &&
        //             parameters.ContainsKey("SideC"))
        //    {
        //        return new Triangle(parameters["SideA"], parameters["SideB"], parameters["SideC"]);
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Неподдерживаемый набор параметров для создания фигуры");
        //    }
        //}
    }

    //public static class AreaCalculator
    //{
        
    //}
}