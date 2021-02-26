using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(X => X.DailyPrice).GreaterThanOrEqualTo(100);
        }
    }
}
