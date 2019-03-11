using System;
using System.Collections;

namespace Hw3_ThreadManager_Singleton
{
    class ThreadManager
    {

        private static ThreadManager manager = new ThreadManager();
        private static ArrayList threads;

        private ThreadManager()
        {
            threads = new ArrayList();
        }

        public static ThreadManager getInstance()
        {
            return manager;
        }

        public Thread creatThread(string name)
        {
            string number = Convert.ToString(DateTime.Now.ToFileTime());
            Thread thread = new Thread(number, name);
            ThreadManager.threads.Add(thread);
            Console.WriteLine("New thread: {0} {1}", number, name);
            return thread;
        }

        public void killThread(Thread thread)
        {
            int i = threads.IndexOf(thread);
            if (i >= 0)
            {
                threads.RemoveAt(i);
            }
            else
            {
                Console.WriteLine("Failed: thread not exist!");
            }
        }

        public void listThread()
        {
            Console.WriteLine("{0} Threads now:", DateTime.Now.ToString());
            foreach (Thread thread in threads)
            {
                Console.Write("  ");
                thread.info();
            }
        }
    }
}