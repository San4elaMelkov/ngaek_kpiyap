using System;
using System.Collections.Generic;
using System.Text;

namespace kpyp
{
    class laba19
    {
        public static int size = new Random().Next(3, 10);
        public static void print()
        {
            
            List<Roma>[] barans = new List<Roma>[new Random().Next(2,3)];
            Roma volk = new Roma(new Random().Next(size), new Random().Next(size),"Волк");
            volk.Info();
        }
        class Roma
        {
            public string Name { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
            public void Move()
            {
                Random rnd = new Random();
                int difа = rnd.Next(-1, 1);
                //проверка X
                if (this.X + difа > size)
                    this.X += rnd.Next(-1, 0);
                else if(this.X+difа < size)
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
