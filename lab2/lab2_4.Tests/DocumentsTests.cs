namespace lab2_4.Tests;

public class ConsoleOutput : IDisposable
{
    private StringWriter _stringWriter;
    private TextWriter _originalOutput;

    public ConsoleOutput()
    {
        _stringWriter = new StringWriter();
        _originalOutput = Console.Out;
        Console.SetOut(_stringWriter);
    }

    public string GetOutput()
    {
        return _stringWriter.ToString();
    }

    public void Dispose()
    {
        Console.SetOut(_originalOutput);
        _stringWriter.Dispose();
    }
}

[TestFixture]
public class DocumentsTests
{
    [Test]
    public void ТипыДокументовКорректны()
    {
        Assert.That(new DocumentWorker().GetType(), Is.EqualTo(typeof(DocumentWorker)));
        Assert.That(new ProDocumentWorker().GetType(), Is.EqualTo(typeof(ProDocumentWorker)));
        Assert.That(new ExpertDocumentWorker().GetType(), Is.EqualTo(typeof(ExpertDocumentWorker)));
    }

    [Test]
    public void БазовыйДокументОткритиеДокумента()
    {
        var doc = new DocumentWorker();

        using (var consoleOutput = new ConsoleOutput())
        {
            doc.OpenDocument();
            string output = consoleOutput.GetOutput().Trim();

            Assert.That(output, Is.EqualTo("Документ открыт"));
        }
    }

    [Test]
    public void БазовыйДокументРедактированиеДокумента()
    {
        var doc = new DocumentWorker();

        using (var consoleOutput = new ConsoleOutput())
        {
            doc.EditDocument();
            string output = consoleOutput.GetOutput().Trim();

            Assert.That(output, Is.EqualTo("Редактирование документа доступно в версии Про"));
        }
    }

    [Test]
    public void БазовыйДокументСохранениеДокумента()
    {
        var doc = new DocumentWorker();

        using (var consoleOutput = new ConsoleOutput())
        {
            doc.SaveDocument();
            string output = consoleOutput.GetOutput().Trim();

            Assert.That(output, Is.EqualTo("Сохранение документа доступно в версии Про"));
        }
    }

    [Test]
    public void ДокументПроОткритиеДокумента()
    {
        var doc = new ProDocumentWorker();

        using (var consoleOutput = new ConsoleOutput())
        {
            doc.OpenDocument();
            string output = consoleOutput.GetOutput().Trim();

            Assert.That(output, Is.EqualTo("Документ открыт"));
        }
    }

    [Test]
    public void ДокументПроРедактированиеДокумента()
    {
        var doc = new ProDocumentWorker();

        using (var consoleOutput = new ConsoleOutput())
        {
            doc.EditDocument();
            string output = consoleOutput.GetOutput().Trim();

            Assert.That(output, Is.EqualTo("Документ отредактирован"));
        }
    }

    [Test]
    public void ДокументПроСохранениеДокумента()
    {
        var doc = new ProDocumentWorker();

        using (var consoleOutput = new ConsoleOutput())
        {
            doc.SaveDocument();
            string output = consoleOutput.GetOutput().Trim();

            string expected = "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт";
            Assert.That(output, Is.EqualTo(expected));
        }
    }

    [Test]
    public void ДокументЭкспертОткритиеДокумента()
    {
        var doc = new ExpertDocumentWorker();

        using (var consoleOutput = new ConsoleOutput())
        {
            doc.OpenDocument();
            string output = consoleOutput.GetOutput().Trim();

            Assert.That(output, Is.EqualTo("Документ открыт"));
        }
    }

    [Test]
    public void ДокументЭкспертРедактированиеДокумента()
    {
        var doc = new ExpertDocumentWorker();

        using (var consoleOutput = new ConsoleOutput())
        {
            doc.EditDocument();
            string output = consoleOutput.GetOutput().Trim();

            Assert.That(output, Is.EqualTo("Документ отредактирован"));
        }
    }

    [Test]
    public void ДокументЭкспертСохранениеДокумента()
    {
        var doc = new ExpertDocumentWorker();

        using (var consoleOutput = new ConsoleOutput())
        {
            doc.SaveDocument();
            string output = consoleOutput.GetOutput().Trim();

            Assert.That(output, Is.EqualTo("Документ сохранен в новом формате"));
        }
    }
}
