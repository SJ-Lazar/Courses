using Newtonsoft.Json;
using System.Collections.Generic;

namespace TestNinja.Mocking;

public class EmployeeController
{
    private EmployeeContext _db;

    public EmployeeController()
    {
        _db = new EmployeeContext();
    }

    public ActionResult DeleteEmployee(int id)
    {
        var employee = _db.Employees.Find(id);
        _db.Employees.Remove(employee);
        _db.SaveChanges();
        return RedirectToAction("Employees");
    }

    private ActionResult RedirectToAction(string employees)
    {
        return new RedirectResult();
    }
}

public class ActionResult { }

public class RedirectResult : ActionResult { }

public class EmployeeContext
{
    public DbSet<Employee> Employees { get; set; }

    public void SaveChanges()
    {
    }
}

public class Employee
{
}


public class OrderService
{
    private readonly IStorage _storage;

    public OrderService(IStorage storage)
    {
        _storage = storage;
    }

    public int PlaceOrder(Order order)
    {
        var orderId = _storage.Store(order);

        // Some other work

        return orderId;
    }
}

public class Order
{
}

public interface IStorage
{
    int Store(object obj);
}

public class Product
{
    public float ListPrice { get; set; }

    public float GetPrice(Customer customer)
    {
        if (customer.IsGold)
            return ListPrice * 0.7f;

        return ListPrice;
    }
}

public class Customer
{
    public bool IsGold { get; set; }
}

public class VideoService
{
    public string ReadVideoTitle()
    {
        var str = File.ReadAllText("video.txt");
        var video = JsonConvert.DeserializeObject<Video>(str);
        if (video == null)
            return "Error parsing the video.";
        return video.Title;
    }

    public string GetUnprocessedVideosAsCsv()
    {
        var videoIds = new List<int>();

        using VideoContext context = new VideoContext();
        var videos =
            (from video in context.Videos
             where !video.IsProcessed
             select video).ToList();

        foreach (var v in videos)
            videoIds.Add(v.Id);

        return String.Join(",", videoIds);
    }
}

public class Video
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsProcessed { get; set; }
}

public class VideoContext : DbContext
{
    public DbSet<Video> Videos { get; set; }
}