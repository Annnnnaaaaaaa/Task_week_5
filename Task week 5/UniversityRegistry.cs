namespace Task_week_5;

// private List<UniversityMember> members.
// • AddMember(UniversityMember m): Adds a member to the registry.
// • ExecuteAllDuties(): Iterates through the collection and invokes PerformDuties() on each member.
// • GetMemberStatistics(): Returns a summary of total actions performed across all members. 

public class UniversityRegistry
{
    private List<UniversityMember> _members = new List<UniversityMember>();
    
    public void AddMember(UniversityMember m)
    {
        _members.Add(m);
    }

    public void ExecuteAllDuties()
    {
        foreach (var member in _members)
        {
            // Dynamic Polymorphism: CLR resolves the method at runtime
            member.PerformDuties();
        }
    }

    public int GetMemberStatistics()
    {
        int sum = 0;
        foreach (var m in _members)
            sum += m.ActionCount;
        return sum;
    }
}