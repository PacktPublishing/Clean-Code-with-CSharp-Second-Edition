namespace CH4;

public struct DataItem
{
    public string Name { get; }
    public string Description { get; }

    public DataItem(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
