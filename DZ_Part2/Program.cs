using System;

namespace DZ_Part2
{
    class Program
    {
        /*Задание 4 вывести день недели исходя из его номера*/
        public enum week
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        static void Main(string[] args)
        {
            try
            {
                /*1 задание - Дана последовательность из 10 чисел. Определить, является ли эта последовательность упорядоченной по возрастанию.*/
                Console.WriteLine("Дана последовательность из 10 чисел. Определить, является ли эта последовательность упорядоченной по возрастанию.");
                long[] array = new long[11];

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"Введите {i} число:");
                    array[i] = Convert.ToInt64(Console.ReadLine());
                }
                for (int i = 1; i <= 9;)
                {
                    if (array[i] <= array[i + 1])
                    {
                        i++;
                    }
                    else if (array[i] > array[i + 1])
                    {
                        Console.WriteLine($"Ошибка возрастающей последовательности, под индексом{i}");
                        break;
                    }
                    if (i == 10)
                    {
                        Console.WriteLine("Последовательность является упорядоченной");
                    }
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Ошибка ввода. Неправильный формат строки.");
            }



            /*2 задания - Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства*/
            Console.WriteLine("\n2 задания - Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства\n");
            try
            {
                Console.WriteLine("Введите достоинство карты от '6' до '14' включительно:");
                byte vod = Convert.ToByte(Console.ReadLine());
                switch (vod)
                {
                    case 6: Console.WriteLine("Шестерка"); break;
                    case 7: Console.WriteLine("Семерка"); break;
                    case 8: Console.WriteLine("Восмерка"); break;
                    case 9: Console.WriteLine("Девятка"); break;
                    case 10: Console.WriteLine("Десятка"); break;
                    case 11: Console.WriteLine("Валет"); break;
                    case 12: Console.WriteLine("Дама"); break;
                    case 13: Console.WriteLine("Короля"); break;
                    case 14: Console.WriteLine("Туз"); break;
                    default: Console.WriteLine("Ошибка.Число не соответствует диапозону от '6' до '14'"); break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Ошибка ввода. Неправильный формат");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Ошибка ввода. Слишком большое число");
            }


            /*Задание 3 - написать программу, на вход подается строка, на основе строки должен вывестись результат.*/
            Console.WriteLine("\nЗадание 3 - написать программу, на вход подается строка, на основе строки должен вывестись результат.\nВведите строку:");
            string str = Console.ReadLine();
            switch (str.ToLower())
            {
                case "jabroni": Console.WriteLine("Patron Tequila"); break;
                case "school counselor": Console.WriteLine("Anything with Alcohol"); break;
                case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
                case "big gang member": Console.WriteLine("Moonshine"); break;
                case "politician": Console.WriteLine("Your tax dollars"); break;
                case "rapper": Console.WriteLine("Cristal"); break;
                default: Console.WriteLine("Beer"); break;
            }


            /*Задание 4 - Вывести название дня недели исходя из его порядкого номера(использовать enum)*/
            Console.WriteLine("\nЗадание 4 - Вывести название дня недели исходя из его порядкого номера(использовать enum)\nВведите порядковый номер дня недели:");
            try
            {
                byte day = Convert.ToByte(Console.ReadLine());
                switch (day)
                {
                    case ((byte)week.Monday): Console.WriteLine("Понедельник"); break;
                    case ((byte)week.Tuesday): Console.WriteLine("Вторник"); break;
                    case ((byte)week.Wednesday): Console.WriteLine("Среда"); break;
                    case ((byte)week.Thursday): Console.WriteLine("Четверг"); break;
                    case ((byte)week.Friday): Console.WriteLine("Пятница"); break;
                    case ((byte)week.Saturday): Console.WriteLine("Суббота"); break;
                    case ((byte)week.Sunday): Console.WriteLine("Воскресенье"); break;
                    default: Console.WriteLine("Нет соответствий"); break;
                }
            }
            catch(System.OverflowException)
            {
                Console.WriteLine("Ошибка. Недопустимое число.");
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Ошибка. Неверный формат вводимых данных");
            }


            /*Задание 5 - написать программу, которая на вход получает массив из строк. Найти кол-во элементов "Hello Kitty" и "Barbie dool"(использовать foreach)*/
            Console.WriteLine("Задание 5 - написать программу, которая на вход получает массив из строк. Найти кол-во элементов 'Hello Kitty' и 'Barbie dool'(использовать foreach)");
            string[] dools = { "Hello Kitty", "hel", "Hello Kitty", "jiujn", "Hello Kitty", "Barbie dool", "njkfnbe", "Barbie dool", "fkenkfj"};
            long count = 0;
            foreach(string index in dools)
            {
                if ((index == "Barbie dool") != (index == "Hello Kitty"))
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Количество кукол в сумке равно: {count}");
            Console.ReadKey();
        }
    }
}
