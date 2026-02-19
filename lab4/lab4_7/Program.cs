namespace lab4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = new string[]
            {
                "Иван",
                "Петр",
                "Алексей",
                "Дмитрий",
                "Анна",
                "Мария",
                "Елена",
                "Сергей",
                "Ольга",
                "Михаил"
            };
            
            PrintArray(firstNames);
            
            InsertionSort(firstNames);
            
            PrintArray(firstNames);
        }
        
        static void InsertionSort(string[] array)
        {
            int n = array.Length;
            
            for (int i = 1; i < n; i++)
            {
                string key = array[i]; 
                int j = i - 1;
                
                Console.WriteLine($"\nВставляем '{key}' на позицию {i}:");
                
                while (j >= 0 && string.Compare(array[j], key) > 0)
                {
                    Console.WriteLine($"  Сдвигаем '{array[j]}' с позиции {j} на {j + 1}");
                    array[j + 1] = array[j];
                    j--;
                }
                
                array[j + 1] = key;
                Console.Write("  Результат: ");
                PrintArray(array);
            }
        }
        
        static void PrintArray(string[] array)
        {
            foreach (string s in array)
            {
                Console.Write(s);
            }
            Console.WriteLine();
        }
    }
}