using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Task : ITask
    {
        public string SourceCode { get; set; }
        public bool IsFinished { get; set; }
        private ITaskState _state { get; set; } = new CodePushedState();

        public void RunTask()
        {
            if (_state != null)
                _state.Run(this);
            else
                throw new Exception("未設定任務初始狀態，無法執行任務");
        }

        public ITask SetState(ITaskState state)
        {
            this._state = state;

            return this;
        }

        public void WriteTaskLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
