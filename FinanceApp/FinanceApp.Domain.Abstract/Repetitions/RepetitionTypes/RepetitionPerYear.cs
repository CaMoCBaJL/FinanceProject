namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes
{
    public class RepetitionPerYear : RepetitionType
    {
        private RepetitionPerYear(Duration duration) : base(duration)
        {
        }

        public override int LeftOperationsAmount => throw new NotImplementedException();

        protected override int RepetitionPeriodDaysAmount => throw new NotImplementedException();

        public static RepetitionPerYear Create(Duration duration)
        {
            throw new NotImplementedException();

            return new RepetitionPerYear(duration);
        }
    }

    public class B
    {

    }

    public class C: B
    {

    }

    public static class BExtentions
    {
        public static int BB(this B b)
        {
            return 1;
        }
    }

    public class D
    {
        public void F()
        {
            new C().BB();
        }
    }
}
