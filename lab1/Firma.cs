using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Firma
    {
        
        
        //свойства класса
        public string Name { get; set; }         //свойство названия фирмы
        public string Adres { get; set; }       //свойство адреса фирмы
        public int Year { get; set; }          //свойство года основания фирмы
        public Firma()  //конструктор по умолчанию
        {
            Name = null;
            Adres = null;
            Year = 0;
        }
        public virtual void Display() //метод для вывода 
        {
            Console.WriteLine("Название фирмы: " + Name);
            Console.WriteLine("Адрес фирмы: " + Adres);
            Console.WriteLine("Год основания: " + Year);
        }
        public virtual void Input()  //метод для ввода
        {
            Console.WriteLine("Название фирмы:  ");
            Name = Console.ReadLine();
            Console.WriteLine("Адрес фирмы: ");
            Adres = Console.ReadLine();
            Console.WriteLine("Год основания: ");
            Year = Convert.ToInt32(Console.ReadLine());
        }
    }
}

    }
}
