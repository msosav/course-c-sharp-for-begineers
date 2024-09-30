﻿namespace SortSearchIndex
{
  class Program
  {
    static void Main(string[] args)
    {
      var names = new List<string> { "<name>", "Ana", "Felipe" };
      names.Add("Maria");
      names.Add("Bill");
      names.Remove("Ana");

      var index = names.IndexOf("Felipe");
      if (index != -1)
      {
        Console.WriteLine($"The name {names[index]} is at index {index}");
      }

      var notFound = names.IndexOf("Not Found");
      Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

      // Sort and then print the list
      Console.WriteLine("\nBefore Sort");
      foreach (var name in names)
      {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }
      Console.WriteLine("\nAfter Sort");
      names.Sort();
      foreach (var name in names)
      {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }
    }
  }
}
