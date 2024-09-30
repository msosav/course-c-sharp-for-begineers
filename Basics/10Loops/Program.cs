namespace Loops
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("While loop");
      int counter = 0;
      while (counter < 10)
      {
        Console.WriteLine($"Hello World! The counter is {counter}");
        counter++;
      }
      Console.WriteLine("\nFor loop");
      for (int index = 0; index < 10; index++)
      {
        Console.WriteLine($"Hello World! The index is {index}");
      }

      Console.WriteLine("\nDo While loop");
      int count = 0;
      do
      {
        Console.WriteLine($"Hello World! The count is {count}");
        count++;
      } while (count < 10);
    }
  }
}
