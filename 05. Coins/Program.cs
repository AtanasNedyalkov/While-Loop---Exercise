﻿using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {    //200, 100, 50,20,10,5,2,1
            double money = double.Parse(Console.ReadLine()) * 100;
            int counter = 0;
            while (money != 0)
            {
                if (money >= 200)
                {
                    money -= 200;
                }
                else if (money >= 100)
                {
                    money -= 100;
                }
                else if (money >= 50)
                {
                    money -= 50;
                }
                else if (money >= 20)
                {
                    money -= 20;
                }
                else if (money >= 10)
                {
                    money -= 10;
                }
                else if (money >= 5)
                {
                    money -= 5;
                }
                else if (money >= 2)
                {
                    money -= 2;
                }
                else if (money >= 1)
                {
                    money -= 1;
                }
                else
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
