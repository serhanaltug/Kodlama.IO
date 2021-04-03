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
            RuleFor(x => x.NameOnCard).NotEmpty().MinimumLength(3);
            RuleFor(x => x.CardNumber).NotEmpty().Length(16);
            RuleFor(x => x.CardSecurityNr).NotEmpty().GreaterThan(99).LessThan(1000);
            RuleFor(x => x.CardExpireMonth).NotEmpty().GreaterThanOrEqualTo(1).LessThanOrEqualTo(12);
            RuleFor(x => x.CardExpireYear).NotEmpty().GreaterThanOrEqualTo(DateTime.Now.Year).LessThanOrEqualTo(DateTime.Now.Year + 20);
            
            RuleFor(x => x.RentalDate).NotEmpty().GreaterThanOrEqualTo(DateTime.Today);

            RuleFor(x => x.ReturnDate).NotEmpty();
            RuleFor(x => x.ReturnDate).GreaterThanOrEqualTo(DateTime.Today);
            RuleFor(x => x.ReturnDate).GreaterThanOrEqualTo(x => x.RentalDate);

        }
    }
}
