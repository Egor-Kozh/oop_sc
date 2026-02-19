namespace lab3_1
{
  public class Taxi : Transport
  {
    private Trip _currentTrip;
    public double baseRate { get; set; }
    
    public Taxi(string name, int capacity, double baseRate, double pricePerKm) 
      : base(name, capacity)
    {
      this.baseRate = baseRate;
      _currentTrip = new Trip(0, pricePerKm);
    }
    
    public void SetTrip(double distance, double pricePerKm)
    {
      _currentTrip = new Trip(distance, pricePerKm);
    }
    
    public override double CalculateRevenue()
    {
      return baseRate + _currentTrip.CalculateCost();
    }
    
    public double TripDistance
    {
      get
      {
        return _currentTrip.distance;
      }
    }
  }
}