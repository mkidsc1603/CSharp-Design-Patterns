using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// 多執行緒時避免同時產生物件
    /// </summary>
    public sealed class ThreadSafeImageSource
    {
        private static ThreadSafeImageSource _image { get; set; }

        private static object locker = new object();

        private string _path { get; set; }

        private ThreadSafeImageSource(string path)
        {
            _path = path;
        }

        public static ThreadSafeImageSource GetInstance(string path)
        {
            if (_image == null)
            {
                lock (locker)
                {
                    _image = new ThreadSafeImageSource(path);
                }
            }

            return _image;
        }

        public string GetPath() => _path;
    }
}
