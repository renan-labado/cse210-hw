public class Product
{
    private string _productName;
    private string _id;
    private float _price;
    private float _quantity;

    public Product(string productName, string id, int price, int quantity)
    {
        _productName = productName;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetNameAndId()
    {
        return $"Product name: {_productName} | ID: {_id}";
    }

    public float GetPrice()
    {
        return _price;
    }

    public float GetQuantity()
    {
        return _quantity;
    }
}