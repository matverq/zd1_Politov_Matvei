using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_1_Politov_Matvei
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите количество котов");
                int count = Convert.ToInt32(Console.ReadLine());

                if (count <=0)
                {
                    Console.WriteLine("Введено неверное значение!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                Cat cats = new Cat("", 1);
                
                for (int i = 0; i < count; i++)
                {
                    cats = new Cat("", 1);
                    Console.WriteLine($"Кот: {i + 1}");
                    Console.WriteLine("Введите имя кота:");
                    cats.Name = Console.ReadLine();
                    Console.WriteLine("Введите вес кота");
                    cats.Mass = Convert.ToDouble(Console.ReadLine());
                    cats.Meow();
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Введено неверное значение!");
                Console.ReadKey();
            }
        }
    }
}
