using EventsAndDelegates;

var videoEncoder = new VideoEncoder(); // publisher
var mailService = new MailService(); // subscriber
var messageService = new MessageService();

videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

var video = new Video
{
    Title = "Video Number 1"
};
videoEncoder.Encode(video);

