namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes.RepetitionPerQuarter
{
    public class RepetitionPerQuarter : RepetitionType
    {
        [Obsolete(ErrorMessages.ConstructorUsageForbidden, true)]
        public RepetitionPerQuarter() { }

        protected override uint RepetitionPeriodDaysAmount => 90;
    }
}
