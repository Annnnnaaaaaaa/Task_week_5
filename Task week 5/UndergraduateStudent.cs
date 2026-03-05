namespace Task_week_5;

// UndergraduateStudent: Overrides PerformDuties().
// Adds "Lab work completed"to log.
    
public class UndergraduateStudent : UniversityMember
{
    public UndergraduateStudent(string name, string member_id) : base(name, member_id) { }
    
    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Lab work completed");
    }
}