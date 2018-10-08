using System;
using System.Collections.Generic;

namespace MathPgcd
{
  public class Program
  {
    public static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Searching for PGCD");
      display($"PGCD(6, 9) is {Pgcd(6, 9)}");
      display($"PGCD(5, 15) is {Pgcd(5, 15)}");
      display($"PGCD(15, 5) is {Pgcd(15, 5)}");
      // PGCD(1 071 ; 1 029) = 21
      display($"PGCD(1071, 1029) is {Pgcd(1029, 1071)}");
      display("Press any key to exit:");
      Console.ReadLine();
    }

    public static int Pgcd(int a, int b)
    {
      int r = a % b;
      while (r != 0)
      {
        a = b;
        b = r;
        r = a % b;
      };

      return b;
    }

    // open solution with VS2017

    //(int, int) Swap(int first, int last)
    //{
    //  return (last, first);
    //}

    //(int, int, int, int) UpdateAges(int age1, int age2, int age3, int age4) // tuple return type
    //{
    //  age1++;
    //  age2++;
    //  age3++;
    //  age4++;

    //  return (age1, age2, age3, age4);
    //}

    public static KeyValuePair<int, int> SwapNumbers(int x, int y)
    {
      return new KeyValuePair<int, int>(y, x);
    }
  }
}