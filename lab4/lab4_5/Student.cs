namespace lab4_5
{
  public class Student
  {
    private static Random _random = new Random();

    private static readonly string[] _firstNames = new string[]
    {
          "Иван", "Петр", "Алексей", "Дмитрий", "Анна",
          "Мария", "Елена", "Сергей", "Ольга", "Михаил"
    };

    private static readonly string[] _lastNames = new string[]
    {
          "Иванов", "Петров", "Сидоров", "Козлов", "Смирнов",
          "Васильев", "Федоров", "Михайлов", "Алексеев", "Николаев"
    };

    private static readonly string[] _patronymics = new string[]
    {
          "Иванович", "Петрович", "Алексеевич", "Дмитриевич", "Сергеевич",
          "Андреевич", "Михайлович", "Николаевич", "Александрович", "Владимирович"
    };

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Patronymic { get; private set; }

    public int ProgrammingGrade { get; private set; }
    public int PhilosophyGrade { get; private set; }
    public int NetworksGrade { get; private set; }
    public int OptimizationMethodsGrade { get; private set; }

    private Student(string firstName, string lastName, string patronymic,
                   int programming, int philosophy, int networks, int optimization)
    {
      FirstName = firstName;
      LastName = lastName;
      Patronymic = patronymic;
      ProgrammingGrade = programming;
      PhilosophyGrade = philosophy;
      NetworksGrade = networks;
      OptimizationMethodsGrade = optimization;
    }

    public string GetStudentInfo()
    {
      return $"{FullName}\n" +
             $"  Программирование: {ProgrammingGrade}\n" +
             $"  Философия: {PhilosophyGrade}\n" +
             $"  Сети: {NetworksGrade}\n" +
             $"  Методы оптимизации: {OptimizationMethodsGrade}\n" +
             $"  Средний балл: {AverageGrade:F1}";
    }

    public bool GetDecision()
    {

      if (ProgrammingGrade == 2 || NetworksGrade == 2)
        return true;

      int badGrades = 0;
      if (ProgrammingGrade == 2) badGrades++;
      if (PhilosophyGrade == 2) badGrades++;
      if (NetworksGrade == 2) badGrades++;
      if (OptimizationMethodsGrade == 2) badGrades++;

      if (badGrades >= 2)
        return true;

      if (AverageGrade < 3.0)
        return true;

      return false;
    }

    public static Student GenerateStudent()
    {
      string firstName = _firstNames[_random.Next(_firstNames.Length)];
      string lastName = _lastNames[_random.Next(_lastNames.Length)];
      string patronymic = _patronymics[_random.Next(_patronymics.Length)];

      int programming = _random.Next(2, 6);
      int philosophy = _random.Next(2, 6);
      int networks = _random.Next(2, 6);
      int optimization = _random.Next(2, 6);

      return new Student(firstName, lastName, patronymic,
                        programming, philosophy, networks, optimization);
    }

    public string FullName
    {
      get
      {
        return LastName + " " + FirstName + " " + Patronymic;
      }
    }

    public double AverageGrade
    {
      get
      {
        return (ProgrammingGrade + PhilosophyGrade + NetworksGrade + OptimizationMethodsGrade) / 4.0;
      }
    }
  }
}