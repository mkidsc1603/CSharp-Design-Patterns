using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class CodePushedState : ITaskState
    {
        public void Run(ITask task)
        {
            // if work well
            task.SourceCode += "--develop";
            task.WriteTaskLog("原始碼上傳完成，進入測試階段");
            task.SetState(new TestingState()).RunTask();
        }
    }
}
