using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            {


                //вывод информации в консоль
                Console.WriteLine("---------------------------------------------- ");
                Console.WriteLine("Введите информацию о фирме: ");
                Console.WriteLine("---------------------------------------------- ");
                Firma st1 = new Firma(); //создание объекта класса
                st1.Input();      //вызов метода ввода класса Firma

                Console.Clear(); //очищение консоли

                //вывод информации в консоль
                Console.WriteLine("----------------------------------------------- ");
                st1.Display();     //вызов метода вывода класса Firma
                Console.WriteLine("----------------------------------------------- ");

                Console.ReadKey();  //ожидание нажатия клавиши для завершение программы


            }
        }

    }
}

