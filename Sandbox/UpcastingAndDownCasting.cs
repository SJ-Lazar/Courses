public class UpcastingAndDownCasting 
{
    //Upcasting and Downcasting
    public void Run() 
    {
        Circle circle = new Circle();
        Shape shape = circle; //Upcasting

        Circle circle2 = (Circle)shape; //Downcasting

        //Downcasting with as operator
        Circle circle3 = shape as Circle; //does not throw exception if shape is not a circle returns null

        //Downcasting with is operator
        if (shape is Circle)
        {
            Circle circle4 = (Circle)shape;
        }

        TextObject text = new TextObject();
        Shape shape2 = text;

        text.Width = 200;
        shape2.Width = 100;

        Console.WriteLine(text.Width); //100

        //StreamReader streamReader = new StreamReader(new MemoryStream());

        //Real World Example of Upcasting and Downcasting
        //var list = new ArrayList();
        //list.Add(1);
        //list.Add("Mosh");
        //list.Add(new Text());

        //var anotherList = new List<int>();
        //anotherList.Add(1);
        //anotherList.Add(2);
        //anotherList.Add(3);

        //var names = new List<string>();
        //names.Add("Mosh");
        //names.Add("John");
        //names.Add("Mary");
    }
}
