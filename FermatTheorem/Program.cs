using System;

namespace FermatTheorem
{
  internal class Program
  {
    static void Main()
    {
      ulong compteur = 0;
      for (int a = 1; a < 100; a++)
      {
        for (int b = 1; b < 100; b++)
        {
          for (int c = 1; c < 100; c++)
          {
            for (int n = 3; n < 10; n++)
            {
              if (Math.Pow(a, n) + Math.Pow(b, n) == Math.Pow(c, n))
              {
                Console.WriteLine($"Found a counterexample: {a}^{n} + {b}^{n} = {c}^{n}");
                return;
              }

              compteur++;
              Console.WriteLine($"Checked {compteur} combinations: a={a}, b={b}, c={c}, n={n}");
            }
          }
        }

        Console.WriteLine("No counterexamples found.");
      }

      Console.WriteLine("Fermat's Last Theorem holds for all tested combinations.");
      Console.WriteLine("Press any key to exit.");
      Console.ReadKey();
    }
  }
}
