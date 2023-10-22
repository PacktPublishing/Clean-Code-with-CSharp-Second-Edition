namespace CrossCuttingConcerns.Security;

public class ConcreteDecorator : DecoratorBase
{
    public ConcreteDecorator(ISecureComponent secureComponent) : base(secureComponent) { }

    public override void AddData(dynamic data)
    {
        if (Credentials.Role.Contains("Administrator") || Credentials.Role.Contains("Restricted"))
        {
            base.AddData((object)data);
        }
        else
        {
            throw new UnauthorizedAccessException("Unauthorized");
        }
    }

}