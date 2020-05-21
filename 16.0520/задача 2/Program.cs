using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
//ТАРАНУХА ЯНА
/*
Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения,  которые содержат не более n букв. 4 буквы
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
 */
{
    class Program
    {
        static void WordLeng(string s, int len)
        {
           string[] ss = s.Split(' ');
            foreach (string item in ss)
                if (item.Length == len)
                    Console.WriteLine(item);
                    //return;
        }
        static string WordDelLet(string s)
        {
            string[] ss = s.Split(' ');
            string newStr = "";
            foreach (string num in ss) //var - string? ругается; все равно ругается
                if (num[num.Length - 1] != 'ь')
                    if (num[num.Length - 1] != ',')
                        newStr += num + ' ';
           // Console.WriteLine(newStr);
            return newStr;
        }
        static int WordMax(string s)
        {
            int max = 0;
            string[] ss = s.Split(' ');
            foreach (string num in ss)
                if (max < num.Length) //здесь вообще ругается
                    max = num.Length; // минус запятая
            //Console.WriteLine(ss);
            //Console.WriteLine(max);
            return max;

        }
             static void Main(string[]args)
        {
            string s = "ноль , один , два , три , четыре , пять , шесть , семь , восемь , девять , десять , квакваква";
            Console.WriteLine(s);

            Console.WriteLine("Слова из 5 букв:"); WordLeng(s, 5); //как так???
            //Console.WriteLine(WordLeng(s, 5));

            Console.WriteLine("Слова без 'ь':");
            Console.WriteLine(WordDelLet(s));

            Console.WriteLine("Самое длинное слово состоит из  " + WordMax(s) + "  букв");
           // Console.WriteLine(WordMax(s));
            
            Console.ReadKey();
        }
        

        
    }
}
