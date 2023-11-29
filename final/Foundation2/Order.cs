class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalPrice();
        }

        // Add shipping cost
        if (_customer.IsInUSA())
            totalPrice += 5;
        else
            totalPrice += 35;

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.GetInfo() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetInfo()}\n{_customer.Address.GetInfo()}";
    }
}
