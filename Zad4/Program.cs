
// Задача №213Б от учебника на проф. Христо Крушков.

using System;

namespace Zad4
{
    class Program
    {
        static void Main()
        {
            double s = 0;
              for(int i=2; i <= 50; i++)
              {
                s += (1.0 / i);
              }
            Console.WriteLine(" Сбора на дробите (1/2 - 1/50) е: {0}", s);
        }
    }
}
