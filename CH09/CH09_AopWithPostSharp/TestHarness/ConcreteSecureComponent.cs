using CrossCuttingConcerns.Security;

namespace TestHarness;

internal class ConcreteSecureComponent : ISecureComponent
{
    public void AddData(dynamic data)
    {
        //throw new NotImplementedException();
    }

    public int DeleteData(dynamic data)
    {
        throw new NotImplementedException();
    }

    public int EditData(dynamic data)
    {
        throw new NotImplementedException();
    }

    public dynamic GetData(dynamic data)
    {
        throw new NotImplementedException();
    }
}
