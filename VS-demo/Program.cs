using System;

namespace VS_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter you name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName);     // concat
            Console.WriteLine("Hello {0}", userName);   // place holder
            Console.WriteLine($"Hello {userName}");
            */

            /*
            Console.WriteLine("Enter you first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter you last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName + " " + lastName);     // concat
            Console.WriteLine("Hello {0} {1}", firstName, lastName);   // place holder
            Console.WriteLine($"Hello {firstName} {lastName}"); 
            */

            // int? i = 77;

            int? ticketsOnSale = null;
            
            /*
            if (ticketsOnSale == null)
                availableTickts = 0;
            else
                availableTickts = (int)ticketsOnSale;
            */

            int availableTickts = ticketsOnSale ?? 0;

            Console.WriteLine(availableTickts);

            // sbyte byte short ushort int uint long ulong

            Console.WriteLine("type: \t\t Size: \t\t Min \t\t\t Max");
            Console.WriteLine("sbyte \t\t" + sizeof(sbyte) + "\t\t" + sbyte.MinValue + "\t\t\t" +
                sbyte.MaxValue);
            Console.WriteLine("byte \t\t" + sizeof(byte) + "\t\t" + byte.MinValue + "\t\t\t" +
                byte.MaxValue);
            Console.WriteLine("short \t\t" + sizeof(short) + "\t\t" + short.MinValue + "\t\t\t" +
                short.MaxValue);
        }
    }
}
