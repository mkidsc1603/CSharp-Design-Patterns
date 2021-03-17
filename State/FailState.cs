using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class FailState : ITaskState
    {
        public void Run(ITask task)
        {
            task.WriteTaskLog("任務失敗...");
            task.SetState(null);
        }
    }
}
