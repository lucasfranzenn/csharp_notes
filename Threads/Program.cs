namespace Threads;

class Program
{

    static Thread threadOne;
    static Thread threadTwo;
    static bool valid;

    //Throuble
    static int solvingThreadProblem;

    // Solving my throuble
    static object objLock;
    static Mutex myMutex;

    static void MyFirstThread()
    {
        while (valid)
        {
            lock (objLock)
            {
                solvingThreadProblem = 10;
                Console.WriteLine($"Thread 1 - One second passed away : {solvingThreadProblem}");
                Thread.Sleep(1000);

            }
        }
    }

    static void MySecondThread()
    {
        while (valid)
        {
            myMutex.WaitOne();

            solvingThreadProblem = 20;
            Console.WriteLine($"Thread 2 - One second passed away : {solvingThreadProblem}");
            Thread.Sleep(1000);

            myMutex.ReleaseMutex();
        }
    }

    static void Main(string[] args)
    {
        valid = true;

        objLock = new();
        myMutex = new();

        threadOne = new Thread(MyFirstThread);
        threadTwo = new Thread(MySecondThread);

        threadOne.Priority = ThreadPriority.Highest;
        threadTwo.Priority = ThreadPriority.Normal;

        threadOne.Start();
        threadTwo.Start();

        Console.ReadKey(true);
        Console.WriteLine("Finishing...");
        valid = false;



    }
}
