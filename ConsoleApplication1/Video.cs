using System;
using System.Threading;

namespace ConsoleApplication1
{
    public class Video
    {
        public string Title { get; set; }
    }

    class VideoEncoder
    {
        // first step
        // public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);

        // second step 
        public event EventHandler<VideoEventArgs> VideoEncoded; // Awesome


        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
        public void Encode(Video video)
        {
            Console.WriteLine("Encode the video");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

    }

    public class MailService
    {
        // event handler
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("We are in mail service sending an amil.." + e.Video.Title);
        }
    }

}
