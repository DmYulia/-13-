using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _13_наследование
{
    sealed class MultiBuilding : Building
    {
        private int floor = 0;
        public int Floor
        {
            set
            {
                if (value < 0) WriteLine("Некорректные днные!"); else floor = value;
            }
            get
            {
                return floor;
            }
        }
        public MultiBuilding (string address, long lenght, long weight, long height, int floor) : base(address, lenght, weight, height)
        {
            Floor = floor;
        }
        public new void Print()
        {
            base.Print();
            WriteLine($"Здание имеет {Floor} этажей .");
        }
    }
}
