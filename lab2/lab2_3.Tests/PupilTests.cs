namespace lab2_3.Tests;

public class Tests
{

    [Test]
    public void СозданиеОбычногоУченика()
    {
        Pupil pupil = new Pupil();

        Assert.That(pupil, Is.Not.Null);
    }

    [Test]
    public void УченикВсеМетодыВозвращаютНеПустыеСтроки()
    {
        Pupil pupil = new Pupil();
        
        Assert.IsNotEmpty(pupil.Study(), "Метод Study() не должен возвращать пустую строку");
        Assert.IsNotEmpty(pupil.Read(), "Метод Read() не должен возвращать пустую строку");
        Assert.IsNotEmpty(pupil.Write(), "Метод Write() не должен возвращать пустую строку");
        Assert.IsNotEmpty(pupil.Relax(), "Метод Relax() не должен возвращать пустую строку");
    }

    [Test]
    public void СозданиеОтличногоУченикаИПереопределенныеМетоды()
    {
        ExcelentPupil pupil = new ExcelentPupil();

        Assert.AreEqual("Отличный ученик много учится", pupil.Study());
        Assert.AreEqual("Отличный ученик много читает", pupil.Read());
        Assert.AreEqual("Отличный ученик много пишет", pupil.Write());
        Assert.AreEqual("Отличный ученик мало отдыхает", pupil.Relax());
    }

    [Test]
    public void СозданиеХорошегоУченикаИПереопределенныеМетоды()
    {
        GoodPupil pupil = new GoodPupil();

        Assert.AreEqual("Хороший ученик умеренно учится", pupil.Study());
        Assert.AreEqual("Хороший ученик умеренно читает", pupil.Read());
        Assert.AreEqual("Хороший ученик умеренно пишет", pupil.Write());
        Assert.AreEqual("Хороший ученик умеренно отдыхает", pupil.Relax());
    }

    [Test]
    public void СозданиеПлохогоУченикаИПереопределенныеМетоды()
    {
        BadPupil pupil = new BadPupil();

        Assert.AreEqual("Плохой ученик мало учится", pupil.Study());
        Assert.AreEqual("Плохой ученик мало читает", pupil.Read());
        Assert.AreEqual("Плохой ученик мало пишет", pupil.Write());
        Assert.AreEqual("Плохой ученик много отдыхает", pupil.Relax());
    }

    [Test]
    public void СозданиеКлассаС2Учениками()
    {
        Pupil pupil1 = new BadPupil();
        Pupil pupil2 = new GoodPupil();
        ClassRoom classRoom = new ClassRoom(pupil1, pupil2);

        Assert.That(classRoom, Is.Not.Null);
    }

    [Test]
    public void СозданиеКлассаС3Учениками()
    {
        Pupil pupil1 = new BadPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new ExcelentPupil();
        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3);

        Assert.That(classRoom, Is.Not.Null);
    }

    [Test]
    public void СозданиеКлассаС4Учениками()
    {
        Pupil pupil1 = new BadPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new ExcelentPupil();
        Pupil pupil4 = new Pupil();
        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);

        Assert.That(classRoom, Is.Not.Null);
    }

    [Test]
    public void СтатическоеПолеPupilCountДолжноСчитатьсяПравильно()
    {
        var pupil1 = new BadPupil();
        var pupil2 = new GoodPupil();
        var pupil3 = new ExcelentPupil();
        var pupil4 = new Pupil();
        
        var classRoom2 = new ClassRoom(pupil1, pupil2);
        var classRoom3 = new ClassRoom(pupil1, pupil2, pupil3);
        var classRoom4 = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        
        Assert.That(classRoom2.PupilCount, Is.EqualTo(2));
        Assert.That(classRoom3.PupilCount, Is.EqualTo(3));
        Assert.That(classRoom4.PupilCount, Is.EqualTo(4));
}

    [Test]
    public void ВычислениеСреднейОценки()
    {
        var pupil1 = new GoodPupil(); 
        var pupil2 = new BadPupil();   
        var classRoom = new ClassRoom(pupil1, pupil2);
        
        double averageGrade = classRoom.GetRoundGrade();
        
        Assert.That(averageGrade, Is.InRange(2.0, 5.0));
        Console.WriteLine($"Средняя оценка: {averageGrade}");
    }
}
