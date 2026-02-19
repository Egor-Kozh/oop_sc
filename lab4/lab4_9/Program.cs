namespace lab4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            
            dictionary.Add("яблоко", "apple");
            dictionary.Add("кот", "cat");
            dictionary.Add("собака", "dog");
            dictionary.Add("книга", "book");
            dictionary.Add("дом", "house");
            dictionary.Add("машина", "car");
            dictionary.Add("солнце", "sun");
            dictionary.Add("луна", "moon");
            dictionary.Add("вода", "water");
            dictionary.Add("дерево", "tree");
            dictionary.Add("привет", "hello");
            dictionary.Add("мир", "world");
            dictionary.Add("хорошо", "good");
            dictionary.Add("плохо", "bad");
            dictionary.Add("красный", "red");
                        
            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
            
            string word = "собака";
            
            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine($"{word} - {dictionary[word]}");
            }
            else
            {
                Console.WriteLine($"Слово '{word}' не найдено в словаре");
            }
        }
    }
}