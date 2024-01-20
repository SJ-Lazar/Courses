public class WorkingWithExceptionHandling

{
    public static void Run()
    {
        StreamReader streamReader = null;
        //Global Exception Handling in main method
        //try
        //{
        //    streamReader = new StreamReader(@"C:\file.zip");
        //    var content = streamReader.ReadToEnd();
        //    streamReader.Close();
        //}
        //catch (DivideByZeroException ex)
        //{
        //    ArithmeticException arithmeticException = new ArithmeticException("Divide by zero", ex);
        //}
        //catch (ArithmeticException ex)
        //{
        //    Console.Write(ex.ToString());
        //}
        //catch (Exception ex)
        //{
        //    Console.Write(ex.ToString());

        //}
        //finally //always executes
        //{
        //    //Close the connection
        //    streamReader?.Dispose();
        //}   

        try
        {
            var api = new YouTubeApi();
            var videos = api.GetVideos("mosh");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }


    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access YouTube web service
                //Read the data
                //Create a list of Video objects
                throw new Exception("Oops some low level YouTube error.");
            }
            catch (Exception ex)
            {
                //Log
                throw new YouTubeException("Could not fetch the videos from YouTube.", ex);
            }
            return new List<Video>();
        }
    }

    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }

    public class Video
    {
        public string Title { get; set; }
    }
}