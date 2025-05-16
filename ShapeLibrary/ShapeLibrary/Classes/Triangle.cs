namespace ShapeLibrary.Classes
{
    public class Triangle : Shape
    {
        public double a { get; }
        public double b { get; }
        public double c { get; }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            Validate();
        }

        public override void Validate()
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Все стороны треугольника должны быть положительными числами");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Треугольник с такими сторонами не существует");
        }

        public override double CalculateArea()
        {
            double semiPerimeter = (a + b + c) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
        }

        public bool IsRightAngled(double tolerance = 0.000001)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);

            return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < tolerance;
        }
    }
}