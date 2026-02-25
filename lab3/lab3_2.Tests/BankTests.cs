namespace lab3_2.Tests;

[TestFixture]
public class BankEmployeeTests
{
    [Test]
    public void СотрудникБанка_РасчетМаксимальногоКредита_ДляМенеджера_ВозвращаетПравильнуюСумму()
    {
        var employee = new BankEmployee("Иван Петров", 100000, 35, 5, "менеджер");

        double maxCredit = employee.CalculateMaxCreditAmount();

        Assert.That(maxCredit, Is.EqualTo(2750000));
    }

    [Test]
    public void СотрудникБанка_РасчетМаксимальногоКредита_ДляРуководителя_ВозвращаетПравильнуюСумму()
    {
        var employee = new BankEmployee("Петр Сидоров", 150000, 40, 10, "руководитель");

        double maxCredit = employee.CalculateMaxCreditAmount();

        Assert.That(maxCredit, Is.EqualTo(4500000));
    }

    [Test]
    public void СотрудникБанка_РасчетПроцентнойСтавки_ДляМенеджера_ВозвращаетПравильнуюСтавку()
    {
        var employee = new BankEmployee("Иван Петров", 100000, 35, 5, "менеджер");

        double rate = employee.CalculateInterestRate();

        Assert.That(rate, Is.EqualTo(0.035));
    }
}

[TestFixture]
public class CitizenTests
{
    [Test]
    public void ОбычныйГражданин_СХорошейКредитнойИсторией_ВозвращаетПравильныеЗначения()
    {
        var citizen = new Citizen("Анна Смирнова", 50000, 30, true, 36);

        double maxCredit = citizen.CalculateMaxCreditAmount();
        double rate = citizen.CalculateInterestRate();

        Assert.That(maxCredit, Is.EqualTo(572000));
        Assert.That(rate, Is.EqualTo(0.13));
    }

    [Test]
    public void ОбычныйГражданин_БезПостояннойРаботы_ВозвращаетПравильныеЗначения()
    {
        var citizen = new Citizen("Елена Козлова", 40000, 28, false, 6);

        double maxCredit = citizen.CalculateMaxCreditAmount();
        double rate = citizen.CalculateInterestRate();

        Assert.That(maxCredit, Is.EqualTo(212000));
        Assert.That(rate, Is.EqualTo(0.20));
    }
}

[TestFixture]
public class BadCreditCitizenTests
{
    [Test]
    public void ПлохаяКредитнаяИстория_СДвумяПросрочками_ВозвращаетПравильныеЗначения()
    {
        var badClient = new BadCreditCitizen("Петр Иванов", 50000, 40, 2, 50000);

        double maxCredit = badClient.CalculateMaxCreditAmount();
        double rate = badClient.CalculateInterestRate();

        Assert.That(maxCredit, Is.EqualTo(100000));
        Assert.That(rate, Is.EqualTo(0.35));
    }

    [Test]
    public void ПлохаяКредитнаяИстория_СТремяПросрочками_ВозвращаетПравильныеЗначения()
    {
        var badClient = new BadCreditCitizen("Сергей Петров", 60000, 35, 3, 100000);

        double maxCredit = badClient.CalculateMaxCreditAmount();
        double rate = badClient.CalculateInterestRate();

        Assert.That(Math.Round(maxCredit, 2), Is.EqualTo(20000));
        Assert.That(Math.Round(rate, 4), Is.EqualTo(0.40));
    }

    [Test]
    public void ПлохаяКредитнаяИстория_КогдаДолгБольшеДохода_ВозвращаетНоль()
    {
        var badClient = new BadCreditCitizen("Должник", 30000, 45, 4, 200000);

        double maxCredit = badClient.CalculateMaxCreditAmount();

        Assert.That(Math.Round(maxCredit, 2), Is.EqualTo(0));
    }
}

[TestFixture]
public class PensionerTests
{
    [Test]
    public void Пенсионер_СДополнительнымДоходом_ВозвращаетПравильныеЗначения()
    {
        var pensioner = new Pensioner("Мария Сидорова", 25000, 68, true, 15000);

        double maxCredit = pensioner.CalculateMaxCreditAmount();
        double rate = pensioner.CalculateInterestRate();

        Assert.That(Math.Round(maxCredit, 2), Is.EqualTo(185000));
        Assert.That(Math.Round(rate, 4), Is.EqualTo(0.10));
    }

    [Test]
    public void Пенсионер_Старше70_ВозвращаетПравильныеЗначения()
    {
        var pensioner = new Pensioner("Николай Петров", 30000, 75, false, 20000);

        double maxCredit = pensioner.CalculateMaxCreditAmount();
        double rate = pensioner.CalculateInterestRate();

        Assert.That(Math.Round(maxCredit, 2), Is.EqualTo(120000));
        Assert.That(Math.Round(rate, 4), Is.EqualTo(0.09));
    }
}
