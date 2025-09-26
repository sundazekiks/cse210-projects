using System;

class Program
{
    static void Main(string[] args)
    {
        Order firstOrder = new Order();
        firstOrder.getCustomerDetails("Travis", "123 Main St", "Maplewood", "VA", "USA");
        firstOrder.AddProducts("Dino World: T-rex", 1, 19.99, 1);
        firstOrder.AddProducts("Globe", 2, 20.99, 1);
        firstOrder.AddProducts("Map", 3, 12, 2);

        firstOrder.packingLabel();
        Console.WriteLine(firstOrder.GenerateShippingLabel());
        Console.WriteLine($"Total Price: ${firstOrder.PrintOutProducts()}");
        Console.WriteLine(" ");

        Order secondOrder = new Order();
        secondOrder.getCustomerDetails("Travis", "123 Main St", "Maplewood", "VA", "USA");
        secondOrder.AddProducts("Bike", 1, 15.3, 1);
        secondOrder.AddProducts("Motor", 2, 12.2, 5);
        secondOrder.AddProducts("Cycling", 3, 12.15, 3);

        secondOrder.packingLabel();
        Console.WriteLine(secondOrder.GenerateShippingLabel());
        Console.WriteLine($"Total Price: ${secondOrder.PrintOutProducts()}");
        Console.WriteLine(" ");

        Order thirdOrder = new Order();
        thirdOrder.getCustomerDetails("Travis", "123 Main St", "Maplewood", "VA", "USA");
        thirdOrder.AddProducts("Borderland: PUBG", 1, 18.75, 4);
        thirdOrder.AddProducts("Apple", 2, 25.90, 1);
        thirdOrder.AddProducts("Pancake", 3, 22.80, 5);

        thirdOrder.packingLabel();
        Console.WriteLine(thirdOrder.GenerateShippingLabel());
        Console.WriteLine($"Total Price: ${thirdOrder.PrintOutProducts()}");

    }
}