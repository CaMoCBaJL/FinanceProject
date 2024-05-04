namespace FinanceApp.Domain.Abstract.Repetitions.RepetitionTypes.NoRepetition
{

    //the last one question: how prevent entity creation using constructor
    public class NoRepetitionFactory : EntityFactory<Duration, NoRepetition, NoRepetitionValidator, ValueParser<Duration, NoRepetition>>
    {
        public NoRepetitionFactory() { }
    }
}
