﻿namespace GeometryLibrary
{
    public class ShapeFactory : IShapeFactory
    {
        public Shape CreateCircle(double radius) => new Circle(radius);
        public Shape CreateTriangle(double a, double b, double c) => new Triangle(a, b, c);
    }
}