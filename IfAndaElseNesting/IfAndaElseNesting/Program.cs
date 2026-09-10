namespace IfAndaElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If And Else Nesting");
            //Nesting tähendab, et if-else struktuuride
            //sees võib olla teise if-else truktuure.
            //se võimaldab teha keerukamaid otsuseid ja
            //kontrollida ernivaid tingimusi. 

            int number = 21;
            if (number ==  9)
            {
                //kui sisestan9, siis see if-else truktuur käivitub
                if (number == 11)
                {
                    //kui sisestan 11, siis see if-else struktuur käivitub
                    Console.WriteLine("number on 11");
                }
                else
                {
                    Console.WriteLine("Vastus oli 0 kuni 10 ja 12 kuni 19");
                }
            }
            else if (number == 21)
            {
                Console.WriteLine("Vastus oli 21");
            }
            else if (number == 30)
            {
                Console.WriteLine("Vasts oli 30");
            }
            else
            {
                Console.WriteLine("Mingi kahtlane number");
            }
        }
    }
}
