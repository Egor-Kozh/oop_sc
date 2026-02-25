namespace lab4_8
{
  public class Think : IThink
  {
    private static Random _random = new Random();

    private static readonly string[] _studyThoughts = new string[]
    {
            "Надо бы подготовиться к экзамену",
            "Опять учить C#.",
            "Зачем мне это вообще нужно?",
            "О, интересная тема, надо почитать!",
            "Завтра точно начну учиться",
            "Еще 5 минут посижу в телефоне и сяду за учебу",
            "Классно было бы стать программистом",
            "Как же сложно учиться..."
    };

    private static readonly string[] _foodThoughts = new string[]
    {
            "Не пойти ли мне поесть",
            "Хочу есть",
            "Хочу в KFC",
            "Опять потолстел",
            "Надо бы приготовить что-то вкусное",
            "Может пиццу заказать?",
            "Салатик бы съесть для здоровья",
            "Эх, сейчас бы борща..."
    };

    private static readonly string[] _gamesThoughts = new string[]
    {
            "Еще одну игру и спать",
            "Надо пройти этот уровень",
            "Почему так сложно?",
            "Ура! Я победил!",
            "Может в Dota 2 покататься?",
            "Надоело проигрывать",
            "Классная графика в этой игре",
            "Завтра рано вставать, но еще поиграю"
    };

    public TypeThink ThinkType { get; private set; }
    public string ThoughtText { get; private set; }

    public Think(TypeThink type, string thought)
    {
      ThinkType = type;
      ThoughtText = thought;
    }

    public static Think GenerateThink()
    {
      TypeThink type = (TypeThink)_random.Next(0, 3);
      string thought = GetRandomThoughtByType(type);

      return new Think(type, thought);
    }

    private static string GetRandomThoughtByType(TypeThink type)
    {
      string[] thoughts;
      switch (type)
      {
        case TypeThink.Study:
          thoughts = _studyThoughts;
          break;
        case TypeThink.Food:
          thoughts = _foodThoughts;
          break;
        case TypeThink.Games:
          thoughts = _gamesThoughts;
          break;
        default:
          thoughts = new string[] { "Пустая мысль..." };
          break;
      }

      return thoughts[_random.Next(thoughts.Length)];
    }

    public string GetThinkInfo()
    {
      string typeName;
      switch (ThinkType)
      {
        case TypeThink.Study:
          typeName = "Мысль об учебе";
          break;
        case TypeThink.Food:
          typeName = "Мысль о еде";
          break;
        case TypeThink.Games:
          typeName = "Мысль об играх";
          break;
        default:
          typeName = "Неизвестная мысль";
          break;
      }

      return $"{typeName}: \"{ThoughtText}\"";
    }

    public bool GetDecision()
    {
      switch (ThinkType)
      {
        case TypeThink.Study:
          if (ThoughtText.Contains("надо") ||
              ThoughtText.Contains("интересно") ||
              ThoughtText.Contains("классно"))
            return true;
          else
            return false;

        case TypeThink.Food:
          if (ThoughtText.Contains("салатик") ||
              ThoughtText.Contains("здоровье") ||
              ThoughtText.Contains("приготовить"))
            return true;
          else if (ThoughtText.Contains("KFC") ||
                   ThoughtText.Contains("пиццу") ||
                   ThoughtText.Contains("потолстел"))
            return false;
          else
            return true;

        case TypeThink.Games:
          if (ThoughtText.Contains("ура") ||
              ThoughtText.Contains("классная") ||
              ThoughtText.Contains("победил"))
            return true;
          else if (ThoughtText.Contains("надоело") ||
                   ThoughtText.Contains("сложно") ||
                   ThoughtText.Contains("работа"))
            return false;
          else
            return false;

        default:
          return false;
      }
    }
  }
}