namespace lab3_1
{
  public class Passenger
  {
    public string name { get; set; }
    public bool hasDiscount { get; set; }
    public int age { get; set; }
    
    public Passenger(string name, int age, bool hasDiscount = false)
    {
        this.name = name;
        this.age = age;
        this.hasDiscount = hasDiscount;
    }
  }
}