using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("Duncan St 94", "Cape Town", "Western Cape", "South Africa");
        Customer customer1 = new Customer("Leonard Luyinga Lumbale", address1);
        List<Product> productsList1 = new List<Product>();

        Product p1001 = new Product("Bank/Printer paper", "PP300", 82.99, 1);
        Product p1002 = new Product("Sticky Tabs", "ST40", 5.50, 5);
        Product p1003 = new Product("Stapler", "SP08", 3.99, 10);

        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("144 St", "Yeoville", "YV 72001", "SA");
        Customer customer2 = new Customer("John B. Anderson", address2);
        List<Product> productsList2 = new List<Product>();

        Product p2001 = new Product("Lead Refills", "LR", 7.99, 3);
        Product p2002 = new Product("Colored Pens", "CP102", 9.75, 2);
        Product p2003 = new Product("Desk Organiser", "DO103", 20.75, 1);

        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("2011 W 500 S", "Los Angeles", "LA 84104", "USA");
        Customer customer3 = new Customer("James A Kamalondo", address3);
        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("Erasable Pens", "EP100", 11.99, 2);
        Product p3002 = new Product("USB Flash Driver", "UFD", 6.99, 4);

        productsList3.Add(p3001);
        productsList3.Add(p3002);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();
    }
}