using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double volumeCake = a * b;
            string counterPieces = Console.ReadLine();

            while (counterPieces!="STOP")
            {
                

                if (volumeCake < 0)
                {
                    break;
                }
                volumeCake -= double.Parse(counterPieces);
                counterPieces = Console.ReadLine();

            }
            if (volumeCake<=0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(volumeCake)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{volumeCake} pieces are left.");
            }
            
        }
    }
}
