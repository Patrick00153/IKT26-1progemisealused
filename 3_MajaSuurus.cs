using System;

namespace SwitchMaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta maja suurus ruutmeetrites: ");
            int maja = int.Parse(Console.ReadLine());
            
            switch (maja)
            {
                case <= 40:
                    Console.WriteLine("Sinu maja suurus on 0-40 ruutmeetrit");
                    break;
                case <= 90:
                    Console.WriteLine("Sinu maja suurus on 41-90 ruutmeetrit");
                    break;
                case <= 130:
                    Console.WriteLine("Sinu maja suurus on 91-130 ruutmeetrit");
                    break;
                default:
                    Console.WriteLine("Sinu maja on suurem, kui 131 ruutmeetrit");
                    break;
            }
        }
    }
}
