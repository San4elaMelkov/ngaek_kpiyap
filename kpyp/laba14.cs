using System;

namespace kpyp
{

    class laba14
    {
        delegate double MyDelegate(int i);
        public static void print()
        {
            Class14_2 cls2 = new Class14_2();
            cls2.Bar(7);
            MyEvent e = new MyEvent();
            Class14_1 cls1 = new Class14_1();
            e.myEvent += cls1.Method2;
            e.myEvent += Class14_1.Method1;
            e.OnMyEvent(43);
        }

    }




    class Class14_1
    {
        
        public static void Method1(int m)
        {
            Console.WriteLine("Выполнился метод 1");
            Console.WriteLine(2 * m / (Math.Log(2)));
        }

        public void Method2(int i)
        {
            Console.WriteLine("Выполнился метод 2");
            Console.WriteLine(2 * i * 2.7);
            
        }
    }

    class Class14_2
    {

        public void Bar(int k)
        {
            Console.WriteLine("Выполнился метод Bar класса 2");

            Console.WriteLine(Math.Abs(k - 10)); 
        }
    }
    delegate void myDelegate(int k);
    class MyEvent
    {
        private event myDelegate _event;
        public event myDelegate myEvent
        {
            add
            {
                _event = value;
            }

            remove
            {
                _event = null;
            }

        }

        public void OnMyEvent(int k)
        {
            _event(k);
        }
    }

}
