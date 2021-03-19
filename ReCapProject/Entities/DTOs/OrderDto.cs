using Core.Entities;
using System;

namespace Entities.DTOs
{
    public class OrderDto : IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int CustomerId { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public int CardSecurityNr { get; set; }
        public int CardExpireMonth { get; set; }
        public int CardExpireYear { get; set; }
    }
}
