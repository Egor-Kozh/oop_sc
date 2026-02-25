using NUnit.Framework;
using System;

namespace lab2_2.Tests
{
  [TestFixture]
  public class AccountTests
  {
    [Test]
    public void ТестНаПополнениеСчета()
    {
      double expectedBalance = 55_000;

      Account egor = new Account(50_000);
      Bankomat atm1 = new Bankomat(500_000);

      atm1.TopUpAccount(5_000, egor.CurrentAccount);

      Assert.AreEqual(expectedBalance, egor.CurrentAccount.Balance);
    }

    [Test]
    public void ТестНаСнятиеСчета()
    {
      double expectedBalance = 45_000;

      Account egor = new Account(50_000);
      Bankomat atm1 = new Bankomat(500_000);

      atm1.WithdrawAccount(5_000, egor.CurrentAccount);

      Assert.AreEqual(expectedBalance, egor.CurrentAccount.Balance);
    }

    [Test]
    public void ТестНаСозданиеДебитовогоСчета()
    {
      Account egor = new Account(50_000);

      egor.CreateDebitAccount(0);

      Assert.That(egor.DebitAccount, Is.Not.Null, "DebitAccount не создан");
    }

    [Test]
    public void ТестНаСозданиеКредитногоСчета()
    {
      Account egor = new Account(50_000);

      egor.CreateCreditAccount(0);

      Assert.That(egor.CreditAccount, Is.Not.Null, "CreditAccount не создан");
    }

    [Test]
    public void ТестНаПереводСоСчетов()
    {
      double expectedfromAccBalance = 45_000;
      double expectedtoAccBalance = 5_000;

      Account egor = new Account(50_000);
      egor.CreateDebitAccount(0);
      Bankomat atm1 = new Bankomat(500_000);

      atm1.TransferToAccount(5_000, egor.CurrentAccount, egor.DebitAccount);

      Assert.AreEqual(expectedfromAccBalance, egor.CurrentAccount.Balance);
      Assert.AreEqual(expectedtoAccBalance, egor.DebitAccount.Balance);
    }

    [Test]
    public void ТестНаЗапретНаСянтиеБолее30000()
    {
      double expectedBalance = 50_000;

      Account egor = new Account(50_000);
      Bankomat atm1 = new Bankomat(500_000);

      atm1.WithdrawAccount(30_001, egor.CurrentAccount);

      Assert.AreEqual(expectedBalance, egor.CurrentAccount.Balance);
    }

    [Test]
    public void ТестНаЗапретНаРаботуСДебетовымСчетомЕслиКредитныйСчетМеньшеМинус20000()
    {
      double expectedBalance = 30_000;

      Account egor = new Account(50_000);
      egor.CreateDebitAccount(30_000);
      egor.CreateCreditAccount(-20_001);
      Bankomat atm1 = new Bankomat(500_000);

      atm1.TopUpAccount(5_000, egor.DebitAccount);
      atm1.WithdrawAccount(5_000, egor.DebitAccount);
      atm1.TransferToAccount(5_000, egor.DebitAccount, egor.CurrentAccount);

      Assert.AreEqual(expectedBalance, egor.DebitAccount.Balance);
    }
  }
}