namespace ParameterizedThread;

class Program
{
    internal class Parameters
    {
        public int Count { get; set; }
        public string Name { get; set; }

        public Parameters(int count, string name)
        {
            Count = count;
            Name = name;
        }
    }

    static Thread threadOne;

    static void ParameterThread(object obj)
    {
        Parameters myParams = (Parameters)obj;
        int limit = myParams.Count+11;

        while(myParams.Count < limit)
        {
            Console.WriteLine(myParams.Count +" - " + myParams.Name);
            Thread.Sleep(250);
            myParams.Count += 1;
        }
    }

    static void Main(string[] args)
    {
        Parameters param = new Parameters(23, "Lucas");

        threadOne = new Thread(() => ParameterThread(param));

        threadOne.Start();
    }
}
