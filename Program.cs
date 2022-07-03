using System;

namespace objected_oriented_programming
{
   abstract class MOSGORGEOTREST
    {
        string ROLE { get; set; }
        public abstract void Act();
    }

    class CLient : MOSGORGEOTREST
    {
        
       public override void Act()
        {
            Console.WriteLine("Делаю заказа");
        }

    }

    class TreatySection : MOSGORGEOTREST
    {
        public override void Act()
        {
            Console.WriteLine("Заключаю договор");
        }
    }

    class TaskDepartment : MOSGORGEOTREST
    {
        public override void Act()
        {
            Console.WriteLine("Подготавливаю план работ!");
        }
    }

    class Laboratory : MOSGORGEOTREST
    {
        public override void Act()
        {
            Console.WriteLine("Делаю лабораторные испытания!");
        }
    }

    class FieldWork : MOSGORGEOTREST
    {
        public override void Act()
        {
            Console.WriteLine("Отбор проб из скважины!");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
