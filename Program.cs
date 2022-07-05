using System;

namespace objected_oriented_programming
{
    internal class Program
    {
        public static string Reverse (string str)
        {
            char[] letters = str.ToCharArray();
            for(int begin = 0, end = letters.Length -1; begin < letters.Length/2; begin++,end--)
            {
                char letter = letters[begin];
                letters[begin] = letters[end];
                letters[end] = letter;
            }
            return new string(letters);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("табуретка"));
            Console.WriteLine(Reverse("москва"));
        }
    }
}
