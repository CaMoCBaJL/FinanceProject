using FinanceApp.Domain.Abstract;

namespace FinanceApp.Domain.Entities
{
    public class Issuer : Entity
    {
        public string Name { get; set; }

        public string FullName { get; set; }
    }
}
