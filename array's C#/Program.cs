using System;
using System.Runtime.Serialization.Formatters;

namespace project
{
    class Program
    {
        static void Main()
        {
            // // Массивы летс гоу
            // // в массив можем за ранее присвоить значения или выделить память
            // // в данном случае через new мы выделяем память что бы внести в будущем значения
            // int[] array = new int[5]; // массив начинается с нулевого элемента    
            // array[0] = 250;
            // array[1] = 123;
            // array[2] = 2309;
            // array[3] = 12;
            // array[4] = 21;
            // // // вывод отдельного элемента массива
            // // Console.WriteLine("El: " + array[2]);

            // // вывод всего массива через цикл for
            // for(int i = 0 ; i < array.Length ; i++)  // Length свойство которое поможет получить длину массива
            // {
            //     Console.WriteLine("El: " + array[i]);
            // }
            // // масси с готовыми данными типа string
           
            // string[] words = new string[] {
            //     "Привет!", 
            //     "О ты запустил пк?", 
            //     "Чем будем заниматься?", 
            //     "Ого, кодишь?"
            //     } ;
            
            // for(int i = 0 ; i < words.Length ; i++)
            // {
            //     Console.WriteLine("SC говорит: " + words[i]);
            
            // }

            // short[] array = new short[10];
            // short sum = 0;
            // Random rand = new Random(); // свойство рандом, рандомайзер кароч
            // for( byte i = 0; i < array.Length ; i++)
            // {
            //     // диапозон от -50 до 50, функция Next - может принимать несколько параметров 
            //     array[i] = Convert.ToInt16(rand.Next(-50, 50)); 
            //     Console.WriteLine("El: " + array[i]);

            //     sum += array[i];  // сумма элементов массива
            // }
            // Console.WriteLine("Summa: " + sum);

            string nameUser;
            Console.WriteLine("Введите свое имя что бы SC мог обращаться к вам!");
            Console.Write("Ваше имя: ");
            nameUser = Console.ReadLine();
            Random rnd = new Random();
            string[] thing = new string[]
            {
              "привет!",
              "меня зовут SC!",
              "пойдем в Steam?",
              "давай включим Youtube?",
              "ого!",
              "сегодня хорошая погода."  
            };

           

            for( byte i = 0 ; i < 6 ; i++)
            {
                int rndThings = rnd.Next(thing.Length);  // вывод рандом строк из массива
                Console.WriteLine(" Мысли SC -> : " + nameUser + " " + thing[rndThings]);
            }
                


            // многомерные массивы

            


        }
    }
}