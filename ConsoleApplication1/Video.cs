using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Video
    {
        public string Title { get; set; }
    }

    class VideoEncoder
    {
        // first step
        public delegate void VideoEncoderEventHandler(object source, EventArgs args);

        // second step 
        public event VideoEncoderEventHandler VideoEncoded;


        protected virtual void OnVideoEncoded()
        {
            if(VideoEncoded !=null )
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
        public void Encode(Video video)
        {
            Console.WriteLine("Encode the video");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }

    }

    public class MailService
    { 
        // event handler
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("We are in mail service sending an amil..");
        }
    }

}
