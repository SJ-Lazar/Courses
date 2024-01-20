




public class PolyRectangle : PolyShape
{
    public int Length { get; set; }
    public int Breadth { get; set; }

    override public void Draw()
    {
        Console.WriteLine("Draw a rectangle");
    }
}
