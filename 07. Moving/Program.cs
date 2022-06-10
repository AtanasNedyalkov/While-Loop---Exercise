using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Широчина на свободното пространство - цяло число в интервала[1...1000]
            //2.Дължина на свободното пространство - цяло число в интервала[1...1000]
            //3.Височина на свободното пространство - цяло число в интервала[1...1000]
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            int freeSpace = width * lenght * high;
            string commande = Console.ReadLine();

            while (commande!="Done")
            {
                if (freeSpace<0)
                {
                    break;
                }
                freeSpace -= int.Parse(commande);
                commande = Console.ReadLine();
            }
            if (freeSpace<=0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }

    }
}
