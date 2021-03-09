using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// 避免繼承時初始化物件屬性
    /// </summary>
    public sealed class SealedImageSource
    {
        private static SealedImageSource _image { get; set; }

        private string _path { get; set; }

        private SealedImageSource(string path) 
        {
            _path = path;
        }

        public static SealedImageSource GetInstance(string path)
        {
            if(_image == null)
            {
                _image = new SealedImageSource(path);
            }

            return _image;
        }

        public string GetPath() => _path;
    }
}
