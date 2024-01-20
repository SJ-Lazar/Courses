public class PresentaionObject
{
    //Inheritance
    //Is-A relationship
    //Polymorphic behavior
    public int width { get; set; }
    public int height { get; set; }

    public void Copy()
    {
        System.Console.WriteLine("Object copied to clipboard");
    }

    public void Duplicate()
    {
        System.Console.WriteLine("Object was duplicated");
    }
}
