using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface IYoutubeMember
    {
        /// <summary>
        /// 影片上傳通知
        /// </summary>
        /// <param name="videoName"></param>
        void onVideoUploaded(string channel, string videoName);

        /// <summary>
        /// 名稱
        /// </summary>
        string Name { get; set; }
    }
}
