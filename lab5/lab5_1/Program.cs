using System.Text;

namespace lab5_1
{
  class Program
  {
    static void Main(string[] args)
    {
      string groupName = "ПИН-232";
      
      string fileName = $"{groupName}.txt";
      string backupFileName = $"backup_{fileName}";
      
      string[] students = new string[]
      {
        "Иванов Иван",
        "Петров Петр",
        "Сидоров Алексей",
        "Козлов Дмитрий",
        "Смирнова Анна",
        "Васильева Мария",
        "Федоров Сергей",
        "Михайлова Елена",
        "Алексеев Николай",
        "Николаева Ольга"
      };
      
      try
      {
        Console.WriteLine($"Создание файла {fileName}...");
        File.WriteAllLines(fileName, students, Encoding.UTF8);
        Console.WriteLine($"Файл успешно создан. Записано {students.Length} студентов.");
        
        Console.WriteLine("\nСодержимое файла:");
        ShowFileContent(fileName);
        
        Console.WriteLine($"\nСоздание резервной копии {backupFileName}...");
        File.Copy(fileName, backupFileName, overwrite: true);
        Console.WriteLine("Резервная копия успешно создана.");
        
        if (File.Exists(backupFileName))
        {
            Console.WriteLine($"Резервная копия {backupFileName} существует.");
            Console.WriteLine($"Размер: {new FileInfo(backupFileName).Length} байт");
        }
        
        Console.WriteLine($"\nУдаление исходного файла {fileName}...");
        File.Delete(fileName);
        Console.WriteLine("Исходный файл удален.");
        
        Console.WriteLine($"Исходный файл существует: {File.Exists(fileName)}");
        Console.WriteLine($"Резервная копия существует: {File.Exists(backupFileName)}");
        
        Console.WriteLine("\nСодержимое резервной копии:");
        ShowFileContent(backupFileName);
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Ошибка: {ex.Message}");
      }
      
      Console.WriteLine("\nПрограмма завершена.");
    }
    
    static void ShowFileContent(string fileName)
    {
      if (File.Exists(fileName))
      {
        string[] lines = File.ReadAllLines(fileName, Encoding.UTF8);
        foreach (string line in lines)
        {
          Console.WriteLine($"  {line}");
        }
      }
      else
      {
        Console.WriteLine($"Файл {fileName} не найден.");
      }
    }
  }
}