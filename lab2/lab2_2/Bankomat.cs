namespace lab2_2
{
  public class Bankomat
  {
    private double _totalBalance;

    public Bankomat(double totalBalance)
    {
      _totalBalance = totalBalance;
    }

    public void TopUpAccount(double money, Account acc)
    {
      Console.WriteLine($"было на аккаунте: {acc.Balance}");
      Console.WriteLine($"пополнили: {money}");
      acc.TopUpBalance(money);
      Console.WriteLine($"стало на аккаунте: {acc.Balance}");
    }

    public void WithdrawAccount(double money, Account acc)
    {
      Console.WriteLine($"было на аккаунте: {acc.Balance}");
      Console.WriteLine($"сняли: {money}");
      acc.WithdrawBalance(money);
      Console.WriteLine($"стало на аккаунте: {acc.Balance}");
    }

    public void TransferToAccount(double money, Account fromAcc, Account toAcc)
    {
      Console.WriteLine($"было на fromAcc аккаунте: {fromAcc.Balance}");
      Console.WriteLine($"было на toAcc аккаунте: {toAcc.Balance}");
      Console.WriteLine($"перевод на: {money}");
      fromAcc.TransferBalance(money, toAcc);
      Console.WriteLine($"стало на fromAcc аккаунте: {fromAcc.Balance}");
      Console.WriteLine($"стало на toAcc аккаунте: {toAcc.Balance}");
    }

    public double TotalBalance
    {
      get { return _totalBalance; }
      private set { _totalBalance = value; }
    }
  }
}