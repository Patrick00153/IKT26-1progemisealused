using System;

namespace SwitchVarv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali värv (punane / roheline / sinine): ");
            string varv = Console.ReadLine();
            
            switch (varv)
            {
                case "punane":
                    Console.WriteLine("Valisid punase");
                    break;
                case "roheline":
                    Console.WriteLine("Valisid rohelise");
                    break;
                case "sinine":
                    Console.WriteLine("Valisid sinise");
                    break;
                default:
                    Console.WriteLine("Tundmatu värv");
                    break;
            }
        }
    }
}
