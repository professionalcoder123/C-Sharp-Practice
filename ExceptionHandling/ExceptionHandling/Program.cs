namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberDivision.HandleDivisionException();

            AgeFormat.HandleFormatException();

            IndexAccessing.HandleIndexException();

            NullString.HandleNullReferenceException();

            InputAndDivisionException.HandleExceptions();

            InvalidAge.HandleException();

            PasswordCheck.HandlePasswordException();

            StudentMarksValidation.HandleMarksOutOfBoundsException();
        }
    }
}