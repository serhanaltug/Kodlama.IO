﻿using Core.Entities;

namespace Entities.DTOs
{
    public class CarDetailsDto : IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public int minFindexScore { get; set; }
    }
}
