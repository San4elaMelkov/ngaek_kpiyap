using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpyp
{
    class laba2
    {
        public void print() 
        {
            Console.WriteLine("лаба 2");
            Console.WriteLine("Задание 1");

            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());
            double otv = Math.Pow(3, x) - 4 * x + (y-Math.Sqrt(Math.Abs(x)));
            Console.WriteLine($"Ответ = {otv}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите меньшее основание");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите большее основание");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите угол");
            double c = Convert.ToDouble(Console.ReadLine());
            double h = (a - b) / 2 * Math.Tan(c);
            double c1 = c*Math.PI/180;
            double otv2 = (a + b)*h / 2*c1;
            Console.WriteLine($"Прощадь трапеции = {otv2}");


        }
    }
}
