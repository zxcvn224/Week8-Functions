using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("sisestage perekonnanimi:");
            string lastName = Console.ReadLine();
            Console.WriteLine("sisesta sünniaasta:");
            int userAge = Convert.ToInt32(Console.ReadLine());


            Greetings(userName, userAge, lastName);
        }

        private static void Greetings(string someString, int someInt, string otherString)
        {
            Console.WriteLine($"Tere {someString} {otherString}!");
            Console.WriteLine($"Oled {2021 - someInt} aastat vana.");
        }


    }
}
