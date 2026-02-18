namespace lab2_3
{
  public class GoodPupil : Pupil
  {
    public override int GetCurrentGrade
    {
      get
      {
        int chance = _random.Next(100); 
        
        if (chance < 15)     
            return 2;
        else if (chance < 25) 
            return 3;
        else if (chance < 80) 
            return 4;
        else                   
            return 5;
      }
    }
    public override string Study()
    {
      return "Хороший ученик умеренно учится";
    }

    public override string Read()
    {
      return "Хороший ученик умеренно читает";
    }

    public override string Write()
    {
      return "Хороший ученик умеренно пишет";
    }

    public override string Relax()
    {
      return "Хороший ученик умеренно отдыхает";
    } 
  }
}