

public class DynamicTypes 
{
   

    public static void Run()
    {
        //Type Resolution
        dynamic name = "John";
        dynamic age = 20;

        dynamic a = 10;
        dynamic b = 5;
        var c = a + b;

        //implicit type conversion
        int i = 10;
        dynamic d = i;

        //explicit type conversion
        dynamic e = 10;
        int f = (int)e;

        //dynamic types are resolved at runtime
        dynamic g = 10;
        dynamic h = 5;
        var j = g + h;


    }


}