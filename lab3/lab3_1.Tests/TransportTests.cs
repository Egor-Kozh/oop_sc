namespace lab3_1.Tests
{
    [TestFixture]
    public class BusTests
    {
        [Test]
        public void Автобус_ВыручкаСОбычнымиПассажирами_ВозвращаетПравильнуюСумму()
        {
            var bus = new Bus("Городской автобус", 40, 50, 25);
            bus.AddPassenger(new Passenger("Иван", 30, false));
            bus.AddPassenger(new Passenger("Петр", 25, false));
            bus.AddPassenger(new Passenger("Мария", 35, false));

            double revenue = bus.CalculateRevenue();

            Assert.That(revenue, Is.EqualTo(150));
        }

        [Test]
        public void Автобус_ВыручкаСЛьготниками_ВозвращаетПравильнуюСумму()
        {
            var bus = new Bus("Городской автобус", 40, 50, 25);
            bus.AddPassenger(new Passenger("Иван", 30, false));
            bus.AddPassenger(new Passenger("Льготник", 70, true));
            bus.AddPassenger(new Passenger("Льготник2", 65, true));

            double revenue = bus.CalculateRevenue();

            Assert.That(revenue, Is.EqualTo(100));
        }

        [Test]
        public void Автобус_ДобавлениеПассажираКогдаПолон_НеДобавляетПассажира()
        {
            var bus = new Bus("Маленький автобус", 2, 50, 25);
            bus.AddPassenger(new Passenger("Иван", 30));
            bus.AddPassenger(new Passenger("Петр", 25));

            bus.AddPassenger(new Passenger("Мария", 35));

            Assert.That(bus.PassengerCount, Is.EqualTo(2));
        }

        [Test]
        public void Автобус_ОчисткаПассажиров_УдаляетВсехПассажиров()
        {
            var bus = new Bus("Автобус", 40, 50, 25);
            bus.AddPassenger(new Passenger("Иван", 30));
            bus.AddPassenger(new Passenger("Петр", 25));

            bus.ClearPassengers();

            Assert.That(bus.PassengerCount, Is.EqualTo(0));
        }
    }

    [TestFixture]
    public class TaxiTests
    {
        [Test]
        public void Такси_ВыручкаСФиксированнымРасстоянием_ВозвращаетПравильнуюСумму()
        {
            var taxi = new Taxi("Такси Эконом", 4, 100, 20);
            taxi.SetTrip(15.5, 20);

            double revenue = taxi.CalculateRevenue();

            double expected = 100 + (15.5 * 20);
            Assert.That(revenue, Is.EqualTo(expected));
        }

        [Test]
        public void Такси_ВыручкаСРазнойЦенойЗаКм_ВозвращаетПравильнуюСумму()
        {
            var taxi = new Taxi("Такси Комфорт", 4, 150, 25);
            taxi.SetTrip(10, 25);

            double revenue = taxi.CalculateRevenue();

            Assert.That(revenue, Is.EqualTo(150 + (10 * 25)));
        }

        [Test]
        public void Такси_РасстояниеПоездки_ВозвращаетПравильноеЗначение()
        {
            var taxi = new Taxi("Такси", 4, 100, 20);
            taxi.SetTrip(25.5, 20);

            double distance = taxi.TripDistance;

            Assert.That(distance, Is.EqualTo(25.5));
        }
    }

    [TestFixture]
    public class TrainTests
    {
        [Test]
        public void Поезд_ВыручкаСОбычнымиПассажирами_ВозвращаетПравильнуюСумму()
        {
            var train = new Train("Электричка", 200, 5, 50, 0.5);
            train.AddPassenger(new Passenger("Иван", 30, false));
            train.AddPassenger(new Passenger("Петр", 25, false));

            double revenue = train.CalculateRevenue();

            double expected = (50 * 5) * 2;
            Assert.That(revenue, Is.EqualTo(expected));
        }

        [Test]
        public void Поезд_ВыручкаСЛьготниками_ВозвращаетПравильнуюСумму()
        {
            var train = new Train("Электричка", 200, 5, 50, 0.5);
            train.AddPassenger(new Passenger("Иван", 30, false));
            train.AddPassenger(new Passenger("Льготник", 70, true));

            double revenue = train.CalculateRevenue();

            double fullPrice = 50 * 5;
            double discountPrice = fullPrice * 0.5;
            double expected = fullPrice + discountPrice;
            Assert.That(revenue, Is.EqualTo(expected));
        }

        [Test]
        public void Поезд_ВыручкаСоСмешаннымиПассажирами_ВозвращаетПравильнуюСумму()
        {
            var train = new Train("Электричка", 200, 5, 50, 0.5);
            train.AddPassengers(new List<Passenger>
            {
                new Passenger("Иван", 30, false),
                new Passenger("Петр", 25, false),
                new Passenger("Льготник1", 70, true),
                new Passenger("Льготник2", 65, true)
            });

            double revenue = train.CalculateRevenue();

            double basePrice = 50 * 5;
            double expected = (basePrice * 2) + (basePrice * 0.5 * 2);
            Assert.That(revenue, Is.EqualTo(expected));
        }
    }
}