namespace BasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberAddition.AddNumbers();

            NumberSubtraction.SubtractNumbers();

            string result = EvenOddChecker.CheckEvenOrOdd();
            Console.WriteLine(result);

            MaximumNumber.FindMaximum();
        }
    }
}
