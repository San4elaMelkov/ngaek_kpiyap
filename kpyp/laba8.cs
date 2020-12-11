using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace kpyp
{
    class laba8
    {
        public static void print()
        {
            try
            {
                string pattern = "^((?!-)[A-Za-z0-9-]{1,63}(?<!-)\\.)+[A-Za-z]{2,6}$";
                while (true)
                {
                    Console.WriteLine("Введите домен");
                    string email = Console.ReadLine();

                    if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
                    {
                        Console.WriteLine("Веденная строка является доменом 2-го уровня");
                        break;
                    }
                    else Console.WriteLine("Веденная строка не является доменом 2-го уровня");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            

        }
    }
}
