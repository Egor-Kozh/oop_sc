namespace lab4_5
{
  public class ExpulsionQueue
  {
    private Student[] _students;
    private int _count;
    private int _capacity;

    public ExpulsionQueue(int capacity = 100)
    {
      _capacity = capacity;
      _students = new Student[_capacity];
      _count = 0;
    }

    public void Enqueue(Student student)
    {
      if (_count >= _capacity)
      {
        _capacity *= 2;
        Array.Resize(ref _students, _capacity);
      }
      _students[_count] = student;
      _count++;
    }

    public Student Dequeue()
    {
      if (_count == 0)
        throw new InvalidOperationException("Очередь пуста");

      Student result = _students[0];

      for (int i = 1; i < _count; i++)
      {
        _students[i - 1] = _students[i];
      }

      _students[_count - 1] = null;
      _count--;

      return result;
    }

    public Student Peek()
    {
      if (_count == 0)
        throw new InvalidOperationException("Очередь пуста");

      return _students[0];
    }

    public int Count
    {
      get
      {
        return _count;
      }
    }

    public void Clear()
    {
      for (int i = 0; i < _count; i++)
      {
        _students[i] = null;
      }
      _count = 0;
    }

    public Student this[int index]
    {
      get
      {
        if (index < 0 || index >= _count)
          throw new IndexOutOfRangeException("Индекс вне диапазона");
        return _students[index];
      }
      set
      {
        if (index < 0 || index >= _count)
          throw new IndexOutOfRangeException("Индекс вне диапазона");
        _students[index] = value;
      }
    }

    public Student this[string fullName]
    {
      get
      {
        for (int i = 0; i < _count; i++)
        {
          if (_students[i].FullName.Equals(fullName, StringComparison.OrdinalIgnoreCase))
            return _students[i];
        }

        throw new KeyNotFoundException($"Студент с именем {fullName} не найден");
      }
    }

    public void PrintAll()
    {
      Console.WriteLine($"\n=== ОЧЕРЕДЬ НА ОТЧИСЛЕНИЕ ({_count} чел.) ===");
      if (_count == 0)
      {
        Console.WriteLine("Очередь пуста");
        return;
      }

      for (int i = 0; i < _count; i++)
      {
        Console.WriteLine($"\n[{i}] {_students[i].GetStudentInfo()}");
      }
    }
  }
}