namespace FiguresProject;

public class Circle : IFigure
{
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be positive");

        Radius = radius;
    }

    public double Radius { get; }

    public double GetSquare() 
    {
        return Math.PI * Radius * Radius;
    }

    public double GetPerimeter() 
    {
        return 2 * Math.PI * Radius;
    }
}