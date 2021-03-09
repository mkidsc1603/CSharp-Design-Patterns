using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string path = "icon";

            // 模擬高併發狀況，ImageSource有機率創建出不同的物件，違反Singleton規則
            List<Task<string>> tasks = new List<Task<string>>();
            for (int i = 0; i < 1000; i++)
            {
                tasks.Add(GetImageAsync(path));
            }

            // 模擬高併發狀況，ThreadSafeImageSource來確保物件是唯一的
            List<Task<string>> threadTasks = new List<Task<string>>();
            for (int i = 0; i < 1000; i++)
            {
                threadTasks.Add(GetThreadSafeImageAsync(path));
            }

            await Task.WhenAll(tasks);
            await Task.WhenAll(threadTasks);

            Console.ReadLine();
        }

        static async Task<string> GetImageAsync(string path)
        {
            string asyncPath = "Iamge:" + path + DateTime.Now.Millisecond;
            await Task.Delay(4 * 1000);
            string res = ImageSource.GetInstance(asyncPath).GetPath();

            Console.WriteLine(res);
            return res;
        }

        static async Task<string> GetThreadSafeImageAsync(string path)
        {
            string asyncPath = "Thread-safe Image:" + path + DateTime.Now.Millisecond;
            await Task.Delay(4 * 1000);
            string res = ThreadSafeImageSource.GetInstance(asyncPath).GetPath();

            Console.WriteLine(res);
            return res;
        }
    }
}
