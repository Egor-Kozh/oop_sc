namespace lab3_1
{
  public class Trip
  {
    public double distance { get; set; }
    public double pricePerKm { get; set; }

    public Trip(double distance, double pricePerKm)
    {
      this.distance = distance;
      this.pricePerKm = pricePerKm;
    }

    public double CalculateCost()
    {
      return distance * pricePerKm;
    }
  }
}