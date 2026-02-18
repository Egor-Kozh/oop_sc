namespace lab2_2
{
  public sealed class CreditAccount : Account
  {
    public CreditAccount(double balance) : base(balance)
    {
      Console.WriteLine($"кредитный счет с балансом: {balance}");
    }
  }
}