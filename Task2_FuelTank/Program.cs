public class Program
{
    public static void Main()
    {
        FuelTank tank = new FuelTank("TANK-01", 0);

        tank.Refuel(50);
        tank.Consume(20);
        tank.ShowLevel();
    }
}
