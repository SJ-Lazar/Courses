public class Generics
{
    //What does a generic classs acomplish?
    //It allows you to create a class that can be used with any data type
    //How to create a generic class?
    public class GenericClass<T>
    {
        //How to create a generic method?
        public void GenericMethod<T>(T param) { }
    }

    //Generic constraints
    //Create a generic method with contraints

    public class GenericConstraints
    {
        // Create a generic method with constraints
        public void GenericMethodWithConstraints<T>(T param) where T : IComparable<T> { }
    }


    //Create a generic method with multiple constraints
    public class GenericConstraints2
    {
        // Create a generic method with multiple constraints
        public void GenericMethodWithMultipleConstraints<T>(T param) where T : IComparable<T>, new() { }
    }

    //Create a generic method with a struct constraint
    public class GenericConstraints3
    {
        // Create a generic method with a struct constraint
        public void GenericMethodWithStructConstraint<T>(T param) where T : struct { }
    }




}



