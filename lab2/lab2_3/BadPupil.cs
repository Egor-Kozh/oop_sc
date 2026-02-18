namespace lab2_3
{
  public class BadPupil : Pupil
  {
    public override int GetCurrentGrade
    {
      get
      {
        int chance = _random.Next(100); 
        
        if (chance < 25)     
            return 2;
        else if (chance < 45) 
            return 3;
        else if (chance < 15) 
            return 4;
        else                   
            return 5;
      }
    }
    public override string Study()
    {
      return "Плохой ученик мало учится";
    }

    public override string Read()
    {
      return "Плохой ученик мало читает";
    }

    public override string Write()
    {
      return "Плохой ученик мало пишет";
    }

    public override string Relax()
    {
      return "Плохой ученик много отдыхает";
    }
  }
}