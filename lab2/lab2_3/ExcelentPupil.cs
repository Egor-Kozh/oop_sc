namespace lab2_3
{
  public class ExcelentPupil : Pupil
  {
    public override int GetCurrentGrade
    {
      get
      {
        int chance = _random.Next(100); 
        
        if (chance < 5)     
            return 2;
        else if (chance < 15) 
            return 3;
        else if (chance < 45) 
            return 4;
        else                   
            return 5;
      }
    }
    public override string Study()
    {
      return "Отличный ученик много учится";
    }

    public override string Read()
    {
      return "Отличный ученик много читает";
    }

    public override string Write()
    {
      return "Отличный ученик много пишет";
    }

    public override string Relax()
    {
      return "Отличный ученик мало отдыхает";
    } 
  }
}