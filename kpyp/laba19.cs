using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace kpyp
{
    class laba19
    {
        public static int size = new Random().Next(3, 10);
        static object locker = new object();
        public static void print()
        {

            List<Roma> barans = Generator();
            Random rnd = new Random();
            Roma volk = new Roma(rnd.Next(size), rnd.Next(size),"Волк");
            Thread myThread;
            foreach (Roma baran in barans)
            {
                myThread = new Thread(baran.Move);
                myThread.Start();
            }
            myThread = new Thread(volk.Move);
            myThread.Start();
            Check check = new Check();
            barans = check.CollisionBaran(barans);
            barans = check.CollisionWolf(volk, barans);
        }
        private static List<Roma> Generator()
        {
            List<Roma> barans = new List<Roma>();
            Console.WriteLine("Введие количество овец");
            int i, n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (i = 0; i < n; i++)
                barans.Add(new Roma(rnd.Next(size), rnd.Next(size)));
            Console.WriteLine("Овцы сгенерированы");
            return barans;
        }
        class Check
        {
            public List<Roma> CollisionBaran(List<Roma> barans)
            {
                lock (locker)
                {
                    List<Roma> temp = barans;
                    int i, j;
                    for (i = 0; i < barans.Count; i++)
                    {
                        for (j = i; j < barans.Count && i != j; j++)
                        {
                            if (barans[i].X == barans[j].X && barans[i].Y == barans[j].Y)
                            {
                                Random rnd = new Random();
                                temp.Add(new Roma(rnd.Next(size), rnd.Next(size)));
                                Console.WriteLine($"Овцы размножились, теперь их осталось {temp.Count}шт");
                            }
                        }
                    }
                    return temp;
                }
            }
            public List<Roma> CollisionWolf(Roma wolf, List<Roma> barans)
            {
                lock (locker)
                {
                    foreach (Roma baran in barans)
                    {
                        if (wolf.X == baran.X && wolf.Y == baran.Y)
                        {
                            barans.Remove(baran);
                            Console.WriteLine($"Волк сьел овцу, теперь их осталось {barans.Count}шт");
                        }
                    }
                    return barans;
                }
            }
        }
        class Roma
        {
            public string Name { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
            public void Move()
            {
                lock (locker)
                {
                    Random rnd = new Random();
                    int difа = rnd.Next(-1, 1);
                    //проверка X
                    if (this.X + difа > size)
                        this.X += rnd.Next(-1, 0);
                    else if (this.X + difа < size)
                        this.X += rnd.Next(0, 1);
                    else
                        this.X += difа;

                    //проверка Y
                    difа = rnd.Next(-1, 1);
                    if (this.Y + difа > size)
                        this.Y += rnd.Next(-1, 0);
                    else if (this.Y + difа < size)
                        this.Y += rnd.Next(0, 1);
                    else
                        this.Y += difа;
                }
            }
            public Roma(int x= 0, int y=0, string name = "Овца")
            {
                this.Name = name;
                this.X = x;
                this.Y = y;
            }
            public void Info()
            {
                Console.WriteLine($"Имя {this.Name}\n" +
                    $"Позиция (x,y) {this.X},{this.Y}");
            }
        }
    }
}
