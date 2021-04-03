using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {

        [SecuredOperation("admin,editor,user")]
        [ValidationAspect(typeof(OrderValidator))]
        public IResult CompleteOrder(OrderDto order)
        {
            return new SuccessResult(Messages.OrderCompleted);
        }

    }
}
