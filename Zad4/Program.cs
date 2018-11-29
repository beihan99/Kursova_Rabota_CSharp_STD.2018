
// Задача №213Б от учебника на проф. Христо Крушков.

using System;

namespace Zad4
{
    class Program
    {
        static void Main()
        {
            double s = 1.0 / 2;
              for(int i=3; i <= 50; i++)
              {
                s += (1.0 / i);
              }
            Console.WriteLine(" Сбора на дробите е: {0}", s);
        }
    }
}
