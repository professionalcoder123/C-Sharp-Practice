namespace AsynchronousProgramming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Enter a string");
            //string str = Console.ReadLine();
            //string result = await StringDisplay.ReturnString(str);
            //Console.WriteLine(result);

            //await DataDisplay.DisplayDataAsync();

            //string result = await NonAsyncMethod.NotAsync();
            //Console.WriteLine(result);

            //await AsyncMethodDelay.Method1();
            //await AsyncMethodDelay.Method2();
            //await AsyncMethodDelay.Method3();
            //Console.WriteLine("All three methods completed successfully in sequence!");

            //var taskA = ParallelAsyncTasks.TaskA();
            //var taskB = ParallelAsyncTasks.TaskB();
            //var taskC = ParallelAsyncTasks.TaskC();
            //var results = await Task.WhenAll(taskA, taskB, taskC);
            //foreach(var result in results)
            //{
            //    Console.WriteLine(result);
            //}

            //try
            //{
            //    string result = await AsyncExceptionMethod.MightThrowAsync(true);
            //    Console.WriteLine(result);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Caught exception : " + e);
            //}

            //await AsyncNonAsyncDifference.PrintMessageAsync();
            //AsyncNonAsyncDifference.PrintMessageAsync(); //Nothing prints

            //await TaskAwaitConfigure.DoWorkAsync();

            //string result = await FileDownload.DownloadFileAsync();
            //Console.WriteLine(result);
        }
    }
}