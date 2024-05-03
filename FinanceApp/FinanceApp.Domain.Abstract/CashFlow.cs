namespace FinanceApp.Domain.Abstract
{
    public abstract class CashFlow: Entity
    {
        public abstract decimal CalculateCurrentIncome();

        public abstract decimal CalculateCurrentFlowOfFunds();

        public abstract decimal CalculatePotentialIncome(Duration duration);

        public abstract decimal CalculatePotentialFlowOfFunds(Duration duration);
    }
}
