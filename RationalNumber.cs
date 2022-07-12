using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objected_oriented_programming
{
    internal class RationalNumber
    {
        private int _numerator;
        private int _denominator;

        public int Numerator
        {
            get { return _numerator; }
            set
            {
                if (value < 0)
                    _numerator = 1;
                else
                    _numerator = value;
            }
        }

        public int Denominator
        {
            get { return _denominator; }
            set
            {
                if (value < 0)
                    _denominator = 1;
                else
                    _denominator = value;
            }
        }

        public RationalNumber(int numerator) : this(numerator, 1) { }
        public RationalNumber(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return (a.Numerator == b.Numerator && a.Denominator == b.Denominator);
        }

        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return (a.Numerator != b.Numerator || a.Denominator != b.Denominator);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            return obj is RationalNumber && this == (RationalNumber)obj;
        }

        public override int GetHashCode()
        {
            return Numerator ^ Denominator;
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
                return new(a.Numerator * b.Denominator + b.Numerator * b.Denominator, a.Denominator * b.Denominator);
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            if (a.Denominator == b.Denominator)
                return new(a.Numerator - b.Numerator, a.Denominator);
            else
                return new(a.Numerator * b.Denominator - b.Numerator * b.Denominator, a.Denominator * b.Denominator);
        }

        public static RationalNumber operator ++(RationalNumber a)
        {
            a.Numerator++;
            return a;
        }

        public static RationalNumber operator --(RationalNumber a)
        {
            a.Numerator--;
            if (a.Numerator == 0)
                a.Numerator = -1;
            return a;
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
            return a.Denominator * b.Numerator - a.Numerator * b.Denominator;
        }
    }
    

        
}
