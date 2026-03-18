public class Program
{
    public static void Main()
    {
        LotteryBall firstLotteryBall = new LotteryBall();
        LotteryBall secondLotteryBall = new LotteryBall(100);

        Console.WriteLine("Лототрон с максимумом 60:");
        Console.WriteLine(firstLotteryBall.Draw());
        Console.WriteLine(firstLotteryBall.Draw());
        Console.WriteLine(firstLotteryBall.Draw());

        Console.WriteLine();

        Console.WriteLine("Лототрон с максимумом 100:");
        Console.WriteLine(secondLotteryBall.Draw());
        Console.WriteLine(secondLotteryBall.Draw());
        Console.WriteLine(secondLotteryBall.Draw());
    }
}
