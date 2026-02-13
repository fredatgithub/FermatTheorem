using System;
using System.Numerics;

namespace FermatTheoremBigInteger
{
  internal class Program
  {
    static void Main()
    {
      BigInteger compteur = 0;

      for (BigInteger a = 1; a < 100; a++)
      {
        for (BigInteger b = 1; b < 100; b++)
        {
          for (BigInteger c = 1; c < 100; c++)
          {
            for (int n = 3; n < 10; n++)
            {
              BigInteger aPow = BigInteger.Pow(a, n);
              BigInteger bPow = BigInteger.Pow(b, n);
              BigInteger cPow = BigInteger.Pow(c, n);

              if (aPow + bPow == cPow)
              {
                Console.WriteLine($"Found a counterexample: {a}^{n} + {b}^{n} = {c}^{n}");
                return;
              }

              compteur++;
              Console.WriteLine($"Checked {compteur} combinations: a={a}, b={b}, c={c}, n={n}");
            }
          }
        }
      }

      Console.WriteLine("Fermat's Last Theorem holds for all tested combinations.");
      Console.WriteLine("Press any key to exit.");
      Console.ReadKey();
    }
  }
}
