﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course3_Events_Delegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message..." + args.Video.Title);
        }
    }
}
