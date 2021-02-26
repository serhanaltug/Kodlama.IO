using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(x => x.CarId).NotEmpty();
            RuleFor(X => X.ImagePath).NotEmpty();
            RuleFor(x => x.Date).NotEmpty();
        }
    }
}
