namespace Task_week_5;

// GraduateStudent: Inherits from UndergraduateStudent.
// Overrides PerformDuties() to call the base implementation AND add
// "Thesis research update"

public class GraduateStudent : UndergraduateStudent
{
    public GraduateStudent(string name, string member_id) : base(name, member_id) { }
    
    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Thesis research update");
    }
}