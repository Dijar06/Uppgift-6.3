using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Största talet av två tal");
            Console.WriteLine("3. Avsluta programmet");
            int val = int.Parse(Console.ReadLine());

            switch (val)
            {
                case 1:
                    MenyvalAddera();
                    break;

                case 2:
                    MenyvalStörstaTalet();
                    break;

                case 3:
                    break;

                default:
                    Console.WriteLine("Ogiligt alternativ");
                    break;
            }
        }

        static void MenyvalAddera()
        {
            Console.WriteLine("Skriv ett tal:");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett annat tal:");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett tredje tal:");
            int tal3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Summan är = " + (tal1+tal2+tal3));
        }

        static void MenyvalStörstaTalet()
        {
            Console.WriteLine("Skriv ett tal:");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett annat tal:");
            int tal2 = int.Parse(Console.ReadLine());
            if (tal1 > tal2)
            {
                Console.WriteLine("Största talet är " + tal1);
            }

            else if (tal1 < tal2)
            {
                Console.WriteLine("Största talet är " + tal2);
            }

            else
            {
                Console.WriteLine("Talen är lika stora");
            }
        }
    }
}