using System;

namespace Part17Task1P2
{
    public class Rhombus : ISimpleNAngle
    {
        private const int numberOfSides = 4;

        public Rhombus(double floor, double angleBetweenFloorAndAdjacentSide)
        {
            if (angleBetweenFloorAndAdjacentSide > 0 &&
                angleBetweenFloorAndAdjacentSide < 180 &&
                floor > 0)
            {
                Floor = floor;
                NumberOfSides = numberOfSides;
                Area = (floor * floor) * Math.Sin(Math.PI * angleBetweenFloorAndAdjacentSide / 180);
                Perimeter = floor * 4;
            }
            else
            {
                throw new ArgumentException("You put incorrect data creating Rhombus object");
            }
        }

        public double Height { get; set; }

        public double Floor { get; set; }

        public double AngleBetweenFloorAndAdjacentSide { get; set; }

        public int NumberOfSides { get; set; }

        public double[] LengthOfSide { get; set; }

        public double Area { get; set; }

        public double Perimeter { get; set; }
    }
}