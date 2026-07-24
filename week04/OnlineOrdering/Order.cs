public class Order
{
    private List<Product> _products = new List<Product>();
    private List<Customer> _customers = new List<Customer>();

    public float CalculateTotalPrice()
    {
        return 0f;
    }

    public int GetShippingCost()
    {
        return 0;
    }

    public string WritePackingLabel()
    {
        return "";
    }

    public string WriteShippingLabel()
    {
        return "";
    }

    public void AddProduct()
    {
        
    }

    public void AddCustomers()
    {
        
    }
}