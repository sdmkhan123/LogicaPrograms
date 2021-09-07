using System;

namespace LogicaPrograms
{
    class Program
    {
        static bool toCheckPrime(int num)
        {
            if (num <= 1)
                return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logica Programs");
            Console.WriteLine("Enter a num ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (toCheckPrime(num))
            {
                Console.Write(num + " is a Prime number");
            }

            else
            {
                Console.Write(num + " is not a prime number");
            }
        }
    }
}