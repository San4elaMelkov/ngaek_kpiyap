using System;

namespace kpyp
{

    class laba14
    {
        delegate double MyDelegate(int i);
        public void print()
        {

            Class14_2 d = new Class14_2();
            d.Notify += DisplayMessage;
            d.Start(30);
            Console.WriteLine();
        }
        private static void DisplayMessage(int k)
        {
            Console.WriteLine($"В метод передано {k}");
        }
    }

    class Class14_1
    {
        
        public static void Method1(int m)
        {
            Console.WriteLine(2 * m / (Math.Log(2)));
        }

        public void Method2(int i)
        {
            Console.WriteLine(2 * i * 2.7);
            
        }
    }

    class Class14_2
    {
        public delegate void StartMethods(int k);
        public event StartMethods Notify;
        public void Start(int k)
        {
            Foobar(Bar,k);
            Notify?.Invoke(k);
            Foobar(Class14_1.Method1,k);
            Class14_1 a = new Class14_1();
            Foobar(a.Method2, k);
        }
        public void Foobar(StartMethods MyDelegate, int k)
        {
            MyDelegate(k);
        }
        public void Bar(int k)
        {
            Console.WriteLine(Math.Abs(k - 10)); 
        }
    }
}
