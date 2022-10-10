namespace HospitalHm.Allmethods;
using HospitalHm.Time;

public static class Staticmethods
{
    public static bool Checkreservesion(this Workdate workdate)
    {
        return !workdate.worktim._Isrezerved;
    }

    public static void Reserve(this Workdate workdate)
    {
        workdate.worktim._Isrezerved = true;
    }
}