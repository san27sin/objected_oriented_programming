using System;
using System.Collections.Generic;
using System.IO;

namespace objected_oriented_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            var tower_1 = Building.Creater.CreateBuild(120, 200, 5);
            var tower_2 = Building.Creater.CreateBuild(200, 50, 10);
            var tower_3 = Building.Creater.CreateBuild(300, 190, 10);

            Building.Creater.DestroyBuild(tower_1);
            Building.Creater.DestroyBuild(tower_3);           
        }
    }
}
