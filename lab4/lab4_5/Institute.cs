namespace lab4_5
{
  public class Institute
  {
    private List<Student> _allStudents = new List<Student>();
    private ExpulsionQueue _expulsionQueue = new ExpulsionQueue();

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
        Student expelled = _expulsionQueue.Dequeue();
        _allStudents.Remove(expelled);
        return expelled;
      }
      return null;
    }

    public int ExpelAllStudents()
    {
      int count = 0;
      while (_expulsionQueue.Count > 0)
      {
        Student expelled = _expulsionQueue.Dequeue();
        _allStudents.Remove(expelled);
        count++;
      }
      return count;
    }

    public void ShowExpulsionQueue()
    {
      _expulsionQueue.PrintAll();
    }

    public void ShowAllStudents()
    {
      Console.WriteLine($"\n=== ВСЕ СТУДЕНТЫ ({_allStudents.Count} чел.) ===");
      foreach (var student in _allStudents)
      {
        string status = student.GetDecision() ? "НА ОТЧИСЛЕНИЕ" : "УЧИТСЯ";
        Console.WriteLine($"\n{student.FullName} - {status}");
      }
    }

    public ExpulsionQueue ExpulsionQueue
    {
      get
      {
        return _expulsionQueue;
      }
    }
  }
}