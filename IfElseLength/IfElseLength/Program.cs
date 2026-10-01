namespace IfElseLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teha neli if-ja else-i kontrolli, kus kontrollitakse inimese pikkustsentimeetrites.
            //esimene kontroll on 40-80 sentimeetri juures.
            //teine kontroll 81-130 sentimeetri juures.
            //kolmas kontroll 131-170 sentimeetri juures ja neljas on suuremad, kui 170 sentimeetrit.
            //kui mingi suurus on tuvastatud, siis konsool näitab teksti: Sinu pikkus on (sisestatud suurus)
            Console.WriteLine("Sisestage oma pikkus");

            string heightnumber = Console.ReadLine();
            int height = int.Parse(heightnumber);

            if (height >= 40 && height <= 80)
            {
                Console.WriteLine("Sinu pikkus on 40 kuni 80 sentimeetrit");
            }
            else if (height >= 81 && height <= 130)
            {
                Console.WriteLine("Sinu pikkus on 81 kuni 130 sentimeetrit");
            }
            else if (height >= 131 && height <= 170)
            {
                Console.WriteLine("Sinu pikkus on 131 kuni 170 sentimeetrit");
            }
            else if (height > 170)
            {
                Console.WriteLine("Sinu pikkus on suurem kui 170 sentimeetrit");
            }
        }
    }
}
