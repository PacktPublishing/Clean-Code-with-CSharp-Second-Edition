namespace CrossCuttingConcerns.Security;

public abstract class DecoratorBase : ISecureComponent
{
    private readonly ISecureComponent _secureComponent;

    public DecoratorBase(ISecureComponent secureComponent)
    {
        _secureComponent = secureComponent;
    }

    public virtual void AddData(dynamic data)
    {
        _secureComponent.AddData(data);
    }

    public virtual int DeleteData(dynamic data)
    {
        _secureComponent?.DeleteData(data);
        return 1;
    }

    public virtual int EditData(dynamic data)
    {
        _secureComponent?.EditData(data);
        return 1;
    }

    public virtual dynamic GetData(dynamic data)
    {
        _secureComponent.GetData(data);
        return "Hi!";
    }
}