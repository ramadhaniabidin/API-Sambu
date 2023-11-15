using RSUP;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        RequestRSUP rsup = new RequestRSUP();
        string token = "";
        token = rsup.GetLoginToken();
        Console.WriteLine($"Login Token = {token}");
    }
}