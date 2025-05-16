using Microsoft.Extensions.DependencyInjection;
using ShapeLibrary.Classes;
using ShapeLibrary.Interfaces;

var services = new ServiceCollection()
    .AddSingleton<IShapeFactory, ShapeFactory>()
    .AddSingleton<IAreaCalculator, AreaCalculator>()
    .BuildServiceProvider();

var calculator = services.GetRequiredService<IAreaCalculator>();
var factory = services.GetRequiredService<IShapeFactory>();

var circle = factory.CreateCircle(5);
double area = calculator.CalculateArea(circle);

Console.WriteLine($"Shape area is {area}");
Console.ReadLine();
