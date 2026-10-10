using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            // задание 1
            /*
            int x;
            Console.WriteLine("Выберите день нидели от 1 до 7");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1: 
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3: 
                    Console.WriteLine("Среда");
                    break;
                case 4: 
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default: 
                    Console.WriteLine("ошибка, не то значение");
                    break;
            }     
            */

            // задание 2
            /*
            int a , b, rez;
            char calc;
            Console.Write("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выбирите операцию - [+], [-], [/], [*]");
            calc = (char)Console.Read();   // ввод символа подсмотрел в инете
            switch (calc)
            {
                case '+':    
                    rez = a + b;
                    Console.WriteLine(rez); 
                    break;    
                case '-':    
                    rez = a - b;
                    Console.WriteLine(rez); 
                    break;
                case '/':    
                    rez = a / b;
                    Console.WriteLine(rez); 
                    break;
                case '*':    
                    rez = a * b;
                    Console.WriteLine(rez); 
                    break;
                default: 
                    Console.WriteLine("такой операции нет в списке");
                    break;                 
            }
            */
            // задание 3
            /*
            int x;
            Console.WriteLine("Выберите число месца 1-12");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 12 or 1 or 2:   //  оператор or подсмотрел в инете
                    Console.WriteLine("Зима");
                    break;
                case 3 or 4 or 5:
                    Console.WriteLine("Весна");
                    break;
                case 6 or 7 or 8:
                    Console.WriteLine("Лето");
                    break;
                case 9 or 10 or 11:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("Нету такого месяца, вы вышли из предела 1-12");
                    break;
            }
             */
             // задание 4
             int zakaz, kol_vo, chek;
             int id_1 = 3, id_2 = 3, id_3 = 2, id_4 = 1; // ценны
             Console.WriteLine("Добро пожаловать в кафе Антейку!");
             Console.WriteLine("Наше меню: [1] кофе - 3$, [2] чай - 3$, [3] сок - 2$, [4] вода - 1$");
             zakaz = Convert.ToInt32(Console.ReadLine());
            switch (zakaz)
            {
                case 1: 
                    Console.WriteLine("Вы выбрали кофе,  какое кол-во вы хотите? ");
                    kol_vo = Convert.ToInt32(Console.ReadLine());
                    chek = kol_vo * id_1;
                    Console.WriteLine("Чек вышел на сумму: " + chek + "$");
                    break;
                case 2: 
                    Console.WriteLine("Вы выбрали чай,  какое кол-во вы хотите? ");
                    kol_vo = Convert.ToInt32(Console.ReadLine());
                    chek = kol_vo * id_2;
                    Console.WriteLine("Чек вышел на сумму: " + chek + "$");
                    break;
                case 3: 
                    Console.WriteLine("Вы выбрали сок,  какое кол-во вы хотите? ");
                    kol_vo = Convert.ToInt32(Console.ReadLine());
                    chek = kol_vo * id_3;
                    Console.WriteLine("Чек вышел на сумму: " + chek + "$");
                    break;
                case 4: 
                    Console.WriteLine("Вы выбрали воду,  какое кол-во вы хотите? ");
                    kol_vo = Convert.ToInt32(Console.ReadLine());
                    chek = kol_vo * id_4;
                    Console.WriteLine("Чек вышел на сумму: " + chek + "$");
                    break;
                default:
                    Console.WriteLine("К сожалению такого в меню нету");
                    break;
            }

        }
    }
}