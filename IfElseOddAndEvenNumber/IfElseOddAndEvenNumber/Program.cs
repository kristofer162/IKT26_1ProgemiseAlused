namespace IfElseOddAndEvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //konsool küsib numbrit
            //number tuleb ära parsida

            //if ja else juures toiub kontroll, et
            //kas on paaris või paaritu number

            string nr = Console.ReadLine();
            int number = int.Parse(nr);

            //% jagab muutuja number 2-ga kuni võrdub 0
            //% jagab muutujat number 2
            //kui 2 asemele panna 3, siis jagab 3-ga
            if (number %2 == 0)
            {
                Console.WriteLine("See on paaris arv" + number);
                // siia tuleb välja kutsuda meetod,
                // mis ütleb, et see on paarisarv
                EvenNumberMethod();

            }
            else
            {
                Console.WriteLine("See on paaritu number" + number);
                //siia tuleb välja kutsuda meetod, 
                //mis ütleb, et see on paarituarv
                OddNumberMethod();
            }
        }

        static void EvenNumberMethod()
        {
            Console.WriteLine("See on paarisarv");
        }

        static void OddNumberMethod()
        {
            Console.WriteLine("See on paarituarv");
        }
    }
}
