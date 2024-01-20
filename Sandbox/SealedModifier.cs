public sealed class SealedModifier
{
    //Prevents derivation of classes or overriding of methods
    //Sealed classes are slightly faster than non-sealed classes

    public void DoSomething()
    {
        System.Console.WriteLine("Doing something");
    }

}