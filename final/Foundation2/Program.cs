using System;

class Program
{
    static void Input(List<Order> orders)
    {
        List<Product> products = new List<Product>(); Customer customer;
        Address address; Product product;Order order;

        address = new Address("123 Main Street", "Thetown", "NY", "USA");

        customer = new Customer("Jack Caleb", address);

        product = new Product("Gadget", "LD1009842", 16.54, 1);

        products.Add(product);

        product = new Product("Widget", "S0097564", 13.48, 2);

        products.Add(product);

        product = new Product("Bagelbites", "BB0040056", 6.27, 6);

        products.Add(product);

        order = new Order(products, customer);

        orders.Add(order);

        products = new List<Product>();

        address = new Address("3 Chome Kanda Kajicho", "Chiyoda City", "Tokyo", "Japan");

        customer = new Customer("Lewis Dean", address);

        product = new Product("Stereo", "MK0012093", 3.79, 5);

        products.Add(product);

        product = new Product("Radio", "HK0041902", 4.23, 2);

        products.Add(product);

        product = new Product("Plasma", "P1060239", 3.16, 5);

        products.Add(product);

        order = new Order(products, customer);

        orders.Add(order);
    }
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        Input(orders);
        
        foreach(Order order in orders){
            Console.WriteLine("Packing Label");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine("Shipping Label");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Shipping Price: ${order.GetShippingPrice()}.00");
            Console.WriteLine($"Total Price: ${Math.Round(order.TotalPrice(), 2)}\n");
        }
    }
}