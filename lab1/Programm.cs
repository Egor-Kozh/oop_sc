namespace lab1
{
  class Programm
  {
    public static void Main(string[] args)
    {
      Animal bear = new Animal();
      Animal wolf = new Animal("wolf", 5, 4, TypeAnimal.Mammal, LivingEnv.Ground, Continents.Eurasia);
      Animal shark = new Animal("shark", 3, 2, TypeAnimal.Fish, LivingEnv.Water, Continents.NorthAmerica);
      Animal bear2 = bear;

      Console.WriteLine(bear == bear2);
      Console.WriteLine(bear == wolf);
      Console.WriteLine(bear != shark);

      Console.WriteLine(shark.CanSwim());

      Console.WriteLine("===========================");

      Figure circle = new Figure(4, TypeFigure.Circle);
      Console.WriteLine(circle.Square);

      Figure rectangle = new Figure(4, 5, TypeFigure.Rectangle);
      Console.WriteLine(rectangle.Square);

      Figure trapezoid = new Figure(3, 6, 2, TypeFigure.Trapezoid);
      Console.WriteLine(trapezoid.Square);
    }
  } 
}