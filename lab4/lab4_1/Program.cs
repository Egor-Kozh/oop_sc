namespace lab4_1
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] lastNames = new string[]
      {
        "Иванов",
        "Петров",
        "Сидоров",
        "Козлов",
        "Смирнов",
        "Васильев",
        "Федоров",
        "Михайлов"
      };
      
      string[] firstNames = new string[]
      {
        "Иван",
        "Петр",
        "Алексей",
        "Дмитрий",
        "Анна",
        "Мария",
        "Елена",
        "Сергей"
      };
      
      if (lastNames.Length != firstNames.Length)
      {
        Console.WriteLine("Ошибка: массивы разной длины!");
        return;
      }
      
      string[] combined = new string[lastNames.Length * 2];
      
      for (int i = 0; i < lastNames.Length; i++)
      {
        combined[i * 2] = firstNames[i];   
        combined[i * 2 + 1] = lastNames[i];
      }
      
      for (int i = 0; i < combined.Length; i++)
      {
        Console.WriteLine($"{i,5}  | {combined[i]}");
      }
    }
  }
}