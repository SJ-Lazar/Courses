public class Car : Vehicle
{
    public Car()
    {
         Console.WriteLine("Car is being initialised");
    }
    public Car(string registrationNumber)
        : base(registrationNumber) //Allows access to the base class 
    {
        //Initialise fields specific to the car class
    }
}

