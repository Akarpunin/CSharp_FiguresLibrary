using FiguresProject;

namespace FiguresProjectTest;

[TestClass]
public class TrianglesTest
{
    [TestMethod]
    public void TestTrianglesSquare()
    {   
        Triangle triangle1 = new Triangle(3, 4, 5);
        double estimation1 = 6;
        Assert.IsTrue(Math.Abs(triangle1.GetSquare() - estimation1) < Consts.EPSILON, $"Sides: 3, 4, 5");

        Triangle triangle2 = new Triangle(Math.Sqrt(2), 1, 1);
        double estimation2 = 0.5;
        Assert.IsTrue(Math.Abs(triangle2.GetSquare() - estimation2) < Consts.EPSILON, $"Sides: Math.Sqrt(2), 1, 1");
    }

    [TestMethod]
    public void TestRightTriangles()
    {
        double[][] sidesValues = new double[][]
        {
            new double[] { 5, 4, 3 },
            new double[] { 1, Math.Sqrt(2), 1 },
        };
        for (int i = 0; i < sidesValues.Length; i++) 
        {
            double[] sides = sidesValues[i];
            Triangle triangle = new Triangle(sides[0], sides[1], sides[2]);
            Assert.IsTrue(triangle.IsRight(), $"Sides: {sides[0]}, {sides[1]}, {sides[2]}");
        }

        sidesValues = new double[][]
        {
            new double[] { 12, 14, 15 },           
            new double[] { 10.4, 6.2, 8.1 },
        };
        for (int i = 0; i < sidesValues.Length; i++) 
        {
            double[] sides = sidesValues[i];
            Triangle triangle = new Triangle(sides[0], sides[1], sides[2]);
            Assert.IsFalse(triangle.IsRight(), $"Sides: {sides[0]}, {sides[1]}, {sides[2]}");
        }
    }

    [TestMethod]
    public void TestInvalidTriangles()
    {
        double[][] sidesValues = new double[][]
        {
            new double[] { 0, 1, 2 },           
            new double[] { 1, 0, 2 },
            new double[] { 1, 2, 0 },
            new double[] { -4, -5, -6 },
            new double[] { 0.34, 1.2, -6.67 },
        };
        for (int i = 0; i < sidesValues.Length; i++) 
        {
            double[] sides = sidesValues[i];
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sides[0], sides[1], sides[2]), $"Sides: {sides[0]}, {sides[1]}, {sides[2]}");
        }

        sidesValues = new double[][]
        {
            new double[] { 2, 3, 5 },           
            new double[] { 1, 110, 2 },
            new double[] { 1.45, 2.54, 0.01 },
            new double[] { 300, 200, 100 },
        };
        for (int i = 0; i < sidesValues.Length; i++) 
        {
            double[] sides = sidesValues[i];
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sides[0], sides[1], sides[2]), $"Sides: {sides[0]}, {sides[1]}, {sides[2]}");
        }
    }
}