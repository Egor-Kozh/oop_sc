namespace lab3_2
{
    public class Pensioner : Client
    {
        public bool hasAdditionalIncome { get; set; }
        public double pensionAmount { get; set; }
        
        public Pensioner(string name, double monthlyIncome, int age, bool hasAdditionalIncome, double pensionAmount) 
            : base(name, monthlyIncome, age)
        {
            this.hasAdditionalIncome = hasAdditionalIncome;
            this.pensionAmount = pensionAmount;
        }
        
        public override double CalculateMaxCreditAmount()
        {
            double baseAmount = monthlyIncome * 8;
            
            if (age > 70)
            {
                baseAmount *= 0.5;
            }
            else if (age > 65)
            {
                baseAmount *= 0.7;
            }
            
            if (hasAdditionalIncome)
            {
                baseAmount += pensionAmount * 3;
            }
            
            return baseAmount;
        }
        
        public override double CalculateInterestRate()
        {
            double baseRate = 0.12;
            
            if (age >= 70)
            {
                baseRate -= 0.03;
            }
            else if (age >= 60)
            {
                baseRate -= 0.02;
            }
            
            return Math.Max(baseRate, 0.08); 
        }
    }
}