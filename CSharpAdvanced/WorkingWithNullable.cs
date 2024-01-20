public class WorkingWithNullable
{
    public static void Run()
    {
      DateTime? date = null;
      DateTime date2 = date ?? DateTime.Today;

      Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
        Console.WriteLine("HasValue: " + date.HasValue);
        //Console.WriteLine("Value: " + date.Value); // Throws an exception



     

    }
}