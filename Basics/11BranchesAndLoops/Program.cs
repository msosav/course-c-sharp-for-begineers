namespace BranchesAndLoops {
  class Program {
    static void Main(string[] args) {
      int sum = 0;
      for (int i = 1; i <= 12; i++) {
        if (i % 3 == 0) {
          sum = sum + i;
          Console.WriteLine($"The sum is {sum}");
        }
      }
    }
  }
}
