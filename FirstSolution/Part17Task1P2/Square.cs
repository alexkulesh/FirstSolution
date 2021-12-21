using System;

namespace Part17Task1P2
{
    public class Square : ISimpleNAngle
    {
        private const int numberOfSides = 4;

        public Square(double floor)
        {
            if (floor > 0)
            {
                Floor = floor;
                NumberOfSides = numberOfSides;
                Area = floor * floor;
                Perimeter = floor * 4;
            }
            else
            {
                throw new ArgumentException("You put incorrect data creating Square object");
            }
        }

        public double Height { get; set; }

        public double Floor { get; set; }

        public double AngleBetweenFloorAndAdjacentSide { get; set; }

        public int NumberOfSides { get; set; }

        public double[] LengthOfSides { get; set; }

        public double Area { get; set; }

        public double Perimeter { get; set; }
    }
}