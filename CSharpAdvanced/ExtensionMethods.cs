public static class ExtensionMethods 
{
    //Allows us to use the extension method on any object

    public static void ExtensionMethod(this object obj)
    {
        System.Console.WriteLine("Extension method called");
    }
    public static string Shorten(this string str, int numberOfWords)
    {
        if (numberOfWords < 0)
            throw new System.ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0");

        if (numberOfWords == 0)
            return "";

        var words = str.Split(' ');
        if (words.Length <= numberOfWords)
            return str;

        return string.Join(" ", words.Take(numberOfWords)) + "...";
    }

}

