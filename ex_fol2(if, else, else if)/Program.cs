using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            /*
            // задание 1
            int number;
            Console.WriteLine("Введите число для проверки на четность");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0 ) // формулу с получение остатка подсмотрел в интернете :(
            {
                Console.WriteLine("остаток равен 0");
            }
            else
            {
                Console.WriteLine("остаток не равен нулю");
            } 
            // задание 2
            double number;
            Console.WriteLine("Введите число для проверки");
            number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ваше число: " + number);
            Console.WriteLine();
            if( number > 0)
            {
                Console.WriteLine("Ваще число положительное");
            }
            else if (number < 0)
            {
                Console.WriteLine("Ваше число отрицательное");
            }
            else
            {
                Console.WriteLine("Ваше число равно нулю");
            } 
            // задание 3
            int grade;
            Console.WriteLine("Введите оценку от 0 до 100");
            grade = Convert.ToInt32(Console.ReadLine());
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Данная оценка невозможна");
            }
            else if( grade >= 90 && grade <= 100)
            {
                Console.WriteLine("Оценка [отлично!]");
            }
            else if( grade >= 70 && grade <= 89)
            {
                Console.WriteLine("Оценка [хорошо!]");
            }
            else if( grade >= 50 && grade <= 69)
            {
                Console.WriteLine("Оценка [удовлетворитльно.]");
            }
            else if( grade >= 0 && grade < 50)
            {
                Console.WriteLine("Оценка [незачет]");
            }
            */
            // задание 4 
            /*
            int x1 , x2, x3;
            Console.WriteLine("Введите 3 числа подряд");
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нажмите на любую клавишу для продолжения");
            Console.ReadKey();
            if ( x1 >= x2 && x1 >= x3)
            {
                Console.WriteLine("Число: [" + x1 + "] больше чем числа: " + x2 + " : " + x3);
            }
            else if (x2 >= x1 && x2 >= x3)
            {
                Console.WriteLine("Число: [" + x2 + "] больше чем числа: " + x1 + " : " + x3);
            }
            else if(x3 >= x2 && x3 >= x1)
            {
                Console.WriteLine("Число: [" + x3 + "] больше чем числа: " + x2 + " : " + x1);
            }  */

            // задание 5
            // не совсем понял суть задания и как вычислять этот год, но я сделал так
            
            int age;
            Console.WriteLine("Введите год");
            age = Convert.ToInt32(Console.ReadLine());
            if (age % 4 == 0 && age % 100 != 0 || age % 400 == 0)  // оператор && вычисляется первее чем || как умножение в математике
            // формулу подсмотрел в интернете, еще не совсем до конца понял когда 
            // использовать оператор %, я знаю что он вычисляет остаток.
            {
                Console.WriteLine("Год высокосный");
            }
            else
            {
                Console.WriteLine("Год не высокосный");
            }
            
            // задание 6
            /*
            int num;
            Console.WriteLine("Введите число что бы отгадать!");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 7)
            {
                Console.WriteLine("Ты отгадал число молодец!");
            }
            else if (num > 7)
            {
                Console.WriteLine("Ты не угадал число, оно меньше.");
            }
            else if (num < 7)
            {
                Console.WriteLine("Ты не угадал чилсо, оно больше.");
            } */
            
        }
    }
}
