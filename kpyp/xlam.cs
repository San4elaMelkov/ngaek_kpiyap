using System;
using System.Collections.Generic;
using System.Text;

namespace kpyp
{
    class xlam
    {
        public static void print()
        {
            Console.WriteLine("Введите длину окружности");//ввывод в консоль
            double l = Convert.ToDouble(Console.ReadLine());//ввод с клавиатуры
            double R = l / 2 * Math.PI;//считаем радиус
            double S = Math.PI * Math.Pow(R, 2);//считаем площадь
            Console.WriteLine($"Площадь окружности = {S}");//ввывод в консоль
            Console.WriteLine();
            Console.Write("Введите X:");//ввывод в консоль
            double X = Convert.ToDouble(Console.ReadLine());//ввод с клавиатуры
            double otvet = X - 10 * Math.Sin(X) + Math.Abs(Math.Pow(X, 4) - Math.Pow(X, 5));//считаем формулу
            Console.WriteLine($"Ответ: {otvet}");//ввывод в консоль
        }

    }
}
