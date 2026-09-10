namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //konsoolis sisestame numbri
            //see number salvestatakse string andmetüüpi
            //toimub kontroll, kas sisetatud väärtus on number
            //kasutada if ja else lauseid
            string input = Console.ReadLine();

            //kontrollime kas sistatud väärtus on number
            if (int.TryParse(input, out int number))
            {
                Console.WriteLine("Sistatud number");
            }
            else
            {
                Console.WriteLine("Sisestaud väärtus ei ole number.");
            }
        }
    }
}
