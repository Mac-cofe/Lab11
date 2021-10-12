using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            double k;
            double b;
            Console.WriteLine("Решение уравнения вида kx+b=0");
            Console.WriteLine();

            Equaition exp = new Equaition();                        // 1 вариант. Задание значений в коде
            exp.k = 5;
            exp.b = -6;
            exp.Solution();

            Console.WriteLine();
            Equaition exp2 = new Equaition() { k = -4, b = 11 };   // 2 вариант. Использование инициализатора
            exp2.Solution();

            Console.WriteLine();
            Equaition exp3 = new Equaition();                       // 3 вариант. Задание значений пользователем
            
            try                                                             // здесь получилось обработать исключение
            {
                Console.WriteLine("Введите значение коэффициента k");
                k = Convert.ToDouble(Console.ReadLine());
                exp3.k = k;
                Console.WriteLine("Введите значение b");
                b = Convert.ToDouble(Console.ReadLine());
                exp3.b = b;
                exp3.Solution();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
        struct Equaition
        {
            public double k;
            public double b;
            double x;

            public void Solution()
            {
                if (b > 0)
                    Console.WriteLine("Уравнение {0}x+{1}=0", k, b);
                else
                    Console.WriteLine("Уравнение {0}x-{1}=0", k, Math.Abs(b));

                try
                {
                    if (k != 0)                                         // пыталась здесь тоже использовать try,catch, но не ловит ноль (может потому что k-double?)
                {
                    x = -b / k;
                    Console.WriteLine("    x={0,5:f2}", x);
                }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
