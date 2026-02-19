namespace lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<Client> clients = new List<Client>
            {
                new BankEmployee("Иван Петров (сотрудник)", 80000, 35, 5, "менеджер"),
                new Citizen("Анна Смирнова (обычный)", 60000, 30, true, 36),
                new BadCreditCitizen("Петр Иванов (плохая история)", 50000, 40, 3, 150000),
                new Pensioner("Мария Сидорова (пенсионер)", 25000, 76, true, 15000),
            };
            
            Console.WriteLine("=== РАСЧЕТ КРЕДИТОВ ДЛЯ РАЗНЫХ КАТЕГОРИЙ ===");
            
            foreach (var client in clients)
            {
                client.ShowCreditInfo();
            }
            
            Console.WriteLine("\n=== ДЕТАЛЬНЫЙ РАСЧЕТ ===");
            CalculateAllCredits(clients);
        }
        
        static void CalculateAllCredits(List<Client> clients)
        {
            foreach (var client in clients)
            {
                double maxCredit = client.CalculateMaxCreditAmount();
                double rate = client.CalculateInterestRate();
                
                Console.WriteLine($"\n{client.name}:");
                Console.WriteLine($"  Доход: {client.monthlyIncome}/мес");
                Console.WriteLine($"  Макс. кредит: {maxCredit}");
                Console.WriteLine($"  Ставка: {rate}");
            }
        }
    }
}