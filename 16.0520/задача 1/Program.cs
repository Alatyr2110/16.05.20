using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1
//ТАРАНУХА ЯНА
/*
  Создать программу, которая будет проверять корректность ввода логина. 
  Корректным логином будет строка от 2 до 10 символов, 
  содержащая только буквы латинского алфавита или цифры, 
  при этом цифра не может быть первой:
а) без использования регулярных выражений; 
*/
{
    class Program
    {
        public static bool LoginInput(string s)//
        {
            if (s.Length < 2 || s.Length > 10) 
            return false;

            if (Char.IsDigit(s[0]))//честно содрала из учебника
                return false;

            for (int i = 1; i < s.Length; i++)
                if (!(Char.IsLetterOrDigit(s[i]))) //это тоже
                    return false;
            return true;
        }

        static void Main(string[]args)
        {
            
            string login = Console.ReadLine();
            
            if (LoginInput(login)) 
                Console.WriteLine("Проверку прошли");
            else 
                Console.WriteLine("Прoверку не прошли");
         
            Console.ReadKey();

        }

    }

}