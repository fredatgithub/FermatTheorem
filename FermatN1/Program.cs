using System;
using System.Collections.Generic;

namespace FermatN1
{
  internal class Program
  {
    static void Main()
    {
      var results = new List<string>();
      ulong compteur = 0;
      for (int a = 1; a < 100; a++)
      {
        for (int b = 1; b < 100; b++)
        {
          for (int c = 1; c < 100; c++)
          {
            int n = 2;

            if (Math.Pow(a, n) > ulong.MaxValue || Math.Pow(b, n) > ulong.MaxValue || Math.Pow(c, n) > ulong.MaxValue)
            {
              Console.WriteLine($"Values exceed ulong max value: {ulong.MaxValue}");
              return;
            }

            if (Math.Pow(a, n) + Math.Pow(b, n) == Math.Pow(c, n))
            {
              Console.WriteLine($"Found a counterexample: {a}^{n} + {b}^{n} = {c}^{n} and {Math.Pow(a, n)} + {Math.Pow(b, n)} = {Math.Pow(c, n)}");
              results.Add($"Counter example: {a}^{n} + {b}^{n} = {c}^{n} and {Math.Pow(a, n)} + {Math.Pow(b, n)} = {Math.Pow(c, n)}");
            }

            compteur++;
            Console.WriteLine($"Checked {compteur} combinations: a={a}, b={b}, c={c}, n={n} and {Math.Pow(a, n)} + {Math.Pow(b, n)} = {Math.Pow(c, n)}");
          }
        }

        if (results.Count == 0)
        {
          Console.WriteLine("No counterexamples found.");
          Console.WriteLine("Fermat's Last Theorem holds for all tested combinations.");
        }
        else
        {
          Console.WriteLine($"{results.Count} counter examples found:");
          foreach (var result in results)
          {
            Console.WriteLine(result);
          }
        }
      }

      
      Console.WriteLine("Press any key to exit.");
      Console.ReadKey();
    }
  }
}
