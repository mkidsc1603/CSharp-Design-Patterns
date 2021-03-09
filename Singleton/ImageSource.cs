using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class ImageSource
    {
        private static ImageSource _image { get; set; }

        private string _path { get; set; }

        private ImageSource(string path)
        {
            _path = path;
        }

        public static ImageSource GetInstance(string path)
        {
            if (_image == null)
            {
                _image = new ImageSource(path);
            }

            return _image;
        }

        public string GetPath() => _path;
    }
}
