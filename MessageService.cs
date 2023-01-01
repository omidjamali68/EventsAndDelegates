using EventsAndDelegates;

public class MessageService
{
    public void OnVideoEncoded(object source, VideoEventArgs args)
    {
        System.Console.WriteLine($"Message Sent for {args.video.Title}.");
    }
}

