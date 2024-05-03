namespace FinanceApp.Domain.Abstract.Repetitions
{
    /// <summary>
    /// Сущность описывает период для повторяющейся операции(пополнение / зачисление купонов / досрочные погашения и т. п.)
    /// </summary>
    public abstract class RepetitionType : Entity<Duration>
    {
        protected uint _operationsAmount = 0;
        protected uint _daysUntilNextOperation = 0;

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

                if (Value.StartDate > startDate)
                {
                    startDate = Value.StartDate;
                }

                return startDate;
            }
        }

        protected abstract int RepetitionPeriodDaysAmount { get; }
    }
}
