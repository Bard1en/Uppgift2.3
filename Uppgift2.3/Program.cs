using System;
 namespace Uppgift2._3 
{ 
  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            string g = Console.ReadLine();

            Console.WriteLine("Hur många kilometer kommer du köra?");
            string z = Console.ReadLine();

            double x = double.Parse(g);
            double y = double.Parse(z);

            double sum = 300 + y + x*500 -500;
            Console.WriteLine("Din hyra för att låna bilen blir " + sum + " kr");
            Console.ReadKey();

        }
    }
}