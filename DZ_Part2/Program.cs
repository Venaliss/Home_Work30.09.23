using System;

namespace DZ_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1 задание - Дана последовательность из 10 чисел. Определить, является ли эта последовательность упорядоченной по возрастанию.*/
            Console.WriteLine("Дана последовательность из 10 чисел. Определить, является ли эта последовательность упорядоченной по возрастанию.");
            int[] array = new int[11];

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Введите {i} число:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i <= 9;)
            {
                if (array[i] < array[i + 1])
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
            Console.ReadKey();
        }
    }
}
