using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objected_oriented_programming
{
    public class ACoder : ICoder
    {
        private string _text;
        private char[] _letters;
        private bool _encode;

        public string Text { get { return _text; } }

        public bool EncodeCondition { get { return _encode; } }
               
        public void Encode()
        {
            if(EncodeCondition == false)
            {
                _letters = _text.ToCharArray();
                for (int i = 0; i < _letters.Length; i++)
                {
                    _letters[i] = (char)((int)_letters[i] + 1);
                }
                _text = new string(_letters);
                _encode = true;
            }            
        }

        public void Decode()
        {
            if(EncodeCondition == true)
            {
                _letters = _text.ToCharArray();
                for (int i = 0; i < _letters.Length; i++)
                {
                    _letters[i] = (char)((int)_letters[i] - 1);
                }
                _text = new string(_letters);
                _encode = false;
            }            
        }

        //сделать что сначала будет доступен метод Encode, а потом Decode
        public ACoder (string text)
        {
            _text = text;
            _encode = false;
        }
    }
}
