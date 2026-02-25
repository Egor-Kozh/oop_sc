namespace lab2_3
{
  public class ClassRoom
  {
    private int _pupilCount;

    private Pupil _pupil1;
    private Pupil _pupil2;
    private Pupil? _pupil3;
    private Pupil? _pupil4;

    public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
    {
      _pupil1 = pupil1;
      _pupil2 = pupil2;
      _pupil3 = pupil3;
      _pupil4 = pupil4;

      _pupilCount = 4;
    }

    public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
    {
      _pupil1 = pupil1;
      _pupil2 = pupil2;
      _pupil3 = pupil3;

      _pupilCount = 3;
    }

    public ClassRoom(Pupil pupil1, Pupil pupil2)
    {
      _pupil1 = pupil1;
      _pupil2 = pupil2;

      _pupilCount = 2;
    }

    public double GetRoundGrade()
    {
      if (_pupilCount == 2)
      {
        return (_pupil1.GetCurrentGrade + _pupil2.GetCurrentGrade) / _pupilCount;
      }
      if (_pupilCount == 3)
      {
        return (_pupil1.GetCurrentGrade + _pupil2.GetCurrentGrade +
        _pupil3.GetCurrentGrade) / _pupilCount;
      }
      if (_pupilCount == 4)
      {
        return (_pupil1.GetCurrentGrade + _pupil2.GetCurrentGrade +
        _pupil3.GetCurrentGrade + _pupil4.GetCurrentGrade) / _pupilCount;
      }
      return 0.0;
    }

    public int PupilCount
    {
      get { return _pupilCount; }
    }
  }
}