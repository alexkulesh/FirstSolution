using System;

namespace Part17Task1P2
{
    public class Rectangle : ISimpleNAngle
    {
        private const int numberOfSides = 4;

        public Rectangle(double height, double floor)
        {
            if (floor > 0 && height > 0)
            {
                Height = height;
                Floor = floor;
                NumberOfSides = numberOfSides;
                Area = floor * height;
                Perimeter = (floor + height) * 2;
            }
            else
            {
                throw new ArgumentException("You put incorrect data creating Rectangle object");
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