using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class FinishState : ITaskState
    {
        public void Run(ITask task)
        {
            task.WriteTaskLog("完成任務");
            task.IsFinished = true;
        }
    }
}
