namespace Part17Task1P1
{
    public abstract class GeometricFigure
    {
        protected double area;
        protected double perimeter;

        protected GeometricFigure(double area, double perimeter)
        {
            this.area = area;
            this.perimeter = perimeter;
        }

        protected GeometricFigure(double area)
        {
            this.area = area;
        }

        public double Area
        {
            get => area;
            set => area = value;
        }

        public double Perimeter
        {
            get => perimeter;
            set => perimeter = value;
        }
    }
}