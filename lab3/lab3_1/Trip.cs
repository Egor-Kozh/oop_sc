namespace lab3_1
{
  public class Trip
  {
    public double distance { get; set; }
    public double pricePerKm { get; set; }
    
    public Trip(double distance, double pricePerKm)
    {
      distance = distance;
      pricePerKm = pricePerKm;
    }
    
    public double CalculateCost()
    {
      return distance * pricePerKm;
    }
  }
}