using System;
using System.Collections.Generic;
using System.IO;


namespace objected_oriented_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber a = new(3, 4);
            RationalNumber b = new(1, 8);

            Console.WriteLine(a==b);

            Console.WriteLine(a != b);

            Console.WriteLine(a.Equals(b));

            Console.WriteLine(a.GetHashCode());

            Console.WriteLine(b.GetHashCode());

            Console.WriteLine(a < b);

            Console.WriteLine(a > b);

            Console.WriteLine(a <= b);

            Console.WriteLine(a >= b);

            Console.WriteLine(a + b);

            Console.WriteLine(a - b);

            Console.WriteLine(++a);

            Console.WriteLine(++b);

            Console.WriteLine(--a);

            Console.WriteLine(--b);

            Console.WriteLine(a * b);

            Console.WriteLine(a / b);

            Console.WriteLine(a % b);

            Console.WriteLine(a.ToString());

            Console.WriteLine(b.ToString());
        }
    }
}
