using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation equation;
            Console.WriteLine("Решим уравнение типа 0=kx+b:");
            Console.WriteLine("Введите k");
            equation.k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            equation.b = Convert.ToDouble(Console.ReadLine());

            equation.Root();            
            
            Console.ReadKey();

        }
        struct Equation
        {
            public double b;
            public double k;

            public void Root()
            {
                if (b == 0 && k == 0)
                {
                    Console.WriteLine("Корень уравнения равен: 0");
                }
                else
                {
                    if (k == 0)
                    {
                        Console.WriteLine("Деление на 0!");
                    }
                    else
                    {
                        Console.WriteLine("Корень уравнения равен: {0}", -b / k);
                    }
                }
                    
            }
        }
    }
}
