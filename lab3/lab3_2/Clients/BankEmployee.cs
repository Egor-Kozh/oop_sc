namespace lab3_2
{
    public class BankEmployee : Client
    {
        public int workExperience { get; set; }
        public string position { get; set; }
        
        public BankEmployee(string name, double monthlyIncome, int age, int workExperience, string position) 
            : base(name, monthlyIncome, age)
        {
            this.workExperience = workExperience;
            this.position = position;
        }
        
        public override double CalculateMaxCreditAmount()
        {
            double baseAmount = monthlyIncome * 20;
            
            double experienceBonus = workExperience * 50000;
            
            double positionBonus;

            string lowerPosition = position.ToLower();

            if (lowerPosition == "руководитель")
              positionBonus = 1000000;
            else if (lowerPosition == "менеджер")
              positionBonus = 500000;
            else if (lowerPosition == "специалист")
              positionBonus = 200000;
            else
              positionBonus = 0;
            
            return baseAmount + experienceBonus + positionBonus;
        }
        
        public override double CalculateInterestRate()
        {
            double baseRate = 0.05;
            
            double experienceDiscount = Math.Min(workExperience * 0.002, 0.02);
            
            double positionDiscount;

            string lowerPosition = position.ToLower();

            if (lowerPosition == "руководитель")
              positionDiscount = 0.01;
            else if (lowerPosition == "менеджер")
              positionDiscount = 0.005;
            else
              positionDiscount = 0;
            
            return baseRate - experienceDiscount - positionDiscount;
        }
    }
}