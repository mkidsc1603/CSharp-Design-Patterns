using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class XmlImporter : ImportDataStrategy
    {
        public override void Import(string filePath)
        {
            Console.WriteLine($"使用XML匯入資料，檔案來源:{filePath}");
        }
    }
}
