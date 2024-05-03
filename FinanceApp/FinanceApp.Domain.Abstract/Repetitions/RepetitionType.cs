namespace FinanceApp.Domain.Abstract.Repetitions
{
    /// <summary>
    /// Сущность описывает период для повторяющейся операции(пополнение / зачисление купонов / досрочные погашения и т. п.)
    /// </summary>
    public abstract class RepetitionType : Entity
    {
        protected uint _operationsAmount = 0;
        protected uint _daysUntilNextOperation = 0;
        protected Duration _duration;

        protected RepetitionType(Duration Duration) 
        {
            _duration = Duration;
        }

        public virtual int DaysUntilNextOperation
        {
            get
            {
                return RepetitionPeriodStartDate.DayOfYear % RepetitionPeriodDaysAmount;
            }
        }

        public abstract int LeftOperationsAmount { get; }

        protected DateTime RepetitionPeriodStartDate
        {
            get
            {
                var startDate = DateTime.Now;

                if (_duration.StartDate > startDate)
                {
                    startDate = _duration.StartDate;
                }

                return startDate;
            }
        }

        protected abstract int RepetitionPeriodDaysAmount { get; }
    }
}
