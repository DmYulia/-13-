using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _13_наследование
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "";
            long lenght = 0, weight = 0, height = 0;
            int floor = 0;
            WriteLine("Задайте параметры здания:");
        BA: Write("Адрес: ");
            try
            {
                address = ReadLine();
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                goto BA;
            }
        BL: Write("Длина: ");
            try
            {
                lenght = long.Parse(ReadLine());
                if (lenght <= 0) throw new Exception("Некорректные данные!");
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                goto BL;
            }
        BW: Write("Ширина: ");
            try
            {
                weight = long.Parse(ReadLine());
                if (weight <= 0) throw new Exception("Некорректные данные!");
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                goto BW;
            }
        BH: Write("Высота: ");
            try
            {
                height = long.Parse(ReadLine());
                if (height <= 0) throw new Exception("Некорректные данные!");
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                goto BH;
            }
        BF: Write("Количество этажей: ");
            try
            {
                floor = int.Parse(ReadLine());
                if (floor <= 0) throw new Exception("Некорректные данные!");
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                goto BF;
            }

            Building house = new Building(address, lenght, weight, height);
            MultiBuilding fhouse = new MultiBuilding(address, lenght, weight, height, floor);
            string q = "";
        Zero:
            WriteLine("             Введите код необходимого пункта меню:");
            WriteLine("1 - Вывести адрес здания.");
            WriteLine("2 - Вывести длину здания.");
            WriteLine("3 - Вывести ширину здания.");
            WriteLine("4 - Вывести высоту здания.");
            WriteLine("5 - Вывести этажность здания.");
            WriteLine("6 - Вывести данные здания без учета этажей.");
            WriteLine("7 - Вывести данные здания с учетом этажей.");
            WriteLine("q - Выход из программы.");
        Begin:
                try
                {
                    q = ReadLine();
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                    goto Begin;
                }
                switch (q)
                {
                case "1":
                    WriteLine($"Адрес здания: {house.Address} .");
                    WriteLine(""); Read();
                    goto Zero;
                case "2":
                    WriteLine($"Длина здания: {house.Lenght} cm.");
                    WriteLine(""); Read();
                    goto Zero;
                case "3":
                    WriteLine($"Ширина здания: {house.Weight} cm.");
                    WriteLine(""); Read();
                    goto Zero;
                case "4":
                    WriteLine($"Высота здания: {house.Height} cm.");
                    WriteLine(""); Read();
                    goto Zero;
                case "5":
                    WriteLine($"В здании {fhouse.Floor} этажей.");
                    WriteLine(""); Read();
                    goto Zero;
                case "6":
                    house.Print();
                    WriteLine(""); Read();
                    goto Zero;
                case "7":
                    fhouse.Print();
                    WriteLine(""); Read();
                    goto Zero;
                case "q":
                    goto End;
                default:
                    WriteLine("Введен несуществующий код пункта меню!");
                    goto Begin;
                }
        End:
            Write("");
        }
    }
}
