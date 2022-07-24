using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objected_oriented_programming
{
    public class Circle : Point, IMathFigure
    {
        private const double pi = Math.PI;
        private double _radius;

        public double Square() => pi * _radius * _radius;
        
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public override string ToString()
        {
            return $"Окружность: координаты х:{X} y:{Y},площадь {Square()} см^2, цвет {Color}, визуально {Visible}.";
        }

        public Circle(double radius):base(0,0,0,true)
        {
            _radius = radius;
        }        

        public Circle(double radius, double x, double y, int color, bool visible) : base(x, y, color, visible)
        {
            _radius = radius;
        }
    }
}
