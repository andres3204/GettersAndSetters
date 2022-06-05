using System;

namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie(" The Avengers", " Joss Whedon", " PG-13");
            Movie shrek = new Movie(" Shrek", " Adam Adamson", " PG");

            Console.WriteLine(avengers.title);
            Console.WriteLine(avengers.director);
            Console.WriteLine(avengers.Rating);
            Console.WriteLine("----");
            Console.WriteLine(shrek.title);
            Console.WriteLine(shrek.director);
            Console.WriteLine(shrek.Rating);

            Console.ReadLine();
        }
    }
}
