







public class Canvas
{
    public void DrawShape(List<PolyShape> shapes)
    {
        foreach (var shape in shapes)
        {
            //polymorphic behavior
           shape.Draw();
        }
    }
}