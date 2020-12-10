using System;
using System.Collections.Generic;
using System.Text;

namespace kpyp
{
    class laba13
    {
        delegate double MyDelegate(int i);
        public void print()
        {
            Console.WriteLine("Статический метод Class1");
            MyDelegate d = Class1.Method1;
            Console.WriteLine("Введите число: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ответ: {d(k)}");

            Console.WriteLine("Метод Class1 экземпляра ");
            Class1 c1 = new Class1();
            d += c1.Method2;
            Console.WriteLine("Введите число: ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ответ: {d(k)}");

            Console.WriteLine("Метот Class2 ");
            Class2 c2 = new Class2();
            d = c2.Method;
            Console.WriteLine("Введите число: ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ответ: {d(k)}");

            Console.ReadLine();
        }
    }
    class Class1
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;
        public static double Method1(int m)
        {
            return 2*m/(Math.Log(2));
        }

        public double Method2(int i)
        {
            return 2*i*2.7;
        }
    }

    class Class2
    {
        public double Method(int k)
        {
            return Math.Abs(k-10);
        }
    }

}
