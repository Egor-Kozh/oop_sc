namespace lab3_2
{
    public class BadCreditCitizen : Client
    {
        public int defaultsCount { get; set; }
        public double currentDebt { get; set; }
        
        public BadCreditCitizen(string name, double monthlyIncome, int age, int defaultsCount, double currentDebt) 
            : base(name, monthlyIncome, age)
        {
            this.defaultsCount = defaultsCount;
            this.currentDebt = currentDebt;
        }
        
        public override double CalculateMaxCreditAmount()
        {
            double baseAmount = monthlyIncome * 5;
            
            double defaultPenalty = defaultsCount * 0.2;
            baseAmount *= (1 - Math.Min(defaultPenalty, 0.8));
            
            baseAmount -= currentDebt;
            
            return Math.Max(baseAmount, 0);
        }
        
        public override double CalculateInterestRate()
        {
            double baseRate = 0.25;
            
            baseRate += defaultsCount * 0.05;
            
            return Math.Min(baseRate, 0.5);
        }
    }
}