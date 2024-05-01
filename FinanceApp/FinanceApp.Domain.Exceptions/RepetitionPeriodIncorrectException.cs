namespace FinanceApp.Domain.Exceptions
{
    public class RepetitionPeriodIncorrectException : Exception
    {
        public RepetitionPeriodIncorrectException() : base("Incorrect duration setup!")
        {

        }
    }
}
