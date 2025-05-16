using GeometryLibrary;

var circle = new Circle(5);
double circleArea = circle.CalculateArea();

var triangle = new Triangle(3, 4, 5);
double triangleArea = triangle.CalculateArea();
bool isRight = triangle.IsRightAngled();

//var shape = ShapeFactory.CreateShape(new Dictionary<string, double> { { "Radius", 4 } });
//double area = AreaCalculator.CalculateArea(shape);

var shape = ShapeFactory.CreateCircle(radius: 4);
double area = ShapeFactory.CalculateArea(shape);


Console.WriteLine($"Shape area is {area}");
Console.ReadLine();
