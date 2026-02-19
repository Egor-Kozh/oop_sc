namespace lab4_3
{
  public class Institute
  {
    private Queue<Student> _expulsionQueue = new Queue<Student>();
    private List<Student> _allStudents = new List<Student>();

    public void AddStudent(Student student)
    {
      _allStudents.Add(student);

      if (student.GetDecision())
      {
        _expulsionQueue.Enqueue(student);
      }
    }

    public void GenerateStudents(int count)
    {
      for (int i = 0; i < count; i++)
      {
        AddStudent(Student.GenerateStudent());
      }
    }

    public Student ExpelNextStudent()
    {
      if (_expulsionQueue.Count > 0)
      {
        return _expulsionQueue.Dequeue();
      }
      return null;
    }

    public int ExpelAllStudents()
    {
      int count = 0;
      while (_expulsionQueue.Count > 0)
      {
        var student = _expulsionQueue.Dequeue();
        _allStudents.Remove(student);
        count++;
      }
      return count;
    }

    public void ShowExpulsionQueue()
    {
      Console.WriteLine($"\n=== ОЧЕРЕДЬ НА ОТЧИСЛЕНИЕ ({_expulsionQueue.Count} чел.) ===");

      if (_expulsionQueue.Count == 0)
      {
        Console.WriteLine("Очередь пуста");
        return;
      }

      int index = 1;
      foreach (var student in _expulsionQueue)
      {
        Console.WriteLine($"\n{index++}. {student.GetStudentInfo()}");
      }
    }

    public void ShowAllStudents()
    {
      Console.WriteLine($"\n=== ВСЕ СТУДЕНТЫ ({_allStudents.Count} чел.) ===");

      foreach (var student in _allStudents)
      {
        string status = student.GetDecision() ? "НА ОТЧИСЛЕНИЕ" : "УЧИТСЯ";
        Console.WriteLine($"\n{student.FullName} - {status}");
        Console.WriteLine($"  Оценки: П:{student.ProgrammingGrade}, Ф:{student.PhilosophyGrade}, " +
                         $"С:{student.NetworksGrade}, МО:{student.OptimizationMethodsGrade}");
      }
    }
  }
}