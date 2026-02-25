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
      if (Owner.CreditAccount != null)
      {
        Console.WriteLine($"{Owner.CreditAccount.Balance} КРЕЕДИИТТ!!!");
      }

      return Owner.CreditAccount != null ? Owner.CreditAccount.Balance >= -20_000 : true;
    }
  }
}