public class InterfacesAndExtensibility 
{
    //Change behavior of an application by extending it without modifying its source code
    //OCP - Open Closed Principle

    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);
            //Details of migrating the database
            _logger.LogInfo("Migration finished at {0}" + DateTime.Now);
        }
    }

    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }

    public class Logger : ILogger
    {
        public void LogError(string message)
        {
            System.Console.WriteLine("Error: " + message);
        }

        public void LogInfo(string message)
        {
            System.Console.WriteLine("Info: " + message);
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            System.Console.WriteLine("Error: " + message);
        }

        public void LogInfo(string message)
        {
            System.Console.WriteLine("Info: " + message);
        }
    }

    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
           using StreamWriter streamWriter = new StreamWriter(_path, true);
           streamWriter.WriteLine("Error: " + message);
        }

        public void LogInfo(string message)
        {
            using StreamWriter streamWriter = new StreamWriter(_path, true);
            streamWriter.WriteLine("Info: " + message); 
        }
    }
  
}