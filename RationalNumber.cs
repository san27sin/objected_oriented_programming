using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objected_oriented_programming
{
    readonly struct RationalNumber//структура вместо класса из-за быстродействия, МАЛО ДАННЫХ
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public int Numerator
        {
            get { return _numerator; }
            
        }

        public int Denominator
        {
            get { return _denominator; }
        }

        public RationalNumber(int numerator) : this(numerator, 1) { }
        public RationalNumber(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !a.Equals(b);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj is RationalNumber)
            {
                RationalNumber b = (RationalNumber)obj;
                return (this.Numerator == b.Numerator && this.Denominator == b.Denominator);
            }
                
            else
                return false;
        }

        public override int GetHashCode()
        {
            //return Numerator ^ Denominator; -- Плохой hashсode из-за того что может повторится с другим объектом
            return Tuple.Create(Numerator, Denominator).GetHashCode();
        }

        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            if (a.Denominator == b.Denominator)
                return a.Numerator > b.Numerator;
            else
            {
                return a.Numerator * b.Denominator > b.Numerator * a.Denominator;
            }
        }

        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            if (a.Denominator == b.Denominator)
                return a.Numerator < b.Numerator;
            else
            {
                return a.Numerator * b.Denominator < b.Numerator * a.Denominator;
            }
        }

        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            if (a.Denominator == b.Denominator)
                return (a.Numerator > b.Numerator) || (a.Numerator == b.Numerator);
            else
                return (a.Numerator * b.Denominator > b.Numerator * a.Denominator) || (a.Numerator * b.Denominator == b.Numerator * a.Denominator);
        }

        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            if (a.Denominator == b.Denominator)
                return (a.Numerator < b.Numerator) || (a.Numerator == b.Numerator);
            else
                return (a.Numerator * b.Denominator < b.Numerator * a.Denominator) || (a.Numerator * b.Denominator == b.Numerator * a.Denominator);
        }

        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            if (a.Denominator == b.Denominator)
                return new(a.Numerator + b.Numerator, a.Denominator);
            else
                return (double)a.Numerator / a.Denominator > (double)b.Numerator / b.Denominator;
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            if (a.Denominator == b.Denominator)
                return new(a.Numerator - b.Numerator, a.Denominator);
            else
                return new(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        }


        //надо ли создавать новую структуру при унарной операции
        public static RationalNumber operator ++(RationalNumber a)
        {
            int num = a.Numerator;
            return new RationalNumber(++num, a.Denominator);
        }

        public static RationalNumber operator --(RationalNumber a)
        {
            if (a.Numerator == 0)
                return a;
            else
            {
                int num = a.Numerator;
                return new RationalNumber(--num, a.Denominator);
            }            
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public static explicit operator double(RationalNumber a)
        {
            return (double)((double)a.Numerator / (double)a.Denominator);
        }

        public static explicit operator float(RationalNumber a)
        {
            return (float)((float)a.Numerator / (float)a.Denominator);
        }

        public static explicit operator int(RationalNumber a)
        {
            return (int)((int)a.Numerator / (int)a.Denominator);
        }

        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            return new(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            return new(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }

        public static int operator %(RationalNumber a, RationalNumber b)
        {
            int num = a.Numerator * b.Denominator;
            int den = b.Numerator * a.Denominator;
            return num % den;
        }
    }
    

        
}
