public class Linq
{


    public void Run() 
    {
        var books = new BookRepository().GetBooks();
        //var cheapBooks = books
        //                    .Where(b => b.Price < 10)
        //                    .OrderBy(b => b.Title)
        //                    .Select(b => b.Title);

        //foreach (var book in cheapBooks)
        //    System.Console.WriteLine(book);

        //Linq Query Operators
        //var cheaperBooks = from b in books
        //                    where b.Price < 10
        //                    orderby b.Title
        //                    select b.Title;

        //var book1 = books.SingleOrDefault(b => b.Title == "ASP.Net MVC++");
        //System.Console.WriteLine(book1 == null);


        //var book2 = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
        //System.Console.WriteLine(book2 == null);

        //var book3 = books.LastOrDefault(b => b.Title == "C# Advanced Topics");

        //var pagedBooks = books.Skip(2).Take(3);

        //foreach (var book in pagedBooks)
        //    System.Console.WriteLine(book.Title + " " + book.Price);


        var count = books.Count();
        System.Console.WriteLine(count);

        var maxPrice = books.Max(b => b.Price);
        System.Console.WriteLine(maxPrice);

        var minPrice = books.Min(b => b.Price);
        System.Console.WriteLine(minPrice);

        var totalPrice = books.Sum(b => b.Price);
        System.Console.WriteLine(totalPrice);

        var averagePrice = books.Average(b => b.Price);
        System.Console.WriteLine(averagePrice);




    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new() {Title = "ADO.Net Step by Step", Author = "John Doe", Price = 5f},
                new() {Title = "ASP.Net MVC", Author = "John Doe" , Price =9.5f},
                new() {Title = "ASP.Net Web API", Author = "John Doe", Price = 10f},
                new() {Title = "C# Advanced Topics", Author = "John Doe", Price = 8f},
                new() {Title = "C# Advanced Topics", Author = "John Doe", Price = 25f},
                new() {Title = "C# Advanced Topics", Author = "John Doe"   , Price = 15f}
            };
        }
    }
}
