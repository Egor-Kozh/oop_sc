namespace lab4_3.Tests
{
    [TestFixture]
    public class StudentDecisionTests
    {
        [Test]
        public void GetDecision_ДвойкаПоПрограммированию_ВозвращаетTrue()
        {
            var student = new Student(
                "Иван", "Иванов", "Иванович",
                programming: 2,
                philosophy: 4,
                networks: 4,
                optimization: 4
            );

            bool result = student.GetDecision();

            Assert.That(result, Is.True, "Студент с двойкой по программированию должен быть отчислен");
        }

        [Test]
        public void GetDecision_ДвойкаПоСетям_ВозвращаетTrue()
        {
            var student = new Student(
                "Петр", "Петров", "Петрович",
                programming: 4,
                philosophy: 4,
                networks: 2,
                optimization: 4
            );

            bool result = student.GetDecision();

            Assert.That(result, Is.True, "Студент с двойкой по сетям должен быть отчислен");
        }

        [Test]
        public void GetDecision_ДвеДвойки_ВозвращаетTrue()
        {
            var student = new Student(
                "Сергей", "Сергеев", "Сергеевич",
                programming: 2,
                philosophy: 2,
                networks: 4,
                optimization: 4
            );

            bool result = student.GetDecision();

            Assert.That(result, Is.True, "Студент с двумя двойками должен быть отчислен");
        }

        [Test]
        public void GetDecision_СреднийБаллНиже3_ВозвращаетTrue()
        {
            var student = new Student(
                "Анна", "Аннова", "Анновна",
                programming: 3,
                philosophy: 3,
                networks: 2,
                optimization: 3
            );

            bool result = student.GetDecision();

            Assert.That(result, Is.True, "Студент со средним баллом ниже 3.0 должен быть отчислен");
        }

        [Test]
        public void GetDecision_ХорошийСтудент_ВозвращаетFalse()
        {
            var student = new Student(
                "Мария", "Марова", "Маровна",
                programming: 4,
                philosophy: 5,
                networks: 4,
                optimization: 5
            );

            bool result = student.GetDecision();

            Assert.That(result, Is.False, "Хороший студент не должен быть отчислен");
        }
    }
}