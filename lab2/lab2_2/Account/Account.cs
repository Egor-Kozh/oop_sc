namespace lab2_2
{
  public class Account
  {
    private static double _totalBalance = 0;
    protected double _balance;

    private Account _owner;

    private CreditAccount? _creditAccount;

    private DebitAccount? _debitAccount;

    private CurrentAccount _currentAccount;

    public Account(double balance)
    {
      if (GetType() == typeof(Account))
      {
        CreateCurrentAccount(balance);
        _owner = this;
      }
      else
      {
        _balance = balance;
        _totalBalance += balance;
      }
    }

    public virtual void TopUpBalance(double money)
    {
      _balance += money;
      _totalBalance += money;
    }

    public virtual void WithdrawBalance(double money)
    {
      if (money <= 30_000)
      {
        _balance -= money;
        _totalBalance -= money;
      }
      else
      {
        Console.WriteLine("Сумма больше чем 30 000");
      }
    }

    public virtual void TransferBalance(double money, Account toAcc)
    {
      WithdrawBalance(money);
      toAcc.TopUpBalance(money);
    }

    public double Balance
    {
      get { return _balance; }
      set { _balance = value; }
    }

    public static double TotalBalance
    {
      get { return _totalBalance; }
      set { _totalBalance = value; }
    }

    private void SetOwner(Account owner)
    {
      _owner = owner;
    }

    protected Account? Owner => _owner;

    public void CreateCreditAccount(double money)
    {
      _creditAccount = new CreditAccount(money);
      _creditAccount.SetOwner(this);
    }

    public void CreateDebitAccount(double money)
    {
      _debitAccount = new DebitAccount(money);
      _debitAccount.SetOwner(this);
    }

    public void CreateCurrentAccount(double money)
    {
      _currentAccount = new CurrentAccount(money);
      _currentAccount.SetOwner(this);
    }

    public CreditAccount CreditAccount
    {
      get { return _creditAccount; }
    }

    public DebitAccount DebitAccount
    {
      get { return _debitAccount; }
    }

    public CurrentAccount CurrentAccount
    {
      get { return _currentAccount; }
    }
  }
}