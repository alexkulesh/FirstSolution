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
                    // lengthOfTriangleSides[0] > 0 && 
                    // lengthOfTriangleSides[0] > 0 && 
                    // lengthOfTriangleSides[0] > 0 &&
                    // angle1 > 0 && angle1 < 180 &&
                    // angle2 > 0 && angle2 < 180 &&
                    // floor1 > 0 && floor2 > 0
                  Triangle triangle = new Triangle(44, lengthOfTriangleSides);
                  Square square = new Square(floor1);
                  Rhombus rhombus = new Rhombus(floor2, angle2);
                  CompoundFigure compoundFigure = new CompoundFigure(new ISimpleNAngle[] {triangle, square, rhombus});
                  compoundFigure.CalculateArea(compoundFigure.SimpleNAngles);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }
        } 
    }
}