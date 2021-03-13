using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// 資料匯入策略介面
    /// </summary>
    public abstract class ImportDataStrategy
    {
        /// <summary>
        /// 匯入資料
        /// </summary>
        /// <param name="filePath"></param>
        public abstract void Import(string filePath);
    }
}
