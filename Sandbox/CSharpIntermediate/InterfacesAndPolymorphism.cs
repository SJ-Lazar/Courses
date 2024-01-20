

public class InterfacesAndPolymorphism
{
    public static void Run()
    {
        var encoder = new VideoEncoder();
        encoder.RegisterNotificationChannel(new MailNotificationChannel());
        encoder.RegisterNotificationChannel(new SmsNotificationChannel());
        encoder.Encode(new Video());
    }

    public class VideoEncoder
    {
        //private readonly MailService _mailService;
        private List<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            //_mailService = new MailService();
            _notificationChannels = new List<INotificationChannel>();
        }


        public void Encode(Video video)
        {
            foreach (var channel in _notificationChannels)
                channel.Send(new Message());
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }

    public class Video
    {
        public string Title { get; set; }
    }

    public class MailService
    {
        public void Send(Mail mail)
        {
            System.Console.WriteLine("Sending email...");
        }
    }

    public class Mail
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
    }


    public interface INotificationChannel
    {
        void Send(Message message);
    }

    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending mail...");
        }
    }

    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending SMS...");
        }
    }

    public class Message
    {
        public string Body { get; set; }
    }
}


