using System;
using System.Collections.Generic;
using System.Text;

namespace kpyp
{
    class laba17
    {
        public static void print()
        {

            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(-10, 10);
            }
            Melkov<int> obj = new Melkov<int>();
            Console.WriteLine(obj.arraySum(arr));
            Console.WriteLine("----------------------------------------");
            foreach (int a in thinning<int>(arr,3,2))
            {
                Console.WriteLine(a); 
            }
        }
        public static T[] thinning<T>(T[] arr, int after, int before)
        {
            T[] mass = new T[arr.Length];
            int i;
            for (i = after; i+before < arr.Length; i+=before)
            {
                mass[i] = arr[i];
            }
            return mass;
        }
        class Melkov<T>
        {
            public int arraySum(T[] array)
            {
                int summ = 0;
                foreach(T a in array)
                {
                    summ += Convert.ToInt32(a);
                }
                return summ;
            }
        }
    }
}
