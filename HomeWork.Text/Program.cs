namespace HomeWork.Text
{
    class MyText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст\n");    
            string text = Console.ReadLine();
            do
            {
                Console.WriteLine("\n1 - Найти слова, содержащие максимальные количества цифр " +
                                  "\n2 - Найти самое длинное слово и количество его повторений" +
                                  "\n3 - Замена цифр словами " +
                                  "\n4 - Вывести восклицательные предложения, затем вопросительные" +
                                  "\n5 - Вывести предложения в которых нет запятых" +
                                  "\n0 - Закончить\n");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        Numbers.GetQantity(text);
                        break;
                    case ConsoleKey.D2:
                        Length.GetLongest(text);
                        break;
                    case ConsoleKey.D3:
                        Numbers.NumberReplace(text);
                        break;
                    case ConsoleKey.D4:
                        Sentence.Getsentence(text);
                        break;
                    case ConsoleKey.D5:
                        Sentence.Getcomma(text);
                        break;
                    case ConsoleKey.D0: break;
                    default:
                        Console.WriteLine("Неверный символ, повторите попытку");
                        break;
                }
                Console.WriteLine("\n\nНажмите любую клавишу, чтобы продолжить" +
                                  "\n0 - Закончить");
            } while (Console.ReadKey(true).Key != ConsoleKey.D0);
        }                              
    }
}