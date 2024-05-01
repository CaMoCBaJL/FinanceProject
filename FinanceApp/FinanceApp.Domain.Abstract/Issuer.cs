namespace FinanceApp.Domain.Abstract
{
    /// <summary>
    /// Эмитент
    /// </summary>
    public class Issuer : Entity
    {
        public string Name { get; set; }

        public string FullName { get; set; }
    }
}
