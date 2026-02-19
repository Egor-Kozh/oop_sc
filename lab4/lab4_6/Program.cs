namespace lab4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] combined = new string[]
            {
                "Иванов",      
                "Иван",        
                "Петров",      
                "Петр",        
                "Сидоров",     
                "Алексей",     
                "Козлов",      
                "Дмитрий",     
                "Смирнов",     
                "Анна",        
                "Васильев",    
                "Мария",       
                "Федоров",     
                "Елена",       
                "Михайлов",    
                "Сергей"       
            };
            
            for (int i = 0; i < combined.Length; i++)
            {
                Console.WriteLine($"{i,5}  | {combined[i]}");
            }
            Console.WriteLine();
            
            string[] lastNames;  
            string[] firstNames;  
            
            SplitArray(combined, out lastNames, out firstNames);
            
            for (int i = 0; i < lastNames.Length; i++)
            {
                Console.WriteLine($"{i, 5} | {lastNames[i]}");
            }

            Console.WriteLine();
            
            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine($"{i, 5} | {firstNames[i]}");
            }
        }
        
        static void SplitArray(string[] combined, out string[] lastNames, out string[] firstNames)
        {
            if (combined.Length % 2 != 0)
            {
                Console.WriteLine("Массив должен содержать четное количество элементов");
            }
            
            int size = combined.Length / 2;
            lastNames = new string[size];
            firstNames = new string[size];
            
            for (int i = 0; i < size; i++)
            {
                lastNames[i] = combined[i * 2];      
                firstNames[i] = combined[i * 2 + 1];
            }
        }
    }
}