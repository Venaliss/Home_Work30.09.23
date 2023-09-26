using System;

namespace DZ_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Упражнение 4.1 - 4.2 Тумаков, написать программу которая выводит день и месяц введеного числа от 1 до 365(без високосного) с исключением*/
            Console.WriteLine("Упражнение 4.1 - 4.2 Написать программу для вычисления месяца и дня по введеному числу от 1 до 365 с исключением:\n\nВведите число от 1 до 365, пожалуйста.");

            short day = Convert.ToInt16(Console.ReadLine());
            if ((1 > day) != (day > 365))
            {
                Console.WriteLine("Ошибка: неверное число.");
            }
            else if ((1 <= day) == (day <= 31))
            {
                Console.WriteLine($"Число {day} соответствует {day} Январь");
            }
            else if ((32 <= day) == (day <= 59))
            {
                Console.WriteLine($"Число {day} соответствует {day - 31} Февраль");
            }
            else if ((60 <= day) == (day <= 90))
            {
                Console.WriteLine($"Число {day} соответствует {day - 59} Март");
            }
            else if ((91 <= day) == (day <= 120))
            {
                Console.WriteLine($"Число {day} соответствует {day - 90} Апрель");
            }
            else if ((121 <= day) == (day <= 151))
            {
                Console.WriteLine($"Число {day} соответствует {day - 120} Май");
            }
            else if ((152 <= day) == (day <= 181))
            {
                Console.WriteLine($"Число {day} соответствует {day - 151} Июнь");
            }
            else if ((182 <= day) == (day <= 212))
            {
                Console.WriteLine($"Число {day} соответствует {day - 181} Июль");
            }
            else if ((213 <= day) == (day <= 243))
            {
                Console.WriteLine($"Число {day} соответствует {day - 212} Август");
            }
            else if ((244 <= day) == (day <= 273))
            {
                Console.WriteLine($"Число {day} соответствует {day - 243} Сентябрь");
            }
            else if ((274 <= day) == (day <= 304))
            {
                Console.WriteLine($"Число {day} соответствует {day - 273} Октябрь");
            }
            else if ((305 <= day) == (day <= 334))
            {
                Console.WriteLine($"Число {day} соответствует {day - 304} Ноябрь");
            }
            else if ((335 <= day) == (day <= 365))
            {
                Console.WriteLine($"Число {day} соответствует {day - 334} Декабрь");
            }
            Console.ReadKey();


            /*Домашнее задание 4.3 Тумаков, написать программу которая выводит день и месяц введеного числа от 1 до 365 с исключением*/
            Console.WriteLine("\nДомашнее задание 4.3 Тумаков, написать программу которая выводит день и месяц введеного числа от 1 до 365/366(в зависимости от года) с исключением\nВведите год, а затем число от 1 до 366:");
            Console.WriteLine("\nВведите год:");
            uint year = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("\nВведите день:");
            short day1 = Convert.ToInt16(Console.ReadLine());
            if (((year % 4 == 0) != (year % 400 == 0)) != ((year % 4 == 0) == (year % 400 == 0)))
            {
                if ((1 > day1) != (day1 > 366))
                {
                    Console.WriteLine("Ошибка: неверное число.");
                }
                else if ((1 <= day1) == (day1 <= 31))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1} Январь");
                }
                else if ((32 <= day1) == (day1 <= 60))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 31} Февраль");
                }
                else if ((61 <= day1) == (day1 <= 91))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 60} Март");
                }
                else if ((92 <= day1) == (day1 <= 121))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 91} Апрель");
                }
                else if ((122 <= day1) == (day1 <= 152))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 121} Май");
                }
                else if ((153 <= day1) == (day1 <= 182))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 152} Июнь");
                }
                else if ((183 <= day1) == (day1 <= 213))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 182} Июль");
                }
                else if ((214 <= day1) == (day1 <= 244))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 213} Август");
                }
                else if ((245 <= day1) == (day1 <= 274))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 244} Сентябрь");
                }
                else if ((275 <= day1) == (day1 <= 305))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 274} Октябрь");
                }
                else if ((306 <= day1) == (day1 <= 335))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 305} Ноябрь");
                }
                else if ((336 <= day1) == (day1 <= 366))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 335} Декабрь");
                }
            }
            else
            {
                if ((1 > day1) != (day1 > 365))
                {
                    Console.WriteLine("Ошибка: неверное число.");
                }
                else if ((1 <= day1) == (day1 <= 31))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1} Январь");
                }
                else if ((32 <= day1) == (day1 <= 59))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 31} Февраль");
                }
                else if ((60 <= day1) == (day1 <= 90))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 59} Март");
                }
                else if ((91 <= day1) == (day1 <= 120))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 90} Апрель");
                }
                else if ((121 <= day1) == (day1 <= 151))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 120} Май");
                }
                else if ((152 <= day1) == (day1 <= 181))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 151} Июнь");
                }
                else if ((182 <= day1) == (day1 <= 212))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 181} Июль");
                }
                else if ((213 <= day1) == (day1 <= 243))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 212} Август");
                }
                else if ((244 <= day1) == (day1 <= 273))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 243} Сентябрь");
                }
                else if ((274 <= day1) == (day1 <= 304))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 273} Октябрь");
                }
                else if ((305 <= day1) == (day1 <= 334))
                {
                    Console.WriteLine($"Число {day1} соответствует {day1 - 304} Ноябрь");
                }
                else if ((335 <= day1) == (day1 <= 365))
                {
                    Console.WriteLine($"Число {day1} соответствует {day - 334} Декабрь");
                }
                
            }

            Console.ReadKey();
        }
    }
}
