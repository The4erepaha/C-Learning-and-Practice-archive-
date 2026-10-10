using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число");
            int user_number = Convert.ToInt32(Console.ReadLine());

            switch (user_number)  // оператор switch. В скобках мы указываем переменную которую хотим проверить
            {   // способы писания случаев (case)
                case 1: Console.WriteLine("число 1"); break;
                case 5: Console.WriteLine("Число 5");
                break;
                case 3: 
                    Console.WriteLine("число 3");
                    break;
                default:  // deafult выступает в роли else если не одно значение не подошло
                    Console.WriteLine("не правильно");
                    break;
            }




        }
    }
}
