namespace lab4_3
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("=== ИНСТИТУТ: ОЧЕРЕДЬ НА ОТЧИСЛЕНИЕ ===\n");

      Institute institute = new Institute();

      institute.GenerateStudents(20);

      institute.ShowAllStudents();

      institute.ShowExpulsionQueue();

      Console.WriteLine("\n=== ПРОЦЕСС ОТЧИСЛЕНИЯ ===");
      for (int i = 0; i < 3; i++)
      {
        var expelled = institute.ExpelNextStudent();
        if (expelled != null)
        {
          Console.WriteLine($"Отчислен: {expelled.FullName}");
        }
      }

      institute.ShowExpulsionQueue();

      int expelledCount = institute.ExpelAllStudents();
      Console.WriteLine($"\nОтчислено всего: {expelledCount}");
    }
  }
}