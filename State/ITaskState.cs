using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public interface ITaskState
    {
        void Run(ITask task);
    }
}
