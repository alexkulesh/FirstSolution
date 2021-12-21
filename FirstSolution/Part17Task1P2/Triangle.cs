using System;

namespace Part17Task1P2
{
    public class Triangle : ISimpleNAngle
    {
        private const int numberOfSides = 3;

        public Triangle(double angleBetweenFloorAndAdjacentSide, double[] lengthOfSides)
        {
            if (
                angleBetweenFloorAndAdjacentSide > 0 &&
                angleBetweenFloorAndAdjacentSide < 180 &&
                lengthOfSides[0] > 0 &&
                lengthOfSides[1] > 0 &&
                lengthOfSides[2] > 0 &&
                lengthOfSides[0] + lengthOfSides[1] > lengthOfSides[2] &&
                lengthOfSides[1] + lengthOfSides[2] > lengthOfSides[0] &&
                lengthOfSides[2] + lengthOfSides[0] > lengthOfSides[1]
                )
            {
                Height = lengthOfSides[1] * Math.Sin(Math.PI * angleBetweenFloorAndAdjacentSide / 180);
                Floor = lengthOfSides[0];
                NumberOfSides = numberOfSides;
                LengthOfSides = lengthOfSides;
                Area = (Height * Floor) / 2;
                foreach (var i in lengthOfSides)
                {
                    Perimeter += i;
                }
            }
            else
            {
                throw new ArgumentException("You put incorrect data creating Triangle object");
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