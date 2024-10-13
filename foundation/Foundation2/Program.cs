using System;  

namespace OrderSystem  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            // Create address for customer 1  
            Address address1 = new Address("123 West Main St", "Lehi", "UT", "USA");  
            Customer customer1 = new Customer("Barry Allen", address1);  
            Order order1 = new Order(customer1);  
            order1.AddProduct(new Product("Monitor", "P001", 250.00m, 1));  
            order1.AddProduct(new Product("Gaming Headset", "P002", 50.00m, 1));  

            // Create address for customer 2  
            Address address2 = new Address("123 Oak St", "Vancouver", "BC", "Canada");  
            Customer customer2 = new Customer("Bruce Wayne", address2);  
            Order order2 = new Order(customer2);  
            order2.AddProduct(new Product("Keyboard", "P003", 100.00m, 1));  
            order2.AddProduct(new Product("Mousepad", "P004", 20.00m, 2));  

            // Display order details for customer 1  
            Console.WriteLine(order1.GetPackingLabel());  
            Console.WriteLine(order1.GetShippingLabel());  
            Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");  

            // Display order details for customer 2  
            Console.WriteLine(order2.GetPackingLabel());  
            Console.WriteLine(order2.GetShippingLabel());  
            Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}\n");  
        }  
    }  
}