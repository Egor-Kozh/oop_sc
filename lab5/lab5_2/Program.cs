namespace lab5_2
{
  class Program
  {
    static List<string> docs = new List<string>();

    static void Main(string[] args)
    {
      DriveInfo[] drives = DriveInfo.GetDrives();
      
      foreach (DriveInfo drive in drives)
      {
        if (drive.IsReady)
        {
          ScanDirectory(drive.RootDirectory.FullName);
        }
      }
      
      string fileName = "documents_list.txt";
      File.WriteAllLines(fileName, docs);
      
      Console.WriteLine($"Готово! Найдено документов: {docs.Count}");
      Console.WriteLine($"Список сохранен в файл: {fileName}");
  }
  
  static void ScanDirectory(string path)
  {
      try
      {
        string[] files = Directory.GetFiles(path);
        
        foreach (string file in files)
        {
          try
          {
            string ext = Path.GetExtension(file).ToLower();
            
            if (ext == ".txt" || ext == ".doc" || ext == ".docx" || 
              ext == ".pdf" || ext == ".xls" || ext == ".xlsx" || 
              ext == ".rtf" || ext == ".odt")
            {
              docs.Add(file);
            }
          }
          catch
          {
              // Игнорируем ошибки при обработке отдельных файлов
          }
        }
        
        string[] directories = Directory.GetDirectories(path);
        
        foreach (string dir in directories)
        {

          ScanDirectory(dir);
            
        }
      }
      catch (UnauthorizedAccessException)
      {
          // Нет доступа к папке - просто пропускаем
      }
      catch (DirectoryNotFoundException)
      {
          // Папка не найдена - пропускаем
      }
      catch
      {
          // Другие ошибки - пропускаем
      }
    }
  }
}