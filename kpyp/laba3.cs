using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpyp
{
    class laba3
    {
        public void print()
        {
            try
            {
                Console.WriteLine("лаба 3");
                Console.WriteLine("Задание 1");
                string[] mes = new string[] { "январь зима", "ферваль зима", "март весна", "апрель весна", "май весна", "июнь всена", "июль всена", "август всена", "сентябрь всена", "октябрь всена", "ноябрь всена", "декабрь всена" };
                Console.WriteLine("Введите номер месяца");
                int n = Convert.ToInt32(Console.ReadLine());
                if (12 >= n && n>= 1) Console.WriteLine(mes[n - 1]);
                else Console.WriteLine("Такого месяца не существует");
                Console.WriteLine("Введите z");
                double z = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите k");
                double k = Convert.ToDouble(Console.ReadLine());
                double x = (k < 1) ? k * Math.Pow(z, 3): z*(z+1);
                double y = (Math.Log10(1 + Math.Pow(x, 2) + Math.Pow(Math.Cos(x + 1), Math.Pow(Math.E, k + x))));
                Console.WriteLine($"При k = {k}, y = {y}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Задание 2");
                double a = 0.0,itog=1.0;
                while (a <= 10)
                {
                    a += 0.1;
                    itog *= 1 + Math.Sin(a);
                }
                Console.WriteLine($"Ответ = {itog}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
