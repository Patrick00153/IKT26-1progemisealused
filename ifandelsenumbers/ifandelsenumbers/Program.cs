namespace ifandelsenumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //konoolis sisestame numbri
            //see number salvestatakse string andmetuupi
            //toimub konroll kas sisestatud vaartus on number
            //kasutada if ja else lauseid

            Console.WriteLine("sisesta number");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                Console.WriteLine("Sisestatud väärtus on number: " + number);
            }
            else
            {
                Console.WriteLine("Sisestatud väärtus ei ole number!");
            }
        }
    }
}
