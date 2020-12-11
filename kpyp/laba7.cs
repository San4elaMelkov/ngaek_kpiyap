using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace kpyp
{
    class laba7
    {
        public static void print()
        {
            Console.WriteLine("Лаба 7");
            Console.WriteLine("Задание 1");
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            var str = s.Split().ToList();
            int min,max;
            min = max = str[0].Length;
            for (int i = 1; i < str.Count; i++)
            {
                if (min > str[i].Length) min = str[i].Length;
                if (max < str[i].Length) max = str[i].Length;
            }
            Console.WriteLine("Длина кратчайшего слова: " + min);
            Console.WriteLine("Длина длинейшего слова: " + max);
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите строку");
            string str1 = Console.ReadLine();
            var result = Regex.Replace(str1.Trim(), "\\s+", " ");
            Console.WriteLine($"Исправленная строка: {result}");
            

        }
    }
}
