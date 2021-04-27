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
            Console.WriteLine($"Создано поле размером {size} На {size}");
            List<Roma> barans = Generator();
            Random rnd = new Random();
            Roma volk = new Roma(rnd.Next(size), rnd.Next(size),"Волк");
            Thread myThread;
            Check check = new Check();
            while (true)
            {
                foreach (Roma baran in barans)
                {
                    myThread = new Thread(baran.Move);
                    myThread.Start();
                }
                myThread = new Thread(volk.Move);
                myThread.Start();

                barans = check.CollisionBaran(barans);
                barans = check.CollisionWolf(volk, barans);
                if (barans.Count < 3)
                {
                    Console.WriteLine($"Осталось {barans.Count}. Игра окончена");
                    break;
                }
            }
            
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
                    Console.WriteLine("Провера овец");
                    List<Roma> temp = barans;
                    int i, j;
                    for (i = 0; i < barans.Count; i++)
                    {
                        for (j = i+1; j < barans.Count; j++)
                        {
                            if (barans[i].X == barans[j].X && barans[i].Y == barans[j].Y)
                            {
                                Random rnd = new Random();
                                temp.Add(new Roma(rnd.Next(size), rnd.Next(size)));
                                Console.WriteLine($"Овцы размножились, теперь их осталось {temp.Count}шт");
                            }
                        }
                    }
                    //Thread.Sleep(500);
                    return temp;
                }
            }
            public List<Roma> CollisionWolf(Roma wolf, List<Roma> barans)
            {
                lock (locker)
                {
                    Console.WriteLine("Провера волка и овец");
                    int i;
                    for ( i = 0; i < barans.Count; i++)
                    {
                        
                        if (wolf.X == barans[i].X && wolf.Y == barans[i].Y)
                        {
                            barans.Remove(barans[i]);
                            Console.WriteLine($"Волк сьел овцу, теперь их осталось {barans.Count}шт");
                        }
                    }
                    Thread.Sleep(300);
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
                    else if (this.X + difа < 0)
                        this.X += rnd.Next(0, 1);
                    else
                        this.X += difа;

                    //проверка Y
                    difа = rnd.Next(-1, 1);
                    if (this.Y + difа > size)
                        this.Y += rnd.Next(-1, 0);
                    else if (this.Y + difа < 0)
                        this.Y += rnd.Next(0, 1);
                    else
                        this.Y += difа;
                    Console.WriteLine("Выполнился метод Move");
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
