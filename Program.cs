using System;

namespace objected_oriented_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10, 20, 1, true);
            IMove move = point;
            move.MoveHorizontal(80);
            move.MoveVertical(150);
            Console.WriteLine(point.ToString());


            var circle = new Circle(100);
            circle.Visible = true;
            IMathFigure square = circle;
            square.Square();
            Console.WriteLine(circle.ToString());


            var rectangle = new Rectangle(100, 20);
            rectangle.Visible = false;
            rectangle.MoveVertical(400);
            double area = rectangle.Square();
            Console.WriteLine(rectangle.ToString());
        }
    }
}
