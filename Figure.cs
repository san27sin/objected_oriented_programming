using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objected_oriented_programming
{
    public abstract class Figure
    {
        private int _color;
        private bool _visible;

        public int Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public bool Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }
        
        protected Figure(int color, bool visible)
        {
            _color = color;
            _visible = visible;
        }
    }
}
