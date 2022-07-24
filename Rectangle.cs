using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objected_oriented_programming
{
    public class Rectangle : Point, IMathFigure
    {
        private double _width;
        private double _length;

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                    _width = 1;
                else
                    _width = value;
            }
        }

        public double Length
        {
            get { return _length; }
            set
            {
                if (value < 0)
                    _length = 1;
                else
                    _length = value;
            }
        }

        public double Square() => _width * _length;

        public override string ToString()
        {
            return $"Прямоугольник: координаты х:{X} y:{Y},площадь {Square()} см^2, цвет {Color}, визуально {Visible}.";
        }

        public Rectangle(double width, double length) : this(width, length, 0, 0, 0, true) { }
        
        public Rectangle(double width, double length, double x, double y, int color, bool visible) : base(x,y,color,visible)
        {
            Width = width;
            Length = length;
        }
    }
}
