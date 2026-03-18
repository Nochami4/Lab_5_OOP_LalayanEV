public class Employee
{
    public int SkillLevel;
    public int Energy;

    public Employee(int skillLevel, int energy)
    {
        SkillLevel = skillLevel;
        Energy = energy;
    }

    public void Work()
    {
        Console.WriteLine("Сотрудник выполняет задачу.");
    }
}
