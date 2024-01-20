public class Vehicle
{
    private string _registrationNumber;

    public Vehicle() 
    {
        Console.WriteLine("Vehicle is being initialised");
    }
    public Vehicle(string registrationNumber)
    {
        _registrationNumber = registrationNumber;
    }
}

