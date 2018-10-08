using System;

namespace MathPgcd
{
  public class Program
  {
    public static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Searching for PGCD");
      display($"PGCD(6, 9) is {Pgcd(6, 9)}");
      display($"PGCD(15, 5) is {Pgcd(5, 15)}");
      display("Press any key to exit:");
      Console.ReadLine();
    }

    public static int Pgcd(int a, int b)
    {
      if (b > a)
      {
        a = Math.Max(a, b);
        b = Math.Min(a, b);
      }

      int r = a % b;
      //do
      //{
      //  r = a % b;
      //  a = b;
      //  b = r;
      //}while(r != 0);
      
      while (r != 0)
      {
        r = a % b;
        a = b;
        b = r;
      }; 

      return b;
    }

    //public static (int, int) Swap(int a, int b)
    //{
    //  return new ValueTuple<int, int>(b, a);
    //}
  }
}