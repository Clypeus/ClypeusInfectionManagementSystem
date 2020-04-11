namespace Clypeus.Core.Initalisation
{
    public delegate string GetUsername();

    public delegate string GetPassword();

    public delegate string GetDatabaseConnectionString(string username, string password);
}