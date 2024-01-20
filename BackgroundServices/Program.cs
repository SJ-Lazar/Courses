using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

class Program
{
    static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<MyBackgroundService>();
            });
}

public class MyBackgroundService : IHostedService, IDisposable
{
    private Timer? _timer;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Background service is starting.");


        _timer = new Timer(DoWork, null, TimeSpan.Zero, // Start immediately
            TimeSpan.FromSeconds(5)); // Run every 5 seconds

        return Task.CompletedTask;
    }

    private void DoWork(object? state)
    {
        Console.WriteLine($"Background service is doing its work. {DateTime.Now}");
        // Do some work here that runs every 5 seconds ...
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Background service is stopping.");

        _timer?.Change(Timeout.Infinite, 0);

        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _timer?.Dispose();
    }
}
