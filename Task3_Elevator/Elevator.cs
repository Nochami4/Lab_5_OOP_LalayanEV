public class Elevator
{
    public string Model;
    public int CurrentFloor;
    public int MaxFloor;

    public Elevator(string model, int maxFloor)
    {
        Model = model;
        MaxFloor = maxFloor;
        CurrentFloor = 1;
    }

    public void MoveUp(int floors)
    {
        CurrentFloor += floors;

        if (CurrentFloor > MaxFloor)
        {
            CurrentFloor = MaxFloor;
        }

        Console.WriteLine($"Лифт {Model} находится на этаже {CurrentFloor}.");
    }

    public void Reset()
    {
        CurrentFloor = 1;
        Console.WriteLine($"Лифт {Model} возвращен на этаж {CurrentFloor}.");
    }
}
