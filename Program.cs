using System;

namespace function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шаг x");
            double step = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите диапозон значений x");
            double start = Convert.ToDouble (Console.ReadLine());
            double end = Convert.ToDouble(Console.ReadLine());
            
            for (; start<=end ; start+=step)
            {
                double y = Math.Pow(start, 2) + 0.5*start +2 ;
                Console.WriteLine($"|x = {start}\t| y = {y}|");
                Console.WriteLine("__________________");
            }
           
        }
    }
}
