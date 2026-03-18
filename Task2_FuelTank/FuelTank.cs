public class FuelTank
{
    public string TankId;
    private double CurrentFuel;

    public FuelTank(string tankId, double currentFuel)
    {
        this.TankId = tankId;
        this.CurrentFuel = currentFuel;
    }

    public void Refuel(double amount)
    {
        this.CurrentFuel += amount;
        Console.WriteLine($"Бак {this.TankId} заправлен на {amount} л.");
    }

    public void Consume(double amount)
    {
        if (amount <= this.CurrentFuel)
        {
            this.CurrentFuel -= amount;
            Console.WriteLine($"Из бака {this.TankId} потрачено {amount} л.");
        }
        else
        {
            Console.WriteLine($"В баке {this.TankId} недостаточно топлива.");
        }
    }

    public void ShowLevel()
    {
        Console.WriteLine($"Текущий уровень топлива в баке {this.TankId}: {this.CurrentFuel} л.");
    }
}
