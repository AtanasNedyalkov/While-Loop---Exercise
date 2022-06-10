using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string stepCounterSum = Console.ReadLine();
            int steps = 0;
            while (true)
            {
                if (stepCounterSum == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    break;

                }
                steps += int.Parse(stepCounterSum);
              
                if (steps >= 10000)
                {
                    break;
                }
                stepCounterSum = Console.ReadLine();
            }
            if (steps < 10000)
            {
                Console.WriteLine($"{10000 - steps} more steps to reach goal.");
            }
            else
            {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{steps-10000} steps over the goal!");
            }

        }
    }
}
