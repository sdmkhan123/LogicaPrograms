using System;

namespace LogicaPrograms
{
    class Program
    {
        static int reversNumber(int num)
        {
            int revNnum = 0;
            while (num > 0)
            {
                revNnum = revNnum * 10 + num % 10;
                num = num / 10;
            }
            return revNnum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logica Programs");
            Console.WriteLine("Enter a num ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Reverse of " + num + " is " + reversNumber(num));
        }
    }
}