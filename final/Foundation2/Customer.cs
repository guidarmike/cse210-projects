class Customer
{
    private string _name;
    public Address Address; // Exposing the Address field directly

    public Customer(string name, Address address)
    {
        _name = name;
        Address = address;
    }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }

    public string GetInfo()
    {
        return _name;
    }
}