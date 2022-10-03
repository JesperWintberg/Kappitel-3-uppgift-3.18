using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt för och efternamn");
            string mening = Console.ReadLine();

            string[] ord = mening.Split(' ');

            string[] names = { ord[0], ord[1] };
            var sortedNames = names.OrderBy(n => n);
            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);    
            } 
        }
    }
}

