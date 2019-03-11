namespace Hw3_ThreadManager_Singleton
{
    class Launcher
    {
        static void Main(string[] args)
        {
            ThreadManager manager = ThreadManager.getInstance();

            Thread thread1 = manager.creatThread("YouChat");
            manager.creatThread("WeChat");
            manager.listThread();
            manager.killThread(thread1);
            manager.listThread();
        }
    }

}