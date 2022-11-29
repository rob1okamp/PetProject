using System;
using System.Threading;

namespace PetProject
{
    class Program
    {
        /*
         Здесь должен быть вызов
         */
        static void Main(string[] args)
        {
            // ВОТ
            Comparer comparer = new Comparer();

            if (comparer.Compare())
            {
                Console.WriteLine("Сравниваем");
                Thread.Sleep(3000);
                Console.WriteLine("\n\t" + comparer.Result);
            }
            else
                Console.WriteLine("Символы несравнимы");

            //Команда ожидания ввода любого символа с клавиатуры, чтобы программа не завершалась пока не нажмешь.
            Console.ReadKey();
        }
    }
}
