using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class YoutubeChannel : IYoutubeChannel
    {
        /// <summary>
        /// 頻道名稱
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// 訂閱者
        /// </summary>
        private IList<IYoutubeMember> _subscribers { get; set; } = new List<IYoutubeMember>();

        public void Subscribe(IYoutubeMember member)
        {
            this._subscribers.Add(member);
            Console.WriteLine($"{member.Name}訂閱{Name}");
        }

        public void Unsubscribe(IYoutubeMember member)
        {
            this._subscribers.Remove(member);
            Console.WriteLine($"{member.Name}取消訂閱{Name}");
        }

        public void UploadVideo(string videoName)
        {
            // 上傳完成
            Console.WriteLine($"{Name} 上傳新影片成功 : {videoName}");
            NotifySubscribers(videoName);
        }

        /// <summary>
        /// 發送通知
        /// </summary>
        /// <param name="message"></param>
        private void NotifySubscribers(string message)
        {
            foreach (IYoutubeMember member in this._subscribers)
                member.onVideoUploaded(this.Name, message);
        }
    }
}
