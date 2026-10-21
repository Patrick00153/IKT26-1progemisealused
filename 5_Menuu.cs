using System;

namespace SwitchMenuu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Tere\n2 - Nägemist\n3 - Välju");
            string valik = Console.ReadLine();
            
            switch (valik)
            {
                case "1":
                    Console.WriteLine("Tere!");
                    break;
                case "2":
                    Console.WriteLine("Nägemist!");
                    break;
                case "3":
                    Console.WriteLine("Väljun programmist");
                    break;
                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }
    }
}
