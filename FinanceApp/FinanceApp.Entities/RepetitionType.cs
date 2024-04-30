using FinanceApp.Domain.Abstract.Interfaces;

namespace FinanceApp.Domain.Abstract
{
    public abstract class RepetitionType : Entity, IValidatable
    {
        protected uint _operationsAmount = 0;
        protected uint _daysUntilNextOperation = 0;

        protected RepetitionType() { }

        public required Duration Duration { get; init; }

        public abstract int DaysUntilNextOperation { get; }

        public abstract int OperationsAmount { get; }

        public abstract void Validate();
    }
}
