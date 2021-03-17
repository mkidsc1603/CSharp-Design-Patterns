using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            ITask codeReleaseTask = new Task() { SourceCode = "a" };

            codeReleaseTask.SetState(new CodePushedState()).RunTask();

            if (!codeReleaseTask.IsFinished)
            {
                // 重新上傳正確版本
                codeReleaseTask.SourceCode = "bbbbb !!!";
                codeReleaseTask.SetState(new CodePushedState()).RunTask();
            }

            Console.Read();
        }
    }
}
