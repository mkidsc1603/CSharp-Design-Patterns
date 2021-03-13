using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ImportController
    {
        private ImportDataStrategy _strategy { get; set; } = null;

        public ImportController(ImportDataStrategy strategy)
        {
            _strategy = strategy;
        }

        /// <summary>
        /// Hybrid with simple factory pattern
        /// </summary>
        /// <param name="type"></param>
        public ImportController(string type)
        {
            switch (type.ToLower())
            {
                case "xml":
                    _strategy = new XmlImporter();
                    break;
                case "csv":
                    _strategy = new CsvImporter();
                    break;
                case "json":
                    _strategy = new JsonImporter();
                    break;
                default:
                    throw new Exception($"不接受的資料類型:{type}");
            }
        }

        public void ImportFile(string filePath)
        {
            if (_strategy != null)
                _strategy.Import(filePath);
        }
    }
}
