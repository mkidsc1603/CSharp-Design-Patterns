using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IYoutubeChannel channel = new YoutubeChannel() { Name = "Pattern Channel" };

            IYoutubeMember member = new YoutubeMember() { Name = "Andy" };
            IYoutubeMember member2 = new YoutubeMember() { Name = "Joanne" }; ;

            channel.Subscribe(member);
            channel.Subscribe(member2);

            channel.UploadVideo("新影片");

            channel.Unsubscribe(member2);

            channel.UploadVideo("發燒影片");

            Console.ReadLine();
        }
    }
}
