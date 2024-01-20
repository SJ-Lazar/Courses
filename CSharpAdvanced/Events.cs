public class Events 
{
    //what is an event?
    //an event is a notification that something has happened
    //an event is a mechanism for communication between objects
    //helps build loosely coupled applications
    //helps extend applications

    //how do we create an event?
    //1. define a delegate
    //2. define an event based on that delegate
    //3. raise the event
    public static void Run(string[] args)
    {
        var video = new Video() { Title = "Video 1" };
        var videoEncoder = new VideoEncoder(); //publisher
        var mailService = new MailService(); //subscriber
        var messageService = new MessageService(); //subscriber

        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
        videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

        videoEncoder.Encode(video);
    }

    public class Video
    {
        public string Title { get; set; }
    }

    public class VideoEncoder
    {
        //1. define a delegate
        //2. define an event based on that delegate
        //3. raise the event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;

        //or

        //EventHandler
        //EventHandler<TEventArgs>

        //public event EventHandler VideoEncoded;

        //or

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding Video...");
            System.Threading.Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            System.Console.WriteLine("MailService: Sending an email..." + args.Video.Title);
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            System.Console.WriteLine("MessageService: Sending a text message..." + args.Video.Title);
        }
    }
}




