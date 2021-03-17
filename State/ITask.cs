using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public interface ITask
    {
        /// <summary>
        /// 是否完成
        /// </summary>
        bool IsFinished { get; set; }

        /// <summary>
        /// 原始碼
        /// </summary>
        string SourceCode { get; set; }

        ITask SetState(ITaskState state);

        void RunTask();

        void WriteTaskLog(string message);
    }
}
