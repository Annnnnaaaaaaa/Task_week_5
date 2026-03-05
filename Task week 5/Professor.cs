namespace Task_week_5;

// Professor: Overrides PerformDuties(). Adds "Lecture delivered"to
// log. Includes a unique method ConductResearch(string topic).

public class Professor : UniversityMember
{
    public Professor(string name, string member_id) : base(name, member_id) { }
    
    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Lecture delivered");
    }

    public void ConductResearch(string topic)
    {
        ActionLog.Add($"Research conducted: {topic}");
        Console.WriteLine($"Conducting research on: {topic}");
    }
}