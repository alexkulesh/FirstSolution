using System;

namespace Part17Task1P2
{
    public class Task
    {
        private static void Main(string[] args)
        {
            double[] lengthOfTriangleSides = {5.4, 5.4, 4.5};
            double angle1 = 44;
            double angle2 = 55;
            double floor1 = 5;
            double floor2 = 4.5;

            try
            {
                  Triangle triangle = new Triangle(44, lengthOfTriangleSides);
                  Square square = new Square(floor1);
                  Rhombus rhombus = new Rhombus(floor2, angle2);
                  CompoundFigure compoundFigure1 = new CompoundFigure(new ISimpleNAngle[] {triangle, square, rhombus});
                  double area1 = compoundFigure1.CalculateArea(compoundFigure1.SimpleNAngles);
                  Console.WriteLine(area1);
                  CompoundFigure compoundFigure2 = new CompoundFigure(new ISimpleNAngle[] {triangle, square, rhombus, triangle});
                  double area2 = compoundFigure2.CalculateArea(compoundFigure2.SimpleNAngles);
                  Console.WriteLine(area2);
                  Console.WriteLine(compoundFigure1.Equals(compoundFigure2));
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }
        } 
    }
}