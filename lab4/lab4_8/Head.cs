namespace lab4_8
{
  public class Head
  {
    private Stack<Think> _thoughts = new Stack<Think>();
    private string _ownerName;

    public Head(string ownerName)
    {
      _ownerName = ownerName;
    }

    public void AddThink(Think think)
    {
      _thoughts.Push(think);
      Console.WriteLine($"В голове {_ownerName} появилась новая мысль!");
    }

    public void GenerateRandomThink()
    {
      Think think = Think.GenerateThink();
      AddThink(think);
    }

    public Think? PopThink()
    {
      if (_thoughts.Count > 0)
      {
        return _thoughts.Pop();
      }
      else
      {
        Console.WriteLine($"В голове {_ownerName} пусто...");
        return null;
      }
    }

    public Think? PeekThink()
    {
      if (_thoughts.Count > 0)
      {
        return _thoughts.Peek();
      }
      else
      {
        Console.WriteLine($"В голове {_ownerName} пусто...");
        return null;
      }
    }

    public void ShowAllThoughts()
    {
      Console.WriteLine($"\n=== МЫСЛИ В ГОЛОВЕ {_ownerName.ToUpper()} ===");

      if (_thoughts.Count == 0)
      {
        Console.WriteLine("В голове пусто...");
        return;
      }

      Think[] thoughtsArray = _thoughts.ToArray();

      for (int i = 0; i < thoughtsArray.Length; i++)
      {
        string decision = thoughtsArray[i].GetDecision() ? "Хорошая" : "Плохая";
        Console.WriteLine($"{i + 1}. {thoughtsArray[i].GetThinkInfo()} - {decision}");
      }

      Console.WriteLine($"\nВсего мыслей: {_thoughts.Count}");
    }

    public void ClearThoughts()
    {
      _thoughts.Clear();
      Console.WriteLine($"🧹 Голова {_ownerName} очищена!");
    }

    public int ThoughtCount
    {
      get
      {
        return _thoughts.Count;
      }
    }
  }
}