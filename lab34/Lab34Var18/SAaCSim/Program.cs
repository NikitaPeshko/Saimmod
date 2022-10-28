using System;

namespace SAaCSim
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;

            Console.WriteLine("p:");
            double p= Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("p1:");
            double π1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("p2:");
            double π2 = Convert.ToDouble(Console.ReadLine()); do
            {

                
                 Task20 task20 =  new Task20(p, π1, π2);
                

                task20.Execute();
                Console.WriteLine("Press Escape to exit.");
                keyInfo = Console.ReadKey();
                Console.Clear();
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}