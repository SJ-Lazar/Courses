using System.Collections;

public class  BoxingAndUnboxing 
{
    public void Run() 
    {
        //Value type => stored on the stack, short lived
        //Reference Type => Heap => long lived

        Circle circle = new Circle();
        Shape shape = circle; //implicit conversion
        object shape2 = circle; //implicit conversion

        //Boxing the process of converting a value type to a reference type
        int number = 10;
        object obj = number; //boxing

        //or
        object obj2 = 10; //boxing

        //Unboxing the process of converting a reference type to a value type
        object obj3 = 10;
        int number2 = (int)obj3; //unboxing

        //have a performance penalty

        var list = new ArrayList();
        list.Add(1); //boxing
        list.Add("Mosh"); //boxing
        list.Add(DateTime.Today); //boxing

        var number3 = (int)list[1]; //unboxing

        var anotherList = new List<int>();  
        anotherList.Add(1); //no boxing and typesafe
        anotherList.Add(2); //no boxing
        anotherList.Add(3); //no boxing




    }
}