namespace lab2_2
{
  public sealed class CurrentAccount : Account
  {
    public CurrentAccount(double balance) : base(balance)
    {
      Console.WriteLine($"текущий счет с балансом: {balance}");
    }

    public override void TopUpBalance(double money)
    {
      if(money > 1_000_000)
      {
        base.DebitAccount.TopUpBalance(2_000);
      }
      base.TopUpBalance(money);
    }
  }
}