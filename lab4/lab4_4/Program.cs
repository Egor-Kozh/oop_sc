namespace lab4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            
            dictionary.Add("apple", "яблоко");
            dictionary.Add("cat", "кот");
            dictionary.Add("dog", "собака");
            dictionary.Add("book", "книга");
            dictionary.Add("house", "дом");
            dictionary.Add("car", "машина");
            dictionary.Add("sun", "солнце");
            dictionary.Add("moon", "луна");
            dictionary.Add("water", "вода");
            dictionary.Add("tree", "дерево");
                        
            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
            
            string word = "cat";
            
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