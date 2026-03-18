public class Program
{
    public static void Main()
    {
        Employee trainee = new Employee(1, 100);
        Employee specialist = new Employee(5, 80);
        Employee manager = new Employee(10, 60);

        Console.WriteLine("Стажер:");
        Console.WriteLine($"Уровень навыка: {trainee.SkillLevel}");
        Console.WriteLine($"Запас сил: {trainee.Energy}");
        trainee.Work();

        Console.WriteLine();

        Console.WriteLine("Специалист:");
        Console.WriteLine($"Уровень навыка: {specialist.SkillLevel}");
        Console.WriteLine($"Запас сил: {specialist.Energy}");
        specialist.Work();

        Console.WriteLine();

        Console.WriteLine("Руководитель:");
        Console.WriteLine($"Уровень навыка: {manager.SkillLevel}");
        Console.WriteLine($"Запас сил: {manager.Energy}");
        manager.Work();
    }
}
