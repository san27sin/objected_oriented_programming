using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objected_oriented_programming
{
    public class BCoder : ICoder
    {
        private string _text;
        private char[] _letters;
        private bool _encode;

        public string Text { get { return _text; } }

        public bool EncodeCondition { get { return _encode; } }

        public void Encode()
        {
            if (EncodeCondition == false)
            {
                _letters = _text.ToCharArray();
                for (int i = 0; i < _letters.Length; i++)
                {
                    int number = (int)_letters[i];
                    if(number >= 65 && number <= 90)
                    {
                        _letters[i] = (char)(90 - (number - 65));
                    }
                    if(number >= 97 && number <= 122)
                    {
                        _letters[i] = (char)(122 - (number - 97));
                    }
                }
                _text = new string(_letters);
                _encode = true;
            }
        }

        public void Decode()
        {
            if (EncodeCondition == true)
            {
                _letters = _text.ToCharArray();
                for (int i = 0; i < _letters.Length; i++)
                {
                    int number = (int)_letters[i];
                    if (number >= 65 && number <= 90)
                    {
                        _letters[i] = (char)(65 + (90 - number));
                    }
                    if (number >= 97 && number <= 122)
                    {
                        _letters[i] = (char)(97 + (122 - number));
                    }
                }
                _text = new string(_letters);
                _encode = false;
            }
        }

        //сделать что сначала будет доступен метод Encode, а потом Decode
        public BCoder(string text)
        {
            _text = text;
            _encode = false;
        }
    }
}

