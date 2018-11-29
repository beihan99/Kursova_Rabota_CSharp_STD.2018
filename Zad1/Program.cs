
// Превърнете числото 2090 в 2, 8 и 16 бройна система.


using System;


namespace Zad1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" 2090(10) ---> (2)");
            Console.WriteLine(" 2090 / 2 = 1045  ост. 0 ^");
            Console.WriteLine(" 1045 / 2 = 522   ост. 1 |");
            Console.WriteLine(" 522 / 2 = 261    ост. 0 |");
            Console.WriteLine(" 261 / 2 = 130    ост. 1 |");
            Console.WriteLine(" 130 / 2 = 65     ост. 0 |");
            Console.WriteLine(" 65 / 2 = 32      ост. 1 |");
            Console.WriteLine(" 32 / 2 = 16      ост. 0 |");
            Console.WriteLine(" 16 / 2 = 8       ост. 0 |");
            Console.WriteLine(" 8 / 2 = 4        ост. 0 |");
            Console.WriteLine(" 4 / 2 = 2        ост. 0 |");
            Console.WriteLine(" 2 / 2 = 1        ост. 0 |");
            Console.WriteLine(" 1 / 2 = 0        ост. 1 |");
            Console.WriteLine(" 2090(10) ---> 100000101010(2)");
            Console.WriteLine(" ");

            Console.WriteLine(" 2090(10) ---> (8)");
            Console.WriteLine(" 2090 / 8 = 261  ост. 2 ^");
            Console.WriteLine(" 261 / 8 = 32    ост. 5 |");
            Console.WriteLine(" 32 / 8 = 4      ост. 0 |");
            Console.WriteLine(" 4 / 8 = 0       ост. 4 |");
            Console.WriteLine(" 2090(10) ---> 4052(8)");
            Console.WriteLine(" ");

            Console.WriteLine(" 2090(10) ---> (16)");
            Console.WriteLine(" 2090 / 16 = 130  ост. A ^");
            Console.WriteLine(" 130 / 16 = 8     ост. 2 |");
            Console.WriteLine(" 8 / 16 = 0       ост. 8 |");
            Console.WriteLine(" 2090(10) ---> 82A(16)");
        }
    }
}
