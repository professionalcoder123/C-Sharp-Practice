using System.Diagnostics;

namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //There are different ways to pass a function to a thread start.
            //ThreadStart obj = new ThreadStart(Test);
            //ThreadStart obj = Test;
            //ThreadStart obj = delegate () { Test(); };
            //ThreadStart obj = () => Test();
            //OR simply we can write like this as well.
            //Thread t1 = new Thread(ThreadsDemo.Func1);
            //Thread t2 = new Thread(ThreadsDemo.Func2);
            //Thread t3 = new Thread(ThreadsDemo.Func3);
            //t1.Start();
            //t2.Start();
            //t3.Start();

            //Thread t1 = new Thread(ThreadsDelayDemo.PrintNumbers);
            //Thread t2 = new Thread(ThreadsDelayDemo.PrintLetters);
            //Thread t3 = new Thread(ThreadsDelayDemo.PrintMessage);
            //t1.Start();
            //t2.Start();
            //t3.Start("This is a message returning function");
            //t1.Join();
            //t2.Join();
            //t3.Join();

            //Thread t1 = new Thread(ThreadPriorityDemo.PrintA);
            //Thread t2 = new Thread(ThreadPriorityDemo.PrintB);
            //Thread t3 = new Thread(ThreadPriorityDemo.PrintC);
            //t1.Priority = ThreadPriority.Highest;
            //t2.Priority = ThreadPriority.Normal;
            //t3.Priority = ThreadPriority.Lowest;
            //t1.Start();
            //t2.Start();
            //t3.Start();

            //Process currentProcess = Process.GetCurrentProcess();
            //Console.WriteLine($"Process ID : {currentProcess.Id}");
            //Console.WriteLine($"Process Name : {currentProcess.ProcessName}");
            //Thread t1 = new Thread(ThreadProcessDemo.PrintNumbers);
            //Thread t2 = new Thread(ThreadProcessDemo.PrintLetters);
            //t1.Start();
            //t2.Start();
            //t1.Join();
            //t2.Join();

            //Thread t1 = new Thread(DeadlockDemo.Thread1);
            //t1.Start();
            //Thread t2 = new Thread(DeadlockDemo.Thread2);
            //t2.Start();

            //ThreadPool.QueueUserWorkItem(ThreadPoolDemo.WorkItem1, "Hello!");
            //ThreadPool.QueueUserWorkItem(ThreadPoolDemo.WorkItem2, 5);
            //Thread.Sleep(1000);
            //Console.WriteLine("Main thread exits!");

            //Stopwatch s1 = new Stopwatch();
            //Stopwatch s2 = new Stopwatch();
            //Thread t1 = new Thread(ThreadPerformanceDemo.IncrementCounter1);
            //Thread t2 = new Thread(ThreadPerformanceDemo.IncrementCounter2);
            //Console.WriteLine("Single Threaded Model :");
            //s1.Start();
            //ThreadPerformanceDemo.IncrementCounter1();
            //ThreadPerformanceDemo.IncrementCounter2();
            //s1.Stop();
            //Console.WriteLine("Multi-Threaded Model :");
            //s2.Start();
            //t1.Start();
            //t2.Start();
            //s2.Stop();
            //t1.Join();
            //t2.Join();
            //Console.WriteLine("Time taken in single-threaded model : " + s1.ElapsedMilliseconds);
            //Console.WriteLine("Time taken in multi-threaded model : " + s2.ElapsedMilliseconds);
        }
    }
}