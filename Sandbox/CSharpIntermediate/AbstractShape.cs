public abstract class AbstractShape
{
    //Abstrct classes and members 
    //Indicates that the containing type is incomplete and must be implemented in a derived class
    public abstract void Draw(); //Just a signature, no implementation

    public void Copy()
    {
        System.Console.WriteLine("Object copied to clipboard");
    }

    public void Duplicate()
    {
        System.Console.WriteLine("Object was duplicated");
    }

    public void Select()
    {
        System.Console.WriteLine("Object was selected");
    }

    //Do not include any implementation
    //if a member is marked as abstract, the containing class must be marked as abstract
    //Must implement all abstract members in the derived class

    //force design to be followed.

    //Common behavior for all shapes
    public int Width { get; set; }
    public int Height { get; set; }

}
