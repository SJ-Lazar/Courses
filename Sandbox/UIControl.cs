using System.Drawing;

public class UIControl
{

    //Not used for mutiple inheritance
    //A class can only inherit from one class
    //Interfaces are contacts that a class can implement
    public string Id { get; set; }
    public Size Size { get; set; }
    public Position TopLeft { get; set; }

    public virtual void Draw()
    {

    }

    public void Focus()
    {
        System.Console.WriteLine("Received focus");
    }
}
