using System;

namespace P11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    price = 2.5;
                    Console.WriteLine($"{quantity * price:f2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.2;
                    Console.WriteLine($"{quantity * price:f2}");
                }
                else if (fruit == "orange")
                {
                    price = 0.85;
                    Console.WriteLine($"{quantity * price:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45;
                    Console.WriteLine($"{quantity * price:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 2.7;
                    Console.WriteLine($"{quantity * price:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.5;
                    Console.WriteLine($"{quantity * price:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = 3.85;
                    Console.WriteLine($"{quantity * price:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.7;
                    Console.WriteLine($"{quantity * price:f2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.25;
                    Console.WriteLine($"{quantity * price:f2}");
                }
                else if (fruit == "orange")
                {
                    price = 0.9;
                    Console.WriteLine($"{quantity * price:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.6;
                    Console.WriteLine($"{quantity * price:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 3;
                    Console.WriteLine($"{quantity * price:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.6;
                    Console.WriteLine($"{quantity * price:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = 4.2;
                    Console.WriteLine($"{quantity * price:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
