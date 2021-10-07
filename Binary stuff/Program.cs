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
      Console.WriteLine("Adj meg egy számot: ");
      int szam = Convert.ToInt32(Console.ReadLine());
      while (szam != 0)
      {
        int maradek = szam % 2;
        szam /= 2;
        Console.WriteLine($"{szam } - {maradek}");
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
  }
}
