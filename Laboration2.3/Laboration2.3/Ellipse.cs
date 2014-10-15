using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2._3
{
    class Ellipse : Shape
    {
        public Ellipse(double length, double width)
            : base(length, width)
        {
            length = Length;
            width = Width;
        }

        public override double Area
        {
            get
            {
                double a = Length / 2;
                double b = Width / 2;

                return Math.PI * a * b;
            }
        }

        public override double Perimeter
        {
            get
            {
                double a = Length / 2;
                double b = Width / 2;

                return Math.PI * Math.Sqrt(2 * a * a + 2 * b * b);
            }

        }
    }
}
