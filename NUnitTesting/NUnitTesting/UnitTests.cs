using ProgramsTest;

namespace NUnitTesting
{
    public class Tests
    {
        private Calculations calc;
        public NumberReverse numReverse;
        private EvenOddChecker checker;
        private PrimeChecker primeChecker;
        private MaximumNumber maxNum;
        private MinimumNumber minNum;
        private StringReverse strReverse;
        private StringPalindrome palindromeChecker;
        private NonDuplicateString nonDuplicate;
        private DuplicateCount dupCount;
        private AnagramChecker anagramChecker;

        [SetUp]
        public void Setup()
        {
            calc = new Calculations();
            numReverse = new NumberReverse();
            checker = new EvenOddChecker();
            primeChecker = new PrimeChecker();
            maxNum = new MaximumNumber();
            minNum = new MinimumNumber();
            strReverse = new StringReverse();
            palindromeChecker = new StringPalindrome();
            nonDuplicate = new NonDuplicateString();
            dupCount = new DuplicateCount();
            anagramChecker = new AnagramChecker();
        }

        [Test]
        public void Add()
        {
            int a = 20;
            int b = 10;
            int expected = 30;
            var actual = calc.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtract()
        {
            int a = 20;
            int b = 10;
            int expected = 10;
            var actual = calc.Subtract(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiply()
        {
            int a = 20;
            int b = 50;
            int expected = 1000;
            var actual = calc.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Divide()
        {
            int a = 100;
            int b = 50;
            int expected = 2;
            var actual = calc.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Reverse()
        {
            int num = 187;
            int expected = 781;
            int actual = numReverse.ReverseNumber(num);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckEven()
        {
            int num = 18;
            string expected = "Even number";
            var actual = checker.TellEvenOrOdd(num);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckOdd()
        {
            int num = 15;
            string expected = "Odd number";
            string actual = checker.TellEvenOrOdd(num);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckPrime()
        {
            int num = 7;
            bool expected = true;
            bool actual = primeChecker.IsPrime(num);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckNotPrime()
        {
            int num = 12;
            bool expected = false;
            bool actual = primeChecker.IsPrime(num);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindMaximumNumber()
        {
            int num1 = 15;
            int num2 = 20;
            int expected = 20;
            int actual = maxNum.FindMaximum(num1, num2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindMinimumNumber()
        {
            int num1 = 7;
            int num2 = 10;
            int expected = 7;
            int actual = minNum.FindMinimum(num1, num2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindReverse()
        {
            string str = "Book";
            string expected = "koob";
            string actual = strReverse.ReverseString(str);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckForPalindrome()
        {
            string str = "Madam";
            bool expected = true;
            bool actual = palindromeChecker.IsPalindrome(str);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckForNotPalindrome()
        {
            string str = "Aditya";
            bool expected = false;
            bool actual = palindromeChecker.IsPalindrome(str);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReturnNonDuplicate()
        {
            string str = "Programming";
            string expected = "progamin";
            string actual = nonDuplicate.ReturnNonDuplicateString(str);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CountDuplicates()
        {
            string str = "Programming";
            int expected = 3;
            int actual = dupCount.CountDuplicates(str);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckForAnagrams()
        {
            string str1 = "Listen";
            string str2 = "Silent";
            bool expected = true;
            bool actual = anagramChecker.CheckAnagramsOrNot(str1, str2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckForNotAnagrams()
        {
            string str1 = "Aditya";
            string str2 = "Airoli";
            bool expected = false;
            bool actual = anagramChecker.CheckAnagramsOrNot(str1, str2);
            Assert.AreEqual(expected, actual);
        }
    }
}