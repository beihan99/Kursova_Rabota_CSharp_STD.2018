
// Задача №396 от учебника на проф. Христо Крушков.

using System;

namespace Zad6
{
    class Program
    {
        static double KtoC(double k)
        {
            double c = k - 273.15;
            return c;
        }
        static double Tmin(double[] arr)
        {
            double min;
            double n = arr.Length;
            min = arr[0];
            for (int i = 1; i < n; i++)

            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
            return min;
        }

        static void Main()
        {
            Console.Write(" Въведете темпертура в Келвини: ");
            double k = double.Parse(Console.ReadLine());
            Console.WriteLine(" Темпертурата в Целзий е: {0:F1}",KtoC(k));

            Console.WriteLine(" ");
            Console.Write(" Месец: ");
            string m = Console.ReadLine();
            double[] arr = new double[31];
            
              for (int i = 0; i < arr.Length; i++)
              {
                Console.Write(" Въведете среднодневната темпертура по дни в Келвини: ");
                double kt = double.Parse(Console.ReadLine());
                
                  if (kt >= 223 && kt <= 323)
                  {
                    arr[i] = kt;
                  }
                  else
                  {
                    Console.WriteLine(" Невалиднa среднoдневна температурa !!!");
                  }
              }

            Console.WriteLine(" ");
            Console.WriteLine(" Минималната температура за м. {0} в Келвини е: {1:F1}", m,Tmin(arr));
            Console.WriteLine(" Минималната температура за м. {0} в Целзий е: {1:F1}", m,KtoC(Tmin(arr)));
            Console.WriteLine(" ");
            
                double[] arr1 = new double[arr.Length]; ;
                  for (int i = 0; i < arr.Length; i++)
                  {
                    arr1[i] = KtoC(arr[i]);
                    if (arr1[i] >= 10 && arr1[i] <= 30)
                    {
                      Console.WriteLine(" Среднодневните температури в диапозона (10 - 30 Целзий) за {0} са: {1:F1}",m,arr1[i]);
                    }
                  }
        }
    }
}
