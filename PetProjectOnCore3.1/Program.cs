﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //Можно так
            Console.WriteLine(comparer.Compare());

            //Или так
            Console.WriteLine(comparer.Result);
            //Команда ожидания ввода любого символа с клавиатуры, чтобы программа не завершалась пока не нажмешь.
            Console.ReadKey();





            byte b1; // переменная 0..255
            sbyte sb1;// перменная -128..127
            short s1;// перменная -32 768.. 32 767
            ushort us1;// перменная 0..65 535
            int i1;// перменная много
            uint ui1;// переменная многоположительных целочисленных 
            long l1; // переменная очень многоо целочисленных 
            ulong ul1;// переменная очень много положительных целочисленных 
            float f1;//перменная с плавающей точкой 
            double d1;// переменная с плавающей точкой больше f1
            decimal dc1;// переменная с плавающей точкой супер точная (кто блять ее использует) пиздец большая
            char c1;// unicode (unicore) единорог выводить значение юникода 
            string st1; // строковый тип можно выводить в  консоль мат в процессе разработки
            bool bl1;// всегда использую тру и фолс 
            object ob1;// все вместе и абстрактно
                       // далее идет какая-то инициализация <- на эльфийском
            b1 = 10;
            sb1 = -10;
            s1 = -32768;
            us1 = 65535;
            i1 = -128935;
            ui1 = 65555555;
            l1 = 19302841948293572;
            ul1 = 2194032532752308402;
            f1 = 535.95f;
            d1 = 684.312;
            dc1 = 75.3214124m;
            st1 = "Нормально,заебал";
            bl1 = true;
        }
    }
}
