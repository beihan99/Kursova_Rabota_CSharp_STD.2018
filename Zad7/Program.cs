
// Задача №362 от учебника на проф. Христо Крушков.

using System;

namespace Zad7
{
    class Program
    {
        static string Change(string s, string x, string y)
        {
            string chang = s.Replace(x, y);
            return chang;
        }
        static void Main()
        {
            Console.Write(" Въведете текстов низ(S): ");
            string s = Console.ReadLine();

            Console.Write(" Въведете низ за проверка(Х): ");
            string x = Console.ReadLine();

            Console.Write(" Въведете низ за заместване(Y): ");
            string y = Console.ReadLine();

            Console.WriteLine(" Резултатa от замяната: {0}", Change(s, x, y)); 
        }
    }
}
