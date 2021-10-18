using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13Version2
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "ул. Ленина дом.2";
            double length = 15;
            double width = 15;
            double height = 15;
            int level = 5;
            // Вывод результата
            Console.WriteLine("Родительский метод");
            Building building = new Building(address, length, width, height);
            building.Print();
            Console.WriteLine();
            Console.WriteLine("Дочерний метод");
            MultiBuilding multiBuilding = new MultiBuilding(address, length, width, height, level);
            multiBuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {// Поля
        public string Address { get; set; }
        private double length;
        private double width;
        private double height;
        // Свойства
        public double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Длина здания должна быть больше нуля!");
                }
            }
            get
            {
                return length;
            }
        }
        public double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Ширина здания должна быть больше нуля!");
                }
            }
            get
            {
                return width;
            }
        }
        public double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Высота здания должна быть больше нуля!");
                }
            }
            get
            {
                return height;
            }
        }
        //Конструктор
        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }
        //Метод Print
        public void Print()
        {
            if (Length == 0 && Width == 0 && Height == 0)
            {
                Console.WriteLine("Ошибка ввода данных!");
            }
            else
            {
                Console.WriteLine("Адрес здания: {0}", Address);
                Console.WriteLine("Длина х  Ширина х Высота = {0}м x {1}м x {2}м", Length, Width, Height);
            }

        }
    }
    sealed class MultiBuilding : Building
    {//Поля
        private int level;
        public int Level
        {
            set
            {
                if (value > 0)
                {
                    level = value;
                }
                else
                {
                    Console.WriteLine("Количество этажей должно быть больше нуля!");
                }
            }
            get
            {
                return level;
            }
        }

        // Конструктор
        public MultiBuilding(string address, double length, double width, double height, int level)
            : base(address, length, width, height)
        {
            Level = level;
        }
        // метод Print
        public void Print()

        {
            base.Print();
            Console.WriteLine("Колличество этажей {0}", Level);
        }

    }

}
