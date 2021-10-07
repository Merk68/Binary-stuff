using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_stuff
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> binar = new List<int>();
      int szamR = 0;
      string szoveg = "";
      Console.WriteLine("Adj meg egy számot: ");
      int szam = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Milyen szamrendszerben? ");
      szamR = Convert.ToInt32(Console.ReadLine());
      while (szam != 0)
      {
        int maradek = szam % szamR;
        szam /= 2;
        Console.WriteLine($"{szam } - {maradek}");
        szoveg = MaradekSzamjegybe(maradek) + szoveg;
        binar.Add(maradek);
        
      }
      binar.Reverse();
      Console.Write("\n");
      foreach (var b in binar)
      {
        Console.Write(b);
      }
      Console.ReadLine();
    }

    private static string MaradekSzamjegybe(int maradek)
    {
      if (maradek < 10)
      {
        return maradek.ToString();
      }
      else
      {
        return ((char)(55 + maradek)).ToString();
      }
    }
  }
}
