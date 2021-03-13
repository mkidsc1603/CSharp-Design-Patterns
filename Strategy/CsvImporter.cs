using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CsvImporter : ImportDataStrategy
    {
        public override void Import(string filePath)
        {
            Console.WriteLine($"使用CSV匯入資料，檔案來源:{filePath}");
        }
    }
}
