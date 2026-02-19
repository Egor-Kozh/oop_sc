namespace lab4_8
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("=== СИМУЛЯТОР МЫСЛЕЙ В ГОЛОВЕ (СТЕК) ===\n");

      Head myHead = new Head("Иван");

      bool exit = false;

      while (!exit)
      {
        Console.WriteLine("\nВыберите действие:");
        Console.WriteLine("1. Сгенерировать случайную мысль");
        Console.WriteLine("2. Показать все мысли");
        Console.WriteLine("3. Посмотреть последнюю мысль");
        Console.WriteLine("4. Удалить последнюю мысль");
        Console.WriteLine("5. Очистить голову");
        Console.WriteLine("6. Выход");
        Console.Write("Ваш выбор: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
          case "1":
            myHead.GenerateRandomThink();
            break;

          case "2":
            myHead.ShowAllThoughts();
            break;

          case "3":
            var peekThink = myHead.PeekThink();
            if (peekThink != null)
            {
              string decision = peekThink.GetDecision() ? "Хорошая" : "Плохая";
              Console.WriteLine($"\nПоследняя мысль: {peekThink.GetThinkInfo()} - {decision}");
            }
            break;

          case "4":
            var poppedThink = myHead.PopThink();
            if (poppedThink != null)
            {
              string decision = poppedThink.GetDecision() ? "Хорошая" : "Плохая";
              Console.WriteLine($"\nУдалена мысль: {poppedThink.GetThinkInfo()} - {decision}");
            }
            break;

          case "5":
            myHead.ClearThoughts();
            break;

          case "6":
            exit = true;
            break;

          default:
            Console.WriteLine("Неверный выбор!");
            break;
        }
      }

      Console.WriteLine("\nПрограмма завершена. Спасибо за использование!");
    }
  }
}