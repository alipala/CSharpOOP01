using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Course3_Events_Delegates
{

    public class VideoEventArgs : EventArgs
    {
        public Video Video
        {
            get; set;
        }
    }
    public class VideoEncoder
    {
        //1- Define a delegate
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //2- Define an event basd on that delegate
        public event VideoEncodedEventHandler VideoEncoded;

        //3- Raise the event (Event publisher method)
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                //Source is this class and no additional data
                VideoEncoded(this, new VideoEventArgs() { Video= video});
        }

        public void Encode(Video video)
        { 
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }
    }
}
