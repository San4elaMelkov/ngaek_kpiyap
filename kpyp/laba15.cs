using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kpyp
{
    class laba15 
    {
        public static void print()
        {
            List<Staf> stafs = new List<Staf>();
            stafs.Add(new Staf("Коловратов", "Х-15", 7300));
            stafs.Add(new Staf("Боброва", "Х-15", 25000));
            stafs.Add(new Staf("Лопатко", "П-9", 15000));
            stafs.Add(new Staf("Ленивцев", "Х-4", 5800));
            stafs.Add(new Staf("Нечитайло", "Х-15", 3000));
            stafs.Add(new Staf("Шорох", "Х-15", 10900));
            int totalPay = 0;
            var Staf_X_4 = from staf in stafs where staf.Otdel == "Х-4" select staf;
            var Staf_P_9 = from staf in stafs where staf.Otdel == "П-9" select staf;
            var Staf_X_15 = from staf in stafs where staf.Otdel == "Х-15" select staf;
            Otdel[] otdels = new Otdel[3];
            otdels[0].name = "Х-4";
            otdels[1].name = "П-9";
            otdels[2].name = "Х-15";
            for (int i = 0; i < otdels.Length; i++)
            {
                Console.WriteLine($"Введите зп для отдела {otdels[0].name}");
                otdels[i].minPay = double.Parse(Console.ReadLine());
            }
            
            foreach (Staf staf in Staf_X_4)
            {
                if (staf.Pay < otdels[0].minPay)
                {
                    Console.WriteLine($"Имя: {staf.SurName}\n" +
                        $"Отдел: {staf.Otdel}\n" +
                        $"Зарплата: {staf.Pay}\n");
                }
                otdels[0].pay += staf.Pay;
            }
            otdels[0].sredn = otdels[0].pay / Staf_X_4.Count();
            foreach (Staf staf in Staf_P_9)
            {
                if (staf.Pay < otdels[1].minPay)
                {
                    Console.WriteLine($"Имя: {staf.SurName}\n" +
                        $"Отдел: {staf.Otdel}\n" +
                        $"Зарплата: {staf.Pay}\n");
                }
                otdels[1].pay += staf.Pay;
            }
            otdels[1].sredn = otdels[1].pay / Staf_P_9.Count();
            foreach (Staf staf in Staf_X_15)
            {
                if (staf.Pay < otdels[2].minPay)
                {
                    Console.WriteLine($"Имя: {staf.SurName}\n" +
                        $"Отдел: {staf.Otdel}\n" +
                        $"Зарплата: {staf.Pay}\n");
                }
                otdels[2].pay += staf.Pay;
            }
            otdels[2].sredn = otdels[2].pay / Staf_X_15.Count();

        }
        struct Staf
        {
            public string SurName;
            public string Otdel;
            public double Pay;
            public Staf(string name, string otdel, double pay)
            {
                this.SurName = name;
                this.Otdel = otdel;
                this.Pay = pay;
            }
        }
        struct Otdel
        {
            public string name;
            public double pay;
            public double sredn;
            public double minPay;
        }
    }
}
