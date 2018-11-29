
// Задача №200 от учебника на проф. Христо Крушков.

using System;


namespace Zad2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" Система от линейни уравнения от вида:");
            Console.WriteLine("  ах + by = c");
            Console.WriteLine("  dх + ey = f");

            Console.Write(" Въведете коефициента а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write(" Въведете коефициента b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write(" Въведете свободния член c: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write(" Въведете коефициента d: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write(" Въведете коефициента e: ");
            int e = int.Parse(Console.ReadLine());
            Console.Write(" Въведете свободния член f: ");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine(" Система от линейни уравнения бива:");
            Console.WriteLine("  {0}х + {1}y = {2}",a,b,c);
            Console.WriteLine("  {0}х + {1}y = {2}",d,e,f);

            int det = ((a * e) - (d * b));
            int d1 = ((c*e)-(f*b));
            int d2 = ((a * f) - (d * c));

            int x = d1 / det;
            int y = d2 / det;

            Console.WriteLine("  x = {0}",x);
            Console.WriteLine("  y = {0}",y);
        }
    }
}
