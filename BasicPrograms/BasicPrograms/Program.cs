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

            GradeSystem.GetGrade();

            string number = NumberIdentification.CheckNumber();
            Console.WriteLine(number);

            VotingEligibility.CheckEligibility();

            string character = CharacterCheck.CheckCharacter();
            Console.WriteLine("Entered character is " + character);

            bool isDivisible = NumberDivisibility.CheckDivisibility();
            Console.WriteLine(isDivisible);

            LeapYear.CheckLeapYear();

            string letter = LetterIdentification.CheckLetter();
            Console.WriteLine(letter);

            NumbersDisplay.PrintNumbers();

            EvenNumbers.DisplayEvenNumbers();

            SumOfNumbers.PrintSum();

            int factorial = Factorial.FindFactorial();
            Console.WriteLine("Factorial of a number is " + factorial);

            SumOfRange.CalculateSumOfRange();

            NumberOfDigits.PrintNumberOfDigits();

            Calculator.Calculate();

            Numbers1To100.PrintStatementsThroughNumbers();
        }
    }
}