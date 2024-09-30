using System;
using System.Collections.Generic;

namespace DataStructures
{
  class Program
  {
    static void Main(string[] args)
    {
      var names = new List<string> { "<name>", "Ana", "Felipe" };
      foreach (var name in names)
      {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }

      Console.WriteLine();

      for (int i = 0; i < names.Count; i++)
      {
        Console.WriteLine($"Hello {names[i].ToUpper()}!");
      }

      Console.WriteLine();

      names.Add("Maria");
      names.Add("Bill");
      names.Remove("Ana");
      foreach (var name in names)
      {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }
    }
  }
}
