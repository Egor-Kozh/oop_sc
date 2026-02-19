namespace lab3_2
{
    public class Citizen : Client
    {
        public bool hasPermanentJob { get; set; }
        public int creditHistoryMonths { get; set; }
        
        public Citizen(string name, double monthlyIncome, int age, bool hasPermanentJob, int creditHistoryMonths) 
            : base(name, monthlyIncome, age)
        {
            this.hasPermanentJob = hasPermanentJob;
            this.creditHistoryMonths = creditHistoryMonths;
        }
        
        public override double CalculateMaxCreditAmount()
        {
            double baseAmount = monthlyIncome * 10;
            
            if (!hasPermanentJob)
            {
                baseAmount *= 0.5;
            }
            
            double historyBonus = creditHistoryMonths * 2000;
            
            return baseAmount + historyBonus;
        }
        
        public override double CalculateInterestRate()
        {
            double baseRate = 0.15;
            
            if (creditHistoryMonths > 24)
            {
                baseRate -= 0.02;
            }
            
            if (!hasPermanentJob)
            {
                baseRate += 0.05;
            }
            
            return Math.Min(baseRate, 0.3);
        }
    }
}