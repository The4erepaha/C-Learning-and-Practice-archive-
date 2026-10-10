using System;
using System.Security.Principal;

namespace project
{
    class Pogram
    {
        static void Main()
        {
            // задание 1
            //int sum = 0;
            // на бумаге я думал что будет вывод в виде 1 -> 1, 2 -> 2 и т.д но я ошибся
            // for(int i = 1; i < 5; i++)
            // {
            //     sum += i;
            //     Console.WriteLine(i + "->" + sum);
            // }
            // тоже самое только с while, сначала я допустил ошибку записав sum += 1 в скобках while, но потом вспомнил что там условие и исправил
            // int i = 0;
            // while(i < 5)
            // {
            //     sum += i;
            //     Console.WriteLine(i + "->" + sum);
            //     i++;
            // }

            // задание 2
            // int num, sum;
            // Console.Write("Введите число для вывода таблицы умножения: ");
            // num = Convert.ToInt32(Console.ReadLine());
            // for(int i = 0 ; i <= 10 ; i++)
            // {
            //     sum = num * i;
            //     Console.WriteLine(num + " x "+ i + " = " + sum);
            // }
            // задание 3
            // int n, sum = 0, sum_ch = 0 ;
            // Console.Write("Введите число n: ");
            // n = Convert.ToInt32(Console.ReadLine());
            // for( int i = 1; i <= n ; i++)
            // {
            //     sum = sum + i;
                
            //     if(i % 2 == 0)
            //     {
            //         sum_ch = sum_ch + i;
            //     }
               
            //    // Console.WriteLine("sum ->: " + i);
            // }
            // Console.WriteLine("Сумма чисел от 1 до n : " + sum);
            // Console.WriteLine("Сумма четных: " + sum_ch);

            // задание 4
            // int n;
            // Console.WriteLine("Угадайте число от 1 до 10");
            // n = Convert.ToInt32(Console.ReadLine());
            // while(n != 7)
            // {
            //     Console.WriteLine("Вы не угадали число!");
            //     Console.WriteLine("Попробуйте еще раз!");
            //     n = Convert.ToInt32(Console.ReadLine());
            // }
            // if ( n == 7)
            // {
            //     Console.WriteLine("Вы угадали число!");
            // }
            

            // второй вариант задания 3
            // int n;
            // Console.WriteLine("Угадайте число от 1 до 10");
            // n = Convert.ToInt32(Console.ReadLine());
            // do
            // {
            //     Console.WriteLine("Вы не угадали число!");
            //     Console.WriteLine("Попробуйте еще раз!");
            //     n = Convert.ToInt32(Console.ReadLine());
            // }
            // while( n != 7);
            // if ( n == 7)
            // {
            //     Console.WriteLine("Вы угадали число!");
            // }
            
        }
    }
}