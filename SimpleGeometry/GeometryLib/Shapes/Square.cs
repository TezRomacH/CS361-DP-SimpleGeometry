using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Квадрат
    /// </summary>
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }

        public override string Print() =>
            $"Square: side: {Side1}, area = {Area()}";
    }
}
