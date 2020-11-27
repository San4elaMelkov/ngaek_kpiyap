using System;
using System.Collections.Generic;
using System.Text;

namespace kpyp
{
    class laba9
    {
        public void print()
        {
            try
            {
                Console.WriteLine("Введите количество студентов");
                int n = Convert.ToInt32(Console.ReadLine());
                Student[] students = new Student[n];
                int i;
                for (i = 0; i < n; i++)
                {
                    students[i] = new Student(students[i].enterName(), students[i].enterYear(), students[i].enterGroup(), students[i].enterMatem(), students[i].enterFisic(), students[i].enterInform());
                    Console.WriteLine("Студент успешно создан");
                    Console.Clear();
                }
                Console.WriteLine("Все студенты успешно созданы");
                Console.WriteLine("Чтобы узнать лучших слудентов нажмите ENTER");
                Console.ReadLine();
                Console.Clear();
                for (i = 0; i < n; i++)
                {
                    if (students[i].isFisic(8) && students[i].isMatem(10)) students[i].Info();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        struct Student
        {
             string name;
             int year;
             int group;
             byte matem;
             byte fisic;
             byte inform;
             float ball;
            public Student(string n = "",int y=0,int g=0,byte m=0,byte f=0,byte i=0)
            {
                name = n;
                year = y;
                matem = m;
                fisic = f;
                group = g;
                inform = i;
                ball = (matem + fisic + inform) / 3;
            }

            public string enterName()
            {
                do
                {
                    Console.WriteLine("Введите ФИО");
                    name = Console.ReadLine();
                } while (name == "");
                return name;
            }
            public int enterYear()
            {
                do
                {
                    Console.WriteLine("Введите год рождения");
                    year = Convert.ToInt32(Console.ReadLine());
                } while (year <= 0);
                return year;
            }
            public byte enterMatem()
            {
                do
                {
                    Console.WriteLine("Введите балл по математике");
                    matem = Convert.ToByte(Console.ReadLine());
                } while (matem <= 0);
                return matem;
            }
            public int enterGroup()
            {
                do
                {
                    Console.WriteLine("Введите номер группы");
                    group = Convert.ToInt32(Console.ReadLine());
                } while (group <= 0);
                return group;
            }
            public byte enterFisic()
            {
                do
                {
                    Console.WriteLine("Введите балл по физике");
                    fisic = Convert.ToByte(Console.ReadLine());
                } while (fisic <= 0);
                return fisic;
            }
            public byte enterInform()
            {
                do
                {
                    Console.WriteLine("Введите балл по информатике");
                    inform = Convert.ToByte(Console.ReadLine());
                } while (inform <= 0);
                return inform;
            }
            public bool isMatem(int ball)
            {
                return matem >= ball;
            }
            public bool isFisic(int ball)
            {
                return fisic >= ball;
            }
            public void Info()
            {
                Console.WriteLine($"ФИО студента: {name}\n" +
                    $"Год рождения: {year}\n" +
                    $"Номер группы: {group}\n" +
                    $"Информатика: {inform}\n" +
                    $"Физика: {fisic}\n" +
                    $"Математика: {matem}\n" +
                    $"Средний балл: {ball}\n");
                Console.WriteLine();
            }
        }
    }
}
