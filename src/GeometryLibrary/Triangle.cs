namespace GeometryLibrary;

public class Triangle : IShape
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Стороны треугольника должны быть положительными числами");
            
        if (a + b <= c || b + c <= a || a + c <= b)
            throw new ArgumentException("Нарушено неравенство треугольника");
            
        _a = a;
        _b = b;
        _c = c;
    }

    public double CalculateArea()
    {
        var p = (_a + _b + _c) / 2;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    public bool IsRightTriangle()
    {
        var sides = new[] { _a, _b, _c };
        Array.Sort(sides);
        
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 1e-10;
    }
} 