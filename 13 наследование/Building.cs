using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _13_наследование
{
    public class Building
    {
        private long lenght = 0;
        private long weight = 0;
        private long height = 0;
        public Building(string address, long lenght, long weight, long height)
        {
            Address = address;
            Lenght = lenght;
            Weight = weight;
            Height = height;
        }
        public string Address { private set; get; } = "Not address";
        public long Lenght
        {
            set
            {
                if (value < 0) WriteLine("Некорректные днные!"); else lenght = value;
            }
            get
            {
                return lenght;
            }
        }
        public long Weight
        {
            set
            {
                if (value < 0) WriteLine("Некорректные днные!"); else weight = value;
            }
            get
            {
                return weight;
            }
        }
        public long Height
        {
            set
            {
                if (value < 0) WriteLine("Некорректные днные!"); else height = value;
            }
            get
            {
                return height;
            }
        }
        public void Print()
        {
            WriteLine($"Здание по адресу {Address} имеет размер (ДхШхВ) {Lenght}x{Weight}x{Height} cm.");
        }
    }
}
