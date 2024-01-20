





public class PolyShape 
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Position Position { get; set; }
    //public ShapeType Type { get; set; }

    public virtual void Draw()
    {
        Console.WriteLine("Draw a shape");
    }

}
