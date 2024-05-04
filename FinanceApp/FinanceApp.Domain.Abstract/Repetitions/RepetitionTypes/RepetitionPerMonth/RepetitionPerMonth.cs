namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes.RepetitionPerMonth
{
    public class RepetitionPerMonth : RepetitionType
    {
        [Obsolete(ErrorMessages.ConstructorUsageForbidden, true)]
        public RepetitionPerMonth() { }

        protected override uint RepetitionPeriodDaysAmount => 30;
    }
}
