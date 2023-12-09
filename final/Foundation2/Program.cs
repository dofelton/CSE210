using System;
// create at least 2 orders with 2-3 products; get packing label, shipping label and total cost for each order and display results

// first order

Customer c1 = new Customer("Bill", "3 S St", "NewValley", "Iowa", "US");
Order o1 = new Order(c1);
Product p1 = new Product("Phone", 1, 450, 1);
o1._products.Add(p1);
Product p2 = new Product("Sandwich", 2, 5, 3);
o1._products.Add(p2);
Product p3 = new Product("Cookie", 3, 3, 12);
o1._products.Add(p3);
Console.Clear();
Console.WriteLine("First Order:");
o1.PackingLabel(o1._products);
o1.ShippingLabel(c1);
o1.CalcPrice(o1._products);

// Second order

Customer c2 = new Customer("Sally", "321 Mustang Alley", "Istanbul", "Constantinople", "Turkey");
Order o2 = new Order(c2);
Product p4 = new Product("Light Saber", 4, 32, 2);
o2._products.Add(p4);
Product p5 = new Product("Tie Fighter", 5, 124, 250);
o2._products.Add(p5);
Product p6 = new Product("AT-AT", 6, 413, 20);
o2._products.Add(p6);
Console.WriteLine("\nSecond Order:");
o2.PackingLabel(o2._products);
o2.ShippingLabel(c2);
o2.CalcPrice(o2._products);

