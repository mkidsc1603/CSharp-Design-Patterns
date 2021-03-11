using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface IYoutubeChannel
    {
        /// <summary>
        /// 訂閱頻道
        /// </summary>
        void Subscribe(IYoutubeMember member);

        /// <summary>
        /// 取消訂閱
        /// </summary>
        /// <param name="member"></param>
        void Unsubscribe(IYoutubeMember member);

        /// <summary>
        /// 上傳影片
        /// </summary>
        /// <param name="videoName"></param>
        void UploadVideo(string videoName);
    }
}
