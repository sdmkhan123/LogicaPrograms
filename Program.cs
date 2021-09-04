using System;

namespace LogicaPrograms
{
    class Program
    {
        public static void fibSeries(int terms)
        {
            int a = 0, b = 1, c = 0;
            if (terms == 0)
            {
                Console.Write(a +" ");
            }
            for (int i = 2; i <= terms; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(b +" ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logica Programs");
            Console.WriteLine("Enter the num of terms of fibonacci series");
            int terms = Convert.ToInt32(Console.ReadLine());
            fibSeries(terms);
        }
    }
}
