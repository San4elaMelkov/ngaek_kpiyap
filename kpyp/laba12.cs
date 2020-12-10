using System;
using System.Collections.Generic;
using System.Text;

namespace kpyp
{
    class laba12
    {
        public void print()
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                double log = Math.Log10(num);
                int n = (int)log == log ? (int)log : (int)log + 1;
                List<int> arr = new List<int>();
                for (int i = n - 1; i > -1; --i)
                {
                    if (num % 10 % 3 == 0)
                        arr.Add(num % 10);
                    num /= 10;
                }
                Console.WriteLine("Числа кратные 3 из строки");
                foreach (int i in arr)
                    Console.Write(i);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
          
    }
}
