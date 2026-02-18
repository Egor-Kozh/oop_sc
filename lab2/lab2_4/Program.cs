namespace lab2_4
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("=== СИСТЕМА РАБОТЫ С ДОКУМЕНТАМИ ===\n");
      
      DocumentWorker documentWorker;
      
      Console.WriteLine("Введите ключ доступа (pro / exp) или оставьте пустым для бесплатной версии:");
      string key = Console.ReadLine()?.Trim().ToLower();
      
      if (key == "pro")
      {
        documentWorker = new ProDocumentWorker();
        Console.WriteLine("\nАктивирована версия Про\n");
      }
      else if (key == "exp")
      {
        documentWorker = new ExpertDocumentWorker();
        Console.WriteLine("\nАктивирована версия Эксперт\n");
      }
      else
      {
        documentWorker = new DocumentWorker();
        Console.WriteLine("\nАктивирована бесплатная версия\n");
      }
      
      bool exit = false;
      while (!exit)
      {
        Console.WriteLine("\nВыберите действие:");
        Console.WriteLine("1. Открыть документ");
        Console.WriteLine("2. Редактировать документ");
        Console.WriteLine("3. Сохранить документ");
        Console.WriteLine("4. Выход");
        Console.Write("Ваш выбор: ");
        
        string choice = Console.ReadLine();
        
        switch (choice)
        {
          case "1":
            documentWorker.OpenDocument();
            break;
          case "2":
            documentWorker.EditDocument();
            break;
          case "3":
            documentWorker.SaveDocument();
            break;
          case "4":
            exit = true;
            break;
          default:
            Console.WriteLine("Неверный выбор. Попробуйте снова.");
            break;
        }
      }      
    }
  }
}