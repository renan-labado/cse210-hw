using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Order #1:");
        Console.WriteLine("");
        Address firstAddress = new Address("123 Main Street", "Los Angeles", "CA", "United States");
        Customer firstCustomer = new Customer("James Martin", firstAddress);
        Product firstProduct = new Product("Soap", "SOAP-WHIT-200", 5, 5);
        Product secondProduct = new Product("Shampoo", "SHAM-VOL-400", 10, 2);
        Order firstOrder = new Order(firstCustomer);
        firstOrder.AddProduct(secondProduct);
        firstOrder.AddProduct(firstProduct);

        Console.WriteLine("Order by:");
        Console.WriteLine(firstOrder.GetShippingLabel());
        Console.WriteLine("Items:");
        Console.WriteLine(firstOrder.GetPackingLabel());
        Console.WriteLine($"The total price is: {firstOrder.CalculateTotalPrice()}");

        // / / / / / / / / / / /
        Console.WriteLine("");
        Console.WriteLine("Order #2:");
        Console.WriteLine("");
        Address secondAddress = new Address("Blk 8 Mngghn St.", "Caloocan City", "Tala", "Philippines");
        Customer secondCustomer = new Customer("Renz Labado", secondAddress);
        Product newProduct = new Product("Pomade", "POMA-HOL-80", 3, 1);
        Product secondNewProduct = new Product("Ice Cream", "ICEC-AVOC-1300", 5, 3);
        Product thirdNewProduct = new Product("Frozen Pizza", "FPIZZ-HAWA-500", 10, 3);
        Order secondOrder = new Order(secondCustomer);
        secondOrder.AddProduct(newProduct);
        secondOrder.AddProduct(secondNewProduct);
        secondOrder.AddProduct(thirdNewProduct);
        
        Console.WriteLine("Order by:");
        Console.WriteLine(secondOrder.GetShippingLabel());
        Console.WriteLine("Items:");
        Console.WriteLine(secondOrder.GetPackingLabel());
        Console.WriteLine($"The total price is: ${secondOrder.CalculateTotalPrice()}");

    }
}