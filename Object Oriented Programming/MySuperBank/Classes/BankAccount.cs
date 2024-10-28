namespace Classes
{
  public class BankAccount
  {
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }

    private static int accountNumberSeed = 1234567890;

    public BankAccount(string owner, decimal balance)
    {
      this.Owner = owner;
      this.Balance = balance;
      this.Number = accountNumberSeed.ToString();
      accountNumberSeed++;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
      
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
      
    }
  }
}
