public class Program
{
    public static void Main()
    {
        Product firstProduct = new Product();
        Product secondProduct = new Product("Ноутбук", 54999.99m, true);

        Console.WriteLine("Первый товар:");
        firstProduct.ShowInfo();

        Console.WriteLine("Второй товар:");
        secondProduct.ShowInfo();
    }
}
