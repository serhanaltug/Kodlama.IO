using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public int CardType { get; private set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public int CardExpireMonth { get; set; }
        public int CardExpireYear { get; set; }
    }
}
