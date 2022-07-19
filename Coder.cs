using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objected_oriented_programming
{
    public abstract class Coder
    {
        protected string _text;
        protected char[] _letters;
        protected bool _encode;

        public string Text { get { return _text; } }

        public bool EncodeCondition { get { return _encode; } }

        protected Coder()
        {

        }
    }
}
