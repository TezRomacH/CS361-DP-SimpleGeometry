using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    public class Rectangle : Shape
    {
        public double Side1 { get; }
        public double Side2 { get; }

        public Rectangle(double side1, double side2)
        {
            Side1 = GetNormilizedSide(side1);
            Side2 = GetNormilizedSide(side2);
        }

        public override double Area() => Side1 * Side2;

        public override string Print() =>
            $"Rectangle: sides: {Side1} {Side2}, area = {Area()}";
        private double GetNormilizedSide(double side)
        {
            return side > 0 ? side : 0;
        }
    }
}
