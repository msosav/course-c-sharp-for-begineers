using Classes;

namespace MySuperBank
{
  class Program
  {
    static void Main(string[] args)
    {
      var account = new BankAccount("Soos", 10000);
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
      var account2 = new BankAccount("Sooos", 10000);
      Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");
    }
  }
}
