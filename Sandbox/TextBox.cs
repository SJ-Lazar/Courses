public class TextBox : UIControl, IDraggable, IDroppable
{
    public string Text { get; set; }

    public override void Draw()
    {
        System.Console.WriteLine("Drawing a textbox");
    }
}