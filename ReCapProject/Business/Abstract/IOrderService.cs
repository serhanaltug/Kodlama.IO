using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IResult CompleteOrder(OrderDto order);
    }
}
