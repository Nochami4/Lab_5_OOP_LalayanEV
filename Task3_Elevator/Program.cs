public class Program
{
    public static void Main()
    {
        Elevator elevator = new Elevator("OTIS", 16);

        elevator.MoveUp(10);
        elevator.Reset();
    }
}
