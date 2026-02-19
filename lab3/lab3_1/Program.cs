namespace lab3_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("--- АВТОБУС ---");
            Bus bus = new Bus("№5", 40, 50, 25);
            
            List<Passenger> busPassengers = new List<Passenger>()
            {
                new Passenger("Иван", 30),
                new Passenger("Мария", 25, true),
                new Passenger("Петр", 45),
                new Passenger("Анна", 70, true),
                new Passenger("Дмитрий", 20)
            };
            
            bus.AddPassengers(busPassengers);
            Console.WriteLine($"Пассажиров: {bus.PassengerCount}");
            Console.WriteLine($"Выручка автобуса: {bus.CalculateRevenue()}");
            
            Console.WriteLine("\n--- ТАКСИ ---");
            Taxi taxi = new Taxi("Эконом", 4, 100, 20);
            taxi.SetTrip(15.5, 2);
            Console.WriteLine($"Поездка: {taxi.TripDistance} км");
            Console.WriteLine($"Выручка такси: {taxi.CalculateRevenue()}");
            
            Console.WriteLine("\n--- Поезд ---");
            Train train = new Train("Сапсан", 200, 5, 45.0, 0.5);
            
            List<Passenger> trainPassengers = new List<Passenger>();
            for (int i = 0; i < 150; i++)
            {
                trainPassengers.Add(new Passenger($"Пассажир {i}", 20 + i % 50, i % 3 == 0));
            }
            
            train.AddPassengers(trainPassengers);
            Console.WriteLine($"Пассажиров: {train.PassengerCount}");
            Console.WriteLine($"Из них льготников: {trainPassengers.Count(p => p.hasDiscount)}");
            Console.WriteLine($"Выручка электрички: {train.CalculateRevenue()}");  
            
            Console.WriteLine("\n=== ОБЩАЯ ВЫРУЧКА ===");
            double totalRevenue = bus.CalculateRevenue() + taxi.CalculateRevenue() + 
                                  train.CalculateRevenue();
            Console.WriteLine($"Всего: {totalRevenue}");
        }
    }
}