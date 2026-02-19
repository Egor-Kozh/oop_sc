namespace lab4_5
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("=== ИНСТИТУТ: ОЧЕРЕДЬ НА ОТЧИСЛЕНИЕ (МАССИВ) ===\n");

      Institute institute = new Institute();
      institute.GenerateStudents(15);

      institute.ShowAllStudents();

      institute.ShowExpulsionQueue();

      Console.WriteLine("\n=== ДЕМОНСТРАЦИЯ ИНДЕКСАТОРА ===");

      var queue = institute.ExpulsionQueue;

      if (queue.Count > 0)
      {
        Console.WriteLine($"\nПервый студент в очереди (индекс 0):");
        Console.WriteLine(queue[0].GetStudentInfo());

        Console.WriteLine($"\nИзменяем данные через индексатор...");
        var newStudent = Student.GenerateStudent();
        queue[0] = newStudent;
        Console.WriteLine($"Новый студент на позиции 0: {queue[0].FullName}");

        try
        {
          string name = queue[0].FullName;
          var foundStudent = queue[name];
          Console.WriteLine($"\nНайден студент по имени '{name}':");
          Console.WriteLine(foundStudent.GetStudentInfo());
        }
        catch (KeyNotFoundException ex)
        {
          Console.WriteLine(ex.Message);
        }
      }

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
    }
  }
}