using FiguresProject;

namespace FiguresProjectTest;

[TestClass]
public class CirclesTest
{
    [TestMethod]
    public void TestCirclesSquare()
    {
        double[] radiusValues = { 1.0, 0.01, 654.34 };
        for (int i = 0; i < radiusValues.Length; i++) 
        {
            double radius = radiusValues[i];
            Circle circle = new Circle(radius);
            Assert.IsTrue(Math.Abs(circle.GetSquare() - Math.PI * radius * radius) < Consts.EPSILON, $"Radius: {radius}");
        }
    }

    [TestMethod]
    public void TestInvalidCircles()
    {
        double[] radiusValues = { -1.0, 0.0, -76.345 };
        for (int i = 0; i < radiusValues.Length; i++) 
        {
            double radius = radiusValues[i];
            Assert.ThrowsException<ArgumentException>(() => new Circle(radius), $"Radius: {radius}");
        }
    }
}