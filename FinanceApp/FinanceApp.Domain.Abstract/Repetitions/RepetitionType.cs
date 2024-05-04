using FinanceApp.Domain.Abstract.EntityBase;

namespace FinanceApp.Domain.Abstract.Repetitions
{
    /// <summary>
    /// Сущность описывает период для повторяющейся операции(пополнение / зачисление купонов / досрочные погашения и т. п.)
    /// </summary>
    public abstract class RepetitionType : Entity<Duration>
    {
        protected uint _operationsAmount = 0;
        protected uint _daysUntilNextOperation = 0;

        public virtual uint DaysUntilNextOperation
        {
            get
            {
                return (uint)(RepetitionPeriodStartDate.DayOfYear % RepetitionPeriodDaysAmount);
            }
        }

        public virtual uint LeftOperationsAmount
        {
            get
            {
                return (uint)(Math.Ceiling(Value.EndDate.Subtract(RepetitionPeriodStartDate).TotalDays) / RepetitionPeriodDaysAmount);
            }
        }

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

        protected abstract uint RepetitionPeriodDaysAmount { get; }

        public bool IsExpired { get => Value.EndDate.Subtract(DateTime.Now).Days < 0; }
    }
}
