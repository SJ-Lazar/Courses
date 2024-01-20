using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;



class Program
{
    static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder()
       .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json");
        IConfiguration configuration = builder.Build();

        ServiceCollection serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);

        ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
        serviceProvider.GetService<App>()?.Run();
    }

    private static void ConfigureServices(ServiceCollection serviceCollection)
    {
        // Add app
        serviceCollection.AddTransient<App>();
        // Add services
        serviceCollection.AddTransient<IMyService, MyService>();
        serviceCollection.AddTransient<IAuthenticator, Authenticator>();

    }
}

public class Authenticator : IAuthenticator
{
    public bool Authenticate()
    {
        return true;
    }
}

//Create for a dependency injection using a factory 



