namespace lab3_2
{
    public abstract class Client
    {
        public string name { get; set; }
        public double monthlyIncome { get; set; }
        public int age { get; set; }
        
        protected Client(string name, double monthlyIncome, int age)
        {
            this.name = name;
            this.monthlyIncome = monthlyIncome;
            this.age = age;
        }
        
        public abstract double CalculateMaxCreditAmount();
        public abstract double CalculateInterestRate();
        
        public virtual void ShowCreditInfo()
        {
            Console.WriteLine($"\nКлиент: {name}");
            Console.WriteLine($"Максимальный кредит: {CalculateMaxCreditAmount()}");
            Console.WriteLine($"Процентная ставка: {CalculateInterestRate()}");
        }
    }
}