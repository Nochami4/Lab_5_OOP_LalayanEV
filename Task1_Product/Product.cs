public class Product
{
    public string Name;
    public decimal Price;
    public bool IsInStock;

    public Product()
    {
        Name = "Товар без названия";
        Price = 0m;
        IsInStock = false;
    }

    public Product(string name, decimal price, bool isInStock)
    {
        Name = name;
        Price = price;
        IsInStock = isInStock;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Название товара: {Name}");
        Console.WriteLine($"Цена: {Price}");
        Console.WriteLine($"Есть на складе: {IsInStock}");
        Console.WriteLine();
    }
}
