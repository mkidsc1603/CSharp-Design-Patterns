using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class TestingState : ITaskState
    {
        public void Run(ITask task)
        {
            if(task.SourceCode.Length > 15)
            {
                // testing...
                task.WriteTaskLog("原始碼測試完成，進入結束階段。");
                
                task.SetState(new FinishState()).RunTask();
            }
            else
            {
                task.WriteTaskLog("原始碼測試失敗，進入失敗階段。");
                task.SetState(new FailState()).RunTask();
            }
        }
    }
}
