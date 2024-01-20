public class Installer
{
    private readonly Logger _logger; //Create Associatio to logger

    public Installer(Logger logger)
    {
        _logger = logger;
    }

    public void Install()
    {
        _logger.Log("We are installing blah blah blah");
    }
}



