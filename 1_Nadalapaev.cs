using System;

namespace SwitchNadalapaev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta nädalapäeva number (1-7): ");
            int paev = int.Parse(Console.ReadLine());
            
            switch (paev)
            {
                case 1:
                    Console.WriteLine("Esmaspäev");
                    break;
                case 2:
                    Console.WriteLine("Teisipäev");
                    break;
                case 3:
                    Console.WriteLine("Kolmapäev");
                    break;
                case 4:
                    Console.WriteLine("Neljapäev");
                    break;
                case 5:
                    Console.WriteLine("Reede");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Nädalavahetus");
                    break;
                default:
                    Console.WriteLine("Sellist päeva pole");
                    break;
            }
        }
    }
}
