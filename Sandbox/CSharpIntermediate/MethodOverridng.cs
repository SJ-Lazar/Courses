public class MethodOverridng
{
    //Modifiying the implementation of a method in a base class , virtual keyword is used to allow the method to be overriden in a derived class
    //override keyword is used to override the method in the derived class
    public virtual void DoSomething()
    {
        Console.WriteLine("MethodOverridung.DoSomething");
    }

    public static void Run()
    {
        var shapes = new List<PolyShape>();
        shapes.Add(new PolyCircle());
        shapes.Add(new PolyRectangle());

        var canvas = new Canvas();
        canvas.DrawShape(shapes);

    }
      
}
