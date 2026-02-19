namespace lab3_1
{
    public abstract class Transport
    {
        public string name { get; set; }
        public int capacity { get; set; }
        
        public Transport(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }

        public abstract double CalculateRevenue();
        
        public override string ToString()
        {
            return $"{name}: Выручка за рейс = {CalculateRevenue():C}";
        }
    }
}