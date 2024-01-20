public class App
{
    private readonly IMyService _myService;
    private readonly IAuthenticator _authenticator;

    public App(IMyService myService, IAuthenticator authenticator)
    {
        _myService = myService;
        _authenticator = authenticator;
    }

    public void Run()
    {
        Console.WriteLine(_myService.GetMessage());
        Console.WriteLine(_authenticator.Authenticate());
    }
}

