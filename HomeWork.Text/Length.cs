using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Text
{
    public class Length
    {
        public static void GetLongest(string text)
        {
            string[] Substring = text.Split('.', '!', ' ', '?', ',', '"', ':');
            string Longest = Substring[0];
            foreach (string Sub in Substring)
            {
                if (Longest.Length < Sub.Length)
                {
                    Longest = Sub;
                }
            }
            int i = 0;
            foreach (string Sub in Substring)
            {
                if (Longest == Sub) i++;
            }
            Console.WriteLine($"\nРезультат : {Longest}\t(Количество символов - {Longest.Length})\t(Встречается в тексте - {i})");
        }
        static void NumberReplace(string text)
        {
            char[] Numbers = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];
            string[] Replace = ["Один", "Два", "Три", "Четыре", "Пять", "Шесть", "Семь", "Восем", "Девять", "Ноль"];
            for (int i = 0; i < text.Length; i++)
            {


                for (int j = 0; j < Numbers.Length; j++)
                {
                    if (text[i] == Numbers[j])
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(Replace[j]);
                        Console.ResetColor();
                        break;
                    }
                    if (j == 9 & Numbers[j] != text[i])
                    {
                        Console.Write(text[i]);
                    }
                }
            }
        }
    }
}
