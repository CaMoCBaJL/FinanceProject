namespace FinanceApp.Domain.Abstract
{
    public class Currency : Entity
    {
        //ISO 4217
        public string CurrencyCode { get; set; }

        public string Name { get; set; }

        public char CurrencySymbol { get; set; }
    }
}
