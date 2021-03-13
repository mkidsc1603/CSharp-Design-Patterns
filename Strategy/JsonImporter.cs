using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class JsonImporter : ImportDataStrategy
    {
        public override void Import(string filePath)
        {
            Console.WriteLine($"使用Json匯入資料，檔案來源:{filePath}");
        }
    }
}
