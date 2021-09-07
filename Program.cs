using System;

namespace LogicaPrograms
{
    class Program
    {
        public static bool PerfectNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i<num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logica Programs");
            Console.WriteLine("Enter a num ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (PerfectNumber(num))
            {
                Console.WriteLine(num + " is a perfect number");
            }
            else
            {
                Console.WriteLine(num + " is not a perfect number");
            }
        }
    }
}