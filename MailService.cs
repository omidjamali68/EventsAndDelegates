using EventsAndDelegates;

public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs args)
    {
        System.Console.WriteLine($"Email Sent for {args.video.Title}.");
    }
}

