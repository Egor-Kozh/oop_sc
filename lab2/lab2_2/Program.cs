using lab2_2;

class Programm
{
  public static void Main(string[] args)
  {
    Account egor = new Account(50_000);

    egor.CreateDebitAccount(0);

    Bankomat atm1 = new Bankomat(500_000);

    atm1.TopUpAccount(5_000, egor.CurrentAccount);
    atm1.TransferToAccount(20_000, egor.CurrentAccount, egor.DebitAccount);
  }
} 
