using System;

namespace apl
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 10);

            Console.WriteLine($"Introdu un numar pentru axa X: ");
            string firstN = Console.ReadLine();
            int coodronataX = Convert.ToInt32(firstN);

            Console.WriteLine($"Numarul introdus este: {coodronataX}");

            Console.WriteLine($"Introdu un numar pentru axa Y: ");
            string secondN = Console.ReadLine();
            int coordonataY = Convert.ToInt32(secondN);

            Console.WriteLine($"Numarul introdus este: {coordonataY}");

            Point punctulUserului = new Point(coodronataX, coordonataY);

            bool nuSeContineInP1 = punctulUserului.X > p1.X || punctulUserului.Y > p1.Y;

            if (nuSeContineInP1 == true)
            {
                Console.WriteLine("Nu se contine");
            }
            else
            {
                Console.WriteLine($"Punctul cu coordonatele X: {punctulUserului.X} si Y: {punctulUserului.Y} este in interior");
            }

            Console.ReadLine();
        }
    }
}
