using System;
using System.Linq;


namespace kpyp
{
    class laba4
    {
        static string MaxElement(int[] Arr)
        {
            int Result = Arr.Select(w => w = w % 2 == 0 ? w : -1).Max();
            return string.Join(" ", Result == -1 ? "not found" : Result.ToString());
        }
        static bool isDecreases(int n)
        {
            int m4 = n % 10;
            int m3 = n / 10 % 10;
            int m2 = n / 10 / 10 % 10;
            int m1 = n / 10 / 10 / 10 % 10;
            return m1 > m2 && m2 > m3 && m3 > m4;
        }
        public void print()
        {
            Console.WriteLine("лаба 4");
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите четырехзначное число");
            try {
                int n = Convert.ToInt32(Console.ReadLine());
                while (n < 1000 || n >9999)
                {
                    Console.WriteLine("Введенное число не четырех значное");
                    n = Convert.ToInt32(Console.Read());
                }
                if (isDecreases(n)) Console.Write($" - Да");
                else Console.Write($" - Нет");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Произошла ошибка {e.Message}");
            }
            Console.WriteLine("Для продолжения программы нажмите ENTER");
            Console.Read();
            Console.Clear();

            Console.WriteLine("Задание 2");
            int[] arr = new int[4];
            try
            {
                int i;
                for (i = 0; i < 4; i++)
                {
                    Console.WriteLine($"Введите {i+1}-е число");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(MaxElement(arr));

            }
            catch (Exception e)
            {
                Console.WriteLine($"Произошла ошибка {e.Message}");
            }
            
        }
    }
}
