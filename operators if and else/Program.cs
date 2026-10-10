using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            int a;
           // string word = "hi";
            bool isHasCar = false; 
            Console.WriteLine("введите нужное число");
            a = Convert.ToInt32(Console.ReadLine());
            // И - && , ИЛИ - ||, равно - == , не равно - !=
            // больше/меньше/больш.равно/меньш.равно - > , <, >= , <=
            if( a == 5 || a == 10) // если в условии 1 строка, можно не использовать фиг. скобки
                Console.WriteLine("вы ввели нужное число");
            else if(a < 5 && !isHasCar)  // доп условие для проверки, так же их можно прописывать сколько раз угодно 
            {
                Console.WriteLine("число меньше 5");
                Console.WriteLine("у пользователя есть машина");
            }
            else
            {
                Console.WriteLine("вы ввели не нужное число");
            }
            /*
            Console.WriteLine("вторая проверка - проверка слова (нажмите любую клавишу для продолжения)");
            Console.ReadKey(); // ждет нажатия клавиши
            Console.WriteLine("введите слово - hi");
            word = Console.ReadLine();
            if (word == "hi")
            {
                Console.WriteLine("слово верное - " + word);
            }
            else
            {
                Console.WriteLine("слово не верное");
            }

            if(isHappy == true) // это полная форма записи, так же можно записать if(isHappy)
            {
                Console.WriteLine("вы счастливы");
                
            }
            */


        }
    }
}