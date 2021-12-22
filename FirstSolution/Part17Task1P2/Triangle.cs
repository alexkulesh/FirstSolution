using System;

namespace Part17Task1P2
{
    public class Triangle : ISimpleNAngle
    {
        private const int numberOfSides = 3;

        public Triangle(double angleBetweenFloorAndAdjacentSide, double[] lengthOfSide)
        {
            if (angleBetweenFloorAndAdjacentSide > 0 &&
                angleBetweenFloorAndAdjacentSide < 180 &&
                lengthOfSide[0] > 0 &&
                lengthOfSide[1] > 0 &&
                lengthOfSide[2] > 0 &&
                lengthOfSide[0] + lengthOfSide[1] > lengthOfSide[2] &&
                lengthOfSide[1] + lengthOfSide[2] > lengthOfSide[0] &&
                lengthOfSide[2] + lengthOfSide[0] > lengthOfSide[1])
            {
                Height = lengthOfSide[1] * Math.Sin(Math.PI * angleBetweenFloorAndAdjacentSide / 180);
                Floor = lengthOfSide[0];
                NumberOfSides = numberOfSides;
                LengthOfSide = lengthOfSide;
                Area = (Height * Floor) / 2;
                foreach (var i in lengthOfSide)
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

        public double[] LengthOfSide { get; set; }

        public double Area { get; set; }

        public double Perimeter { get; set; }
    }
}