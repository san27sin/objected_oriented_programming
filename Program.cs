using System;

namespace objected_oriented_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10, 50, 1, false);
            Console.WriteLine(point.ToString());

            var circle_1 = new Circle(10);
            var circle_2 = new Circle(15,0,5,2,true);

            circle_2.Visible = false;
            circle_2.Radius = 25;
            circle_2.MoveHorizontal(20);
            circle_2.MoveVertical(40);
            double cSquare = circle_2.Square();
            Console.WriteLine(circle_2.ToString());

            var rectangle_1 = new Rectangle(140, 200);
            var rectangle_2 = new Rectangle(40, 30, 30, 0, 1, true);
            double rSquare = rectangle_2.Square();
            rectangle_2.MoveHorizontal(123);
            rectangle_2.MoveVertical(45);

            Console.WriteLine(rectangle_2.ToString());
        }
    }
}
