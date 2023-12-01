namespace CH4;

public struct Credential
{
    public Credential(string email, string password)
    {
        EmailAddress = email;
        Password = password;
    }

    public string EmailAddress { get; }
    public string Password { get; }
}
