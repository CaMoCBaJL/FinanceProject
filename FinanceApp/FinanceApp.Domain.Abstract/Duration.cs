namespace FinanceApp.Domain.Abstract
{
    public class Duration
    {
        private DateTime _startDate;
        private DateTime _endDate;

        public Duration() 
        {
            var nowDate = DateTime.Now;

            _startDate = nowDate;
            _endDate = nowDate;
        }

        public Duration(DateTime date)
        {
            _startDate = date;
            _endDate = date;
        }

        public Duration(DateTime startDate, DateTime endDate)
        {
            _startDate = startDate;
            _endDate = endDate;
        }

        public DateTime StartDate { get => _startDate; }

        public DateTime EndDate { get => _endDate; }
    }
}
