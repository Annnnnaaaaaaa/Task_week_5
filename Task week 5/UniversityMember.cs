namespace Task_week_5;

public class UniversityMember
{
    public string Name { get; private set; }
    
    private string MemberId { get; } // read-only
    protected List<string> ActionLog = new List<string>();
    
    public int ActionCount => ActionLog.Count;
    
    
    public UniversityMember(string name, string member_id)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Name cannot be empty");
        Name = name;
        MemberId = member_id; }

    public virtual void PerformDuties()
    {
        if (ActionLog.Count >= 5)
        {
            throw new Exception("You've already reached a daily limit of 5 actions");
        }
    }
}