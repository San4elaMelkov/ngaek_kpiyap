using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kpyp
{
    class laba5
    {
        public static void print()
        {
            
            try
            {
                Console.WriteLine("Введите количество файлов");
                int n = Convert.ToInt32(Console.ReadLine());
                int i;
                Files[] files = new Files[n];
                for (i = 0; i < n; i++)
                {
                    files[i] = new Files();
                    Console.Clear();
                }
                Console.WriteLine("Создание файлов закончено!!!");
                Console.WriteLine("Для продолжения программы нажмите ENTER");
                Console.Read();
                Console.Clear();
                Console.WriteLine("Список файлов упорядоченный в алфовитном порядке");
                string[] names = new string[files.Length];
                for (i = 0; i < files.Length; i++) names[i] = files[i].Name;
                //-------------------
                Console.WriteLine("Отсортированный массив");
                Array.Sort(names);
                foreach (string name in names) Console.Write(name + " ");
                //---------------------
                Console.WriteLine("Введите размер файла для вывода");
                int size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Список файлов размер которых больше заданного");
                foreach (Files file in files) if (file.Size > size) Console.WriteLine(file.Size);
                //---------------
                Console.WriteLine("Введите количество обращений для вывода");
                int count = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Список файлов количество обращений которых больше заданного");
                foreach (Files file in files) if (file.Count > count) Console.WriteLine(file.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
           
        }
        
    }
    class Files
    {
         string name;
         int size;
         DateTime date;
         int count;
        //----------------SET()-------------------
        public string Name{get{return name;} set{name = value;}}
        public int Size { get { return size; } set { size = value; } }
        public DateTime Date { get { return date; } set { DateTime date = value;} }
        public int Count { get { return count; } set { count = value; } }

        //----------------SHOW()-------------------
        public void ShowName()
        {
            Console.WriteLine($"Имя файла: {this.name}");
        }
        public void ShowSize()
        {
            Console.WriteLine($"Размер файла: {this.size}");
        }
        public void ShowDate()
        {
            Console.WriteLine($"Дата создания файла: {this.date}");

        }
        public void ShowCount()
        {
            Console.WriteLine($"Количество обращений: {this.count}");
        }
        public Files()
        {
            Console.Write("Введите имя файла: ");
            name = Console.ReadLine();
            Console.Write("Введите размер файла: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите введите количество обращений к файлу: ");
            count = Convert.ToInt32(Console.ReadLine());
            //------------
            int y = -1;
            int m = -1;
            int d = -1;
            while (y <= 0)
            {
                Console.Write("Введите год создания: ");
                y = int.Parse(Console.ReadLine());
            }
            while (m <= 0 || m > 12)
            {
                Console.Write("Введите месяц создания: ");
                m = int.Parse(Console.ReadLine());            
            }
            while (d <= 0 || d > 30)
            {
                Console.Write("Введите день создания: ");
                d = int.Parse(Console.ReadLine());
            }
            date = new DateTime(y, m, d);
            
        }

    }
}
