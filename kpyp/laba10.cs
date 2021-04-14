using System;
using System.Collections.Generic;
using System.Text;

namespace kpyp
{
    class laba10
    {
        public static void print()
        {
            try
            {
                Console.WriteLine("Введите количество студентов ");
                int n = Convert.ToInt32(Console.ReadLine());
                int i;
                Student[] students = new Student[n];
                for (i = 0; i < n; i++)
                {
                    string name, group;
                    int year;
                    byte matem,inform,course, semester;
                    Console.Write("Введите ФИО студеннта: ");
                    name = Console.ReadLine();
                    Console.Write("Введите год рождения: ");
                    year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите название группы: ");
                    group = Console.ReadLine();
                    Console.Write("Введите номер курса: ");
                    course = Convert.ToByte(Console.ReadLine());
                    Console.Write("Введите номер семестрв: ");
                    semester = Convert.ToByte(Console.ReadLine());
                    Console.Write("Введите балл по математике: ");
                    matem = Convert.ToByte(Console.ReadLine());
                    Console.Write("Введите балл по информатике: ");
                    inform = Convert.ToByte(Console.ReadLine());
                    students[i] = new Student(name,year,group,course,semester,matem,inform);
                    Console.Clear();
                }
                Console.WriteLine("Введите количество школьников: ");
                n = Convert.ToInt32(Console.ReadLine());
                Schoolboy[] schoolboys = new Schoolboy[n];

                for (i = 0; i < n; i++)
                {
                    string name, shoolclass;
                    int year;
                    byte matem, inform, quarter;
                    Console.Write("Введите ФИО школьника: ");
                    name = Console.ReadLine();
                    Console.Write("Введите год рождения: ");
                    year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите название группы: ");
                    shoolclass = Console.ReadLine();
                    Console.Write("Введите номер курса: ");
                    quarter = Convert.ToByte(Console.ReadLine());
                    Console.Write("Введите балл по математике: ");
                    matem = Convert.ToByte(Console.ReadLine());
                    Console.Write("Введите балл по информатике: ");
                    inform = Convert.ToByte(Console.ReadLine());
                    schoolboys[i] = new Schoolboy(name, year, shoolclass, quarter,matem, inform);
                    Console.Clear();
                }
                Console.WriteLine("Школьники");
                Console.WriteLine("----------------------------------");
                foreach (Schoolboy schoolboy in schoolboys) schoolboy.Info();
                Console.WriteLine("Студенты");
                Console.WriteLine("----------------------------------");
                foreach (Student student in students) student.Info();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
    class Learner
    {
        public string name { get; protected set; }
        public int year { get; protected set; }
        public byte matem { get; protected set; }
        public byte inform { get; protected set; }
        public double ball { get; protected set; }

    }
    class Student : Learner 
    {
        public string group { get; private set; }
        public byte course { get; private set; }
        public byte semester { get; private set; }
        public Student(string __name, int __year,string __group, byte __course, byte __semestr,byte __matem, byte __inform)
        {
            this.name = __name;
            this.year = __year;
            this.group = __group;
            this.course = __course;
            this.semester = __semestr;
            this.matem = __matem;
            this.inform = __inform;
            this.ball = (this.matem + this.inform) / 2;
        }
        public void Info()
        {
            Console.WriteLine($"ФИО: {name}\n" +
                $"Год рождения: {year}\n" +
                $"Группа: {group}\n" +
                $"Курс: {course}\n" +
                $"Семестр: {semester}\n" +
                $"Балл по математике: {matem}\n" +
                $"Балл по информатике: {inform}");
            Console.WriteLine();
        }
    }
    class Schoolboy : Learner
    {
        public string shoolclass { get; private set; }
        public byte quarter { get; private set; }
        public Schoolboy(string __name, int __year, string __shoolclass, byte __quarter, byte __matem, byte __inform)
        {
            name = __name;
            year = __year;
            shoolclass = __shoolclass;
            quarter = __quarter;
            matem = __matem;
            inform = __inform;
            ball = (matem + inform) / 2;
        }
        public void Info()
        {
            Console.WriteLine($"ФИО: {name}\n" +
                $"Год рождения: {year}\n" +
                $"Класс: {shoolclass}\n" +
                $"Четверть: {quarter}\n" +
                $"Балл по математике: {matem}\n" +
                $"Балл по информатике: {inform}");
            Console.WriteLine();
        }
    }


}
