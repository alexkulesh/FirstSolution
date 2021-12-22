namespace Part17Task1P2
{
    public interface ISimpleNAngle
    {   
        double Height { get; set; }

        double Floor { get; set; }

        double AngleBetweenFloorAndAdjacentSide { get; set; }

        int NumberOfSides { get; set; }

        double [] LengthOfSide  { get; set; }

        double Area { get; set; }

        double Perimeter { get; set; }
    }
}