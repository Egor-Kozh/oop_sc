namespace lab2_2
{
  public sealed class DebitAccount : Account
  {
    public DebitAccount(double balance) : base(balance)
    {
      Console.WriteLine($"дебитовый счет с балансом: {balance}");
    }

    public override void TopUpBalance(double money)
    {
      if (Check())
      {
        base.TopUpBalance(money);
      }
    }

    public override void WithdrawBalance(double money)
    {
      if (Check())
      {
        base.WithdrawBalance(money);
      }
    }

    public override void TransferBalance(double money, Account toAcc)
    {
      if (Check())
      {
        base.TransferBalance(money, toAcc);
      }
    }

    private bool Check()
    {
      return base.CreditAccount != null ? base.CreditAccount.Balance >= -20_000 : true;
    } 
  }
}