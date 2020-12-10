using System;
using System.Collections.Generic;
using System.Text;

namespace kpyp
{
    class laba6
    {
        public void print()
        {
            Console.WriteLine("Лаба 6");
            Console.WriteLine("Задание 1");
            try
            {
                int[] arr = new int[10];
                int i,kr=7;
                for (i = 0; i < 10; i++)
                {
                    Console.Write($"Введите {i+1}-е число: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();
                int[] titki = SummaKrat(arr,kr);
                Console.WriteLine($"Количество чисел кратных {kr} = {titki[0]}");
                Console.WriteLine($"Сумма чисел кратных {kr} = {titki[1]}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Произошла ошибка {e.Message}");
            }
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadLine();
            Console.Clear();
            //-----------------------------------------------------------------------

            Console.WriteLine("Задание 2");
            try
            {
                
                Console.Write("Введите количество элементов массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
                int i;
                for (i = 0; i < n; i++)
                {
                    Console.Write($"Введите {i + 1}-е число: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Введите нижние число интервала: ");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите верхнее число интервала: ");
                int max = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"Максимальное число по модулю = {MaxModul(arr)}"); 
                Console.WriteLine("Преобразованный массив:");
                Console.WriteLine($"Сумма чисел по модулю = {SummaModul(arr)}");
                Console.WriteLine("Начальный массив:");
                for (i = 0; i < n; i++)
                {
                    Console.Write($"{arr[i]} ");
                }
                Console.WriteLine();
                Console.WriteLine("Преобразованный массив:");
                int[] mass = Pereobr(arr,min,max);
                for (i = 0; i < n; i++)
                {
                    Console.Write($"{mass[i]} ");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Произошла ошибка {e.Message}");
            }
        }
        static int[] SummaKrat(int[] arr, int kr)
        {
            int[] titki = new int[2];
            int i;
            for (i = 0; i < 10; i++)
            {
                if (arr[i] % kr== 0)
                {
                    titki[0]++;
                    titki[1] += arr[i];
                }
            }
            return titki;
        }
        static int SummaModul(int[] arr)
        {
            bool positive=false;
            int i,summ=0,n;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) {
                    positive = true;
                    break;
                } 
            }
            if (positive)
                for (n = i; n < arr.Length; n++)
                {
                    summ += arr[n];
                }
            else { 
                Console.WriteLine("Положительных чисел не найдено");
                return 0;
            }
            return summ;
        }
        static int MaxModul(int[] arr)
        {
            int i,max;
            max = Math.Abs(arr[0]);
            for (i = 1; i < arr.Length; i++)
            if (max < Math.Abs(arr[i]))
                max = Math.Abs(arr[i]);
            return max;
        }
        static int[] Pereobr(int[] arr,int min, int max)
        {
            int i,n=0;
            int[] titki = new int[arr.Length];
            int[] siski = new int[arr.Length];
            

            for (i = 0; i < arr.Length; i++)
            {
                if (min < arr[i] && arr[i]<max)
                {
                    titki[i] = arr[i];
                    n++;
                }
                else
                {
                    siski[i] = arr[i];
                }
            }
            for(i = 0; i < siski.Length-n; i++)
            {
                titki[i + n] = siski[i];
            }
            return titki;
        }
    }
}
