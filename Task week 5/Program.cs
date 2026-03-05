using Task_week_5;

var registry = new UniversityRegistry();

var prof = new Professor("Jeffrey", "1");
var student = new UndergraduateStudent("Alice", "2");
var gradStudent = new GraduateStudent("Bob", "3");

registry.AddMember(prof);
registry.AddMember(student);
registry.AddMember(gradStudent);

registry.ExecuteAllDuties();

Console.WriteLine($"\nTotal actions: {registry.GetMemberStatistics()}");

// Перевірка методу професора
prof.ConductResearch("Some topic");

// Перевищуємо ліміт по діях
try
{
    for (int i = 0; i < 10; i++)
    {
        prof.PerformDuties();
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Caught expected error: {ex.Message}");
}
