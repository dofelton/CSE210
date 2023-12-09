// keeps track of name: string, product_id: int, price: float, quantity: int, prod_price = price * quantity: float

using System.Net.Http.Headers;

class Product
{
    private string _prodName;
    private int _prodId;
    private float _price;
    private int _quantity;
    private float _prodPrice;
    
    public Product(string prod, int prodId, float price, int quantity)
    {
        _prodName = prod;
        _prodId = prodId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _prodName;
    }
    
    public float GetPrice()
    {
        return _price;
    }

    public int GetId()
    {
        return _prodId;
    }

    public float GetProdPrice(float price, int quantity)
    {
        return _prodPrice = price * quantity;
    }
}