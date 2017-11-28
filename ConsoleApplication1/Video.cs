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
        public void Encode(Video video)
        {
            Console.WriteLine("Encode the video");
            Thread.Sleep(3000);
        }

    }

}
