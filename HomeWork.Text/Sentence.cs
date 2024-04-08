using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Text
{
    public class Sentence
    {

        public static void Getsentence(string text)
        {
            Queue<string> Result = new Queue<string>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.' || text[i] == '!' || text[i] == '?')
                {
                    string SubText = text.Substring(0, i + 1);
                    text = text.Substring(i + 1);
                    i = 0;
                    Result.Enqueue(SubText);
                }
            }
            Console.WriteLine("Восклицательные предложения :");
            foreach (string result in Result)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '!')
                    {
                        Console.WriteLine(result);
                    }
                }
            }
            Console.WriteLine("Вопросительные предложения :");
            foreach (string result in Result)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == '?')
                    {
                        Console.WriteLine(result);
                    }
                }
            }
        }


        public static void Getcomma(string text)
        {
            Queue<string> Result = new Queue<string>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.' || text[i] == '!' || text[i] == '?')
                {
                    string SubText = text.Substring(0, i + 1);
                    text = text.Substring(i + 1);
                    i = 0;
                    Result.Enqueue(SubText);
                }
            }
            foreach (string result in Result)
            {
                int j = 0;
                for (int i = 0; i < result.Length; i++)
                {

                    if (result[i] == ',')
                    {
                        j++;
                    }
                }
                if (j == 0) Console.WriteLine(result);
            }
        }
    }
}
