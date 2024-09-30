using Classes;

namespace MySuperBank
{
  class Program
  {
    static void Main(string[] args)
    {
      var account = new BankAccount("Soos", 10000);
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
    }
  }
}
