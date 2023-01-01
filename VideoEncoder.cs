namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event

        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        // public event VideoEncodedEventHandler VideoEncoded;

        // We can simplify and use EventHandler<> 
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            System.Console.WriteLine($"Encoding {video.Title}...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs { video = video });
        }
    }
}