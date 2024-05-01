using FinanceApp.Domain.Abstract.Interfaces;

namespace FinanceApp.Domain.Abstract
{
    /// <summary>
    /// Сущность описывает период для повторяющейся операции(пополнение / зачисление купонов / досрочные погашения и т. п.)
    /// </summary>
    public abstract class RepetitionType : Entity, IValidatable
    {
        protected uint _operationsAmount = 0;
        protected uint _daysUntilNextOperation = 0;

        protected RepetitionType() { }

        public required Duration Duration { get; init; }

        public virtual int DaysUntilNextOperation
        {
            get
            {
                return RepetitionPeriodStartDate.DayOfYear % RepetitionPeriodDaysAmount;
            }
        }

        public abstract int LeftOperationsAmount { get; }

        public abstract void Validate();

        protected DateTime RepetitionPeriodStartDate
        {
            get
            {
                var startDate = DateTime.Now;

                if (Duration.StartDate > startDate)
                {
                    startDate = Duration.StartDate;
                }

                return startDate;
            }
        }

        protected abstract int RepetitionPeriodDaysAmount { get; }
    }
}
