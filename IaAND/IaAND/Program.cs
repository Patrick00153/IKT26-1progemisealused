using System.ComponentModel.Design;
using System.Threading.Channels;

namespace IaAND
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("sisesta enda nimi");

            string name = Console.ReadLine();
            //kui kasutaja sisestab midagi siis mudedakse taustavarvi


            if (name != "")
            {
                Console.WriteLine("Sisestasid enda nime");
                Console.WriteLine(name);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;

                Console.WriteLine("sisestasid tühja nime");
                //kui kasutaja ei sisesa midagi siis kostub 2 piiksu
                Thread.Sleep(1000);
                Console.Beep();
            }
        }

    }
}
