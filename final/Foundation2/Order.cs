// contains list of products, a customer, 
// calculate total order cost, return a string for packing label, return a string for shipping label

class Order
{
    public List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public List<Product> GetList()
    {
        return _products;
    }

    public float CalcPrice(List<Product> products)
    {
        // total price = sum of product prices plus shipping
        float totalPrice = 0;
        foreach (Product prod in _products)
        {
            totalPrice = totalPrice + prod.GetPrice();
        }
        // totalPrice = totalPrice + CalcShipping(_customer._isDomestic);
        return totalPrice;
    }

    private int CalcShipping(bool isDomestic)
    {
        // $5 domestic, $35 international
        if (isDomestic == true)
        {
            return 5;
        }
        else 
        {
            return 35;
        }

    }

    public void PackingLabel(List<Product> products)
    {
        // return string with name and id of products in the order
        Console.WriteLine("Packing Label:");
        foreach (Product prod in products)
        {
            Console.WriteLine(prod.GetName() +" " + prod.GetId());
        }
    }

    public void ShippingLabel(Customer customer)
    {
        // return string with name and address of customer
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"{customer.GetName()}");
        Console.WriteLine($"{customer.GetAddress()}");
    }
}