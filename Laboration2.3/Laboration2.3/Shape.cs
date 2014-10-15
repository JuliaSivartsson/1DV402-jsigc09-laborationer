using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2._3
{
    public abstract class Shape
    {
        private double _length;
        private double _width;


        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;

        }

        public abstract double Area
        {
            get;
        }

        public abstract double Perimeter
        {
            get;

        }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Talet måste vara större än 0.");
                }
                else
                {
                    _length = value;
                }
            }

        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Talet måste vara större än 0.");
                }
                else
                {
                    _width = value;
                }
            }

        }


        public override string ToString()
        {
            string length = string.Format("Längd {0:F1} \nBredd {1:F1} \nOmkrets {3:F1} \nArea {2:F1}", Length, Width, Perimeter, Area);
            return length;
        }
    }
}