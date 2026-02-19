namespace lab4_2
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
      
      PrintArray(lastNames);
      
      BubbleSort(lastNames);
      
      PrintArray(lastNames);
  }
  
  static void BubbleSort(string[] array)
  {
      int n = array.Length;
      bool swapped;
      
      for (int i = 0; i < n - 1; i++)
      {
          swapped = false;
          
          for (int j = 0; j < n - i - 1; j++)
          {
              if (string.Compare(array[j], array[j + 1]) > 0)
              {
                  string temp = array[j];
                  array[j] = array[j + 1];
                  array[j + 1] = temp;
                  
                  swapped = true;
              }
          }
          
          if (!swapped)
              break;
              
          Console.WriteLine($"\nПроход {i + 1}:");
          PrintArray(array);
      }
  }
  
  static void PrintArray(string[] array)
  {
      for (int i = 0; i < array.Length; i++)
      {
          Console.Write($"{array[i]} ");
      }
      Console.WriteLine();
  }
  }
}