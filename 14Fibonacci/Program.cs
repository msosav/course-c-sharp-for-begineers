namespace Fibonacci {
  class Program {
    static void Main(string[] args) {
      var fibonacciNumbers = new List<int> {0, 1};
      for (int i = 0; i < 18; i++) {
        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
        fibonacciNumbers.Add(previous + previous2);
        Console.WriteLine(fibonacciNumbers[i]);
      }
    }
  }
}
