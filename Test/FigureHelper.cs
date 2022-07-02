namespace Test;

public class FigureHelper
{
    public double GetCircleArea(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Radius cannot be negative");
        }
        return Math.PI * Math.Pow(radius, 2);
    } 

    public double GetTriangleArea(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Side cannot be negative");
        }
        var p = (a + b + c) / 2;
        var area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return area;
    }

    public bool IsTriangleRight(double a, double b, double c) => Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2);
}