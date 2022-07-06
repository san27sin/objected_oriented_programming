using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objected_oriented_programming
{
    public class Building
    {
        private int _NumberOfTheBuilding, _NumberOfTheFloors, _NumberOfTheFlats, _NumberOfTheEntrences;
        private double _Height;
        private static int _Number;


        public int NumberOfTheBuilding
        {
            get { return _NumberOfTheBuilding; }
        }

        public int NumberOfTheFloor
        {
            private set { _NumberOfTheFloors = value; }

            get { return _NumberOfTheFloors; }
        }

        public int NumberOfTheFlats//задать в конструкторе
        {
            set
            {
                if (value <= 0)
                    _NumberOfTheFlats = 1;

                else
                    _NumberOfTheFlats = value;
            }

            get { return _NumberOfTheFlats; }
        }

        public int NumberOfTheEntrences
        {
            set
            {
                if (value <= 0)
                    _NumberOfTheEntrences = 1;

                else
                    _NumberOfTheEntrences = value;
            }

            get { return _NumberOfTheEntrences; }
        }

        public double Height
        {
            set
            {
                if (value <= 3)
                {
                    _Height = 3;
                    return;
                }
                if (value >= 828)
                {
                    _Height = 828;
                    return;
                }
                else
                    _Height = value;
            }

            get { return _Height; }
        }

        public void Print()
        {
            Console.WriteLine($"Номер здания №{NumberOfTheBuilding}\tВысота {Height}м\t" +
                $"Кол-во: квартир {NumberOfTheFlats}, подъездов {NumberOfTheEntrences}, этажей {NumberOfTheFloor}м\n" +
                $"высота этажа {TheHeightOfTheFloor()}\tкол-во квартир: в подъезде {TheNumberOfTheFlatsInAnEntrance()}\t" +
                $"на этаже {TheNumberOfTheFlatsOnTheFloor()}");
        }

        private int TheHeightOfTheFloor()
        {
            return (int)Height / NumberOfTheFloor;//кол-во этажей получается ноль
        }

        private int TheNumberOfTheFlatsInAnEntrance()
        {
            return NumberOfTheFloor/ NumberOfTheEntrences;
        }

        private int TheNumberOfTheFlatsOnTheFloor()
        {
            return NumberOfTheFlats / NumberOfTheFloor;
        }

        private void GenerateTheNumberOfTheBuilding()
        {
            _NumberOfTheBuilding = ++_Number; 
        }                

        public Building(double height, int numberOfTheFlats, int numberOfTheEntrences)
        {
            Height = height;
            NumberOfTheFlats = numberOfTheFlats;
            NumberOfTheEntrences = numberOfTheEntrences;
            NumberOfTheFloor = (int)Height / 3;
            GenerateTheNumberOfTheBuilding();
        }
    }
}
