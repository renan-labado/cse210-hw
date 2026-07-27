public class Order
{
    private List<Product> _products = new List<Product>();
    private List<Customer> _customers = new List<Customer>();

    public Order(Customer customer)
    {
        _customers.Add(customer);
    }
    public float CalculateTotalPrice()
    {   
        float finalTotal = 0f;
        float shippingCost = GetShippingCost();
        foreach (Product product in _products)
        {
            float price = product.GetPrice();
            float quantity = product.GetQuantity();
            float total = price * quantity;
            finalTotal += total;
        }

        return finalTotal + shippingCost;
    }

    public float GetShippingCost()
    {
        foreach (Customer customer in _customers)
        {
            if (customer.GetBoolAddress() == true)
            {
                return 5f;
            }
            else
            {
                return 35f;
            }
        }
        return 0;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel = packingLabel + product.GetNameAndId() + "\n" ;
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "";
        foreach (Customer customer in _customers)
        {
            shippingLabel += customer.GetNameAndAddress();
        }
        return shippingLabel;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}