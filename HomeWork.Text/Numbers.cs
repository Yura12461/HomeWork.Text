using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Text
{
    public class Numbers
    {


        public static void GetQantity(string text)
        {
            string[] Substring = text.Split('.', '!', ' ', '?', ',');
            char[] Numbers = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];
            int QantityOfNumbers = 0;
            int RememberTheQantity = 0;
            Queue<string> Result = new Queue<string>();
            foreach (string Sub in Substring)
            {
                QantityOfNumbers = 0;
                for (int i = 0; i < Sub.Length; i++)
                {
                    for (int a = 0; a < Numbers.Length; a++)
                    {
                        if (Sub[i] == Numbers[a])
                        {
                            QantityOfNumbers++;
                        }
                    }
                }
                if (QantityOfNumbers >= RememberTheQantity)
                {
                    if (RememberTheQantity < QantityOfNumbers) { Result.Clear(); }
                    RememberTheQantity = QantityOfNumbers;
                    Result.Enqueue(Sub);
                }
            }
            if (RememberTheQantity == 0)
            {
                Result.Clear();
                Console.WriteLine("Не найдено слов с цифрами");
            }
            if (RememberTheQantity != 0)
            {
                foreach (string result in Result)
                {
                    Console.Write($"\nСлово - {result}  (Количество цифр - {RememberTheQantity})");
                }
            }
        }


        public static void NumberReplace(string text)
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
