namespace CH4;

public struct Product
{
    public string Vendor { get; }
    public string ProductName { get; }

    public Product(string vendor, string productName)
    {
        Vendor = vendor;
        ProductName = productName;
    }
}
