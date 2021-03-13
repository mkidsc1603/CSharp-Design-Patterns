using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ImportController importController = null;

            string xml = "./data.xml";
            string csv = "./data.csv";
            string json = "./data.json";

            importController = new ImportController(new XmlImporter());
            importController.ImportFile(xml);


            importController = new ImportController(new CsvImporter());
            importController.ImportFile(csv);


            importController = new ImportController(new JsonImporter());
            importController.ImportFile(json);

            // 結合簡單工廠模式
            importController = new ImportController("xml");
            importController.ImportFile(xml);


            importController = new ImportController("csv");
            importController.ImportFile(csv);


            importController = new ImportController("json");
            importController.ImportFile(json);

            Console.ReadLine();
        }
    }
}
