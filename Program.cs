using System;

namespace objected_oriented_programming
{  
    class Program
    {
        static void Main(string[] args)
        {
            Building tower_1 = new(100, 500, 4);
            tower_1.Print();

            Building tower_2 = new(50, 200, 6);
            tower_2.Print();
        }
    }
}
