using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderValidator : AbstractValidator<OrderDto>
    {
        public OrderValidator()
        {
            RuleFor(x => x.CustomerId).NotEmpty();
            RuleFor(x => x.NameOnCard).NotEmpty();
            RuleFor(x => x.CardNumber).NotEmpty();
            RuleFor(x => x.CardSecurityNr).NotEmpty();
            RuleFor(x => x.CardExpireMonth).NotEmpty().GreaterThanOrEqualTo(1).LessThanOrEqualTo(12);
            RuleFor(x => x.CardExpireYear).NotEmpty().GreaterThanOrEqualTo(DateTime.Now.Year).LessThanOrEqualTo(DateTime.Now.Year + 20);
            
            RuleFor(x => x.RentalDate).NotEmpty().GreaterThanOrEqualTo(DateTime.Today);

            RuleFor(x => x.ReturnDate).NotEmpty();
            RuleFor(x => x.ReturnDate).GreaterThanOrEqualTo(DateTime.Today);
            RuleFor(x => x.ReturnDate).GreaterThanOrEqualTo(x => x.RentalDate);

        }
    }
}
