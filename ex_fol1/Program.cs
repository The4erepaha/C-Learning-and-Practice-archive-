using System;

namespace Ex_app1
{
    class Program
    {
        static void Main()
        {
            /*
            // задание номер 1
            string name;
            int age;
            Console.WriteLine("Введите ваше имя: ___");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите ваш возраст: ___");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Привет, " + name + " !. Тебе " + age + " лет!" );
            */
            /*
            // задание 2
            double a, b;
            double sum;
            int x = 5;  // переменная для теста деления на ноль
            Console.WriteLine(" Введите число а: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            b = Convert.ToDouble(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("Сумма двух чисел = " + sum);
            sum = a - b;
            Console.WriteLine("Разность двух чисел = " + sum);
            sum = a * b;
            Console.WriteLine("Произведение двух чисел = " + sum);
            sum = a / b;
            Console.WriteLine("Частное двух чисел = " + sum);
            // тест деления на ноль double и int
            a = a/0;
            Console.WriteLine("Деление на ноль double: " + a);
            x = x/0;
            Console.WriteLine("Деление на ноль int: " + x);
            // после теста: деление на ноль double возращает бесконечность, а деление на ноль int вызывает ошибку.
            */

            // задание 3
            /*
            float a,b,sum,ost;
            Console.WriteLine("Введите число a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            b = float.Parse(Console.ReadLine());
            sum = a/b;
            ost = a%b;
            Console.WriteLine("Целове деление = " + sum);
            Console.WriteLine("Остаток от деления = " + ost);
            */
            /*
            // задание 4
            float r, dlina, ploshad;
            Console.WriteLine("введите радиус окружности для длины и площади:");
            r = float.Parse(Console.ReadLine());
            dlina = 2 * Math.PI * r; // формула длины окружности 
            ploshad = Math.PI * Math.Pow(r, 2); // формула площади окружности 
            Console.WriteLine("Длина окружности = " + dlina);
            Console.WriteLine("Площадь окружности = " + ploshad);
            // округление до 2 чисел (подсмотрел метод Math.Round, и способ применения)
            dlina = (float)Math.Round(dlina, 2);
            ploshad = (float)Math.Round(ploshad, 2);
            Console.WriteLine("Длина оркужности округленная: " + dlina);
            Console.WriteLine("Площадь окружности округленная: " + ploshad);
            */
            /*
            // задание 5
            int sec, hours, minutes;
            Console.WriteLine("Введите кол-во секунд для конвертации: ");
            sec = Convert.ToInt32(Console.ReadLine());
            hours = sec / 3600;
            minutes = (sec % 3600) / 60; // формулу для минут я подсмотрел в интернете, так как не мог сам вывести формулу
            sec = sec % 60;
            Console.WriteLine("Время: [часы: "+ hours + " ]=[минуты: " + minutes + " ]=[секунды: " + sec + "]");
            */

            
        }
    }
}