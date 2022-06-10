using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoritBook = Console.ReadLine();
            int counter = 0;
            string nextBookName = Console.ReadLine();
            while (nextBookName!="No More Books")
            {
                if (nextBookName==favoritBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                counter++;
                nextBookName = Console.ReadLine();
            }
            if (nextBookName=="No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked { counter} books.");
            }
        }
    }
}
