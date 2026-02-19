namespace lab3_1
{
  public class Bus : Transport
  {
    private List<Passenger> _passengers;
    public double ticketPrice { get; set; } 
    public double discountPrice { get; set; }
    
    public Bus(string name, int capacity, double ticketPrice, double discountPrice) 
      : base(name, capacity)
    {
      this.ticketPrice = ticketPrice;
      this.discountPrice = discountPrice;
      _passengers = new List<Passenger>();
    }
    
    public void AddPassenger(Passenger passenger)
    {
      if (_passengers.Count < capacity)
      {
        _passengers.Add(passenger);
      }
      else
      {
        Console.WriteLine("Автобус полон");
      }
    }
    
    public void AddPassengers(IEnumerable<Passenger> passengers)
    {
      foreach (var passenger in passengers)
      {
        AddPassenger(passenger);
      }
    }
    
    public int PassengerCount
    {
      get
      {
        return _passengers.Count;
      }
    }
    
    public override double CalculateRevenue()
    {
      double revenue = 0;
        
      foreach (var passenger in _passengers)
      {
        revenue += passenger.hasDiscount ? discountPrice : ticketPrice;
      }
        
      return revenue;
    }
    
    public void ClearPassengers()
    {
      _passengers.Clear();
    }
  }
}