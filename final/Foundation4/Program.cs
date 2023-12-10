using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
// create at least one instance of each class(activity) and put them in a list, iterate list and display GetSummary
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities= new List<Activity>();
        Run r1 = new Run("09 December 2023", 37, 2.2);
        r1.GetSummary(r1, r1.GetDate(), r1.GetDuration(), r1.GetDistance());
        activities.Add(r1);

        Cycle c1 = new Cycle("09 December 2023", 65, 12);
        c1.GetSummary(c1, c1.GetDate(), c1.GetDuration(), c1.GetSpeed());
        activities.Add(c1);

        Swim s1 = new Swim("09 December 2023", 45, 16);
        s1.GetSummary(s1, s1.GetDate(), s1.GetDuration(), s1.GetLaps());
        activities.Add(s1);

        foreach (Activity act in activities)
        {
            act.ListGetSummary(act);
        }
    }
}