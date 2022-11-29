using System;
//class Program
//{
//    /*
//     Это че такое????
//     */
//    static void Main(string[] args)
//    {
//        Compare compare = new Compare();
//        compare.toMatch();
//    }
//}
namespace PetProject
{
    /// <summary>
    /// Класс сравнения чисел
    /// </summary>
    public class Comparer
    {
        /// <summary>
        /// Первое число сравнения
        /// </summary>
        public double DigitOne { get; private set; }
        /// <summary>
        /// Второе число сравнения
        /// </summary>
        public double DigitTwo { get; private set; }
        /// <summary>
        /// Результат сравнения
        /// </summary>
        public string Result { get; private set; }

        public Comparer()
        {
            DigitOne = 0;
            DigitTwo = 0;
            Result = string.Empty;
        }
        /// <summary>
        /// Метод сравнивает два числа
        /// </summary>
        /// <returns>Словесный результат сравнения</returns>
        ///
        public string Compare()
        {//Именования методов начинаются с большой буквы
         //локальные переменные именуются с маленькой буквы
         //Фантомные переменные усложняют чтение кода
         //Лучше назвать digitOne и digitTwo
            Console.WriteLine(GetNumbers());

            if (DigitOne > DigitTwo)
            {
                Result = "Первое число больше второго";
            }
            else if (DigitOne < DigitTwo)
            {
                Result = "Первое число меньше второго";
            }
            else
            {
                Result = "Числа равны";
            }
            return Result;
        }

        private string GetNumbers()
        {
            try
            {
                Console.WriteLine("Введите первое число: ");
                DigitOne = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число: ");
                DigitTwo = Convert.ToDouble(Console.ReadLine());
                return "Числа введены успешно.";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Ошибка при вводе чисел";
            }
        }
    }
}