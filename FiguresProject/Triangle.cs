namespace FiguresProject;

public class Triangle : IFigure
{
    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("All sides must be positive");
        if (a >= b + c || b >= a + c || c >= a + b)
            throw new ArgumentException($"Triangle with sides {a}, {b} and {c} does not exist");

        SideA = a;
        SideB = b;
        SideC = c;
    }

    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public double GetSquare() 
    {
        double halfPerimeter = this.GetPerimeter() / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
    }

    public double GetPerimeter()
    {
        return SideA + SideB + SideC;
    }

    public bool IsRight() 
    {
        return Math.Abs(SideB * SideB + SideC * SideC - SideA * SideA) < Consts.EPSILON
            || Math.Abs(SideA * SideA + SideC * SideC - SideB * SideB) < Consts.EPSILON
            || Math.Abs(SideA * SideA + SideB * SideB - SideC * SideC) < Consts.EPSILON;
    }
}