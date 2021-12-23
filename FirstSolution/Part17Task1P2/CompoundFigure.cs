using System;

namespace Part17Task1P2
{
    public class CompoundFigure
    {
        private ISimpleNAngle[] simpleNAngles;
        private double area;

        public CompoundFigure(ISimpleNAngle[] simpleNAngles)
        {
            this.simpleNAngles = simpleNAngles;
        }

        public double CalculateArea(ISimpleNAngle[] simpleNAngles)
        {
            area = 0;

            for (int i = 0; i < simpleNAngles.Length; i++)
            {
                area += simpleNAngles[i].Area;
            }

            return area;
        }

        public ISimpleNAngle[] SimpleNAngles
        {
            get => simpleNAngles;
            set => simpleNAngles = value ?? throw new ArgumentNullException(nameof(value));
        }

        public double Area
        {
            get => area;
            set => area = value;
        }

        public override bool Equals(Object obj) => Equals(obj as CompoundFigure);

        public bool Equals(CompoundFigure compoundFigure) => Area == compoundFigure.Area;

        public override string ToString() =>
            $"Compound figure info: number of figures - {simpleNAngles.Length} ; total area - {Area}";
    }
}