using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class YoutubeMember : IYoutubeMember
    {
        public string Name { get; set; }

        public void onVideoUploaded(string channel, string videoName)
        {
            Console.WriteLine($"{Name} 快來收看 {channel} 上傳新影片: {videoName}");
        }
    }
}
