namespace lab4_8.Tests
{
    [TestFixture]
    public class ThinkDecisionTests
    {
        [Test]
        public void GetDecision_УчебаМотивирующаяМысль_ВозвращаетTrue()
        {
            var think = new Think(TypeThink.Study, "Так, надо бы подготовиться к экзамену");

            bool result = think.GetDecision();

            Assert.That(result, Is.True, "Мотивирующая мысль об учебе должна быть хорошей");
        }

        [Test]
        public void GetDecision_УчебаЛениваяМысль_ВозвращаетFalse()
        {
            var think = new Think(TypeThink.Study, "Завтра точно начну учиться");

            bool result = think.GetDecision();

            Assert.That(result, Is.False, "Ленивая мысль об учебе должна быть плохой");
        }

        [Test]
        public void GetDecision_ЕдаПолезнаяМысль_ВозвращаетTrue()
        {
            var think = new Think(TypeThink.Food, "Салатик бы съесть для здоровья");

            bool result = think.GetDecision();

            Assert.That(result, Is.True, "Мысль о полезной еде должна быть хорошей");
        }

        [Test]
        public void GetDecision_ЕдаВреднаяМысль_ВозвращаетFalse()
        {
            var think = new Think(TypeThink.Food, "Хочу в KFC");

            bool result = think.GetDecision();

            Assert.That(result, Is.False, "Мысль о вредной еде должна быть плохой");
        }

        [Test]
        public void GetDecision_ИгрыПозитивнаяМысль_ВозвращаетTrue()
        {
            var think = new Think(TypeThink.Games, "Ура! Я победил!");

            bool result = think.GetDecision();

            Assert.That(result, Is.True, "Позитивная мысль об игре должна быть хорошей");
        }
    }
}