using Core.Entities;
using System;

namespace Entities.DTOs
{
    public class RentalDetailsDto : IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
