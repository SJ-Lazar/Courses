public class LambdaExpressions
{

    //What is a lambda expression?
    //An anonymous method
    //No access modifier, no name and no return statement
    //Can be assigned to a delegate
    //Can be passed as a parameter
    //Can be used in the context of LINQ

    //Write Less Code 
 
    public static void Run(string[] args)
    {
        //args => expression
        //number => number * number;

        //() => ...
        //x => ...
        //(x, y, z) => ...

        Func<int, int> square = number => number * number;

        Console.WriteLine(square(5));

        const int factor = 5;
        Func<int, int> multiplier = n => n * factor;

        var result = multiplier(10);
        Console.WriteLine(result);

        var books = new BookRepository().GetBooks();
        var cheapBooks = books.FindAll(b => b.Price < 10);

        foreach (var book in cheapBooks)
        {
            Console.WriteLine(book.Title);
        }
    }

    static bool IsCheaperThan10Dollars(Book book)
    {
        return book.Price < 10;
    }

    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5},
                new Book() {Title = "Title 2", Price = 7},
                new Book() {Title = "Title 3", Price = 17}
            };
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
   
}



