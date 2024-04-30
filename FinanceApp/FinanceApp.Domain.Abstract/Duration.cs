namespace FinanceApp.Domain.Abstract
{
    public class Duration(DateTime _startDate, DateTime _endDate)
    {
        public DateTime StartDate { get => _startDate; }

        public DateTime EndDate { get => _endDate; }
    }
}
