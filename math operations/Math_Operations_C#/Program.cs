using System;

namespace Math_Operations_CSharp
{
    class Program
    {
        static void Main()
        {
            /* float user_num;
            Console.WriteLine("ВВедите число:");
            // user_num = Convert.ToDouble(Console.ReadLine()); // способ ввода числа с плавающей точкой
            user_num = float.Parse(Console.ReadLine()); // конвертирует в формат floar

            float result;
            result = user_num + 10f;  // f в конце числа указывает что он тип float (сложение)
             result = user_num - 10f; // вычитание
            result = user_num * 10f; // умножение
            result = user_num / 10f; // деление
            result = user_num % 10f; // остаток от деления
            
            Console.WriteLine("Результат:" + result);
            int a = 5, b = 10;
            int resINT;
            resINT = a + b;
            Console.WriteLine("результат сложение двух целых чисел: " + resINT);
            resINT *= b;  // сокращенные операции 
            Console.WriteLine("Сумма умножается на 10: " + resINT);
            resINT++; // инкремент (увелечение на 1) так же есть декремент (уменьшение на 1) resINT--
            Console.WriteLine("Результат после инкремента: " + resINT);
            */
            // встроенные математические функции
            const int num = 10; // константа (неизменяемая переменная)
            Console.WriteLine(Math.PI); // вывод числа Пи
            Console.WriteLine(Math.E); // вывод числа E
            Console.WriteLine(Math.Abs(20)); // модуль числа
            // урок 4 минута 14:48



        }
    }
}