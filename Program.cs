using System;

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
