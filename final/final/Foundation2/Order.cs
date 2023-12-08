// contains list of products, a customer, 
// calculate total order cost, return a string for packing label, return a string for shipping label

class Order
{
    private List<string> _products = new List<string>();
    private string _customer;

    public Order(    )
    {

    }

    public float CalcPrice()
    {
        // total price = sum of product prices plus shipping

    }

    private int CalcShipping(string country)
    {
        // $5 domestic, $35 international

    }

    public string PackingLabel(  )
    {
        // return string with name and id of products in the order

    }

    public string ShippingLabel(  )
    {
        // return string with name and address of customer
    }
}