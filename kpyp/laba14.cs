using System;

namespace kpyp
{

    class laba14
    {
        delegate void MyDelegate(int i);
        public static void print()
        {
            Class2 cls2 = new Class2();
            cls2.Bar(7);
            MyEvent e = new MyEvent();
            Class1 cls1 = new Class1();
         
            MyDelegate deleg = cls1.Method2;
            deleg += Class1.Method1;
            e.myEvent += deleg;
            e.OnMyEvent(43);
        }

        class Class1
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
        class Class2
        {

            string name;
            public void Bar(int k)
            {
                Console.WriteLine("Выполнился метод Bar класса 2");

                Console.WriteLine(Math.Abs(k - 10));
            }
        }
        class MyEvent
        {
            private event MyDelegate _event;
            public event MyDelegate myEvent
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






}
