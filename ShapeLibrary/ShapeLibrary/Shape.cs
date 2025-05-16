namespace GeometryLibrary
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public virtual void Validate() { }
    }
}