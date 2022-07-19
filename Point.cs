using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objected_oriented_programming
{
    public class Point : Figure
    {
        private double _x;
        private double _y;

        public double X
        {
            get { return _x; }            
        }

        public double Y
        {
            get { return _y; }
        }

        public void MoveHorizontal(double x) => _x = x;

        public void MoveVertical(double y) => _y = y;

        public override string ToString()
        {
            return $"Точка: координаты х:{X} y:{Y}, цвет {Color}, визуально {Visible}.";
        }

        public Point(double x, double y, int color, bool visible) : base(color,visible)
        {
            _x = x;
            _y = y;
        }
    }
}
