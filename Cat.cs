using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_1_Politov_Matvei
{
    class Cat
    {
        private string name;
        // Свойство с проверкой на верное значение имени
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                bool OnlyLetters = true;
                foreach(var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }
                if(OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
        private double mass;
        // Свойство с проверкой на верные значения массы
        public double Mass
        {
            get
            {
                return mass;
            }
            set
            {
                if(value > 0 && value < 21)
                {
                    mass = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильный вес!!!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
        // Конструктор класса
        public Cat(string CatName, double CatMass)
        {
            Name = CatName;
            Mass = CatMass;
        }
        // Вывод информаци
        public void Meow()
        {
            Console.WriteLine($"Кот: {name} вес: {Mass} - МЯЯЯЯУ!!!!");
        }
    }
}
