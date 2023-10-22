namespace CH13_MAUI.Models;

public struct ImmutableModel
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }

    public ImmutableModel(
        int id,
        string name,
        string description
    )
    {
        Id = id;
        Name = name;
        Description = description;
    }
}
