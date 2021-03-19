using Core.Entities;

namespace Entities.DTOs
{
    public class CustomerDetailsDto : IDto
    {
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string CustomerName { get; set; }
        public string CompanyName { get; set; }
    }
}
