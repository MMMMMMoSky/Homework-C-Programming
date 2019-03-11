using System;

namespace Hw3_ThreadManager_Singleton
{
    class Thread
    {
        private string name;
        private string number;

        public Thread(string number, string name)
        {
            this.name = name;
            this.number = number;
        }

        public void info()
        {
            Console.WriteLine("{0} {1}", number, name);
        }
    }

}