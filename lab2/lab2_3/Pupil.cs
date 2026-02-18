namespace lab2_3
{
  public class Pupil
  {
    protected static Random _random = new Random();

    public virtual int GetCurrentGrade
    {
      get
      {
        return _random.Next(2, 6); 
      }
    }

    public virtual string Study()
    {
      return "Ученик учится";
    }

    public virtual string Read()
    {
      return "Ученик читает";
    }

    public virtual string Write()
    {
      return "Ученик пишет";
    }

    public virtual string Relax()
    {
      return "Ученик отдыхает";
    } 
  }
}