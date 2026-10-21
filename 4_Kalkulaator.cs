using System;

namespace SwitchKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta teine number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Vali tehe (+, -, *, /): ");
            string tehe = Console.ReadLine();
            
            switch (tehe)
            {
                case "+":
                    Console.WriteLine("Vastus: " + (a + b));
                    break;
                case "-":
                    Console.WriteLine("Vastus: " + (a - b));
                    break;
                case "*":
                    Console.WriteLine("Vastus: " + (a * b));
                    break;
                case "/":
                    Console.WriteLine("Vastus: " + (a / b));
                    break;
                default:
                    Console.WriteLine("Tundmatu tehe");
                    break;
            }
        }
    }
}
