namespace lab3_1
{
  public class Train : Transport
  {
    private List<Passenger> _passengers;
    public double pricePerKm { get; set; }
    public double routeDistance { get; set; }
    public double discountPercent { get; set; }
    
    public Train(string name, int capacity, double pricePerKm, double routeDistance, double discountPercent = 0.5) 
      : base(name, capacity)
    {
      this.pricePerKm = pricePerKm;
      this.routeDistance = routeDistance;
      this.discountPercent = discountPercent;
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
        Console.WriteLine("Поезд полон");
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
      double basePrice = routeDistance * pricePerKm;
      double revenue = 0;
        
      foreach (var passenger in _passengers)
      {
        if (passenger.hasDiscount)
        {
          revenue += basePrice * (1 - discountPercent);
        }
        else
        {
          revenue += basePrice;
        }
      }
        
      return revenue;
    }
    
    public void ClearPassengers()
    {
      _passengers.Clear();
    }
  }
}