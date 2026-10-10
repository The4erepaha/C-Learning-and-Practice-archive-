using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            // базовый цикл for
            /*
            for(byte i = 0; i <= 10 ; i++)
            {
                Console.WriteLine("Element: " + i);
            } */
            // второй пример цикла for
            /*
            for (float i = 200; i > 10; i /= 2)
            {
                Console.WriteLine("Element: " + i);
            }
            */
            /*
            // цикл while
            byte i = 10;
            while (i >= 1)  // в скобках пишем только условие
            {
                Console.WriteLine("Element: " + i);
                i--;
            }
            */
            // второй пример использования while()
            // bool isHasCar = true;
            // while (isHasCar)
            // {
            //     string end = Console.ReadLine();
            //     if(end == "end")
            //     {
            //         isHasCar = false;
            //     }
            // }

            // do while
            // byte i = 100;
            // do
            // {
            //     Console.WriteLine("Element: " + i);
            // }while(i < 10);
            

            //операторы для циклов (for, while, do while)
            for (short i = 0 ; i < 10 ; i++)
            {
            //     if( i > 5)
            //     {
            //         break; // делает то же самое что и в switch (как i дойдет до 5 мы выходим из цикла)
            //     }
                if(i%2 == 0)
                {
                    continue;   // делает что и break но наоборот, например за счет этого оператора в условии иф, мы пропускаем четные числа
                }
            
                Console.WriteLine("El: " + i);
            }
        }
    }
}