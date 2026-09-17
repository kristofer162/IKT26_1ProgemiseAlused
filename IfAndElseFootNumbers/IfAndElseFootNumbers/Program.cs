namespace IfAndElseFootNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Sisesta jalanumber");

            string footNumber = Console.ReadLine();
            int foot = int.Parse(footNumber);

            if (foot >= 30 && foot <= 33)
            {
                Console.WriteLine("Jalanumber on 30 kuni 33");
            }
            else if (foot >= 34 && foot <= 38)
            {
                Console.WriteLine("Jalanumber on 34 kuni 38");
            }
            else if (foot >= 39 && foot <= 44)
            {
                Console.WriteLine("Jalanumber on 39 kuni 44");
            }
            else if (foot >= 45 && foot <= 48)
            {
                Console.WriteLine("Jalanumber on 45 kuni 48");
            }
            else
            {
                Console.WriteLine("Sinu jalanumber on väga suur või väga väike");
            }

        }
    }
}
