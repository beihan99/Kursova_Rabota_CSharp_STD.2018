
// Задача №164 от учебника на проф. Христо Крушков.

using System;

namespace Zad5
{
    class Program
    {
         static bool Triag(double xa, double ya, double xb, double yb, double xc, double yc)
         {
            double A = xa + ya;
            double B = xb + yb;
            double C = xc + yc;
            double max = Math.Max(Math.Max(A, B), C);

            bool a = max == A && A > B + C ? true : false;
            bool b = max == B && B > A + C ? true : false;
            bool c = max == C && C > A + B ? true : false;
            bool abc = a == true || b == true || c == true ? true : false;
            
            return abc;
         }

         static double Lice(double xa, double ya, double xb, double yb, double xc, double yc)
         {
            double Xab = xb - xa;
            double Yab = yb - ya;
            double Zab = 0;

            double Xac = xc - xa;
            double Yac = yc - ya;
            double Zac = 0;

            double Xdet = (Yab * Zac) - (Zab * Yac);
            double Ydet = (Xab * Zac) - (Zab * Xac);
            double Zdet = (Xab * Yac) - (Yab * Xac);

            double ABxAC = Math.Sqrt(Math.Pow(Xdet,2) + Math.Pow(Ydet, 2) + Math.Pow(Zdet, 2));
            double S = 0.5 * ABxAC;
            
            return S;
         } 
        
        static  void Main()
        {
            Console.WriteLine(" Въведете кординати за т. А");
            Console.Write(" xa = ");
            double xa = double.Parse(Console.ReadLine());
            Console.Write(" ya = ");
            double ya = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine(" Въведете кординати за т. B");
            Console.Write(" xb = ");
            double xb = double.Parse(Console.ReadLine());
            Console.Write(" yb = ");
            double yb = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine(" Въведете кординати за т. C");
            Console.Write(" xc = ");
            double xc = double.Parse(Console.ReadLine());
            Console.Write(" yc = ");
            double yc = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine(" ABC триъгълник ? - {0}",Triag(xa, ya, xb, yb, xc, yc));

             if (Triag(xa, ya, xb, yb, xc, yc) == true)
             {
                Console.WriteLine(" Лицето на тр. ABC e: {0} кв.см", Lice(xa, ya, xb, yb, xc, yc));
             }
        }
    }
}
